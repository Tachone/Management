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
    public partial class frmPerInfo : Form
    {
        public frmPerInfo()
        {
            InitializeComponent();
            SetBind();
        }
        sqlConnnect con = new sqlConnnect();
        public DataSet ds = new DataSet();
        private string sql,YouSeted;
        public void SetBind()
        {
            try
            {
                 YouSeted=GetLogin.GuestLogin;
                 sql = "select * from Liust_Pxian where lst_Sno='"+YouSeted+"'";
                con.BindDataGridView(dataGviewXian, sql);
                dataGviewXian.Columns[0].ReadOnly = true;
                dataGviewXian.AllowUserToAddRows = false;
                txtSno.Text = dataGviewXian.Rows[0].Cells[0].Value.ToString();
                txtSname.Text = dataGviewXian.Rows[0].Cells[1].Value.ToString();
                txtMajor.Text = dataGviewXian.Rows[0].Cells[2].Value.ToString();
                txtBan.Text = dataGviewXian.Rows[0].Cells[3].Value.ToString();
                txtHome.Text = dataGviewXian.Rows[0].Cells[4].Value.ToString();
                txtAcreit.Text = dataGviewXian.Rows[0].Cells[5].Value.ToString();

            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
