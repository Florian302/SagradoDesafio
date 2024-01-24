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
    public partial class FrmP8Jesus : Form
    {
        public FrmP8Jesus()
        {
            InitializeComponent();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            {
                if (rbtnCerta.Checked == true)
                {
                    MessageBox.Show("Resposta correta", "Quiz");
                    VariaveisGlobais.Acertos++;
                    FrmP9Jesus p9jesus = new FrmP9Jesus();
                    p9jesus.ShowDialog();
                    this.Dispose();
                }
                else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    MessageBox.Show("Resposta incorreta, correta era a alternativa B", "Quiz");
                    VariaveisGlobais.Erros++;
                    FrmP9Jesus p9jesus = new FrmP9Jesus();
                    p9jesus.ShowDialog();
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
