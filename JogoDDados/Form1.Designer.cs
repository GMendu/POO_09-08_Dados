
namespace JogoDDados
{
    partial class FormJogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDados = new System.Windows.Forms.Label();
            this.txtDado1 = new System.Windows.Forms.TextBox();
            this.txtDado2 = new System.Windows.Forms.TextBox();
            this.labelJogador1 = new System.Windows.Forms.Label();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.txtComputador = new System.Windows.Forms.TextBox();
            this.labelComputador = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDados
            // 
            this.labelDados.AutoSize = true;
            this.labelDados.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDados.Location = new System.Drawing.Point(30, 25);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(68, 28);
            this.labelDados.TabIndex = 0;
            this.labelDados.Text = "Dados";
            // 
            // txtDado1
            // 
            this.txtDado1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDado1.Location = new System.Drawing.Point(30, 180);
            this.txtDado1.Name = "txtDado1";
            this.txtDado1.ReadOnly = true;
            this.txtDado1.Size = new System.Drawing.Size(61, 61);
            this.txtDado1.TabIndex = 1;
            // 
            // txtDado2
            // 
            this.txtDado2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDado2.Location = new System.Drawing.Point(122, 180);
            this.txtDado2.Name = "txtDado2";
            this.txtDado2.ReadOnly = true;
            this.txtDado2.Size = new System.Drawing.Size(63, 61);
            this.txtDado2.TabIndex = 2;
            // 
            // labelJogador1
            // 
            this.labelJogador1.AutoSize = true;
            this.labelJogador1.Location = new System.Drawing.Point(30, 96);
            this.labelJogador1.Name = "labelJogador1";
            this.labelJogador1.Size = new System.Drawing.Size(61, 15);
            this.labelJogador1.TabIndex = 3;
            this.labelJogador1.Text = "Jogador 1:";
            // 
            // txtJogador1
            // 
            this.txtJogador1.Location = new System.Drawing.Point(97, 93);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(100, 23);
            this.txtJogador1.TabIndex = 4;
            // 
            // txtComputador
            // 
            this.txtComputador.Location = new System.Drawing.Point(97, 138);
            this.txtComputador.Name = "txtComputador";
            this.txtComputador.ReadOnly = true;
            this.txtComputador.Size = new System.Drawing.Size(100, 23);
            this.txtComputador.TabIndex = 5;
            // 
            // labelComputador
            // 
            this.labelComputador.AutoSize = true;
            this.labelComputador.Location = new System.Drawing.Point(13, 141);
            this.labelComputador.Name = "labelComputador";
            this.labelComputador.Size = new System.Drawing.Size(78, 15);
            this.labelComputador.TabIndex = 6;
            this.labelComputador.Text = "Computador:";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(122, 13);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 61);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 264);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.labelComputador);
            this.Controls.Add(this.txtComputador);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.labelJogador1);
            this.Controls.Add(this.txtDado2);
            this.Controls.Add(this.txtDado1);
            this.Controls.Add(this.labelDados);
            this.Name = "FormJogo";
            this.Text = "Jogo de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDados;
        private System.Windows.Forms.TextBox txtDado1;
        private System.Windows.Forms.TextBox txtDado2;
        private System.Windows.Forms.Label labelJogador1;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.TextBox txtComputador;
        private System.Windows.Forms.Label labelComputador;
        private System.Windows.Forms.Button btnJogar;
    }
}

