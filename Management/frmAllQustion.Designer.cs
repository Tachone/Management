namespace Management
{
    partial class frmAllQustion
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
            this.dataGviewTea = new System.Windows.Forms.DataGridView();
            this.ComInit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewTea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择查询内容：";
            // 
            // dataGviewTea
            // 
            this.dataGviewTea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGviewTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGviewTea.Location = new System.Drawing.Point(2, 45);
            this.dataGviewTea.Name = "dataGviewTea";
            this.dataGviewTea.RowTemplate.Height = 23;
            this.dataGviewTea.Size = new System.Drawing.Size(452, 306);
            this.dataGviewTea.TabIndex = 3;
            // 
            // ComInit
            // 
            this.ComInit.FormattingEnabled = true;
            this.ComInit.Items.AddRange(new object[] {
            "教师任课查询",
            "班级课程查询",
            "地区人数查询"});
            this.ComInit.Location = new System.Drawing.Point(207, 12);
            this.ComInit.Name = "ComInit";
            this.ComInit.Size = new System.Drawing.Size(121, 20);
            this.ComInit.TabIndex = 4;
            this.ComInit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmAllQustion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 398);
            this.Controls.Add(this.ComInit);
            this.Controls.Add(this.dataGviewTea);
            this.Controls.Add(this.label1);
            this.Name = "frmAllQustion";
            this.Text = "公共信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewTea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGviewTea;
        private System.Windows.Forms.ComboBox ComInit;
    }
}