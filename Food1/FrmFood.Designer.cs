namespace Food1
{
    partial class FrmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFood));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice_Item = new System.Windows.Forms.TextBox();
            this.txtNa_Item = new System.Windows.Forms.TextBox();
            this.txtNo_Item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Out = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Show_All = new DevExpress.XtraEditors.SimpleButton();
            this.btn_First_item = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Last_item = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Next_item = new DevExpress.XtraEditors.SimpleButton();
            this.btn_previous_item = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPrice_Item);
            this.panel1.Controls.Add(this.txtNa_Item);
            this.panel1.Controls.Add(this.txtNo_Item);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Name = "panel1";
            // 
            // txtPrice_Item
            // 
            this.txtPrice_Item.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.txtPrice_Item, "txtPrice_Item");
            this.txtPrice_Item.Name = "txtPrice_Item";
            // 
            // txtNa_Item
            // 
            this.txtNa_Item.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.txtNa_Item, "txtNa_Item");
            this.txtNa_Item.Name = "txtNa_Item";
            // 
            // txtNo_Item
            // 
            this.txtNo_Item.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.txtNo_Item, "txtNo_Item");
            this.txtNo_Item.Name = "txtNo_Item";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSave.Appearance.Font")));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_Delete.Appearance.Font")));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            resources.ApplyResources(this.btn_Delete, "btn_Delete");
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_Out.Appearance.Font")));
            this.btn_Out.Appearance.Options.UseFont = true;
            this.btn_Out.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Out.ImageOptions.Image")));
            resources.ApplyResources(this.btn_Out, "btn_Out");
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_Update.Appearance.Font")));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            resources.ApplyResources(this.btn_Update, "btn_Update");
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Show_All
            // 
            this.btn_Show_All.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_Show_All.Appearance.Font")));
            this.btn_Show_All.Appearance.Options.UseFont = true;
            this.btn_Show_All.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Show_All.ImageOptions.Image")));
            resources.ApplyResources(this.btn_Show_All, "btn_Show_All");
            this.btn_Show_All.Name = "btn_Show_All";
            this.btn_Show_All.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Show_All.Click += new System.EventHandler(this.btn_Show_All_Click);
            // 
            // btn_First_item
            // 
            this.btn_First_item.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_First_item.Appearance.Options.UseForeColor = true;
            this.btn_First_item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_First_item.ImageOptions.Image")));
            resources.ApplyResources(this.btn_First_item, "btn_First_item");
            this.btn_First_item.Name = "btn_First_item";
            this.btn_First_item.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_First_item.Click += new System.EventHandler(this.btn_First_item_Click);
            // 
            // btn_Last_item
            // 
            this.btn_Last_item.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Last_item.Appearance.Options.UseForeColor = true;
            this.btn_Last_item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Last_item.ImageOptions.Image")));
            resources.ApplyResources(this.btn_Last_item, "btn_Last_item");
            this.btn_Last_item.Name = "btn_Last_item";
            this.btn_Last_item.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Last_item.Click += new System.EventHandler(this.btn_Last_item_Click);
            // 
            // btn_Next_item
            // 
            this.btn_Next_item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next_item.ImageOptions.Image")));
            resources.ApplyResources(this.btn_Next_item, "btn_Next_item");
            this.btn_Next_item.Name = "btn_Next_item";
            this.btn_Next_item.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Next_item.Click += new System.EventHandler(this.btn_Next_item_Click);
            // 
            // btn_previous_item
            // 
            this.btn_previous_item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous_item.ImageOptions.Image")));
            resources.ApplyResources(this.btn_previous_item, "btn_previous_item");
            this.btn_previous_item.Name = "btn_previous_item";
            this.btn_previous_item.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_previous_item.Click += new System.EventHandler(this.btn_previous_item_Click);
            // 
            // FrmFood
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btn_previous_item);
            this.Controls.Add(this.btn_Next_item);
            this.Controls.Add(this.btn_Last_item);
            this.Controls.Add(this.btn_First_item);
            this.Controls.Add(this.btn_Show_All);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFood";
            this.Load += new System.EventHandler(this.FrmFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrice_Item;
        private System.Windows.Forms.TextBox txtNo_Item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Out;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Show_All;
        private DevExpress.XtraEditors.SimpleButton btn_First_item;
        private DevExpress.XtraEditors.SimpleButton btn_Last_item;
        private DevExpress.XtraEditors.SimpleButton btn_Next_item;
        private DevExpress.XtraEditors.SimpleButton btn_previous_item;
        protected System.Windows.Forms.TextBox txtNa_Item;
    }
}