using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace APP_Cataquese
{
    public partial class FrmP1Noe : Form
    {
        public FrmP1Noe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Resposta correta", "Quiz");
                VariaveisGlobais.Acertos++;
                FrmP2Noe p2noe = new FrmP2Noe();
                p2noe.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta incorreta, correta era a alternativa A", "Quiz");
                VariaveisGlobais.Erros++;
                FrmP2Noe p2noe = new FrmP2Noe();
                p2noe.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }

        private void rbtnCerta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmP1Noe_Load(object sender, EventArgs e)
        {

        }
    }
}
