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
    public partial class FrmP4Jesus : Form
    {
        public FrmP4Jesus()
        {
            InitializeComponent();
        }

        private void rbtnCerta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            {
                if (rbtnCerta.Checked == true)
                {
                    MessageBox.Show("Resposta correta", "Quiz");
                    VariaveisGlobais.Acertos++;
                    FrmP5Jesus p5jesus = new FrmP5Jesus();
                    p5jesus.ShowDialog();
                    this.Dispose();
                }
                else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    MessageBox.Show("Resposta incorreta, correta era a alternativa B", "Quiz");
                    VariaveisGlobais.Erros++;
                    FrmP5Jesus p5jesus = new FrmP5Jesus();
                    p5jesus.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Escolha uma alternativa");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
