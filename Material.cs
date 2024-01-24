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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void BtnArca_Click(object sender, EventArgs e)
        {
            MaterialNoe materialNoe = new MaterialNoe();
            materialNoe.ShowDialog();
        }

        private void BtnAmorDeus_Click(object sender, EventArgs e)
        {
            MaterialAmor materialAmor = new MaterialAmor();
            materialAmor.ShowDialog();
        }

        private void BtnDaviGolias_Click(object sender, EventArgs e)
        {
            MaterialDavi materialDavi = new MaterialDavi();
            materialDavi.ShowDialog();
        }

        private void BtnMarVermelho_Click(object sender, EventArgs e)
        {
            MaterialMar materialMar = new MaterialMar();
            materialMar.ShowDialog();
        }

        private void BtnNascimento_Click(object sender, EventArgs e)
        {
            MaterialJesus materialJesus = new MaterialJesus();
            materialJesus.ShowDialog();
        }

        private void BtnPecado_Click(object sender, EventArgs e)
        {
            MaterialPecado materialPecado = new MaterialPecado();
            materialPecado.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Material_Load(object sender, EventArgs e)
        {

        }
    }
}
