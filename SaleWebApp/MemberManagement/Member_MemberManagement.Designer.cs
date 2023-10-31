namespace SaleWebApp.MemberManagement
{
    partial class Member_MemberManagement
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
            lb_Email = new Label();
            txtb_Email = new TextBox();
            txtb_CompanyName = new TextBox();
            lb_CompanyName = new Label();
            txtb_City = new TextBox();
            lb_City = new Label();
            txtb_Country = new TextBox();
            lb_Country = new Label();
            txtb_Password = new TextBox();
            lb_Password = new Label();
            btn_Load = new Button();
            btn_Update = new Button();
            SuspendLayout();
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Email.Location = new Point(66, 64);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(65, 21);
            lb_Email.TabIndex = 0;
            lb_Email.Text = "Email:";
            // 
            // txtb_Email
            // 
            txtb_Email.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Email.Location = new Point(258, 56);
            txtb_Email.Name = "txtb_Email";
            txtb_Email.Size = new Size(332, 29);
            txtb_Email.TabIndex = 1;
            // 
            // txtb_CompanyName
            // 
            txtb_CompanyName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_CompanyName.Location = new Point(258, 102);
            txtb_CompanyName.Name = "txtb_CompanyName";
            txtb_CompanyName.Size = new Size(332, 29);
            txtb_CompanyName.TabIndex = 3;
            // 
            // lb_CompanyName
            // 
            lb_CompanyName.AutoSize = true;
            lb_CompanyName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_CompanyName.Location = new Point(66, 110);
            lb_CompanyName.Name = "lb_CompanyName";
            lb_CompanyName.Size = new Size(157, 21);
            lb_CompanyName.TabIndex = 2;
            lb_CompanyName.Text = "Company Name:";
            // 
            // txtb_City
            // 
            txtb_City.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_City.Location = new Point(258, 150);
            txtb_City.Name = "txtb_City";
            txtb_City.Size = new Size(332, 29);
            txtb_City.TabIndex = 5;
            // 
            // lb_City
            // 
            lb_City.AutoSize = true;
            lb_City.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_City.Location = new Point(66, 158);
            lb_City.Name = "lb_City";
            lb_City.Size = new Size(56, 21);
            lb_City.TabIndex = 4;
            lb_City.Text = "City: ";
            // 
            // txtb_Country
            // 
            txtb_Country.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Country.Location = new Point(258, 198);
            txtb_Country.Name = "txtb_Country";
            txtb_Country.Size = new Size(332, 29);
            txtb_Country.TabIndex = 7;
            // 
            // lb_Country
            // 
            lb_Country.AutoSize = true;
            lb_Country.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Country.Location = new Point(66, 206);
            lb_Country.Name = "lb_Country";
            lb_Country.Size = new Size(93, 21);
            lb_Country.TabIndex = 6;
            lb_Country.Text = "Country: ";
            // 
            // txtb_Password
            // 
            txtb_Password.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Password.Location = new Point(258, 248);
            txtb_Password.Name = "txtb_Password";
            txtb_Password.Size = new Size(332, 29);
            txtb_Password.TabIndex = 9;
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Password.Location = new Point(66, 256);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(98, 21);
            lb_Password.TabIndex = 8;
            lb_Password.Text = "Password:";
            // 
            // btn_Load
            // 
            btn_Load.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Load.Location = new Point(258, 319);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(128, 50);
            btn_Load.TabIndex = 10;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(462, 319);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(128, 50);
            btn_Update.TabIndex = 11;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // Member_MemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(679, 381);
            Controls.Add(btn_Update);
            Controls.Add(btn_Load);
            Controls.Add(txtb_Password);
            Controls.Add(lb_Password);
            Controls.Add(txtb_Country);
            Controls.Add(lb_Country);
            Controls.Add(txtb_City);
            Controls.Add(lb_City);
            Controls.Add(txtb_CompanyName);
            Controls.Add(lb_CompanyName);
            Controls.Add(txtb_Email);
            Controls.Add(lb_Email);
            Name = "Member_MemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberManagement";
            Load += Member_MemberManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Email;
        private TextBox txtb_Email;
        private TextBox txtb_CompanyName;
        private Label lb_CompanyName;
        private TextBox txtb_City;
        private Label lb_City;
        private TextBox txtb_Country;
        private Label lb_Country;
        private TextBox txtb_Password;
        private Label lb_Password;
        private Button btn_Load;
        private Button btn_Update;
    }
}