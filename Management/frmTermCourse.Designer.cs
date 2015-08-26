namespace Management
{
    partial class frmTermCourse
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
            this.dataGviewTg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewTg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGviewTg
            // 
            this.dataGviewTg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGviewTg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGviewTg.Location = new System.Drawing.Point(-1, 49);
            this.dataGviewTg.Name = "dataGviewTg";
            this.dataGviewTg.RowTemplate.Height = 23;
            this.dataGviewTg.Size = new System.Drawing.Size(437, 295);
            this.dataGviewTg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择学期：";
            // 
            // comboTg
            // 
            this.comboTg.FormattingEnabled = true;
            this.comboTg.Items.AddRange(new object[] {
            "2013(1)",
            "2013(2)",
            "2014(1)",
            "2014(2)",
            "2015(1)",
            "2015(2)"});
            this.comboTg.Location = new System.Drawing.Point(207, 6);
            this.comboTg.Name = "comboTg";
            this.comboTg.Size = new System.Drawing.Size(108, 20);
            this.comboTg.TabIndex = 2;
            this.comboTg.SelectedIndexChanged += new System.EventHandler(this.comboTg_SelectedIndexChanged);
            // 
            // frmTermCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 366);
            this.Controls.Add(this.comboTg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGviewTg);
            this.Name = "frmTermCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学期课程信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewTg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGviewTg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTg;
    }
}