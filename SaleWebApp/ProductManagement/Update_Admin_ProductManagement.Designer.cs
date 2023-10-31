namespace SaleWebApp.ProductManagement
{
    partial class Update_Admin_ProductManagement
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
            btn_Update = new Button();
            txtb_UnitsInStock = new TextBox();
            lb_UnitsInStock = new Label();
            txtb_UnitPrice = new TextBox();
            lb_UnitPrice = new Label();
            txtb_Weight = new TextBox();
            lb_Weight = new Label();
            txtb_ProductName = new TextBox();
            lb_ProductName = new Label();
            txtb_CategoryID = new TextBox();
            lb_CategoryID = new Label();
            SuspendLayout();
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(316, 271);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(141, 61);
            btn_Update.TabIndex = 44;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // txtb_UnitsInStock
            // 
            txtb_UnitsInStock.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_UnitsInStock.Location = new Point(218, 224);
            txtb_UnitsInStock.Name = "txtb_UnitsInStock";
            txtb_UnitsInStock.Size = new Size(332, 29);
            txtb_UnitsInStock.TabIndex = 43;
            // 
            // lb_UnitsInStock
            // 
            lb_UnitsInStock.AutoSize = true;
            lb_UnitsInStock.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UnitsInStock.Location = new Point(26, 232);
            lb_UnitsInStock.Name = "lb_UnitsInStock";
            lb_UnitsInStock.Size = new Size(143, 21);
            lb_UnitsInStock.TabIndex = 42;
            lb_UnitsInStock.Text = "Units in Stock: ";
            // 
            // txtb_UnitPrice
            // 
            txtb_UnitPrice.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_UnitPrice.Location = new Point(218, 174);
            txtb_UnitPrice.Name = "txtb_UnitPrice";
            txtb_UnitPrice.Size = new Size(332, 29);
            txtb_UnitPrice.TabIndex = 41;
            // 
            // lb_UnitPrice
            // 
            lb_UnitPrice.AutoSize = true;
            lb_UnitPrice.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UnitPrice.Location = new Point(26, 182);
            lb_UnitPrice.Name = "lb_UnitPrice";
            lb_UnitPrice.Size = new Size(101, 21);
            lb_UnitPrice.TabIndex = 40;
            lb_UnitPrice.Text = "Unit Price:";
            // 
            // txtb_Weight
            // 
            txtb_Weight.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Weight.Location = new Point(218, 126);
            txtb_Weight.Name = "txtb_Weight";
            txtb_Weight.Size = new Size(332, 29);
            txtb_Weight.TabIndex = 39;
            // 
            // lb_Weight
            // 
            lb_Weight.AutoSize = true;
            lb_Weight.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Weight.Location = new Point(26, 134);
            lb_Weight.Name = "lb_Weight";
            lb_Weight.Size = new Size(76, 21);
            lb_Weight.TabIndex = 38;
            lb_Weight.Text = "Weight:";
            // 
            // txtb_ProductName
            // 
            txtb_ProductName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_ProductName.Location = new Point(218, 78);
            txtb_ProductName.Name = "txtb_ProductName";
            txtb_ProductName.Size = new Size(332, 29);
            txtb_ProductName.TabIndex = 37;
            // 
            // lb_ProductName
            // 
            lb_ProductName.AutoSize = true;
            lb_ProductName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProductName.Location = new Point(26, 86);
            lb_ProductName.Name = "lb_ProductName";
            lb_ProductName.Size = new Size(140, 21);
            lb_ProductName.TabIndex = 36;
            lb_ProductName.Text = "Product Name:";
            // 
            // txtb_CategoryID
            // 
            txtb_CategoryID.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_CategoryID.Location = new Point(218, 32);
            txtb_CategoryID.Name = "txtb_CategoryID";
            txtb_CategoryID.Size = new Size(332, 29);
            txtb_CategoryID.TabIndex = 35;
            // 
            // lb_CategoryID
            // 
            lb_CategoryID.AutoSize = true;
            lb_CategoryID.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_CategoryID.Location = new Point(26, 40);
            lb_CategoryID.Name = "lb_CategoryID";
            lb_CategoryID.Size = new Size(114, 21);
            lb_CategoryID.TabIndex = 34;
            lb_CategoryID.Text = "CategoryID:";
            // 
            // Update_Admin_ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(607, 373);
            Controls.Add(btn_Update);
            Controls.Add(txtb_UnitsInStock);
            Controls.Add(lb_UnitsInStock);
            Controls.Add(txtb_UnitPrice);
            Controls.Add(lb_UnitPrice);
            Controls.Add(txtb_Weight);
            Controls.Add(lb_Weight);
            Controls.Add(txtb_ProductName);
            Controls.Add(lb_ProductName);
            Controls.Add(txtb_CategoryID);
            Controls.Add(lb_CategoryID);
            Name = "Update_Admin_ProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update";
            Load += Update_Admin_ProductManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Update;
        private TextBox txtb_UnitsInStock;
        private Label lb_UnitsInStock;
        private TextBox txtb_UnitPrice;
        private Label lb_UnitPrice;
        private TextBox txtb_Weight;
        private Label lb_Weight;
        private TextBox txtb_ProductName;
        private Label lb_ProductName;
        private TextBox txtb_CategoryID;
        private Label lb_CategoryID;
    }
}