using EnterpriseCourseworkTwo.ViewsControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseCourseworkTwo
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            IncomeView n = new IncomeView();
            this.Hide();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContactsView form = new ContactsView();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportView r = new ReportView();
            this.Hide();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExpenseView view = new ExpenseView();
            this.Hide();
            view.Show();
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            //Read TempUsers File and Get Username
            if (File.Exists(@"D:\TempUsers.xml") == true)
            {
                TempUsers dataS = new TempUsers();
                dataS.ReadXml(@"D:\TempUsers.xml");
                TempUsers.UsersRow data = dataS.Users[0];
                this.WelcomeLabel.Text = String.Format("Welcome, {0}!", data.User.ToString());
            }
        }

        private void PredictionBtn_Click(object sender, EventArgs e)
        {
            PredictionView form = new PredictionView();
            this.Close();
            form.Show();
        }

        private void AssetsBtn_Click(object sender, EventArgs e)
        {
            AssetsView form = new AssetsView();
            this.Close();
            form.Show();
        }

        private void LiabilitiesBtn_Click(object sender, EventArgs e)
        {
            LiabilitiesView form = new LiabilitiesView();
            form.Show();
            this.Close();
        }
    }
}
