namespace SaleWebApp.MemberManagement
{
    partial class Admin_MemberManagement
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
            dataGridView_Members = new DataGridView();
            btn_Load = new Button();
            btn_Create = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Members).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Members
            // 
            dataGridView_Members.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Members.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Members.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_Members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Members.Dock = DockStyle.Top;
            dataGridView_Members.Location = new Point(0, 0);
            dataGridView_Members.Name = "dataGridView_Members";
            dataGridView_Members.RowHeadersWidth = 51;
            dataGridView_Members.RowTemplate.Height = 29;
            dataGridView_Members.Size = new Size(963, 301);
            dataGridView_Members.TabIndex = 0;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(25, 332);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(162, 54);
            btn_Load.TabIndex = 1;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(272, 332);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(162, 54);
            btn_Create.TabIndex = 2;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(523, 332);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(162, 54);
            btn_Update.TabIndex = 3;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(776, 332);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(162, 54);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // Admin_MemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(963, 426);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Create);
            Controls.Add(btn_Load);
            Controls.Add(dataGridView_Members);
            Name = "Admin_MemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += Admin_MemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Members).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Members;
        private Button btn_Load;
        private Button btn_Create;
        private Button btn_Update;
        private Button btn_Delete;
    }
}