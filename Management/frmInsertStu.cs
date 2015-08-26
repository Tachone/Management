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
    public partial class frmInsertStu : Form
    {
        private frmStuInfo frmCopy = new frmStuInfo();
        public frmInsertStu(frmStuInfo f)
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
                sql2 = "insert into Liust_Student values('" + txtSno.Text + "','" + txtSname.Text + "','" + txtClnum.Text + "','" + txtSex.Text + "'," + txtAge.Text + ",'" + txtHome.Text + "'," + txtSalcredit.Text + ")";

                con2.OpreateData(sql2);
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
