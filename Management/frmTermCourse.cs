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
    public partial class frmTermCourse : Form
    {
        public frmTermCourse()
        {
            InitializeComponent();
            SetBind();
        }
        sqlConnnect con = new sqlConnnect();
        public DataSet ds = new DataSet();
        private string sql;
        public string YouSel = GetLogin.GuestLogin;
       
        public void SetBind()
        {
            try
            {
                //YouSel= GetLogin.GuestLogin;
                sql = "select * from Liust_CourTableQ where lst_Sno='"+YouSel+"'";
                con.BindDataGridView(dataGviewTg, sql);
                dataGviewTg.Columns[0].ReadOnly = true;
                dataGviewTg.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string YouSelected;
        private void comboTg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 YouSelected = comboTg.SelectedItem.ToString();
                 sql = "select * from Liust_CourTableQ where lst_Tbgtime='" + YouSelected + "'and lst_Sno='"+YouSel+"'";
                con.BindDataGridView(dataGviewTg, sql);
                dataGviewTg.Columns[0].ReadOnly = true;
                dataGviewTg.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
