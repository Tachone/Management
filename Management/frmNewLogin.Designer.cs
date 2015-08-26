namespace Management
{
    partial class frmNewLogin
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
            this.comBLogin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewA = new System.Windows.Forms.TextBox();
            this.txtNewP = new System.Windows.Forms.TextBox();
            this.dataGviewHello = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewHello)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择用户级别:";
            // 
            // comBLogin
            // 
            this.comBLogin.FormattingEnabled = true;
            this.comBLogin.Items.AddRange(new object[] {
            "教师",
            "学生"});
            this.comBLogin.Location = new System.Drawing.Point(113, 18);
            this.comBLogin.Name = "comBLogin";
            this.comBLogin.Size = new System.Drawing.Size(121, 20);
            this.comBLogin.TabIndex = 1;
           // this.comBLogin.SelectedIndexChanged += new System.EventHandler(this.comBLogin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码：";
            // 
            // txtNewA
            // 
            this.txtNewA.Location = new System.Drawing.Point(113, 93);
            this.txtNewA.Name = "txtNewA";
            this.txtNewA.Size = new System.Drawing.Size(100, 21);
            this.txtNewA.TabIndex = 4;
            // 
            // txtNewP
            // 
            this.txtNewP.Location = new System.Drawing.Point(113, 157);
            this.txtNewP.Name = "txtNewP";
            this.txtNewP.Size = new System.Drawing.Size(100, 21);
            this.txtNewP.TabIndex = 5;
            // 
            // dataGviewHello
            // 
            this.dataGviewHello.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGviewHello.Location = new System.Drawing.Point(260, 242);
            this.dataGviewHello.Name = "dataGviewHello";
            this.dataGviewHello.RowTemplate.Height = 23;
            this.dataGviewHello.Size = new System.Drawing.Size(22, 18);
            this.dataGviewHello.TabIndex = 6;
            this.dataGviewHello.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 217);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmNewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGviewHello);
            this.Controls.Add(this.txtNewP);
            this.Controls.Add(this.txtNewA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comBLogin);
            this.Controls.Add(this.label1);
            this.Name = "frmNewLogin";
            this.Text = "新建用户";
            ((System.ComponentModel.ISupportInitialize)(this.dataGviewHello)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewA;
        private System.Windows.Forms.TextBox txtNewP;
        private System.Windows.Forms.DataGridView dataGviewHello;
        private System.Windows.Forms.Button btnOK;
    }
}