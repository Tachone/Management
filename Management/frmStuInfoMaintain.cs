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
    public partial class frmStuInfoMaintain : Form
    {
        public frmStuInfoMaintain()
        {
            InitializeComponent();
        }
        private string sql2,sql;
        sqlConnnect con2 = new sqlConnnect();
        private string year;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTno.Text == GetLogin.GuestLogin)
                {
                    sql = "exec Auto_GetCredit '" + txtTno.Text + "','" + txtSno.Text + "','" + txtClno.Text + "'";//存储过程
                    year = txtTerm.Text.Substring(0, 4);
                    sql2 = "insert into Liust_Report values('" + txtSno.Text + "','" + txtClno.Text + "'," + txtGrade.Text + ",'" + txtTno.Text + "','" + txtTerm.Text + "','" + year + "')";
                    con2.OpreateData(sql2);
                    con2.OpreateData(sql);
                    MessageBox.Show("学生成绩输入成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("您没有此权限!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
