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
    public partial class frmInsertBan : Form
    {
        private frmBanInfo frmCopy = new frmBanInfo();
        public frmInsertBan(frmBanInfo f)
        {
            InitializeComponent();
            frmCopy = f;
        }

        private string sql2,sql;
        sqlConnnect con2 = new sqlConnnect();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql2 = "insert into Liust_Class values('" + txtClno.Text + "','" + txtClname.Text + "','" + txtClmajor.Text + "','" + txtClschool.Text + "')";
               // sql = "insert into Liust_ClassCourse values('" + txtClno.Text + "','" + txtBo.Text + "')";
                con2.OpreateData(sql2);
              //  con2.OpreateData(sql);
                frmCopy.SetBind();
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
