using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            String var = "Railander José";
            cx_texto.Text = var;
            /*int valor = 35;
            cx_texto.Text = valor.ToString();
            */            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
