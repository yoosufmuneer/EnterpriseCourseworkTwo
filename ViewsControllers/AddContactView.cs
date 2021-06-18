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
    public partial class AddContactView : Form
    {
        public AddContactView()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Assign variables to Textbox inputs
            string FName = this.FNameTxt.Text;
            string LName = this.LNameTxt.Text;
            string Email = this.EmailTxt.Text;

            //Validation - While accounting for Spaces
            bool hasSpace = FName.Trim().Length == 0 || LName.Trim().Length == 0 || Email.Trim().Length == 0;
            if ((FName.Length <= 2) || (LName.Length <= 2) || hasSpace)
            {
                MessageBox.Show("Please fill the inputs and make sure they're atleast 2 characters each");
            }
            else if (Email.Trim().Contains('@') == false)
            {
                MessageBox.Show("Please enter a valid email address");
            }
            else {
                String Username = null;
                int UserId = 0;
                bool contactExists = false;
                String fileLocation = @"D:\TempUsers.xml";

                //Read Current Username from XML File
                if (File.Exists(fileLocation) == true)
                {
                    TempUsers dataS = new TempUsers();
                    dataS.ReadXml(fileLocation);
                    TempUsers.UsersRow data = dataS.Users[0];
                    Username = data.User;

                    using (FinanceManagerContainer db = new FinanceManagerContainer())
                    {
                        //Get Users from DB
                        var queryGetUserId = from u in db.Users select u;
                        var queryGetContactEmail = from u in db.Contacts select u.Email;

                        foreach(var i in queryGetContactEmail)
                        {
                            if (i.Equals(Email))
                            {
                                MessageBox.Show("Contact already exists");
                                contactExists = true;
                            }
                        }
                        if (!(contactExists))
                        {
                            //Iterate to get specific User ID
                            foreach (var i in queryGetUserId)
                            {
                                if (i.Username.ToString().Equals(Username))
                                {
                                    UserId = (int)i.Id;
                                }
                            }
                            //Create contact object
                            Contact c = new Contact();
                            c.FName = FName;
                            c.LName = LName;
                            c.UserId = UserId;
                            c.Email = Email;

                            //Storing in an XML File
                            TempContacts ds = new TempContacts();
                            ds.Contacts.AddContactsRow(null,FName, LName, Email, UserId.ToString());
                            ds.WriteXml(@"D:\TempContacts.xml");


                            //Forwarding to the database
                            db.Contacts.Add(c);
                            db.SaveChanges();
                            MessageBox.Show("Successfully saved contact!");
                            this.Hide();

                        }

                    }
                }


                        //Storing
                         //dSet.WriteXml(@"D:\TempContacts.xml");

                         //bool auth = true;
                         //var queryO = db.Users.Where(x => x.Username == FName);
                         //var queryFName = from d in db.Contacts where d.FName == FName select d.FName;
                         //var queryLName = from d in db.Contacts where d.LName == LName select d.LName;

                //var queryGetID = db.Users.Where(d => d.Username == username);


            }
            
        }

    }
}