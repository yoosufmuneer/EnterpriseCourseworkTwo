using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseCourseworkTwo
{
    public partial class BackBtnControl : UserControl
    {
        public BackBtnControl()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomeScreen h = new HomeScreen();
            h.Show();
            this.Parent.Hide();
        }

        private void BackBtnControl_Load(object sender, EventArgs e)
        {

        }
    }
}
