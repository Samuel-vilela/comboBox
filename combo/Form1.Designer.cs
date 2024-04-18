namespace combo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEscolha = new System.Windows.Forms.ComboBox();
            this.btn_escolha = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha um numero de 1 a 12";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbEscolha
            // 
            this.cmbEscolha.FormattingEnabled = true;
            this.cmbEscolha.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbEscolha.Location = new System.Drawing.Point(264, 64);
            this.cmbEscolha.Name = "cmbEscolha";
            this.cmbEscolha.Size = new System.Drawing.Size(202, 28);
            this.cmbEscolha.TabIndex = 1;
            // 
            // btn_escolha
            // 
            this.btn_escolha.Location = new System.Drawing.Point(490, 58);
            this.btn_escolha.Name = "btn_escolha";
            this.btn_escolha.Size = new System.Drawing.Size(284, 28);
            this.btn_escolha.TabIndex = 2;
            this.btn_escolha.Text = "Escolha um numero e clique aqui!";
            this.btn_escolha.UseVisualStyleBackColor = true;
            this.btn_escolha.Click += new System.EventHandler(this.btn_escolha_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(707, 369);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(150, 47);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "SAIR ";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMensagem.Location = new System.Drawing.Point(42, 116);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 31);
            this.lblMensagem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite seu nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(170, 22);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(472, 26);
            this.textBoxNome.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 441);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_escolha);
            this.Controls.Add(this.cmbEscolha);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEscolha;
        private System.Windows.Forms.Button btn_escolha;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}

