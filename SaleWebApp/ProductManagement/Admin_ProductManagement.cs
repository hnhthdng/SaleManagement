using BusinessObject;
using DataAccess.Repository;
using SaleWebApp.MemberManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SaleWebApp.ProductManagement
{
    public partial class Admin_ProductManagement : Form
    {
        private ProductRepository productRepository = new ProductRepository();
        private BindingSource source;

        public Admin_ProductManagement()
        {
            InitializeComponent();
        }

        public void LoadListProduct()
        {
            source = new BindingSource();
            source.DataSource = productRepository.GetProducts();
            dataGridView_Products.DataSource = source;
            this.dataGridView_Products.Columns["OrderDetails"].Visible = false;
        }

        private void Admin_ProductManagement_Load(object sender, EventArgs e)
        {
            LoadListProduct();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadListProduct();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Create_Admin_ProductManagement frm = new Create_Admin_ProductManagement();
            frm.ShowDialog();
            LoadListProduct();
            this.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_Products.SelectedRows.Count > 0)
            {
                var product = new Product();
                product = productRepository.GetProductbyProductName(dataGridView_Products.SelectedRows[0].Cells[2].Value.ToString());

                Update_Admin_ProductManagement frm = new Update_Admin_ProductManagement(product);
                frm.ShowDialog();
                LoadListProduct();
                this.Show();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Products.SelectedRows.Count > 0)
            {
                var mess = MessageBox.Show("Are you sure to delete this product ?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mess == DialogResult.OK)
                {
                    productRepository.DeleteProduct(dataGridView_Products.SelectedRows[0].Cells[2].Value.ToString());
                    dataGridView_Products.Rows.RemoveAt(dataGridView_Products.SelectedRows[0].Index);
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductId = int.TryParse(txtB_ProductId.Text, out int ProductId) ? ProductId : 0,
                ProductName = string.IsNullOrEmpty(txtB_ProductName.Text) ? "" : txtB_ProductName.Text,
                UnitPrice = decimal.TryParse(txtB_UnitPrice.Text, out decimal UnitPrice) ? UnitPrice : 0,
                UnitsInStock = int.TryParse(txtB_UnitInStock.Text, out int UnitsInStock) ? UnitsInStock : 0,
            };
            try
            {
                source.DataSource = productRepository.SearchProductFilter(product);
                dataGridView_Products.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}