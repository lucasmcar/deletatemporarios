namespace DeleteTemp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbTmpU = new System.Windows.Forms.RadioButton();
            this.rbTmpW = new System.Windows.Forms.RadioButton();
            this.rbPrefetch = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVerificar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lbNomeDir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFolderSize = new System.Windows.Forms.Label();
            this.lbMedFile = new System.Windows.Forms.Label();
            this.lbTotArquivos = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTmpU
            // 
            this.rbTmpU.AutoSize = true;
            this.rbTmpU.Location = new System.Drawing.Point(3, 55);
            this.rbTmpU.Name = "rbTmpU";
            this.rbTmpU.Size = new System.Drawing.Size(113, 17);
            this.rbTmpU.TabIndex = 0;
            this.rbTmpU.Text = "Pasta Temp (User)";
            this.rbTmpU.UseVisualStyleBackColor = true;
            // 
            // rbTmpW
            // 
            this.rbTmpW.AutoSize = true;
            this.rbTmpW.Location = new System.Drawing.Point(163, 55);
            this.rbTmpW.Name = "rbTmpW";
            this.rbTmpW.Size = new System.Drawing.Size(135, 17);
            this.rbTmpW.TabIndex = 1;
            this.rbTmpW.Text = "Pasta Temp (Windows)";
            this.rbTmpW.UseVisualStyleBackColor = true;
            // 
            // rbPrefetch
            // 
            this.rbPrefetch.AutoSize = true;
            this.rbPrefetch.Location = new System.Drawing.Point(361, 55);
            this.rbPrefetch.Name = "rbPrefetch";
            this.rbPrefetch.Size = new System.Drawing.Size(65, 17);
            this.rbPrefetch.TabIndex = 2;
            this.rbPrefetch.Text = "Prefetch";
            this.rbPrefetch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btVerificar);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbTmpU);
            this.panel1.Controls.Add(this.rbPrefetch);
            this.panel1.Controls.Add(this.rbTmpW);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 153);
            this.panel1.TabIndex = 3;
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(308, 112);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(118, 38);
            this.btVerificar.TabIndex = 5;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 100);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione uma pasta para limpar";
            // 
            // pnInfo
            // 
            this.pnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInfo.BackColor = System.Drawing.Color.BurlyWood;
            this.pnInfo.Controls.Add(this.lbTotArquivos);
            this.pnInfo.Controls.Add(this.lbMedFile);
            this.pnInfo.Controls.Add(this.lbFolderSize);
            this.pnInfo.Controls.Add(this.lbNomeDir);
            this.pnInfo.Controls.Add(this.label5);
            this.pnInfo.Controls.Add(this.label4);
            this.pnInfo.Controls.Add(this.label3);
            this.pnInfo.Controls.Add(this.label2);
            this.pnInfo.Location = new System.Drawing.Point(12, 260);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(271, 178);
            this.pnInfo.TabIndex = 4;
            this.pnInfo.Visible = false;
            // 
            // lbNomeDir
            // 
            this.lbNomeDir.AutoSize = true;
            this.lbNomeDir.Location = new System.Drawing.Point(3, 50);
            this.lbNomeDir.Name = "lbNomeDir";
            this.lbNomeDir.Size = new System.Drawing.Size(34, 13);
            this.lbNomeDir.TabIndex = 0;
            this.lbNomeDir.Text = "Pasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informações do Diretório";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tamanho da Pasta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Média em Arquivos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total de Arquivos:";
            // 
            // lbFolderSize
            // 
            this.lbFolderSize.AutoSize = true;
            this.lbFolderSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolderSize.Location = new System.Drawing.Point(138, 78);
            this.lbFolderSize.Name = "lbFolderSize";
            this.lbFolderSize.Size = new System.Drawing.Size(0, 18);
            this.lbFolderSize.TabIndex = 4;
            // 
            // lbMedFile
            // 
            this.lbMedFile.AutoSize = true;
            this.lbMedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedFile.Location = new System.Drawing.Point(138, 113);
            this.lbMedFile.Name = "lbMedFile";
            this.lbMedFile.Size = new System.Drawing.Size(0, 18);
            this.lbMedFile.TabIndex = 5;
            // 
            // lbTotArquivos
            // 
            this.lbTotArquivos.AutoSize = true;
            this.lbTotArquivos.Location = new System.Drawing.Point(138, 150);
            this.lbTotArquivos.Name = "lbTotArquivos";
            this.lbTotArquivos.Size = new System.Drawing.Size(0, 13);
            this.lbTotArquivos.TabIndex = 6;
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 171);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(429, 82);
            this.lstFiles.TabIndex = 5;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(320, 387);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 46);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(366, 259);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limpeza de Temporários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTmpU;
        private System.Windows.Forms.RadioButton rbTmpW;
        private System.Windows.Forms.RadioButton rbPrefetch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbNomeDir;
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotArquivos;
        private System.Windows.Forms.Label lbMedFile;
        private System.Windows.Forms.Label lbFolderSize;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

