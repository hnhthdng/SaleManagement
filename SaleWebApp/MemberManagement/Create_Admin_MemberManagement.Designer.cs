namespace SaleWebApp.MemberManagement
{
    partial class Create_Admin_MemberManagement
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
            txtb_Password = new TextBox();
            lb_Password = new Label();
            txtb_Country = new TextBox();
            lb_Country = new Label();
            txtb_City = new TextBox();
            lb_City = new Label();
            txtb_CompanyName = new TextBox();
            lb_CompanyName = new Label();
            txtb_Email = new TextBox();
            lb_Email = new Label();
            btn_Create = new Button();
            SuspendLayout();
            // 
            // txtb_Password
            // 
            txtb_Password.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Password.Location = new Point(218, 238);
            txtb_Password.Name = "txtb_Password";
            txtb_Password.Size = new Size(332, 29);
            txtb_Password.TabIndex = 21;
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Password.Location = new Point(26, 246);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(98, 21);
            lb_Password.TabIndex = 20;
            lb_Password.Text = "Password:";
            // 
            // txtb_Country
            // 
            txtb_Country.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Country.Location = new Point(218, 188);
            txtb_Country.Name = "txtb_Country";
            txtb_Country.Size = new Size(332, 29);
            txtb_Country.TabIndex = 19;
            // 
            // lb_Country
            // 
            lb_Country.AutoSize = true;
            lb_Country.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Country.Location = new Point(26, 196);
            lb_Country.Name = "lb_Country";
            lb_Country.Size = new Size(93, 21);
            lb_Country.TabIndex = 18;
            lb_Country.Text = "Country: ";
            // 
            // txtb_City
            // 
            txtb_City.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_City.Location = new Point(218, 140);
            txtb_City.Name = "txtb_City";
            txtb_City.Size = new Size(332, 29);
            txtb_City.TabIndex = 17;
            // 
            // lb_City
            // 
            lb_City.AutoSize = true;
            lb_City.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_City.Location = new Point(26, 148);
            lb_City.Name = "lb_City";
            lb_City.Size = new Size(56, 21);
            lb_City.TabIndex = 16;
            lb_City.Text = "City: ";
            // 
            // txtb_CompanyName
            // 
            txtb_CompanyName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_CompanyName.Location = new Point(218, 92);
            txtb_CompanyName.Name = "txtb_CompanyName";
            txtb_CompanyName.Size = new Size(332, 29);
            txtb_CompanyName.TabIndex = 15;
            // 
            // lb_CompanyName
            // 
            lb_CompanyName.AutoSize = true;
            lb_CompanyName.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_CompanyName.Location = new Point(26, 100);
            lb_CompanyName.Name = "lb_CompanyName";
            lb_CompanyName.Size = new Size(157, 21);
            lb_CompanyName.TabIndex = 14;
            lb_CompanyName.Text = "Company Name:";
            // 
            // txtb_Email
            // 
            txtb_Email.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_Email.Location = new Point(218, 46);
            txtb_Email.Name = "txtb_Email";
            txtb_Email.Size = new Size(332, 29);
            txtb_Email.TabIndex = 13;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Lucida Bright", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Email.Location = new Point(26, 54);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(65, 21);
            lb_Email.TabIndex = 12;
            lb_Email.Text = "Email:";
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(316, 285);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(141, 61);
            btn_Create.TabIndex = 22;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // Create_Admin_MemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(598, 358);
            Controls.Add(btn_Create);
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
            ForeColor = SystemColors.ControlText;
            Name = "Create_Admin_MemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_Password;
        private Label lb_Password;
        private TextBox txtb_Country;
        private Label lb_Country;
        private TextBox txtb_City;
        private Label lb_City;
        private TextBox txtb_CompanyName;
        private Label lb_CompanyName;
        private TextBox txtb_Email;
        private Label lb_Email;
        private Button btn_Create;
    }
}