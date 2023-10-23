﻿using System;
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
    public partial class FrmP2Noe : Form
    {
        public FrmP2Noe()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Resposta correta", "Quiz");
                VariaveisGlobais.Acertos++;
                FrmP3Noe p3noe = new FrmP3Noe();
                p3noe.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta incorreta, correta era a alternativa C", "Quiz");
                VariaveisGlobais.Erros++;
                FrmP3Noe p3noe = new FrmP3Noe();
                p3noe.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtnCerta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblPergunta1_Click(object sender, EventArgs e)
        {

        }
    }
}
