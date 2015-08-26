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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnStu_Click(object sender, EventArgs e)//打开对学生信息的操作
        {
            frmStuInfo fmInfo = new frmStuInfo();
            fmInfo.Show();

        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            frmTeaInfo ftInfo = new frmTeaInfo();
            ftInfo.Show();
        }

        private void btnCla_Click(object sender, EventArgs e)
        {
            frmBanInfo fbInfo = new frmBanInfo();
            fbInfo.Show();
        }

        private void btnOth_Click(object sender, EventArgs e)
        {
            frmAllQustion faInfo = new frmAllQustion();
            faInfo.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            frmCourse fC = new frmCourse();
            fC.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewLogin fNL = new frmNewLogin();
            fNL.Show();
        }
    }
}
