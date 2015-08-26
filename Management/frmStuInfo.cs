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
    public partial class frmStuInfo : Form
    {
        public frmStuInfo()
        {
            InitializeComponent();
            SetBind();
        }
        sqlConnnect con = new sqlConnnect();
        public DataSet ds = new DataSet();
        private string sql;
        public void SetBind()
        {
            try
            {
                sql = "select * from Liust_Student";

                con.BindDataGridView(dataGview, sql);
                dataGview.Columns[0].ReadOnly = true;
                dataGview.AllowUserToAddRows = false;

            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)//是对应的保存操作
        {
           try
           {
               sql="update Liust_Student set lst_Sno='"+dataGview.CurrentRow.Cells[0].Value.ToString()+"'where lst_Sno='"+dataGview.CurrentRow.Cells[0].Value.ToString()+"'";
               con.OpreateData(sql);
               sql = "update Liust_Student set lst_Sname='" + dataGview.CurrentRow.Cells[1].Value.ToString() + "'where lst_Sno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
               con.OpreateData(sql);
               sql = "update Liust_Student set lst_Sclasno='" + dataGview.CurrentRow.Cells[2].Value.ToString() + "'where lst_Sno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
               con.OpreateData(sql);
               sql = "update Liust_Student set lst_Ssex='" + dataGview.CurrentRow.Cells[3].Value.ToString() + "'where lst_Sno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
               con.OpreateData(sql);
               sql = "update Liust_Student set lst_Sage='" + dataGview.CurrentRow.Cells[4].Value + "'where lst_Sno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
               con.OpreateData(sql);
               sql = "update Liust_Student set lst_SHome='" + dataGview.CurrentRow.Cells[5].Value.ToString() + "'where lst_Sno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
               con.OpreateData(sql);
               sql = "update Liust_Student set lst_Scredit='" + dataGview.CurrentRow.Cells[6].Value + "'where lst_Sno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
               con.OpreateData(sql);
               SetBind();
           }
            catch
           {
               MessageBox.Show("不能进行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertStu frmStuInt = new frmInsertStu(this);
            frmStuInt.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要删除该条信息吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                try
                {
                    sql = "alter table Liust_Report NOCHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    sql = "delete from Liust_Student where lst_Sno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OpreateData(sql);
                    sql = "alter table Liust_Report CHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    SetBind();
             }
                catch
                {
                    MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

      
    }
}
