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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Material materiais = new Material();
            materiais.ShowDialog();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Temas tema = new Temas();
            tema.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            Creditos credito = new Creditos();
            credito.ShowDialog();
        }
    }
}
