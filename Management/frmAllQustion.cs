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
    public partial class frmAllQustion : Form
    {
        public frmAllQustion()
        {
            InitializeComponent();
            SetBindTea();
            //SetBindBan();
            //SetBindArea();
        }

        sqlConnnect con= new sqlConnnect();
      
        public DataSet ds= new DataSet();
        private string sql;
        public void SetBindTea()
        {
            try
            {
                sql = "select * from Liust_TeaCourseQ ";
                con.BindDataGridView(dataGviewTea, sql);
                dataGviewTea.Columns[0].ReadOnly = true;
                dataGviewTea.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComInit.SelectedItem.ToString() == "班级课程查询")
            {
                SetBindBan();
            }
            else if (ComInit.SelectedItem.ToString() == "地区人数查询")
            {
                SetBindArea();
            }
        }

       public void SetBindBan()
        {
            try
            {
                sql = "select * from BanCourseQ";
                con.BindDataGridView(dataGviewTea, sql);
                dataGviewTea.Columns[0].ReadOnly = true;
                dataGviewTea.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SetBindArea()
        {
            try
            {
                sql = "select * from Liust_AreaCount";
                con.BindDataGridView(dataGviewTea, sql);
                dataGviewTea.Columns[0].ReadOnly = true;
                dataGviewTea.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
