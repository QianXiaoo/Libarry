namespace Libarry
{
    partial class reader
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
            this.图书数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书数据查询ToolStripMenuItem,
            this.借阅数据查询ToolStripMenuItem,
            this.还书数据查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1406, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书数据查询ToolStripMenuItem
            // 
            this.图书数据查询ToolStripMenuItem.Name = "图书数据查询ToolStripMenuItem";
            this.图书数据查询ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.图书数据查询ToolStripMenuItem.Text = "图书数据查询";
            this.图书数据查询ToolStripMenuItem.Click += new System.EventHandler(this.图书数据查询ToolStripMenuItem_Click);
            // 
            // 借阅数据查询ToolStripMenuItem
            // 
            this.借阅数据查询ToolStripMenuItem.Name = "借阅数据查询ToolStripMenuItem";
            this.借阅数据查询ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.借阅数据查询ToolStripMenuItem.Text = "借阅数据情况";
            this.借阅数据查询ToolStripMenuItem.Click += new System.EventHandler(this.借阅数据查询ToolStripMenuItem_Click);
            // 
            // 还书数据查询ToolStripMenuItem
            // 
            this.还书数据查询ToolStripMenuItem.Name = "还书数据查询ToolStripMenuItem";
            this.还书数据查询ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.还书数据查询ToolStripMenuItem.Text = "还书数据情况";
            this.还书数据查询ToolStripMenuItem.Click += new System.EventHandler(this.还书数据查询ToolStripMenuItem_Click);
            // 
            // reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reader";
            this.Text = "读者登录页面";
            this.Load += new System.EventHandler(this.reader_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书数据查询ToolStripMenuItem;
    }
}