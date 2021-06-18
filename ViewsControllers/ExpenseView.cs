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
    public partial class ExpenseView : Form
    {
        public ExpenseView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddIncomeView view = new AddIncomeView();
            view.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditIncomeView view = new EditIncomeView();
            view.ShowDialog();
        }

        Label[] arrAmountLabel;
        Label[] arrDescriptionLabel;
        Label[] arrIsRecurringLabel;
        Label[] arrDate;
        Label[] arrContactEmail;
        private void ExpenseSubmit_Click(object sender, EventArgs e)
        {
            int numofrows = (int)this.ExpenseInput.Value;
            var queryAmount = new List<String>();
            var queryDescription = new List<String>();
            var queryIsRecurring = new List<String>();
            var queryDate = new List<String>();
            var queryContactEmail = new List<String>();

            Label Amount = new Label();
            Label Description = new Label();
            Label IsRecurring = new Label();
            Label Date = new Label();
            Label ContactEmail = new Label();
            Button Edit;
            Button Delete;

            if (numofrows < 10)
            {
                using (FinanceManagerContainer db = new FinanceManagerContainer())
                {
                    var query = from u in db.Expenses.OrderByDescending(p => p.Date) select u;
                    int expenseCount = query.Count();
                    if (numofrows <= expenseCount)
                    {
                        var queryO = from u in db.Contacts
                                     select u;
                        String contactEmail = null;
                        foreach (var i in queryO)
                        {
                            foreach (var b in query)
                            {
                                if (b.UserId == i.UserId)
                                {
                                    contactEmail = i.Email.ToString();
                                    // MessageBox.Show(contactEmail);
                                }
                            }
                        }

                        /*                        List<Contact> contactsList = new List<Contact>();
                                               foreach(var i in queryO)
                                               {
                                                   if (i.UserId == GetData.getUserId())
                                                   {
                                                       Contact c = new Contact();
                                                       c.UserId = i.UserId;
                                                       c.Email = i.Email;
                                                       contactsList.Add(c);
                                                       MessageBox.Show(i.Email);
                                                   }
                                               }

                                             foreach(var b in query)
                                               {
                                                   if(b.UserId == GetData.getUserId())
                                                   {
                                                       foreach(var j in contactsList)
                                                       {
                                                           if(j.id)
                                                           } contactEmail = j.Email;
                                                       }
                                                   }
                                               }*/
                        int userId = GetData.getUserId();

                        foreach (var item in query)
                        {
                            if (item.UserId == userId)
                            {
                                queryAmount.Add(item.Amount);
                                queryDescription.Add(item.Description);
                                queryIsRecurring.Add(item.isRecurring);
                                queryDate.Add(item.Date);
                                queryContactEmail.Add(contactEmail);
                            }
                        }

                        if (this.arrAmountLabel != null)
                        {
                            for (int i = 0; i < this.arrAmountLabel.Length; i++)
                            {
                                this.Controls.Remove(this.arrAmountLabel[i]);
                                this.Controls.Remove(this.arrDescriptionLabel[i]);
                                this.Controls.Remove(this.arrIsRecurringLabel[i]);
                                this.Controls.Remove(this.arrDate[i]);
                                this.Controls.Remove(this.arrContactEmail[i]);

                                /*Controls.Remove(Name);
                                Controls.Remove(Email);*/

                            }
                        }

                        this.arrAmountLabel = new Label[numofrows];
                        this.arrDescriptionLabel = new Label[numofrows];
                        this.arrIsRecurringLabel = new Label[numofrows];
                        this.arrDate = new Label[numofrows];
                        this.arrContactEmail = new Label[numofrows];

                        /*
                        Name.Text = "Name";
                        Name.Location = new Point(50, 120);
                        Name.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                        Email.Text = "Email";
                        Email.Location = new Point(180, 120);
                        Email.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                        Controls.Add(Name);
                        Controls.Add(Email);*/

                        for (int i = 0; i < arrAmountLabel.Length; i++)
                        {
                            this.arrAmountLabel[i] = new Label();
                            this.arrDescriptionLabel[i] = new Label();
                            this.arrIsRecurringLabel[i] = new Label();
                            this.arrDate[i] = new Label();
                            this.arrContactEmail[i] = new Label();

                            //this.arrLabel[i].Text = String.Format("Row number #{0}", i);
                            this.arrAmountLabel[i].Text = queryAmount[i];
                            this.arrAmountLabel[i].Location = new Point(50, 150 + i * 25);
                            this.arrAmountLabel[i].Size = new System.Drawing.Size(90, 19);
                            this.arrAmountLabel[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrAmountLabel[i]);


                            this.arrDescriptionLabel[i].Text = queryDescription[i];
                            this.arrDescriptionLabel[i].Location = new Point(180, 150 + i * 25);
                            this.arrDescriptionLabel[i].Size = new System.Drawing.Size(150, 19);
                            this.arrDescriptionLabel[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrDescriptionLabel[i]);

                            this.arrIsRecurringLabel[i].Text = queryIsRecurring[i];
                            this.arrIsRecurringLabel[i].Location = new Point(250, 150 + i * 25);
                            this.arrIsRecurringLabel[i].Size = new System.Drawing.Size(50, 19);
                            this.arrIsRecurringLabel[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrIsRecurringLabel[i]);

                            this.arrDate[i].Text = queryDate[i];
                            this.arrDate[i].Location = new Point(250, 150 + i * 25);
                            this.arrDate[i].Size = new System.Drawing.Size(50, 19);
                            this.arrDate[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrDate[i]);

                            this.arrContactEmail[i].Text = queryContactEmail[i];
                            this.arrContactEmail[i].Location = new Point(250, 150 + i * 25);
                            this.arrContactEmail[i].Size = new System.Drawing.Size(50, 19);
                            this.arrContactEmail[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(arrContactEmail[i]);

                            Edit = new Button();
                            Edit.Text = "Edit";
                            Edit.Location = new Point(420, 150 + i * 25);
                            Edit.AutoSize = true;
                            Edit.Name = String.Format(queryContactEmail[i]);
                            Edit.Click += Edit_Click; ; ;
                            this.Controls.Add(Edit);

                            Delete = new Button();
                            Delete.Text = "Delete";
                            Delete.Location = new Point(520, 150 + i * 25);
                            Delete.AutoSize = true;
                            Delete.Name = String.Format(queryContactEmail[i]);
                            Delete.Click += Delete_Click;
                            this.Controls.Add(Delete);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number lower than or equal to" + expenseCount.ToString());
                    }



                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                db.Database.ExecuteSqlCommand("Delete Expenses where Email = {0}", btn.Name);
                MessageBox.Show("Expense Deleted Successfully!");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddExpense form = new AddExpense();
            form.ShowDialog();
        }
    }
}
