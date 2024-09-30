using Registro.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Registro : Form
    {
        List<Product> products;
        public Registro()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = tbProduct.Text;
            product.Price = double.Parse
                (tbPrice.Text);
            products.Add(product);
            ShowProducts();


        }

        private void ShowProducts()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }
    }
}
