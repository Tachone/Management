namespace Management
{
    partial class frmStuGrade
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
            this.dataGviewSort = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comBSyear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewSort)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGviewSort
            // 
            this.dataGviewSort.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGviewSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGviewSort.Location = new System.Drawing.Point(-1, 32);
            this.dataGviewSort.Name = "dataGviewSort";
            this.dataGviewSort.RowTemplate.Height = 23;
            this.dataGviewSort.Size = new System.Drawing.Size(389, 299);
            this.dataGviewSort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择学年：";
            // 
            // comBSyear
            // 
            this.comBSyear.FormattingEnabled = true;
            this.comBSyear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015"});
            this.comBSyear.Location = new System.Drawing.Point(174, 6);
            this.comBSyear.Name = "comBSyear";
            this.comBSyear.Size = new System.Drawing.Size(121, 20);
            this.comBSyear.TabIndex = 2;
            this.comBSyear.SelectedIndexChanged += new System.EventHandler(this.comBSyear_SelectedIndexChanged);
            // 
            // frmStuGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 358);
            this.Controls.Add(this.comBSyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGviewSort);
            this.Name = "frmStuGrade";
            this.Text = "学生成绩排名";
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGviewSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBSyear;
    }
}