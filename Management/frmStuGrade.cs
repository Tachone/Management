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
    public partial class frmStuGrade : Form
    {
        public frmStuGrade()
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
                sql = "select * from Liust_StuGradeSort";
                con.BindDataGridView(dataGviewSort, sql);
                dataGviewSort.Columns[0].ReadOnly = true;
                dataGviewSort.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comBSyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                YouSelect = comBSyear.SelectedItem.ToString();
                sql = "select * from Liust_StuGradeSort where lst_LearnYear='" + YouSelect + "' order by 平均成绩 desc";
                con.BindDataGridView(dataGviewSort, sql);
                dataGviewSort.Columns[0].ReadOnly = true;
                dataGviewSort.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
