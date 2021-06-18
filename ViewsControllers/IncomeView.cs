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
    public partial class IncomeView : Form
    {
        public IncomeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddIncomeView f = new AddIncomeView();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditIncomeView f = new EditIncomeView();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IncomeName(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numberEntryRow1_Load(object sender, EventArgs e)
        {

        }
        Label[] arrAmountLabel;
        Label[] arrDescriptionLabel;
        Label[] arrIsRecurringLabel;
        Label[] arrDate;
        Label[] arrContactEmail;

        private void submitTwo_Click(object sender, EventArgs e)
        {
            int numofrows = (int)this.incomeInput.Value;
            var queryAmount = new List<String>();
            var queryDescription = new List<String>();
            var queryIsRecurring = new List<String>();
            var queryDate = new List<String>();
            var queryContactEmail = new List<String>();
            var transactionId = new List<String>();


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
                    var query = from u in db.Incomes.OrderByDescending(p => p.Date) select u;
                    int incomeCount = query.Count();
                    if (numofrows <= incomeCount)
                    {
                        var queryO = from u in db.Contacts
                                     select u;
                        var contactEmail = String.Empty ;
                        foreach (var i in queryO)
                        {
                            foreach (var b in query)
                            {
                                if (b.UserId == i.UserId)
                                {
                                    contactEmail = i.Email.ToString();
                                }
                            }
                        }
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
                            }
                        }

                        this.arrAmountLabel = new Label[numofrows];
                        this.arrDescriptionLabel = new Label[numofrows];
                        this.arrIsRecurringLabel = new Label[numofrows];
                        this.arrDate = new Label[numofrows];
                        this.arrContactEmail = new Label[numofrows];

                        
                        for (int i = 0; i < arrAmountLabel.Length; i++)
                        {
                            this.arrAmountLabel[i] = new Label();
                            this.arrDescriptionLabel[i] = new Label();
                            this.arrIsRecurringLabel[i] = new Label();
                            this.arrDate[i] = new Label();
                            this.arrContactEmail[i] = new Label();

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
                            Edit.Click += Edit_Click; ;
                            this.Controls.Add(Edit);

                            Delete = new Button();
                            Delete.Text = "Delete";
                            Delete.Location = new Point(520, 150 + i * 25);
                            Delete.AutoSize = true;
                            Delete.Name = String.Format(queryContactEmail[i]);
                            Delete.Click += Delete_Click; ;
                            this.Controls.Add(Delete);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number lower than or equal to"+incomeCount.ToString());
                    }


                }
                

            }


        }
        private void IncomeView_Load(object sender, EventArgs e)
        {

        }


        private void Delete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                MessageBox.Show(btn.Name);
                //db.Database.ExecuteSqlCommand("Delete Transactions where Email ="+ btn.Name);
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

            EditIncomeView form = new EditIncomeView();
            form.ShowDialog();
        }
    }
}
