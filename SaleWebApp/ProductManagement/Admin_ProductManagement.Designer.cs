namespace SaleWebApp.ProductManagement
{
    partial class Admin_ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Create = new Button();
            btn_Load = new Button();
            dataGridView_Products = new DataGridView();
            panel1 = new Panel();
            btn_Search = new Button();
            txtB_UnitInStock = new TextBox();
            lb_UnitInStock = new Label();
            txtB_UnitPrice = new TextBox();
            lb_UnitPrice = new Label();
            txtB_ProductName = new TextBox();
            lb_ProductName = new Label();
            txtB_ProductId = new TextBox();
            lb_ProductID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Products).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(788, 529);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(162, 54);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(788, 459);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(162, 54);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(788, 388);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(162, 54);
            btn_Create.TabIndex = 7;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(788, 317);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(162, 54);
            btn_Load.TabIndex = 6;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // dataGridView_Products
            // 
            dataGridView_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Products.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Products.Dock = DockStyle.Top;
            dataGridView_Products.Location = new Point(0, 0);
            dataGridView_Products.Name = "dataGridView_Products";
            dataGridView_Products.RowHeadersWidth = 51;
            dataGridView_Products.RowTemplate.Height = 29;
            dataGridView_Products.Size = new Size(981, 301);
            dataGridView_Products.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Search);
            panel1.Controls.Add(txtB_UnitInStock);
            panel1.Controls.Add(lb_UnitInStock);
            panel1.Controls.Add(txtB_UnitPrice);
            panel1.Controls.Add(lb_UnitPrice);
            panel1.Controls.Add(txtB_ProductName);
            panel1.Controls.Add(lb_ProductName);
            panel1.Controls.Add(txtB_ProductId);
            panel1.Controls.Add(lb_ProductID);
            panel1.Location = new Point(12, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 266);
            panel1.TabIndex = 10;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(333, 212);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(184, 51);
            btn_Search.TabIndex = 8;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txtB_UnitInStock
            // 
            txtB_UnitInStock.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtB_UnitInStock.Location = new Point(188, 168);
            txtB_UnitInStock.Name = "txtB_UnitInStock";
            txtB_UnitInStock.Size = new Size(525, 28);
            txtB_UnitInStock.TabIndex = 7;
            // 
            // lb_UnitInStock
            // 
            lb_UnitInStock.AutoSize = true;
            lb_UnitInStock.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UnitInStock.Location = new Point(40, 176);
            lb_UnitInStock.Name = "lb_UnitInStock";
            lb_UnitInStock.Size = new Size(122, 20);
            lb_UnitInStock.TabIndex = 6;
            lb_UnitInStock.Text = "Unit In Stock:";
            // 
            // txtB_UnitPrice
            // 
            txtB_UnitPrice.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtB_UnitPrice.Location = new Point(188, 114);
            txtB_UnitPrice.Name = "txtB_UnitPrice";
            txtB_UnitPrice.Size = new Size(525, 28);
            txtB_UnitPrice.TabIndex = 5;
            // 
            // lb_UnitPrice
            // 
            lb_UnitPrice.AutoSize = true;
            lb_UnitPrice.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UnitPrice.Location = new Point(40, 122);
            lb_UnitPrice.Name = "lb_UnitPrice";
            lb_UnitPrice.Size = new Size(100, 20);
            lb_UnitPrice.TabIndex = 4;
            lb_UnitPrice.Text = "Unit Price: ";
            // 
            // txtB_ProductName
            // 
            txtB_ProductName.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtB_ProductName.Location = new Point(188, 60);
            txtB_ProductName.Name = "txtB_ProductName";
            txtB_ProductName.Size = new Size(525, 28);
            txtB_ProductName.TabIndex = 3;
            // 
            // lb_ProductName
            // 
            lb_ProductName.AutoSize = true;
            lb_ProductName.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProductName.Location = new Point(40, 68);
            lb_ProductName.Name = "lb_ProductName";
            lb_ProductName.Size = new Size(133, 20);
            lb_ProductName.TabIndex = 2;
            lb_ProductName.Text = "Product Name:";
            // 
            // txtB_ProductId
            // 
            txtB_ProductId.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtB_ProductId.Location = new Point(188, 9);
            txtB_ProductId.Name = "txtB_ProductId";
            txtB_ProductId.Size = new Size(525, 28);
            txtB_ProductId.TabIndex = 1;
            // 
            // lb_ProductID
            // 
            lb_ProductID.AutoSize = true;
            lb_ProductID.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProductID.Location = new Point(40, 17);
            lb_ProductID.Name = "lb_ProductID";
            lb_ProductID.Size = new Size(108, 20);
            lb_ProductID.TabIndex = 0;
            lb_ProductID.Text = "Product ID: ";
            // 
            // Admin_ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(981, 594);
            Controls.Add(panel1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Create);
            Controls.Add(btn_Load);
            Controls.Add(dataGridView_Products);
            Name = "Admin_ProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += Admin_ProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Products).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Create;
        private Button btn_Load;
        private DataGridView dataGridView_Products;
        private Panel panel1;
        private Label lb_ProductID;
        private TextBox txtB_ProductId;
        private Button btn_Search;
        private TextBox txtB_UnitInStock;
        private Label lb_UnitInStock;
        private TextBox txtB_UnitPrice;
        private Label lb_UnitPrice;
        private TextBox txtB_ProductName;
        private Label lb_ProductName;
    }
}