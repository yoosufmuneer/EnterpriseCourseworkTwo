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
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();

            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                var query = from u in db.Contacts
                            select u;
                List<String> contactEmail = new List<String>();
                foreach (var i in query)
                {
                    contactEmail.Add(i.Email);
                }
                payee.DataSource = contactEmail;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Decimal income = this.expenseUpDown.Value;
            String contact = this.payee.Text;
            String description = this.DescriptionTxt.Text;
            DateTime date = this.dateTimePicker1.Value;
            Boolean isRecurring = this.RecurringChkBox.Checked;
            int userId = 0;
            int contactId = 0;

            if (income <= 0 || contact.Trim().Length == 0 || description.Trim().Length == 0
                || date.Date == null)
            {
                MessageBox.Show("Please fill the fields and make sure contacts exist");
            }
            else
            {
                using (FinanceManagerContainer db = new FinanceManagerContainer())
                {
                    //Get User ID
                    userId = GetData.getUserId();

                    //Get Contact ID
                    var queryContactId = db.Contacts.SingleOrDefault(b => b.Email == contact);
                    contactId = queryContactId.Id;

                    //Storing in an XML File
                    TempIncome ds = new TempIncome();
                    ds.Income.AddIncomeRow(income.ToString(), description, isRecurring.ToString(),
                    date.ToString(), userId.ToString(), contactId.ToString());
                    ds.WriteXml(@"D:\TempContacts.xml");

                    try
                    {
                        //Create Transaction Object
                        Expense t = new Expense();
                        t.Amount = income.ToString();
                        t.Description = description;
                        t.isRecurring = isRecurring.ToString();
                        t.Date = date.ToString();
                        t.UserId = userId;
                        t.ContactId = contactId;
                        db.Expenses.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Transaction Added Successfully");
                        this.Close();

                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.ToString());
                    }
                }
            }
        }
    }
}
