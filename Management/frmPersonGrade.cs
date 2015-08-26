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
    public partial class frmPersonGrade : Form
    {
        public frmPersonGrade()
        {
            InitializeComponent();
            SetBind();
        }

        sqlConnnect con = new sqlConnnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string YouSelect;
   
        public void SetBind()
        {
            try
            {
                YouSelect = GetLogin.GuestLogin;
              //  YouSelect = comTerm.SelectedItem.ToString();
              //  sql = "select Liust_Report.lst_Sno,Liust_Course.lst_Cname,lst_Tname,lst_Tcredit,Liust_Course.lst_Tbgtime from Liust_Report,Liust_Course,Liust_Teacherwhere Liust_Report.lst_Cno=Liust_Course.lst_Cno and Liust_Report.lst_Tno=Liust_Teacher.lst_Tno where Liust_Course.lst_Tbgtime=YouSelect";
                sql = "select * from Liust_PerGrade where lst_Sno='"+YouSelect+"'";
                con.BindDataGridView(dataGviewPg, sql);
                dataGviewPg.Columns[0].ReadOnly = true;
                dataGviewPg.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
