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
    public partial class FinalNoe : Form
    {
        public FinalNoe()
        {
            InitializeComponent();
        }

        private void FinalNoe_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErros.Text = VariaveisGlobais.Erros.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Temas tema = new Temas();
            tema.ShowDialog();
        }

        private void lblAcertos_Click(object sender, EventArgs e)
        {

        }

        private void lblErros_Click(object sender, EventArgs e)
        {

        }
    }
}
