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
    public partial class FrmP1Jesus : Form
    {
        public FrmP1Jesus()
        {
            InitializeComponent();
        }

        private void FrmP1Jesus_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            {
                if (rbtnCerta.Checked == true)
                {
                    MessageBox.Show("Resposta correta", "Quiz");
                    VariaveisGlobais.Acertos++;
                    FrmP2Jesus p2jesus = new FrmP2Jesus();
                    p2jesus.ShowDialog();
                    this.Dispose();
                }
                else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    MessageBox.Show("Resposta incorreta, correta era a alternativa A", "Quiz");
                    VariaveisGlobais.Erros++;
                    FrmP2Jesus p2jesus = new FrmP2Jesus();
                    p2jesus.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Escolha uma alternativa");
                }
            }
        }
    }
}