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
        int contV = 0 , contD = 0;

        private void btnPlacar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"┌──────────────────────────────────────\n│ O jogador jogou um total de {contV + contD} jogos\n├──────────────────────────────────────\n│ vitórias: {contV}\n│ derrotas: {contD}\n└──────────────────────────────────────");
        }


        private void btnJogar_Click(object sender, EventArgs e)
        {
            a.Jogar(int.Parse(txtJogador1.Text));
            txtDado1.Text = a.Dado1.ToString();
            txtDado2.Text = a.Dado2.ToString();
            txtComputador.Text = a.Comp.ToString();
            if (a.vitoria)
            {
                contV += 1;
                MessageBox.Show($"\n┌──────────────────────────────────────\n│ Vitória do jogador pela {contV}ª vez\n└──────────────────────────────────────");
                
            }
            else
            {
                contD += 1;
                MessageBox.Show($"\n┌──────────────────────────────────────\n│ Derrota do jogador pela {contD}ª vez\n└──────────────────────────────────────");
            }
        }
    }
}
