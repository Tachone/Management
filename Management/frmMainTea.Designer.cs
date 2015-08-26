namespace Management
{
    partial class frmMainTea
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
            this.btnGrSort = new System.Windows.Forms.Button();
            this.btnOth = new System.Windows.Forms.Button();
            this.btnCouAvg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(210, 28);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(85, 23);
            this.btnGrade.TabIndex = 0;
            this.btnGrade.Text = "学生成绩维护";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGrSort
            // 
            this.btnGrSort.Location = new System.Drawing.Point(210, 78);
            this.btnGrSort.Name = "btnGrSort";
            this.btnGrSort.Size = new System.Drawing.Size(85, 23);
            this.btnGrSort.TabIndex = 1;
            this.btnGrSort.Text = "学生成绩排名";
            this.btnGrSort.UseVisualStyleBackColor = true;
            this.btnGrSort.Click += new System.EventHandler(this.btnGrSort_Click);
            // 
            // btnOth
            // 
            this.btnOth.Location = new System.Drawing.Point(210, 190);
            this.btnOth.Name = "btnOth";
            this.btnOth.Size = new System.Drawing.Size(85, 23);
            this.btnOth.TabIndex = 2;
            this.btnOth.Text = "其他查询";
            this.btnOth.UseVisualStyleBackColor = true;
            this.btnOth.Click += new System.EventHandler(this.btnOth_Click);
            // 
            // btnCouAvg
            // 
            this.btnCouAvg.Location = new System.Drawing.Point(210, 131);
            this.btnCouAvg.Name = "btnCouAvg";
            this.btnCouAvg.Size = new System.Drawing.Size(85, 23);
            this.btnCouAvg.TabIndex = 4;
            this.btnCouAvg.Text = "课程平均成绩";
            this.btnCouAvg.UseVisualStyleBackColor = true;
            this.btnCouAvg.Click += new System.EventHandler(this.btnCouAvg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management.Properties.Resources._20125217549743;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 262);
            this.Controls.Add(this.btnCouAvg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOth);
            this.Controls.Add(this.btnGrSort);
            this.Controls.Add(this.btnGrade);
            this.Name = "frmMainTea";
            this.Text = "教师";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnGrSort;
        private System.Windows.Forms.Button btnOth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCouAvg;
    }
}