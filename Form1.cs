using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMercado
{
    public partial class txtQtd : Form
    {
        private decimal totalAmount = 0m;

        public txtQtd()
        {
            InitializeComponent();
        }

        public void btnInserir_Click(object sender, EventArgs e)
        {
            //pegando os dados
            string produtoName = txtProduto.Text;
            decimal produtoQtd = decimal.Parse(txtQnt.Text);
            decimal produtoValor = decimal.Parse(txtValor.Text);

            decimal itensTotal = produtoValor * produtoQtd;

            //adicionando os dados à lista
            string item = $"{produtoName} / {produtoQtd} / {produtoValor:C}";
            lstProdutos.Items.Add( item );

            totalAmount += itensTotal;

            lblTotal.Text = totalAmount.ToString("C");

            //limpando os inputs
            txtProduto.Clear();
            txtQnt.Clear();
            txtValor.Clear(); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQnt.Clear();
            txtValor.Clear();
            lstProdutos.Items.Clear();
            lblTotal.Text = "R$ 00,00";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
