namespace Projeto4
{
    partial class FormRelatorioCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            this.Impressora = new System.Windows.Forms.GroupBox();
            this.cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAnoCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoCurso = new ReaLTaiizor.Controls.MaterialComboBox();
            this.Impressora.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVisualizar.Depth = 0;
            this.btnVisualizar.HighEmphasis = true;
            this.btnVisualizar.Icon = null;
            this.btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVisualizar.Location = new System.Drawing.Point(512, 410);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVisualizar.Size = new System.Drawing.Size(112, 36);
            this.btnVisualizar.TabIndex = 8;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVisualizar.UseAccentColor = false;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = null;
            this.btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnImprimir.Location = new System.Drawing.Point(398, 410);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImprimir.Size = new System.Drawing.Size(97, 36);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimir.UseAccentColor = false;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Impressora
            // 
            this.Impressora.Controls.Add(this.cboImpressora);
            this.Impressora.Location = new System.Drawing.Point(17, 291);
            this.Impressora.Name = "Impressora";
            this.Impressora.Size = new System.Drawing.Size(636, 100);
            this.Impressora.TabIndex = 7;
            this.Impressora.TabStop = false;
            this.Impressora.Text = "Impressora";
            // 
            // cboImpressora
            // 
            this.cboImpressora.AutoResize = false;
            this.cboImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboImpressora.Depth = 0;
            this.cboImpressora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboImpressora.DropDownHeight = 174;
            this.cboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpressora.DropDownWidth = 121;
            this.cboImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboImpressora.FormattingEnabled = true;
            this.cboImpressora.Hint = "Impressoras";
            this.cboImpressora.IntegralHeight = false;
            this.cboImpressora.ItemHeight = 43;
            this.cboImpressora.Location = new System.Drawing.Point(6, 22);
            this.cboImpressora.MaxDropDownItems = 4;
            this.cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(610, 49);
            this.cboImpressora.StartIndex = 0;
            this.cboImpressora.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAnoCurso);
            this.groupBox2.Location = new System.Drawing.Point(17, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupamento";
            // 
            // txtAnoCurso
            // 
            this.txtAnoCurso.AnimateReadOnly = false;
            this.txtAnoCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAnoCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAnoCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAnoCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAnoCurso.Depth = 0;
            this.txtAnoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnoCurso.HideSelection = true;
            this.txtAnoCurso.Hint = "Ano de Criação do Curso";
            this.txtAnoCurso.LeadingIcon = null;
            this.txtAnoCurso.Location = new System.Drawing.Point(6, 32);
            this.txtAnoCurso.MaxLength = 32767;
            this.txtAnoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAnoCurso.Name = "txtAnoCurso";
            this.txtAnoCurso.PasswordChar = '\0';
            this.txtAnoCurso.PrefixSuffixText = null;
            this.txtAnoCurso.ReadOnly = false;
            this.txtAnoCurso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAnoCurso.SelectedText = "";
            this.txtAnoCurso.SelectionLength = 0;
            this.txtAnoCurso.SelectionStart = 0;
            this.txtAnoCurso.ShortcutsEnabled = true;
            this.txtAnoCurso.Size = new System.Drawing.Size(601, 48);
            this.txtAnoCurso.TabIndex = 3;
            this.txtAnoCurso.TabStop = false;
            this.txtAnoCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAnoCurso.TrailingIcon = null;
            this.txtAnoCurso.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoCurso);
            this.groupBox1.Location = new System.Drawing.Point(17, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cboTipoCurso
            // 
            this.cboTipoCurso.AutoResize = false;
            this.cboTipoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTipoCurso.Depth = 0;
            this.cboTipoCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipoCurso.DropDownHeight = 174;
            this.cboTipoCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCurso.DropDownWidth = 121;
            this.cboTipoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTipoCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTipoCurso.FormattingEnabled = true;
            this.cboTipoCurso.Hint = "Tipo do Curso";
            this.cboTipoCurso.IntegralHeight = false;
            this.cboTipoCurso.ItemHeight = 43;
            this.cboTipoCurso.Items.AddRange(new object[] {
            "",
            "Técnico",
            "Tecnólogo",
            "Bacharelado",
            "Licenciatura"});
            this.cboTipoCurso.Location = new System.Drawing.Point(6, 22);
            this.cboTipoCurso.MaxDropDownItems = 4;
            this.cboTipoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTipoCurso.Name = "cboTipoCurso";
            this.cboTipoCurso.Size = new System.Drawing.Size(610, 49);
            this.cboTipoCurso.StartIndex = 0;
            this.cboTipoCurso.TabIndex = 1;
            // 
            // FormRelatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 479);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.Impressora);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelatorioCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelatorioCurso";
            this.Impressora.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private GroupBox Impressora;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipoCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAnoCurso;
    }
}