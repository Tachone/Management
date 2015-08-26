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
    public partial class frmMainStu : Form
    {
        public frmMainStu()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            frmPersonGrade fpG = new frmPersonGrade();
            fpG.Show();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            frmTermCourse ftC = new frmTermCourse();
            ftC.Show();
        }

        private void btnPerInfo_Click(object sender, EventArgs e)
        {
            frmPerInfo fPIo = new frmPerInfo();
            fPIo.Show();
        }
    }
}
