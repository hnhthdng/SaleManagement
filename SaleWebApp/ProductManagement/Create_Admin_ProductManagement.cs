using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWebApp.ProductManagement
{
    public partial class Create_Admin_ProductManagement : Form
    {
        private ProductRepository productRepository = new ProductRepository();

        public Create_Admin_ProductManagement()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = Int32.Parse(txtb_CategoryID.Text);
            product.ProductName = txtb_ProductName.Text;
            product.Weight = txtb_Weight.Text;
            product.UnitPrice = decimal.Parse(txtb_UnitPrice.Text);
            product.UnitsInStock = Int32.Parse(txtb_UnitsInStock.Text);
            productRepository.CreateProduct(product);
            MessageBox.Show("Create successfully", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}