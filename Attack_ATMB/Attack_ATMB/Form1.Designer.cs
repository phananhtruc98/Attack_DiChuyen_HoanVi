namespace Attack_ATMB
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCThuậtToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchChuyểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoánVịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huấnLuyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tấnCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sCThuậtToánToolStripMenuItem,
            this.attackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sCThuậtToánToolStripMenuItem
            // 
            this.sCThuậtToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dịchChuyểnToolStripMenuItem,
            this.hoánVịToolStripMenuItem});
            this.sCThuậtToánToolStripMenuItem.Name = "sCThuậtToánToolStripMenuItem";
            this.sCThuậtToánToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.sCThuậtToánToolStripMenuItem.Text = "SC Thuật toán";
            // 
            // dịchChuyểnToolStripMenuItem
            // 
            this.dịchChuyểnToolStripMenuItem.Name = "dịchChuyểnToolStripMenuItem";
            this.dịchChuyểnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dịchChuyểnToolStripMenuItem.Text = "Dịch chuyển";
            this.dịchChuyểnToolStripMenuItem.Click += new System.EventHandler(this.dịchChuyểnToolStripMenuItem_Click);
            // 
            // hoánVịToolStripMenuItem
            // 
            this.hoánVịToolStripMenuItem.Name = "hoánVịToolStripMenuItem";
            this.hoánVịToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hoánVịToolStripMenuItem.Text = "Hoán vị";
            this.hoánVịToolStripMenuItem.Click += new System.EventHandler(this.hoánVịToolStripMenuItem_Click);
            // 
            // attackToolStripMenuItem
            // 
            this.attackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huấnLuyệnToolStripMenuItem,
            this.tấnCôngToolStripMenuItem});
            this.attackToolStripMenuItem.Name = "attackToolStripMenuItem";
            this.attackToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.attackToolStripMenuItem.Text = "Attack";
            // 
            // huấnLuyệnToolStripMenuItem
            // 
            this.huấnLuyệnToolStripMenuItem.Name = "huấnLuyệnToolStripMenuItem";
            this.huấnLuyệnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.huấnLuyệnToolStripMenuItem.Text = "Huấn luyện";
            this.huấnLuyệnToolStripMenuItem.Click += new System.EventHandler(this.huấnLuyệnToolStripMenuItem_Click);
            // 
            // tấnCôngToolStripMenuItem
            // 
            this.tấnCôngToolStripMenuItem.Name = "tấnCôngToolStripMenuItem";
            this.tấnCôngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tấnCôngToolStripMenuItem.Text = "Tấn công";
            this.tấnCôngToolStripMenuItem.Click += new System.EventHandler(this.tấnCôngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCThuậtToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchChuyểnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoánVịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huấnLuyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tấnCôngToolStripMenuItem;
    }
}

