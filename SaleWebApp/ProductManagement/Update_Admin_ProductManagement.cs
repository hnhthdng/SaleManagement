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
    public partial class Update_Admin_ProductManagement : Form
    {
        private ProductRepository productRepository = new ProductRepository();
        private Product _product;

        public Update_Admin_ProductManagement(Product product)
        {
            this._product = product;
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            _product.CategoryId = Int32.Parse(txtb_CategoryID.Text);
            _product.ProductName = txtb_ProductName.Text;
            _product.Weight = txtb_Weight.Text;
            _product.UnitPrice = decimal.Parse(txtb_UnitPrice.Text);
            _product.UnitsInStock = Int32.Parse(txtb_UnitsInStock.Text);
            productRepository.UpdateProduct(_product);
            MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Update_Admin_ProductManagement_Load(object sender, EventArgs e)
        {
            txtb_CategoryID.Text = _product.CategoryId.ToString();
            txtb_ProductName.Text = _product.ProductName;
            txtb_Weight.Text = _product.Weight;
            txtb_UnitPrice.Text = _product.UnitPrice.ToString();
            txtb_UnitsInStock.Text = _product.UnitsInStock.ToString();
        }
    }
}