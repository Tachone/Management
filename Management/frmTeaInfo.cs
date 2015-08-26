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
    public partial class frmTeaInfo : Form
    {
        public frmTeaInfo()
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
                sql = "select * from Liust_Teacher";
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
            frmInsertTea frmTint = new frmInsertTea(this);
            frmTint.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from Liust_Teacher where lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
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
                sql = "update Liust_Teacher set lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'where lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Teacher set lst_Tname='" + dataGview.CurrentRow.Cells[1].Value.ToString() + "'where lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Teacher set lst_Tsex='" + dataGview.CurrentRow.Cells[2].Value.ToString() + "'where lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Teacher set lst_Tage='" + dataGview.CurrentRow.Cells[3].Value + "'where lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Teacher set lst_Tphone='" + dataGview.CurrentRow.Cells[4].Value.ToString() + "'where lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
                sql = "update Liust_Teacher set lst_Tposon='" + dataGview.CurrentRow.Cells[5].Value.ToString() + "'where lst_Tno='" + dataGview.CurrentRow.Cells[0].Value.ToString() + "'";
                con.OpreateData(sql);
  
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能进行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
