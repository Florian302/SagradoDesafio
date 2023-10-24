using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Cataquese
{
    public partial class Temas : Form
    {
        public Temas()
        {
            InitializeComponent();
        }

        private void BtnArca_Click(object sender, EventArgs e)
        {
            FrmP1Noe p1noe = new FrmP1Noe();
            p1noe.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNascimento_Click(object sender, EventArgs e)
        {
            FrmP1Jesus p1jesus = new FrmP1Jesus();
            p1jesus.ShowDialog();
        }

        private void BtnDaviGolias_Click(object sender, EventArgs e)
        {
            FrmP1Davi p1davi = new FrmP1Davi();
            p1davi.ShowDialog();
        }

        private void BtnPecado_Click(object sender, EventArgs e)
        {
            FrmP1Pecado p1Pecado = new FrmP1Pecado();
            p1Pecado.ShowDialog();
        }

        private void BtnAmorDeus_Click(object sender, EventArgs e)
        {
            FrmP1Amor p1Amor = new FrmP1Amor();
            p1Amor.ShowDialog();
        }

        private void BtnMarVermelho_Click(object sender, EventArgs e)
        {
            FrmP1Mar p1Mar = new FrmP1Mar();
            p1Mar.ShowDialog();
        }
    }
}
