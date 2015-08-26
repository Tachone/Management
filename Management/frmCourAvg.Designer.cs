namespace Management
{
    partial class frmCourAvg
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
            this.dataGviewCavg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewCavg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGviewCavg
            // 
            this.dataGviewCavg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGviewCavg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGviewCavg.Location = new System.Drawing.Point(0, 0);
            this.dataGviewCavg.Name = "dataGviewCavg";
            this.dataGviewCavg.RowTemplate.Height = 23;
            this.dataGviewCavg.Size = new System.Drawing.Size(285, 264);
            this.dataGviewCavg.TabIndex = 0;
            // 
            // frmCourAvg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.dataGviewCavg);
            this.Name = "frmCourAvg";
            this.Text = "课程平均成绩";
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewCavg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGviewCavg;
    }
}