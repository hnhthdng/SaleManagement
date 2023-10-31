namespace SaleWebApp.OrderManagement
{
    partial class Update_Admin_OrderManagement
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
            txtB_Freight = new TextBox();
            label5 = new Label();
            dateTimePicker_Shipped = new DateTimePicker();
            label4 = new Label();
            dateTimePicker_Required = new DateTimePicker();
            label3 = new Label();
            dateTimePicker_Order = new DateTimePicker();
            label2 = new Label();
            txtB_MemberID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(278, 352);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(151, 59);
            btn_Update.TabIndex = 32;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // txtB_Freight
            // 
            txtB_Freight.Location = new Point(211, 285);
            txtB_Freight.Name = "txtB_Freight";
            txtB_Freight.Size = new Size(306, 27);
            txtB_Freight.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(70, 292);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 30;
            label5.Text = "Freight: ";
            // 
            // dateTimePicker_Shipped
            // 
            dateTimePicker_Shipped.Location = new Point(211, 217);
            dateTimePicker_Shipped.Name = "dateTimePicker_Shipped";
            dateTimePicker_Shipped.Size = new Size(306, 27);
            dateTimePicker_Shipped.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 224);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 28;
            label4.Text = "Shipped Date: ";
            // 
            // dateTimePicker_Required
            // 
            dateTimePicker_Required.Location = new Point(211, 155);
            dateTimePicker_Required.Name = "dateTimePicker_Required";
            dateTimePicker_Required.Size = new Size(306, 27);
            dateTimePicker_Required.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 160);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 26;
            label3.Text = "Required Date: ";
            // 
            // dateTimePicker_Order
            // 
            dateTimePicker_Order.Location = new Point(211, 97);
            dateTimePicker_Order.Name = "dateTimePicker_Order";
            dateTimePicker_Order.Size = new Size(306, 27);
            dateTimePicker_Order.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 104);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 24;
            label2.Text = "Order Date: ";
            // 
            // txtB_MemberID
            // 
            txtB_MemberID.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtB_MemberID.Location = new Point(211, 40);
            txtB_MemberID.Name = "txtB_MemberID";
            txtB_MemberID.Size = new Size(306, 28);
            txtB_MemberID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 48);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 22;
            label1.Text = "Member ID: ";
            // 
            // Update_Admin_OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(586, 450);
            Controls.Add(btn_Update);
            Controls.Add(txtB_Freight);
            Controls.Add(label5);
            Controls.Add(dateTimePicker_Shipped);
            Controls.Add(label4);
            Controls.Add(dateTimePicker_Required);
            Controls.Add(label3);
            Controls.Add(dateTimePicker_Order);
            Controls.Add(label2);
            Controls.Add(txtB_MemberID);
            Controls.Add(label1);
            Name = "Update_Admin_OrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update";
            Load += Update_Admin_OrderManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Update;
        private TextBox txtB_Freight;
        private Label label5;
        private DateTimePicker dateTimePicker_Shipped;
        private Label label4;
        private DateTimePicker dateTimePicker_Required;
        private Label label3;
        private DateTimePicker dateTimePicker_Order;
        private Label label2;
        private TextBox txtB_MemberID;
        private Label label1;
    }
}