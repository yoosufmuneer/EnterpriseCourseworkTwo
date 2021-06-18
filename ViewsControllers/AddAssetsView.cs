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
    public partial class AddAssetsView : Form
    {
        public AddAssetsView()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Decimal value = this.amountInput.Value;
            String description = this.DescriptionTxt.Text;
            DateTime date = this.dateTimePicker1.Value;
            int userId = 0;

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
                    try
                    {
                        //Create Asset Object
                        Asset t = new Asset();
                        t.Value = value.ToString();
                        t.Description = description;
                        t.Date = date.ToString();
                        t.UserId = userId;

                        //Save Asset in Database
                        db.Assets.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Asset Added Successfully");
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.ToString());
                    }
                    this.Close();
                }
            }
        }
    }
}
