namespace SaleWebApp
{
    partial class frm_SaleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SaleManagement));
            pictureBox_SaleManagement = new PictureBox();
            menuStrip1 = new MenuStrip();
            memberManagementToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            orderManagementToolStripMenuItem = new ToolStripMenuItem();
            lb_Wellcome = new Label();
            label_Name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SaleManagement).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_SaleManagement
            // 
            pictureBox_SaleManagement.Dock = DockStyle.Right;
            pictureBox_SaleManagement.Image = (Image)resources.GetObject("pictureBox_SaleManagement.Image");
            pictureBox_SaleManagement.Location = new Point(356, 28);
            pictureBox_SaleManagement.Name = "pictureBox_SaleManagement";
            pictureBox_SaleManagement.Size = new Size(714, 498);
            pictureBox_SaleManagement.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_SaleManagement.TabIndex = 0;
            pictureBox_SaleManagement.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FloralWhite;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { memberManagementToolStripMenuItem, productManagementToolStripMenuItem, orderManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // memberManagementToolStripMenuItem
            // 
            memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            memberManagementToolStripMenuItem.Size = new Size(171, 24);
            memberManagementToolStripMenuItem.Text = "Member Management";
            memberManagementToolStripMenuItem.Click += memberManagementToolStripMenuItem_Click;
            // 
            // productManagementToolStripMenuItem
            // 
            productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            productManagementToolStripMenuItem.Size = new Size(166, 24);
            productManagementToolStripMenuItem.Text = "Product Management";
            productManagementToolStripMenuItem.Click += productManagementToolStripMenuItem_Click;
            // 
            // orderManagementToolStripMenuItem
            // 
            orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            orderManagementToolStripMenuItem.Size = new Size(153, 24);
            orderManagementToolStripMenuItem.Text = "Order Management";
            orderManagementToolStripMenuItem.Click += orderManagementToolStripMenuItem_Click;
            // 
            // lb_Wellcome
            // 
            lb_Wellcome.AutoSize = true;
            lb_Wellcome.Font = new Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Wellcome.Location = new Point(93, 207);
            lb_Wellcome.Name = "lb_Wellcome";
            lb_Wellcome.Size = new Size(160, 34);
            lb_Wellcome.TabIndex = 2;
            lb_Wellcome.Text = "Wellcome";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_Name.Location = new Point(63, 264);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(0, 26);
            label_Name.TabIndex = 3;
            // 
            // frm_SaleManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1070, 526);
            Controls.Add(label_Name);
            Controls.Add(lb_Wellcome);
            Controls.Add(pictureBox_SaleManagement);
            Controls.Add(menuStrip1);
            Name = "frm_SaleManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Management";
            Load += frm_SaleManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_SaleManagement).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_SaleManagement;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem memberManagementToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem orderManagementToolStripMenuItem;
        private Label lb_Wellcome;
        private Label label_Name;
    }
}