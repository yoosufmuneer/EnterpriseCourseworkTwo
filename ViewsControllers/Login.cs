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
    public partial class LoginForm : Form
    {
        TempData dSet = new TempData();
        TempUsers dataS = new TempUsers();
        public LoginForm()
        {
            InitializeComponent();

            /*if (File.Exists(@"D:\TempData.xml") == true)
            {
                dSet.ReadXml(@"D:\TempData.xml");
                TempData.UsersRow data = dSet.Users[0];
                this.usernameTxt.Text = data.Username;
                if (data.IsPasswordNull() == false)
                {
                    this.passwordTxt.Text = data.Password;
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.usernameTxt.Text.Equals("") || this.passwordTxt.Text.Equals(""))
            {
                MessageBox.Show("Please enter name and password");
            }
            else
            {
                bool auth = false;
                using (FinanceManagerContainer db = new FinanceManagerContainer()) {
                    var query = from u in db.Users
                                select u;
                    /*var queryO = db.Users.Where(x => x.Username == this.usernameTxt.Text &&
                    x.Password == this.passwordTxt.Text).Select(x => new ).ToList();*/

                    foreach (var item in query)
                    {
                        if (item.Username.Equals(this.usernameTxt.Text,
                            StringComparison.OrdinalIgnoreCase)
                            && item.Password == this.passwordTxt.Text)
                        {
                            auth = true;
                        }
                    }
                    /*if (queryO.ToString().Equals(this.usernameTxt.Text,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        auth = true;
                    }*/

                    if (auth)
                    {
                        dataS.Clear();
                        dataS.Users.AddUsersRow(this.usernameTxt.Text);
                        dataS.WriteXml(@"D:\TempUsers.xml");
                        HomeScreen n = new HomeScreen();
                        this.Hide();
                        n.Show();
                    }else
                    {
                        MessageBox.Show("Username & Password Combination invalid");
                    }

                }
                
                /*if (query.Equals(""))
                {
                    MessageBox.Show("User doesn't exist");
                }
                else if(query.Equals(this.usernameTxt.Text))
                {

                    Form2 n = new Form2();
                    this.Hide();
                    n.Show();
                }*/

            }


        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Login Successful");

            RegisterForm n = new RegisterForm();
            this.Hide();
            n.Show();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
