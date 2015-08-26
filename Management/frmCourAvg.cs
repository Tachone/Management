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
    public partial class frmCourAvg : Form
    {
        public frmCourAvg()
        {
            InitializeComponent();
            SetBind();
        }
         sqlConnnect con= new sqlConnnect();

        public DataSet ds= new DataSet();
        private string sql;
        public void SetBind()
        {
            try
            {
                sql = "select * from Liust_CGradeavgQ ";
                con.BindDataGridView(dataGviewCavg, sql);
                dataGviewCavg.Columns[0].ReadOnly = true;
                dataGviewCavg.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
