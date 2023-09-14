﻿using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4
{
    public partial class FormRelatorioAluno : MaterialForm
    {
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
    }
}
