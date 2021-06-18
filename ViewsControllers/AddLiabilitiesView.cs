using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseCourseworkTwo.ViewsControllers
{
    public partial class AddLiabilitiesView : Form
    {
        public AddLiabilitiesView()
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
                comboBox1.DataSource = contactEmail;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Decimal value = this.amountInput.Value;
            String description = this.DescriptionTxt.Text;
            DateTime date = this.dateTimePicker1.Value;
            int userId = 0;
            int contactId = 0;

            //Validate Inputs
            if (value <= 0 || description.Trim().Length == 0
                || date.Date == null)
            {
                MessageBox.Show("Please fill the fields");
            }
            else
            {
                using (FinanceManagerContainer db = new FinanceManagerContainer())
                {
                    //Get User ID
                    userId = GetData.getUserId();


                    //Get Contact ID
                    var queryContactId = db.Contacts.SingleOrDefault(b => b.Email == this.comboBox1.Text);
                    contactId = queryContactId.Id;

                    try
                    {
                        //Create Asset Object
                        Liability t = new Liability();
                        t.Value = value.ToString();
                        t.Description = description;
                        t.Date = date.ToString();
                        t.Contact = queryContactId;
                        t.UserId = userId;

                        //Save Asset in Database
                        db.Liabilities.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Liability Added Successfully");
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.ToString());
                    }
                    this.Close();
                }
            }
        }

        private void contactDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
