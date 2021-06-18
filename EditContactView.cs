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
    public partial class EditContactView : Form
    {
        String Btn = null;

        public EditContactView()
        {
            InitializeComponent();

            String FName = this.FNameTxt.Text;
            String LName = this.LNameTxt.Text;
            String Email = this.EmailTxt.Text;
            int id = GetData.getUserId();

            ContactEmail dSet = new ContactEmail();
            if (File.Exists(@"D:\ContactsEmail.xml") == true)
            {
                dSet.ReadXml(@"D:\ContactsEmail.xml");
                ContactEmail.TempContactEmailRow data = dSet.TempContactEmail[0];
                Btn = data.Email;
            }

            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                //var query = from u in db.Contacts select u;
                var result = db.Contacts.SingleOrDefault(b => b.Email == Btn);

                if(result != null)
                {
                    FName = result.FName;
                    LName = result.LName;
                    Email = result.Email;

                    this.FNameTxt.Text = FName;
                    this.LNameTxt.Text = LName;
                    this.EmailTxt.Text = Email;

                }

                /*foreach (var item in query)
                {
                    if (item.Email.Equals(Btn))
                    {
                        FName = item.FName;
                        LName = item.LName;
                        Email = item.Email;;
                        MessageBox.Show(FName);

                        this.FNameTxt.Text = FName;
                        this.LNameTxt.Text = LName;
                        this.EmailTxt.Text = Email;
                        
                        /*TempContacts dataSet = new TempContacts();

                        dataSet.Contacts.AddContactsRow("1", FName, LName, Email, "123");*/

                        //Storing via XML File Writing
                        //string GetCurrentDirectory();

                    //}
              //  }
            }
        }

        private void ContactsSubmitBtn_Click(object sender, EventArgs e)
        {
            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                var result = db.Contacts.SingleOrDefault(b => b.Email == Btn);
                if (result != null)
                {
                    result.FName = this.FNameTxt.Text;
                    result.LName = this.LNameTxt.Text;
                    result.Email = this.EmailTxt.Text;
                    db.SaveChanges();
                    MessageBox.Show("Contact updated successfully!");
                    this.Close();
                }
            }

        }
    }
}
