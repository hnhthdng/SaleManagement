namespace SaleWebApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            lb_Heading = new Label();
            panel1 = new Panel();
            btn_Login = new Button();
            textBox_Password = new TextBox();
            lb_Password = new Label();
            textBox_Email = new TextBox();
            lb_Email = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(727, 609);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_Heading
            // 
            lb_Heading.AutoSize = true;
            lb_Heading.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Heading.ForeColor = Color.CadetBlue;
            lb_Heading.Location = new Point(779, 26);
            lb_Heading.Name = "lb_Heading";
            lb_Heading.Size = new Size(372, 31);
            lb_Heading.TabIndex = 1;
            lb_Heading.Text = "Sale Management System ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(lb_Password);
            panel1.Controls.Add(textBox_Email);
            panel1.Controls.Add(lb_Email);
            panel1.Location = new Point(731, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 471);
            panel1.TabIndex = 2;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.Highlight;
            btn_Login.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.ButtonHighlight;
            btn_Login.Location = new Point(171, 330);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(152, 61);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Log in";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password.Location = new Point(133, 245);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(333, 35);
            textBox_Password.TabIndex = 4;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Password.ForeColor = SystemColors.Highlight;
            lb_Password.Location = new Point(3, 254);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(124, 26);
            lb_Password.TabIndex = 3;
            lb_Password.Text = "Password:";
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(133, 149);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(333, 35);
            textBox_Email.TabIndex = 2;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Email.ForeColor = SystemColors.Highlight;
            lb_Email.Location = new Point(3, 158);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(80, 26);
            lb_Email.TabIndex = 1;
            lb_Email.Text = "Email:";
            // 
            // frmLogin
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1212, 607);
            Controls.Add(panel1);
            Controls.Add(lb_Heading);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_Heading;
        private Panel panel1;
        private TextBox textBox_Email;
        private Label lb_Email;
        private TextBox textBox_Password;
        private Label lb_Password;
        private Button btn_Login;
    }
}