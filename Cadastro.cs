using ReaLTaiizor.Colors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Projeto4
{
    public partial class Cadastro : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=127.0.0.1;uid=root;pwd=;database=academico";
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";
            if (!isAlteracao)
            {

                sql = "INSERT INTO aluno(matricula, data_nasc, nome, endereco, bairro, cidade, estado, senha) VALUES (@matricula, @data_nasc, @nome, @endereco, @bairro, @cidade, @estado, @senha)";

            }
            else
            {


             sql = "UPDATE aluno set matricula = @matricula, data_nasc = @data_nasc, nome = @nome, endereco = @endereco, bairro = @bairro, cidade = @cidade, estado = @estado, senha = @senha WHERE ID = @ID";

            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
            DateTime.TryParse(txtData.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@data_nasc", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }
        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (!DateTime.TryParse(txtData.Text, out DateTime _))
            {
                MessageBox.Show("Data é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtData.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            return true;
        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPage1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            CarregaGrid();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Deseja realmente deletar?", "IFSP",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id); 
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleciona algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();

                var sql = "DELETE FROM ALUNO WHERE id = @id";
                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                isAlteracao= true;
                var linha = dataGridView1.SelectedRows[0];
                txtID.Text = linha.Cells["id"].Value.ToString();
                txtMatricula.Text = linha.Cells["matricula"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
                txtBairro.Text = linha.Cells["bairro"].Value.ToString();
                txtCidade.Text = linha.Cells["cidade"].Value.ToString();
                txtSenha.Text = linha.Cells["senha"].Value.ToString();
                txtData.Text = linha.Cells["data_nasc"].Value.ToString();
                cmbEstado.Text = linha.Cells["estado"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;  
                txtMatricula.Focus();

            }
            else
            {
                MessageBox.Show("Seleciona algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            materialTabControl1.SelectedIndex = 0;
            txtMatricula.Focus();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

    }
}
