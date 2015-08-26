using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class frmInsertTea : Form
    {
        private frmTeaInfo frmCopy = new frmTeaInfo();
        public frmInsertTea(frmTeaInfo f)
        {
            InitializeComponent();
            frmCopy = f;
        }
        private string sql2;
        sqlConnnect con2 = new sqlConnnect();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql2 = "insert into Liust_Teacher values('" + txtTno.Text + "','" + txtTname.Text + "','" + txtTsex.Text + "'," + txtTage.Text + ",'" + txtTphone.Text + "','" + txtPoson.Text + "')";

                con2.OpreateData(sql2);
                // MessageBox.Show("是这里错误吗？", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCopy.SetBind();
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
