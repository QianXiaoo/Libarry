namespace Libarry
{
    partial class admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者数据维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅数据录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书数据录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.图书数据查询ToolStripMenuItem,
            this.读者数据维护ToolStripMenuItem,
            this.借阅数据录入ToolStripMenuItem,
            this.还书数据录入ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1418, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.图书管理ToolStripMenuItem.Text = "图书数据维护";
            this.图书管理ToolStripMenuItem.Click += new System.EventHandler(this.图书管理ToolStripMenuItem_Click);
            // 
            // 图书数据查询ToolStripMenuItem
            // 
            this.图书数据查询ToolStripMenuItem.Name = "图书数据查询ToolStripMenuItem";
            this.图书数据查询ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.图书数据查询ToolStripMenuItem.Text = "图书数据查询";
            this.图书数据查询ToolStripMenuItem.Click += new System.EventHandler(this.图书数据查询ToolStripMenuItem_Click);
            // 
            // 读者数据维护ToolStripMenuItem
            // 
            this.读者数据维护ToolStripMenuItem.Name = "读者数据维护ToolStripMenuItem";
            this.读者数据维护ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.读者数据维护ToolStripMenuItem.Text = "读者数据维护";
            this.读者数据维护ToolStripMenuItem.Click += new System.EventHandler(this.读者数据维护ToolStripMenuItem_Click);
            // 
            // 借阅数据录入ToolStripMenuItem
            // 
            this.借阅数据录入ToolStripMenuItem.Name = "借阅数据录入ToolStripMenuItem";
            this.借阅数据录入ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.借阅数据录入ToolStripMenuItem.Text = "借阅数据录入";
            this.借阅数据录入ToolStripMenuItem.Click += new System.EventHandler(this.借阅数据录入ToolStripMenuItem_Click);
            // 
            // 还书数据录入ToolStripMenuItem
            // 
            this.还书数据录入ToolStripMenuItem.Name = "还书数据录入ToolStripMenuItem";
            this.还书数据录入ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.还书数据录入ToolStripMenuItem.Text = "归还数据录入";
            this.还书数据录入ToolStripMenuItem.Click += new System.EventHandler(this.还书数据录入ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎管理员登录";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin";
            this.Text = "管理员页面";
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 图书数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者数据维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅数据录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书数据录入ToolStripMenuItem;
    }
}