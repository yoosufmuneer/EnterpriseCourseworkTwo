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
    public partial class EditIncomeView : Form
    {
        String Btn = null;

        public EditIncomeView()
        {
            InitializeComponent();
            String Amount = this.numericUpDown1.Value.ToString();
            String ContactEmail = this.comboBox1.Text;
            String Description = this.DescriptionTxt.Text;
            String Date = this.dateTimePicker1.Value.ToString();
            String isRecurring = this.RecurringChkBox.Checked.ToString();
            int id = GetData.getUserId();

            ContactEmail dSet = new ContactEmail();
            if (File.Exists(@"D:\ContactsEmail.xml") == true)
            {
                dSet.ReadXml(@"D:\ContactsEmail.xml");
                ContactEmail.TempContactEmailRow data = dSet.TempContactEmail[0];
                Btn = data.Email;
                MessageBox.Show(Btn);
            }

            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                //var query = from u in db.Contacts select u;
                var rslt = db.Contacts.SingleOrDefault(b => b.Email == Btn);


                var result = db.Incomes.FirstOrDefault(b => b.ContactId == rslt.Id);

                var reesult = from u in db.Incomes select db;


                if (result != null)
                {
                    Amount = result.Amount;
                    ContactEmail = Btn;
                    Description = result.Description;
                    Date = result.Date;
                    isRecurring = result.isRecurring;
                  
                    this.numericUpDown1.Value = System.Convert.ToDecimal(Amount);
                    this.comboBox1.Text = ContactEmail;
                    this.DescriptionTxt.Text = Description;
                    this.dateTimePicker1.Value = System.Convert.ToDateTime(Date);
                    this.RecurringChkBox.Checked = System.Convert.ToBoolean(isRecurring);

                }
            }

        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
