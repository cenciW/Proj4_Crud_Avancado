using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Projeto4
{
    public partial class FormRelatorioAluno : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=127.0.0.1;uid=root;pwd=;database=academico";
        public FormRelatorioAluno()
        {
            InitializeComponent();
            CarregaImpressoras();
        }

        private void CarregaImpressoras() 
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }

        private void MontaRelatorio()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno WHERE 1 = 1";
            if(cboEstado.Text!= "")
                sql += "and estado = @estado";

            if (cboEstado.Text != "")
                sql += "and cidade = @cidade";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            if (cboEstado.Text!="")
                sqlAd.SelectCommand.Parameters.AddWithValue("@estado", cboEstado.Text);

            if (txtCidade.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", txtCidade.Text);

            var dt = new DataTable();
            sqlAd.Fill(dt);
            con.Close();

            //geracao pdf
            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();

            float y = 25;

            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(
                    new Font("Arial",
                    16f,
                    FontStyle.Bold)
                );

            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatório de Alunos", font1, brush1, page.Canvas.ClientSize.Width/2, y, format1);

            PdfTable pdfTable= new PdfTable();

            pdfTable.Style.CellPadding = 2;
            pdfTable.Style.BorderPen = new PdfPen(brush1, 0.75f);
            pdfTable.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            pdfTable.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            pdfTable.Style.HeaderStyle.BackgroundBrush = PdfBrushes.Cyan;
            pdfTable.Style.ShowHeader = true;
            pdfTable.DataSource = dt;
            foreach (PdfColumn col in pdfTable.Columns)
            {
                col.StringFormat = new PdfStringFormat(
                    PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            pdfTable.Draw(page, new PointF(0, y+font1.Size+4));


            doc.SaveToFile(@"RelatorioAlunos.pdf");

            //MessageBox.Show(Directory.GetParent(Directory.GetCurrentDirectory()) + "");
            

            


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            
            string impressora = cboImpressora.Text;
            if (String.IsNullOrEmpty(impressora)) return;

            PdfDocument doc = new PdfDocument();
            
            doc.LoadFromFile(@"RelatorioAlunos.pdf");
            doc.PrintSettings.PrinterName = impressora;
            doc.Print();



        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            //Process.Start("RelatorioAlunos.pdf");

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioAlunos.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
