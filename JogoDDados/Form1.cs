using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDDados
{
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }
        Jogo a = new Jogo();
        private void btnJogar_Click(object sender, EventArgs e)
        {
            a.Jogar(int.Parse(txtJogador1.Text));
            txtDado1.Text = a.Dado1.ToString();
            txtDado2.Text = a.Dado2.ToString();
            txtComputador.Text = a.Comp.ToString();
            if (a.vitoria)
            {
                MessageBox.Show("Vitória");
            }
            else
            {
                MessageBox.Show("Derrota");
            }
        }
    }
}
