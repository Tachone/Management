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
   
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        // public static string GuestLogin
        private string sql,IDinfo,IDpas;
        sqlConnnect con = new sqlConnnect();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                MessageBox.Show("请选择登陆身份!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (txtName.Text == "" || txtPwd.Text == "")
                MessageBox.Show("用户名或密码不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(radioButton1.Checked==true)
            {
                if(txtName.Text=="Super"&&txtPwd.Text=="123456")
                {
                    frmMain fmain = new frmMain();//管理员窗口
                    this.Hide();
                    fmain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(radioButton2.Checked==true)
            {
                IDinfo = txtName.Text;
                sql = "select lst_LoginSName from Liust_StuLogin where lst_LoginSName='"+IDinfo+"'";
                int Decide = con.OpreateData(sql);
                if (Decide == 0)
                {
                    MessageBox.Show("用户名或者密码错误!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    IDpas = txtPwd.Text;
                    sql = "select * from Liust_StuLogin where lst_LoginSName='" + IDinfo + "' and lst_LoginSPas='"+IDpas+"'";
                    int AgainP = con.OpreateData(sql);
                    if (AgainP == 0)
                    {
                        MessageBox.Show("用户名或者密码错误!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        GetLogin.GuestLogin = IDinfo;
                        frmMainStu fmainStu = new frmMainStu();//学生窗口
                        this.Hide();
                        fmainStu.ShowDialog();
                        this.Close();
                    }
                }
               
            }
            else if(radioButton3.Checked==true)
            {
                IDinfo = txtName.Text;
                sql = "select lst_LoginTName from Liust_TeaLogin where lst_LoginTName='" + IDinfo + "'";
                int Decide = con.OpreateData(sql);
                if (Decide == 0)
                {
                    MessageBox.Show("用户名或者密码错误!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    IDpas = txtPwd.Text;
                    sql = "select * from Liust_TeaLogin where lst_LoginTName='" + IDinfo + "' and lst_LoginTPas='" + IDpas + "'";
                    int AgainP = con.OpreateData(sql);
                    if (AgainP == 0)
                    {
                        MessageBox.Show("用户名或者密码错误!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        GetLogin.GuestLogin = IDinfo;
                        frmMainTea fmainTea = new frmMainTea();//教师窗口
                        this.Hide();
                        fmainTea.ShowDialog();
                        this.Close();
                    }
                }

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
