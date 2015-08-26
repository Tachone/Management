namespace Management
{
    partial class frmMain
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
            this.btnStu = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnCla = new System.Windows.Forms.Button();
            this.btnOth = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStu
            // 
            this.btnStu.Location = new System.Drawing.Point(294, 26);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(85, 23);
            this.btnStu.TabIndex = 0;
            this.btnStu.Text = "学生信息维护";
            this.btnStu.UseVisualStyleBackColor = true;
            this.btnStu.Click += new System.EventHandler(this.btnStu_Click);
            // 
            // btnTea
            // 
            this.btnTea.Location = new System.Drawing.Point(294, 73);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(85, 23);
            this.btnTea.TabIndex = 1;
            this.btnTea.Text = "教师信息维护";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // btnCla
            // 
            this.btnCla.Location = new System.Drawing.Point(294, 122);
            this.btnCla.Name = "btnCla";
            this.btnCla.Size = new System.Drawing.Size(85, 23);
            this.btnCla.TabIndex = 2;
            this.btnCla.Text = "班级信息维护";
            this.btnCla.UseVisualStyleBackColor = true;
            this.btnCla.Click += new System.EventHandler(this.btnCla_Click);
            // 
            // btnOth
            // 
            this.btnOth.Location = new System.Drawing.Point(294, 217);
            this.btnOth.Name = "btnOth";
            this.btnOth.Size = new System.Drawing.Size(85, 23);
            this.btnOth.TabIndex = 3;
            this.btnOth.Text = "其他信息查询";
            this.btnOth.UseVisualStyleBackColor = true;
            this.btnOth.Click += new System.EventHandler(this.btnOth_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(294, 169);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(85, 23);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "课程信息维护";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management.Properties.Resources._2012331456021;
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(294, 266);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "新建登陆用户";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 313);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOth);
            this.Controls.Add(this.btnCla);
            this.Controls.Add(this.btnTea);
            this.Controls.Add(this.btnStu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnCla;
        private System.Windows.Forms.Button btnOth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnNew;
    }
}