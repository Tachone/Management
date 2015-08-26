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
    public partial class frmNewBanClass : Form
    {
        public frmNewBanClass()
        {
            InitializeComponent();
        }
        private string sql2;
        sqlConnnect con2 = new sqlConnnect();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql2 = "insert into Liust_ClassCourse values('" + txtBno.Text + "','" + txtCno.Text + "')";

                con2.OpreateData(sql2);
                MessageBox.Show("插入成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
