namespace Food1
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhon_Customer = new System.Windows.Forms.TextBox();
            this.txtName_Customer = new System.Windows.Forms.TextBox();
            this.txtNomber_Customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Show_All_Customer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Out = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPhon_Customer);
            this.panel1.Controls.Add(this.txtName_Customer);
            this.panel1.Controls.Add(this.txtNomber_Customer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 124);
            this.panel1.TabIndex = 9;
            // 
            // txtPhon_Customer
            // 
            this.txtPhon_Customer.BackColor = System.Drawing.Color.Beige;
            this.txtPhon_Customer.Enabled = false;
            this.txtPhon_Customer.Location = new System.Drawing.Point(16, 85);
            this.txtPhon_Customer.Name = "txtPhon_Customer";
            this.txtPhon_Customer.Size = new System.Drawing.Size(218, 20);
            this.txtPhon_Customer.TabIndex = 2;
            // 
            // txtName_Customer
            // 
            this.txtName_Customer.BackColor = System.Drawing.Color.Beige;
            this.txtName_Customer.Enabled = false;
            this.txtName_Customer.Location = new System.Drawing.Point(16, 54);
            this.txtName_Customer.Name = "txtName_Customer";
            this.txtName_Customer.Size = new System.Drawing.Size(218, 20);
            this.txtName_Customer.TabIndex = 1;
            // 
            // txtNomber_Customer
            // 
            this.txtNomber_Customer.BackColor = System.Drawing.Color.Beige;
            this.txtNomber_Customer.Enabled = false;
            this.txtNomber_Customer.Location = new System.Drawing.Point(81, 24);
            this.txtNomber_Customer.Multiline = true;
            this.txtNomber_Customer.Name = "txtNomber_Customer";
            this.txtNomber_Customer.Size = new System.Drawing.Size(152, 20);
            this.txtNomber_Customer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(271, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(234, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "رقم هاتف المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(271, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "اسم المستخدم";
            // 
            // btn_Show_All_Customer
            // 
            this.btn_Show_All_Customer.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_All_Customer.Appearance.Options.UseFont = true;
            this.btn_Show_All_Customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Show_All_Customer.ImageOptions.Image")));
            this.btn_Show_All_Customer.Location = new System.Drawing.Point(386, 1);
            this.btn_Show_All_Customer.Name = "btn_Show_All_Customer";
            this.btn_Show_All_Customer.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Show_All_Customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Show_All_Customer.Size = new System.Drawing.Size(156, 52);
            this.btn_Show_All_Customer.TabIndex = 11;
            this.btn_Show_All_Customer.Text = "قائمة المستخدمين";
            this.btn_Show_All_Customer.Click += new System.EventHandler(this.btn_Show_All_Customer_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.Location = new System.Drawing.Point(408, 157);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Update.Size = new System.Drawing.Size(134, 52);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "تأكيد التعديل ";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Out.Appearance.Options.UseFont = true;
            this.btn_Out.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Out.ImageOptions.Image")));
            this.btn_Out.Location = new System.Drawing.Point(434, 210);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Out.Size = new System.Drawing.Size(108, 44);
            this.btn_Out.TabIndex = 15;
            this.btn_Out.Text = "خروج";
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(413, 105);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Delete.Size = new System.Drawing.Size(129, 52);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "حذف مستخدم";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(394, 53);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Add.Size = new System.Drawing.Size(148, 52);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "اضافة  مستخدم جديد";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "شاشة الزبائن";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(553, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Show_All_Customer);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نموذج الزبائن";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPhon_Customer;
        public System.Windows.Forms.TextBox txtName_Customer;
        private System.Windows.Forms.TextBox txtNomber_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_Show_All_Customer;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Out;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.Label label1;
    }
}