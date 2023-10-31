namespace SaleWebApp.OrderManagement
{
    partial class Member_OrderManagement
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
            dataGridView_Order = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Order
            // 
            dataGridView_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Order.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Order.Dock = DockStyle.Fill;
            dataGridView_Order.Location = new Point(0, 0);
            dataGridView_Order.Name = "dataGridView_Order";
            dataGridView_Order.RowHeadersWidth = 51;
            dataGridView_Order.RowTemplate.Height = 29;
            dataGridView_Order.Size = new Size(994, 414);
            dataGridView_Order.TabIndex = 0;
            // 
            // Member_OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(994, 414);
            Controls.Add(dataGridView_Order);
            Name = "Member_OrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Management";
            Load += Member_OrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Order;
    }
}