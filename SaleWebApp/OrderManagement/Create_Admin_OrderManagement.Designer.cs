namespace SaleWebApp.OrderManagement
{
    partial class Create_Admin_OrderManagement
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
            // btn_Create
            // 
            btn_Create.Location = new Point(292, 352);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(151, 59);
            btn_Create.TabIndex = 21;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // txtB_Freight
            // 
            txtB_Freight.Location = new Point(225, 285);
            txtB_Freight.Name = "txtB_Freight";
            txtB_Freight.Size = new Size(306, 27);
            txtB_Freight.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(84, 292);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 19;
            label5.Text = "Freight: ";
            // 
            // dateTimePicker_Shipped
            // 
            dateTimePicker_Shipped.Location = new Point(225, 217);
            dateTimePicker_Shipped.Name = "dateTimePicker_Shipped";
            dateTimePicker_Shipped.Size = new Size(306, 27);
            dateTimePicker_Shipped.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(84, 224);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 17;
            label4.Text = "Shipped Date: ";
            // 
            // dateTimePicker_Required
            // 
            dateTimePicker_Required.Location = new Point(225, 155);
            dateTimePicker_Required.Name = "dateTimePicker_Required";
            dateTimePicker_Required.Size = new Size(306, 27);
            dateTimePicker_Required.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 160);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 15;
            label3.Text = "Required Date: ";
            // 
            // dateTimePicker_Order
            // 
            dateTimePicker_Order.Location = new Point(225, 97);
            dateTimePicker_Order.Name = "dateTimePicker_Order";
            dateTimePicker_Order.Size = new Size(306, 27);
            dateTimePicker_Order.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 104);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 13;
            label2.Text = "Order Date: ";
            // 
            // txtB_MemberID
            // 
            txtB_MemberID.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtB_MemberID.Location = new Point(225, 40);
            txtB_MemberID.Name = "txtB_MemberID";
            txtB_MemberID.Size = new Size(306, 28);
            txtB_MemberID.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 48);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 11;
            label1.Text = "Member ID: ";
            // 
            // Create_Admin_OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(614, 450);
            Controls.Add(btn_Create);
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
            Name = "Create_Admin_OrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Create;
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