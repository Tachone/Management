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
    public partial class frmMainTea : Form
    {
        public frmMainTea()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            frmStuInfoMaintain fSIMain = new frmStuInfoMaintain();
            fSIMain.Show();

        }

        private void btnGrSort_Click(object sender, EventArgs e)
        {
            frmStuGrade FsG = new frmStuGrade();
            FsG.Show();
        }

        private void btnOth_Click(object sender, EventArgs e)
        {
            frmAllQustion copyIt = new frmAllQustion();
            copyIt.Show();
        }

        private void btnCouAvg_Click(object sender, EventArgs e)
        {
            frmCourAvg fCa = new frmCourAvg();
            fCa.Show();
        }

     
    }
}
