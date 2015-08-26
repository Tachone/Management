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
    public partial class frmBanInfo : Form
    {
        public frmBanInfo()
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
                sql = "select * from Liust_Class";
                con.BindDataGridView(dataGview, sql);
                dataGview.Columns[0].ReadOnly = true;
                dataGview.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertBan frmBint = new frmInsertBan(this);
            frmBint.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "alter table Liust_Class NOCHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    sql = "alter table Liust_Report NOCHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    sql = "alter table Liust_ClassCourse NOCHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    sql = "delete from Liust_Class where lst_Clno ='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OpreateData(sql);
                    sql = "alter table Liust_Class CHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    sql = "alter table Liust_Report CHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    sql = "alter table Liust_ClassCourse CHECK CONSTRAINT All";
                    con.OpreateData(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update Liust_Class set lst_Clno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'where lst_Clno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Class set lst_Clname='" + dataGview.CurrentRow.Cells[1].Value.ToString() + "'where lst_Clno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Class set lst_Clmajor='" + dataGview.CurrentRow.Cells[2].Value.ToString() + "'where lst_Clno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Class set lst_Clschool='" + dataGview.CurrentRow.Cells[3].Value.ToString() + "'where lst_Clno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能进行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBanClass_Click(object sender, EventArgs e)
        {
            frmNewBanClass fNbc = new frmNewBanClass();
            fNbc.Show();
        }


    }
}
