namespace Food1
{
    partial class MDIForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.البياناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الاصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الزبائنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الخToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الطلبياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استلامطلبيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الزباToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الطلبياتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.الاصنافToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.الطلبياتالمستلمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 436);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(587, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.البياناتToolStripMenuItem,
            this.الخToolStripMenuItem,
            this.تقاريرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // البياناتToolStripMenuItem
            // 
            this.البياناتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الاصنافToolStripMenuItem,
            this.الزبائنToolStripMenuItem});
            this.البياناتToolStripMenuItem.Name = "البياناتToolStripMenuItem";
            this.البياناتToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.البياناتToolStripMenuItem.Text = "البيانات";
            // 
            // الاصنافToolStripMenuItem
            // 
            this.الاصنافToolStripMenuItem.Name = "الاصنافToolStripMenuItem";
            this.الاصنافToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.الاصنافToolStripMenuItem.Text = "الاصناف ";
            this.الاصنافToolStripMenuItem.Click += new System.EventHandler(this.الاصنافToolStripMenuItem_Click);
            // 
            // الزبائنToolStripMenuItem
            // 
            this.الزبائنToolStripMenuItem.Name = "الزبائنToolStripMenuItem";
            this.الزبائنToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.الزبائنToolStripMenuItem.Text = "الزبائن";
            this.الزبائنToolStripMenuItem.Click += new System.EventHandler(this.الزبائنToolStripMenuItem_Click);
            // 
            // الخToolStripMenuItem
            // 
            this.الخToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الطلبياتToolStripMenuItem,
            this.استلامطلبيةToolStripMenuItem});
            this.الخToolStripMenuItem.Name = "الخToolStripMenuItem";
            this.الخToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.الخToolStripMenuItem.Text = "الحركة اليومية";
            // 
            // الطلبياتToolStripMenuItem
            // 
            this.الطلبياتToolStripMenuItem.Name = "الطلبياتToolStripMenuItem";
            this.الطلبياتToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.الطلبياتToolStripMenuItem.Text = "الطلبيات";
            this.الطلبياتToolStripMenuItem.Click += new System.EventHandler(this.الطلبياتToolStripMenuItem_Click);
            // 
            // استلامطلبيةToolStripMenuItem
            // 
            this.استلامطلبيةToolStripMenuItem.Name = "استلامطلبيةToolStripMenuItem";
            this.استلامطلبيةToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.استلامطلبيةToolStripMenuItem.Text = "استلام طلبية";
            // 
            // تقاريرToolStripMenuItem
            // 
            this.تقاريرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الزباToolStripMenuItem,
            this.الطلبياتToolStripMenuItem1,
            this.الاصنافToolStripMenuItem1,
            this.الطلبياتالمستلمةToolStripMenuItem});
            this.تقاريرToolStripMenuItem.Name = "تقاريرToolStripMenuItem";
            this.تقاريرToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.تقاريرToolStripMenuItem.Text = "تقارير";
            // 
            // الزباToolStripMenuItem
            // 
            this.الزباToolStripMenuItem.Name = "الزباToolStripMenuItem";
            this.الزباToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.الزباToolStripMenuItem.Text = "الزبائن";
            // 
            // الطلبياتToolStripMenuItem1
            // 
            this.الطلبياتToolStripMenuItem1.Name = "الطلبياتToolStripMenuItem1";
            this.الطلبياتToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.الطلبياتToolStripMenuItem1.Text = "الطلبيات";
            // 
            // الاصنافToolStripMenuItem1
            // 
            this.الاصنافToolStripMenuItem1.Name = "الاصنافToolStripMenuItem1";
            this.الاصنافToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.الاصنافToolStripMenuItem1.Text = "الاصناف";
            // 
            // الطلبياتالمستلمةToolStripMenuItem
            // 
            this.الطلبياتالمستلمةToolStripMenuItem.Name = "الطلبياتالمستلمةToolStripMenuItem";
            this.الطلبياتالمستلمةToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.الطلبياتالمستلمةToolStripMenuItem.Text = "الطلبيات المستلمة";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 458);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة الطلبيات";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem البياناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الاصنافToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الزبائنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الخToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الطلبياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استلامطلبيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الزباToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الطلبياتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem الاصنافToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem الطلبياتالمستلمةToolStripMenuItem;
    }
}



