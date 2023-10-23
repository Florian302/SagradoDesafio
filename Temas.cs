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
    }
}
