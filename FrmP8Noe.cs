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
    public partial class FrmP8Noe : Form
    {
        public FrmP8Noe()
        {
            InitializeComponent();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Resposta correta", "Quiz");
                VariaveisGlobais.Acertos++;
                FrmP9Noe p9noe = new FrmP9Noe();
                p9noe.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta incorreta, correta era a alternativa A", "Quiz");
                VariaveisGlobais.Erros++;
                FrmP9Noe p9noe = new FrmP9Noe();
                p9noe.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
