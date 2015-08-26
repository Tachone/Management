namespace Management
{
    partial class frmPersonGrade
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
            this.dataGviewPg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewPg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGviewPg
            // 
            this.dataGviewPg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGviewPg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGviewPg.Location = new System.Drawing.Point(-1, 1);
            this.dataGviewPg.Name = "dataGviewPg";
            this.dataGviewPg.RowTemplate.Height = 23;
            this.dataGviewPg.Size = new System.Drawing.Size(559, 406);
            this.dataGviewPg.TabIndex = 0;
            // 
            // frmPersonGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 436);
            this.Controls.Add(this.dataGviewPg);
            this.Name = "frmPersonGrade";
            this.Text = "个人成绩查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewPg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGviewPg;
    }
}