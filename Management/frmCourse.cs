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
    public partial class frmCourse : Form
    {
        public frmCourse()
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
                sql = "select * from Liust_Course";
                con.BindDataGridView(dataGviewCourse, sql);
                dataGviewCourse.Columns[0].ReadOnly = true;
                dataGviewCourse.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from Liust_Course where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OpreateData(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update Liust_Course set lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Course set lst_Cname='" + dataGviewCourse.CurrentRow.Cells[1].Value.ToString() + "'where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Course set lst_Tno='" + dataGviewCourse.CurrentRow.Cells[2].Value.ToString() + "'where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Course set lst_Tbgtime='" + dataGviewCourse.CurrentRow.Cells[3].Value.ToString() + "'where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Course set lst_Tlrntime='" + dataGviewCourse.CurrentRow.Cells[4].Value + "'where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Course set lst_Tcredit='" + dataGviewCourse.CurrentRow.Cells[5].Value.ToString() + "'where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Course set lst_Ttype='" + dataGviewCourse.CurrentRow.Cells[6].Value + "'where lst_Cno='" + dataGviewCourse.CurrentRow.Cells[0].Value.ToString() + "'";
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
            frmInsertCourse fIc = new frmInsertCourse(this);
            fIc.Show();
        }
    }
}
