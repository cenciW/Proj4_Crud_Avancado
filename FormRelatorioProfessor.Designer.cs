namespace Projeto4
{
    partial class FormRelatorioProfessor
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
            this.txtArea = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
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
            this.btnVisualizar.Location = new System.Drawing.Point(512, 418);
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
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = null;
            this.btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnImprimir.Location = new System.Drawing.Point(398, 418);
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
            this.Impressora.Location = new System.Drawing.Point(17, 299);
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
            this.groupBox2.Controls.Add(this.txtArea);
            this.groupBox2.Location = new System.Drawing.Point(17, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupamento";
            // 
            // txtArea
            // 
            this.txtArea.AnimateReadOnly = false;
            this.txtArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtArea.Depth = 0;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtArea.HideSelection = true;
            this.txtArea.Hint = "Area de Formacao";
            this.txtArea.LeadingIcon = null;
            this.txtArea.Location = new System.Drawing.Point(6, 32);
            this.txtArea.MaxLength = 32767;
            this.txtArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.PrefixSuffixText = null;
            this.txtArea.ReadOnly = false;
            this.txtArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArea.SelectedText = "";
            this.txtArea.SelectionLength = 0;
            this.txtArea.SelectionStart = 0;
            this.txtArea.ShortcutsEnabled = true;
            this.txtArea.Size = new System.Drawing.Size(610, 48);
            this.txtArea.TabIndex = 5;
            this.txtArea.TabStop = false;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtArea.TrailingIcon = null;
            this.txtArea.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTitulacao);
            this.groupBox1.Location = new System.Drawing.Point(17, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cboTitulacao
            // 
            this.cboTitulacao.AutoResize = false;
            this.cboTitulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTitulacao.Depth = 0;
            this.cboTitulacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTitulacao.DropDownHeight = 174;
            this.cboTitulacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitulacao.DropDownWidth = 121;
            this.cboTitulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTitulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTitulacao.FormattingEnabled = true;
            this.cboTitulacao.Hint = "Titulacao";
            this.cboTitulacao.IntegralHeight = false;
            this.cboTitulacao.ItemHeight = 43;
            this.cboTitulacao.Items.AddRange(new object[] {
            "",
            "Graduação",
            "Mestrado",
            "Doutorado"});
            this.cboTitulacao.Location = new System.Drawing.Point(6, 21);
            this.cboTitulacao.MaxDropDownItems = 4;
            this.cboTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTitulacao.Name = "cboTitulacao";
            this.cboTitulacao.Size = new System.Drawing.Size(610, 49);
            this.cboTitulacao.StartIndex = 0;
            this.cboTitulacao.TabIndex = 10;
            // 
            // FormRelatorioProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 487);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.Impressora);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelatorioProfessor";
            this.Text = "FormRelatorioProfessor";
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
        private ReaLTaiizor.Controls.MaterialComboBox cboTitulacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtArea;
    }
}