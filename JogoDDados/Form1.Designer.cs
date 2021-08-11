
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDados
            // 
            this.labelDados.AutoSize = true;
            this.labelDados.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDados.Location = new System.Drawing.Point(45, 0);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(135, 54);
            this.labelDados.TabIndex = 0;
            this.labelDados.Text = "Dados";
            // 
            // txtDado1
            // 
            this.txtDado1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDado1.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDado1.Enabled = false;
            this.txtDado1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDado1.Location = new System.Drawing.Point(97, 142);
            this.txtDado1.Name = "txtDado1";
            this.txtDado1.ReadOnly = true;
            this.txtDado1.Size = new System.Drawing.Size(61, 61);
            this.txtDado1.TabIndex = 1;
            this.txtDado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDado2
            // 
            this.txtDado2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDado2.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDado2.Enabled = false;
            this.txtDado2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDado2.Location = new System.Drawing.Point(28, 142);
            this.txtDado2.Name = "txtDado2";
            this.txtDado2.ReadOnly = true;
            this.txtDado2.Size = new System.Drawing.Size(63, 61);
            this.txtDado2.TabIndex = 2;
            this.txtDado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelJogador1
            // 
            this.labelJogador1.AutoSize = true;
            this.labelJogador1.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJogador1.Location = new System.Drawing.Point(23, 77);
            this.labelJogador1.Name = "labelJogador1";
            this.labelJogador1.Size = new System.Drawing.Size(68, 17);
            this.labelJogador1.TabIndex = 3;
            this.labelJogador1.Text = "Jogador 1:";
            // 
            // txtJogador1
            // 
            this.txtJogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJogador1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJogador1.Location = new System.Drawing.Point(97, 72);
            this.txtJogador1.MaxLength = 2;
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(44, 29);
            this.txtJogador1.TabIndex = 4;
            this.txtJogador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComputador
            // 
            this.txtComputador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtComputador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComputador.Cursor = System.Windows.Forms.Cursors.No;
            this.txtComputador.Enabled = false;
            this.txtComputador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComputador.Location = new System.Drawing.Point(97, 107);
            this.txtComputador.Name = "txtComputador";
            this.txtComputador.ReadOnly = true;
            this.txtComputador.Size = new System.Drawing.Size(44, 29);
            this.txtComputador.TabIndex = 5;
            this.txtComputador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelComputador
            // 
            this.labelComputador.AutoSize = true;
            this.labelComputador.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComputador.Location = new System.Drawing.Point(-1, 113);
            this.labelComputador.Name = "labelComputador";
            this.labelComputador.Size = new System.Drawing.Size(92, 17);
            this.labelComputador.TabIndex = 6;
            this.labelComputador.Text = "Computador:";
            // 
            // btnJogar
            // 
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJogar.Location = new System.Drawing.Point(147, 71);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(50, 30);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Computador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computador:";
            // 
            // btnPlacar
            // 
            this.btnPlacar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlacar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlacar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlacar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPlacar.Location = new System.Drawing.Point(131, 242);
            this.btnPlacar.Name = "btnPlacar";
            this.btnPlacar.Size = new System.Drawing.Size(75, 23);
            this.btnPlacar.TabIndex = 8;
            this.btnPlacar.Text = "estatisticas";
            this.btnPlacar.UseVisualStyleBackColor = false;
            this.btnPlacar.Click += new System.EventHandler(this.btnPlacar_Click);
            // 
            // FormJogo
            // 
            this.AcceptButton = this.btnJogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(218, 266);
            this.Controls.Add(this.btnPlacar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelComputador);
            this.Controls.Add(this.txtComputador);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.labelJogador1);
            this.Controls.Add(this.txtDado2);
            this.Controls.Add(this.txtDado1);
            this.Controls.Add(this.labelDados);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJogo";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlacar;
    }
}

