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
    public partial class ContactsView : Form
    {
        public ContactsView()
        {
            InitializeComponent();
        }

        private void ContactsView_Load(object sender, EventArgs e)
        {

        }

        private void AddContactsBtn_Click(object sender, EventArgs e)
        {
            AddContactView view = new AddContactView();
            view.ShowDialog();
        }

        //Declare arrays to be looped and later initialized
        Label[] arrFNameLabel;
        Label[] arrLNameLabel;
        Label[] arrEmailLabel;

        private void SubmitNumofRows_Click(object sender, EventArgs e)
        {
            // Input value from the user
            int numofrows = (int)this.inputNumofRows.Value;

            //Create List to be later
            var queryFName = new List<String>();
            var queryLName = new List<String>();
            var queryEmail = new List<String>();
        
            //Create new label
            Label Name = new Label();
            Label Email = new Label();
            //Declare buttons
            Button Edit; 
            Button Delete;


            if (numofrows < 5)
            {
                using (FinanceManagerContainer db = new FinanceManagerContainer())
                {
                    var query = from u in db.Contacts select u;
                    int contactsCount = query.Count();
                    if (numofrows <= contactsCount)
                    {
                        //Set Logged In User's ID
                        int userId = GetData.getUserId();

                        foreach (var item in query)
                        {
                            if (item.UserId == userId)
                            {
                                queryFName.Add(item.FName);
                                queryLName.Add(item.LName);
                                queryEmail.Add(item.Email);
                            }
                        }

                        //Delete if it already exists
                        if (this.arrFNameLabel != null)
                        {
                            for (int i = 0; i < this.arrFNameLabel.Length; i++)
                            {
                                this.Controls.Remove(this.arrFNameLabel[i]);
                                this.Controls.Remove(this.arrLNameLabel[i]);
                                this.Controls.Remove(this.arrEmailLabel[i]);
                                Controls.Remove(Name);
                                Controls.Remove(Email);
                            }
                        }
                        //Create new label arrays with the user input as size
                        this.arrFNameLabel = new Label[numofrows];
                        this.arrLNameLabel = new Label[numofrows];
                        this.arrEmailLabel = new Label[numofrows];

                        //Create Name label
                        Name.Text = "Name";
                        Name.Location = new Point(30, 120);
                        Name.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                        //Create Email label
                        Email.Text = "Email";
                        Email.Location = new Point(190, 120);
                        Email.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                        Controls.Add(Name);
                        Controls.Add(Email);


                        for (int i = 0; i < arrFNameLabel.Length; i++)
                        {
                            this.arrFNameLabel[i] = new Label();
                            this.arrEmailLabel[i] = new Label();

                            this.arrFNameLabel[i].Text = queryFName[i]+" "+queryLName[i];//Add label text
                            this.arrFNameLabel[i].Location = new Point(30, 150 + i * 25); //Offseting to avoid overlap
                            this.arrFNameLabel[i].Size = new System.Drawing.Size(150, 19);//Set size
                            this.arrFNameLabel[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrFNameLabel[i]);//Add the new component to the form's control
                                                                     //Collection


                            this.arrEmailLabel[i].Text = queryEmail[i];
                            this.arrEmailLabel[i].Location = new Point(190, 150 + i * 25);
                            this.arrEmailLabel[i].Size = new System.Drawing.Size(200, 19);
                            this.arrEmailLabel[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrEmailLabel[i]);

                            Edit = new Button();
                            Edit.Text = "Edit";
                            Edit.Location = new Point(420, 150 + i * 25);
                            Edit.AutoSize = true;
                            Edit.Name = String.Format(queryEmail[i]);   
                            Edit.Click += Edit_Click;//Bind Event Delegate
                            this.Controls.Add(Edit);

                            Delete = new Button();
                            Delete.Text = "Delete";
                            Delete.Location = new Point(520, 150 + i * 25);
                            Delete.AutoSize = true;
                            Delete.Name = String.Format(queryEmail[i]);
                            Delete.AccessibleName = String.Format(queryEmail[i]);
                            Delete.Click += Delete_Click;
                            this.Controls.Add(Delete);
                        }

                    }else
                    {
                        MessageBox.Show("Please enter a number lower than or equal to " +
                            contactsCount.ToString());
                    }

                }
            }

        }


        //Delete Record
        private void Delete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {               
                db.Database.ExecuteSqlCommand("Delete Contacts where Email = {0}", btn.Name);
                MessageBox.Show("Contact Deleted Successfully!");
            }
        }

            private void Edit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //Write Selected Email Address to XML File
            ContactEmail dSet = new ContactEmail();

            dSet.Clear();
            dSet.TempContactEmail.AddTempContactEmailRow(btn.Name);
            dSet.WriteXml(@"D:\ContactsEmail.xml");


            EditContactView form = new EditContactView();
            form.ShowDialog();
        }
    }
}
