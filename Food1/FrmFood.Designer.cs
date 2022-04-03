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
            this.btn_First_It = new System.Windows.Forms.Button();
            this.btn_previous_IT = new System.Windows.Forms.Button();
            this.btn_Next_IT = new System.Windows.Forms.Button();
            this.btn_Last_IT = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delet = new System.Windows.Forms.Button();
            this.btn_Updat = new System.Windows.Forms.Button();
            this.btn_Out = new System.Windows.Forms.Button();
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
            // btn_First_It
            // 
            this.btn_First_It.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_First_It, "btn_First_It");
            this.btn_First_It.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_First_It.Name = "btn_First_It";
            this.btn_First_It.UseVisualStyleBackColor = false;
            this.btn_First_It.Click += new System.EventHandler(this.btn_First_It_Click);
            // 
            // btn_previous_IT
            // 
            this.btn_previous_IT.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_previous_IT, "btn_previous_IT");
            this.btn_previous_IT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_previous_IT.Name = "btn_previous_IT";
            this.btn_previous_IT.UseVisualStyleBackColor = false;
            this.btn_previous_IT.Click += new System.EventHandler(this.btn_previous_IT_Click);
            // 
            // btn_Next_IT
            // 
            this.btn_Next_IT.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Next_IT, "btn_Next_IT");
            this.btn_Next_IT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Next_IT.Name = "btn_Next_IT";
            this.btn_Next_IT.UseVisualStyleBackColor = false;
            this.btn_Next_IT.Click += new System.EventHandler(this.btn_Next_IT_Click);
            // 
            // btn_Last_IT
            // 
            this.btn_Last_IT.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Last_IT, "btn_Last_IT");
            this.btn_Last_IT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Last_IT.Name = "btn_Last_IT";
            this.btn_Last_IT.UseVisualStyleBackColor = false;
            this.btn_Last_IT.Click += new System.EventHandler(this.btn_Last_IT_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_ShowAll, "btn_ShowAll");
            this.btn_ShowAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delet
            // 
            this.btn_Delet.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Delet, "btn_Delet");
            this.btn_Delet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delet.Name = "btn_Delet";
            this.btn_Delet.UseVisualStyleBackColor = false;
            this.btn_Delet.Click += new System.EventHandler(this.btn_Delet_Click);
            // 
            // btn_Updat
            // 
            this.btn_Updat.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Updat, "btn_Updat");
            this.btn_Updat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Updat.Name = "btn_Updat";
            this.btn_Updat.UseVisualStyleBackColor = false;
            this.btn_Updat.Click += new System.EventHandler(this.btn_Updat_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Out, "btn_Out");
            this.btn_Out.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.UseVisualStyleBackColor = false;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // FrmFood
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.btn_Updat);
            this.Controls.Add(this.btn_Delet);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.btn_Last_IT);
            this.Controls.Add(this.btn_Next_IT);
            this.Controls.Add(this.btn_previous_IT);
            this.Controls.Add(this.btn_First_It);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNo_Item;
        private System.Windows.Forms.TextBox txtNa_Item;
        private System.Windows.Forms.Button btn_First_It;
        private System.Windows.Forms.Button btn_previous_IT;
        private System.Windows.Forms.Button btn_Next_IT;
        private System.Windows.Forms.Button btn_Last_IT;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delet;
        private System.Windows.Forms.Button btn_Updat;
        private System.Windows.Forms.Button btn_Out;
    }
}