namespace Management
{
    partial class frmPerInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtAcreit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGviewXian = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewXian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "专业：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "生源地：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "已修学分:";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(112, 19);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 21);
            this.txtSno.TabIndex = 6;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(112, 63);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 7;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(112, 108);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 21);
            this.txtMajor.TabIndex = 8;
            // 
            // txtBan
            // 
            this.txtBan.Location = new System.Drawing.Point(112, 149);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(100, 21);
            this.txtBan.TabIndex = 9;
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(112, 190);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(100, 21);
            this.txtHome.TabIndex = 10;
            // 
            // txtAcreit
            // 
            this.txtAcreit.Location = new System.Drawing.Point(112, 237);
            this.txtAcreit.Name = "txtAcreit";
            this.txtAcreit.Size = new System.Drawing.Size(100, 21);
            this.txtAcreit.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "完成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "班级：";
            // 
            // dataGviewXian
            // 
            this.dataGviewXian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGviewXian.Location = new System.Drawing.Point(262, 303);
            this.dataGviewXian.Name = "dataGviewXian";
            this.dataGviewXian.RowTemplate.Height = 23;
            this.dataGviewXian.Size = new System.Drawing.Size(22, 10);
            this.dataGviewXian.TabIndex = 14;
            this.dataGviewXian.Visible = false;
            // 
            // frmPerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.dataGviewXian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAcreit);
            this.Controls.Add(this.txtHome);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPerInfo";
            this.Text = "个人信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewXian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtAcreit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGviewXian;
    }
}