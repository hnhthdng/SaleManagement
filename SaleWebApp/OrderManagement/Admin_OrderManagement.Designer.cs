namespace SaleWebApp.OrderManagement
{
    partial class Admin_OrderManagement
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
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Create = new Button();
            btn_Load = new Button();
            btn_Sort = new Button();
            lb_StartDate = new Label();
            dateTimePicker_Start = new DateTimePicker();
            dateTimePicker_End = new DateTimePicker();
            lb_EndDate = new Label();
            btn_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Order
            // 
            dataGridView_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Order.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Order.Dock = DockStyle.Top;
            dataGridView_Order.Location = new Point(0, 0);
            dataGridView_Order.Name = "dataGridView_Order";
            dataGridView_Order.RowHeadersWidth = 51;
            dataGridView_Order.RowTemplate.Height = 29;
            dataGridView_Order.Size = new Size(992, 310);
            dataGridView_Order.TabIndex = 0;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(818, 411);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(162, 54);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(818, 341);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(162, 54);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(634, 411);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(162, 54);
            btn_Create.TabIndex = 11;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(634, 341);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(162, 54);
            btn_Load.TabIndex = 10;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_Sort
            // 
            btn_Sort.Location = new Point(733, 480);
            btn_Sort.Name = "btn_Sort";
            btn_Sort.Size = new Size(162, 54);
            btn_Sort.TabIndex = 14;
            btn_Sort.Text = "Sort";
            btn_Sort.UseVisualStyleBackColor = true;
            btn_Sort.Click += btn_Sort_Click;
            // 
            // lb_StartDate
            // 
            lb_StartDate.AutoSize = true;
            lb_StartDate.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_StartDate.Location = new Point(72, 375);
            lb_StartDate.Name = "lb_StartDate";
            lb_StartDate.Size = new Size(96, 20);
            lb_StartDate.TabIndex = 16;
            lb_StartDate.Text = "Start Date:";
            // 
            // dateTimePicker_Start
            // 
            dateTimePicker_Start.Location = new Point(215, 370);
            dateTimePicker_Start.Name = "dateTimePicker_Start";
            dateTimePicker_Start.Size = new Size(250, 27);
            dateTimePicker_Start.TabIndex = 17;
            // 
            // dateTimePicker_End
            // 
            dateTimePicker_End.Location = new Point(215, 423);
            dateTimePicker_End.Name = "dateTimePicker_End";
            dateTimePicker_End.Size = new Size(250, 27);
            dateTimePicker_End.TabIndex = 19;
            // 
            // lb_EndDate
            // 
            lb_EndDate.AutoSize = true;
            lb_EndDate.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_EndDate.Location = new Point(72, 428);
            lb_EndDate.Name = "lb_EndDate";
            lb_EndDate.Size = new Size(88, 20);
            lb_EndDate.TabIndex = 18;
            lb_EndDate.Text = "End Date:";
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(215, 480);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(140, 54);
            btn_Search.TabIndex = 20;
            btn_Search.Text = "Report";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // Admin_OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(992, 553);
            Controls.Add(btn_Search);
            Controls.Add(dateTimePicker_End);
            Controls.Add(lb_EndDate);
            Controls.Add(dateTimePicker_Start);
            Controls.Add(lb_StartDate);
            Controls.Add(btn_Sort);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Create);
            Controls.Add(btn_Load);
            Controls.Add(dataGridView_Order);
            Name = "Admin_OrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Management";
            Load += Admin_OrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Order;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Create;
        private Button btn_Load;
        private Button btn_Sort;
        private Button btn_Report;
        private Label lb_StartDate;
        private DateTimePicker dateTimePicker_Start;
        private DateTimePicker dateTimePicker_End;
        private Label lb_EndDate;
        private Button btn_Search;
    }
}