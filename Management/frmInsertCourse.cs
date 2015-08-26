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
    public partial class frmInsertCourse : Form
    {
        private frmCourse frmCopy = new frmCourse();
        public frmInsertCourse(frmCourse f)
        {
            InitializeComponent();
            frmCopy = f;
        }
        private string sql2;
        sqlConnnect con2 = new sqlConnnect();

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                sql2 = "insert into Liust_Course values('" + txtCno.Text + "','" + txtCname.Text + "','" + txtTno.Text + "','" + txtBegin.Text + "'," + txtTime.Text + "," + txtCreit.Text + ",'" + txtType.Text + "')";
                con2.OpreateData(sql2);
               frmCopy.SetBind();
            }
            catch
            {
               MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

    }
}
