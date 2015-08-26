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
    public partial class frmNewLogin : Form
    {
        public frmNewLogin()
        {
            InitializeComponent();
        }
        sqlConnnect con = new sqlConnnect();
        private string sql;
        public void SetBind1()
        {
            try
            {
                sql = "insert into Liust_TeaLogin values('" + txtNewA.Text + "','" + txtNewP.Text + "')";
                con.OpreateData(sql);
                 MessageBox.Show("插入成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SetBind2()
        {
            try
            {
                sql = "insert into Liust_StuLogin values('" + txtNewA.Text + "','" + txtNewP.Text + "')";
                con.OpreateData(sql);
                 MessageBox.Show("插入成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("不能进行该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    
        private void btnOK_Click(object sender, EventArgs e)
        {
         
                if (comBLogin.SelectedItem.ToString() == "教师")
                {
                    SetBind1();
                   
                    
                }
                else if (comBLogin.SelectedItem.ToString() == "学生")
                {
                    SetBind2();
                   // MessageBox.Show("插入成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
          
        }
    }

