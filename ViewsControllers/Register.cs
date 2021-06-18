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
    public partial class RegisterForm : Form
    {
        TempData dSet = new TempData();

        public RegisterForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.usernameTxt.Text;
            String password = this.passwordTxt.Text;
            String FName = this.fNameTxt.Text;
            String LName = this.lNameTxt.Text;

            bool hasSpace = username.Trim().Length == 0 || password.Trim().Length == 0 || FName.Trim().Length == 0
                || LName.Trim().Length == 0;
            if ((username.Length <= 4) || (password.Length <= 4) || hasSpace)
            {
                MessageBox.Show("Please fill the inputs and make sure" +
                    " Username & Passwords are more than 4 characters each");
            }
            else {


                using (FinanceManagerContainer db = new FinanceManagerContainer())
                {
                    bool auth = true;

                    //Query to fetch Users table in the DB
                    var queryUsername = db.Users.SingleOrDefault(b => b.Username == username);

                    //Validate Username Existance
                    try
                    {
                        if(queryUsername == null)
                        {

                            dSet.Users.Clear();
                            dSet.Users.AddUsersRow(username, password,
                                this.FNameLabel.Text, this.LNameLabel.Text);

                            //Storing via XML File Writing
                            //string GetCurrentDirectory();
                            dSet.WriteXml(@"D:\TempData.xml");
                            
                            GetData.registerUser(this.fNameTxt.Text, this.lNameTxt.Text,
                                    username, password);
                            //Forwarding the data to the Database
/*                          User newUser = new User();
                            newUser.FName = this.fNameTxt.Text;
                            newUser.LName = this.lNameTxt.Text;
                            newUser.Username = username;
                            newUser.Password = password;
                            db.Users.Add(newUser);
                            db.SaveChanges();*/
                            MessageBox.Show("Registration Successful!");

                            LoginForm n = new LoginForm();
                            this.Hide();
                            n.Show();

                        }
                        else
                        {
                            if (queryUsername.Username.ToString() == username)
                            {
                                auth = false;
                            }
                            if (auth == false)
                            {
                                MessageBox.Show("Username already exists! Please pick another username.");
                            }
                            else
                            {
                                dSet.Users.Clear();
                                dSet.Users.AddUsersRow(username, password,
                                    this.FNameLabel.Text, this.LNameLabel.Text);

                                //Storing via XML File Writing
                                //string GetCurrentDirectory();
                                dSet.WriteXml(@"D:\TempData.xml");

                                GetData.registerUser(this.fNameTxt.Text, this.lNameTxt.Text,
                                    username, password);
                                

                                MessageBox.Show("Registration Successful!");

                                LoginForm n = new LoginForm();
                                this.Hide();
                                n.Show();
                            }
                        }
                        
                    }
                    catch(Exception z)
                    {
                        MessageBox.Show(z.ToString());
                    }
                    

                }


            }
        }

        private void lNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
