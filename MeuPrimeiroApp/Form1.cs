using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroApp
{
    public partial class Form1 : Form
    {
        Carro Carro;
        public Form1()
        {
            InitializeComponent();
            Carro = new Carro();
        }

        private void BotaoLigar_Click(object sender, EventArgs e)
        {
            string retorno = Carro.Ligar();
            MessageBox.Show(retorno);
        }

        private void BotaoDesligar_Click(object sender, EventArgs e)
        {
            string retorno = Carro.Desligar();
            MessageBox.Show(retorno);
        }

        private void BotaoDetalhes_Click(object sender, EventArgs e)
        {
            string retorno = Carro.Detalhes();
            MessageBox.Show(retorno);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var valor1 = 10;
            var valor2 = 5;

            var resultado = valor1 / valor2;

            MessageBox.Show(resultado.ToString());

            //teste commit
        }
    }
}
