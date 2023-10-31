namespace SaleWebApp.ProductManagement
{
    partial class Create_Admin_ProductManagement
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
            btn_Create = new Button();
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
            // btn_Create
            // 
            btn_Create.Location = new Point(328, 293);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(141, 61);
            btn_Create.TabIndex = 33;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // txtb_UnitsInStock
            // 
            txtb_UnitsInStock.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_UnitsInStock.Location = new Point(230, 246);
            txtb_UnitsInStock.Name = "txtb_UnitsInStock";
            txtb_UnitsInStock.Size = new Size(332, 29);
            txtb_UnitsInStock.TabIndex = 32;
            // 
            // lb_UnitsInStock
            // 
            lb_UnitsInStock.AutoSize = true;
            lb_UnitsInStock.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UnitsInStock.Location = new Point(38, 254);
            lb_UnitsInStock.Name = "lb_UnitsInStock";
            lb_UnitsInStock.Size = new Size(143, 21);
            lb_UnitsInStock.TabIndex = 31;
            lb_UnitsInStock.Text = "Units in Stock: ";
            // 
            // txtb_UnitPrice
            // 
            txtb_UnitPrice.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_UnitPrice.Location = new Point(230, 196);
            txtb_UnitPrice.Name = "txtb_UnitPrice";
            txtb_UnitPrice.Size = new Size(332, 29);
            txtb_UnitPrice.TabIndex = 30;
            // 
            // lb_UnitPrice
            // 
            lb_UnitPrice.AutoSize = true;
            lb_UnitPrice.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UnitPrice.Location = new Point(38, 204);
            lb_UnitPrice.Name = "lb_UnitPrice";
            lb_UnitPrice.Size = new Size(101, 21);
            lb_UnitPrice.TabIndex = 29;
            lb_UnitPrice.Text = "Unit Price:";
            // 
            // txtb_Weight
            // 
            txtb_Weight.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Weight.Location = new Point(230, 148);
            txtb_Weight.Name = "txtb_Weight";
            txtb_Weight.Size = new Size(332, 29);
            txtb_Weight.TabIndex = 28;
            // 
            // lb_Weight
            // 
            lb_Weight.AutoSize = true;
            lb_Weight.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Weight.Location = new Point(38, 156);
            lb_Weight.Name = "lb_Weight";
            lb_Weight.Size = new Size(76, 21);
            lb_Weight.TabIndex = 27;
            lb_Weight.Text = "Weight:";
            // 
            // txtb_ProductName
            // 
            txtb_ProductName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_ProductName.Location = new Point(230, 100);
            txtb_ProductName.Name = "txtb_ProductName";
            txtb_ProductName.Size = new Size(332, 29);
            txtb_ProductName.TabIndex = 26;
            // 
            // lb_ProductName
            // 
            lb_ProductName.AutoSize = true;
            lb_ProductName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ProductName.Location = new Point(38, 108);
            lb_ProductName.Name = "lb_ProductName";
            lb_ProductName.Size = new Size(140, 21);
            lb_ProductName.TabIndex = 25;
            lb_ProductName.Text = "Product Name:";
            // 
            // txtb_CategoryID
            // 
            txtb_CategoryID.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_CategoryID.Location = new Point(230, 54);
            txtb_CategoryID.Name = "txtb_CategoryID";
            txtb_CategoryID.Size = new Size(332, 29);
            txtb_CategoryID.TabIndex = 24;
            // 
            // lb_CategoryID
            // 
            lb_CategoryID.AutoSize = true;
            lb_CategoryID.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_CategoryID.Location = new Point(38, 62);
            lb_CategoryID.Name = "lb_CategoryID";
            lb_CategoryID.Size = new Size(114, 21);
            lb_CategoryID.TabIndex = 23;
            lb_CategoryID.Text = "CategoryID:";
            // 
            // Create_Admin_ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(619, 412);
            Controls.Add(btn_Create);
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
            Name = "Create_Admin_ProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Create;
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