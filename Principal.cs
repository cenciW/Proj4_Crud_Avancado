using ReaLTaiizor.Forms;
namespace Projeto4
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno cadastro = new FormAluno();
            cadastro.MdiParent = this;
            cadastro.Show();
        }
        private void Prinipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.MdiParent = this;
            curso.Show();

        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.MdiParent = this;
            professor.Show();
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formRelAluno = new FormRelatorioAluno();
            formRelAluno.MdiParent = this;
            formRelAluno.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRelCurso = new FormRelatorioCurso();
            formRelCurso.MdiParent = this;
            formRelCurso.Show();
        }

        private void professoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formRelProfessores = new FormRelatorioProfessor();
            formRelProfessores.MdiParent = this;
            formRelProfessores.Show();
        }
    }
}