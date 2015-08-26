namespace Management
{
    partial class frmMainStu
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
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPerInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(230, 106);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(86, 23);
            this.btnGrade.TabIndex = 0;
            this.btnGrade.Text = "个人成绩查询";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnTea
            // 
            this.btnTea.Location = new System.Drawing.Point(230, 197);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(86, 23);
            this.btnTea.TabIndex = 1;
            this.btnTea.Text = "学期课程查询";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management.Properties.Resources.QQ截图20150704125649;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPerInfo
            // 
            this.btnPerInfo.Location = new System.Drawing.Point(230, 25);
            this.btnPerInfo.Name = "btnPerInfo";
            this.btnPerInfo.Size = new System.Drawing.Size(86, 23);
            this.btnPerInfo.TabIndex = 3;
            this.btnPerInfo.Text = "个人信息查询";
            this.btnPerInfo.UseVisualStyleBackColor = true;
            this.btnPerInfo.Click += new System.EventHandler(this.btnPerInfo_Click);
            // 
            // frmMainStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 262);
            this.Controls.Add(this.btnPerInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTea);
            this.Controls.Add(this.btnGrade);
            this.Name = "frmMainStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPerInfo;
    }
}