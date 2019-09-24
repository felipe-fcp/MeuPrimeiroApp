namespace MeuPrimeiroApp
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
            this.BotaoLigar = new System.Windows.Forms.Button();
            this.BotaoDesligar = new System.Windows.Forms.Button();
            this.BotaoDetalhes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoLigar
            // 
            this.BotaoLigar.Location = new System.Drawing.Point(205, 60);
            this.BotaoLigar.Name = "BotaoLigar";
            this.BotaoLigar.Size = new System.Drawing.Size(75, 23);
            this.BotaoLigar.TabIndex = 0;
            this.BotaoLigar.Text = "Ligar";
            this.BotaoLigar.UseVisualStyleBackColor = true;
            this.BotaoLigar.Click += new System.EventHandler(this.BotaoLigar_Click);
            // 
            // BotaoDesligar
            // 
            this.BotaoDesligar.Location = new System.Drawing.Point(316, 60);
            this.BotaoDesligar.Name = "BotaoDesligar";
            this.BotaoDesligar.Size = new System.Drawing.Size(75, 23);
            this.BotaoDesligar.TabIndex = 1;
            this.BotaoDesligar.Text = "Desligar";
            this.BotaoDesligar.UseVisualStyleBackColor = true;
            this.BotaoDesligar.Click += new System.EventHandler(this.BotaoDesligar_Click);
            // 
            // BotaoDetalhes
            // 
            this.BotaoDetalhes.Location = new System.Drawing.Point(436, 60);
            this.BotaoDetalhes.Name = "BotaoDetalhes";
            this.BotaoDetalhes.Size = new System.Drawing.Size(75, 23);
            this.BotaoDetalhes.TabIndex = 2;
            this.BotaoDetalhes.Text = "Detalhes";
            this.BotaoDetalhes.UseVisualStyleBackColor = true;
            this.BotaoDetalhes.Click += new System.EventHandler(this.BotaoDetalhes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotaoDetalhes);
            this.Controls.Add(this.BotaoDesligar);
            this.Controls.Add(this.BotaoLigar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoLigar;
        private System.Windows.Forms.Button BotaoDesligar;
        private System.Windows.Forms.Button BotaoDetalhes;
        private System.Windows.Forms.Button button1;
    }
}

