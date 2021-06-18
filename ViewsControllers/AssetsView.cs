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
    public partial class AssetsView : Form
    {
        public AssetsView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAssetsView form = new AddAssetsView();
            form.ShowDialog();
        }

        Label[] arrValueLabel;
        Label[] arrDescriptionLabel;
        Label[] arrDate;
        private void SubmitAssets_Click(object sender, EventArgs e)
        {
            int numofrows = (int)this.incomeInput.Value;
            var queryValue = new List<String>();
            var queryDescription = new List<String>();
            var queryDate = new List<String>(); 

            Label Value = new Label();
            Label Description = new Label();
            Button Edit;
            Button Delete;

            if (numofrows < 10)
            {
                using (FinanceManagerContainer db = new FinanceManagerContainer())
                {
                    var query = from u in db.Assets.OrderByDescending(p => p.Date) select u;
                    int assetsCount = query.Count();
                    if (numofrows <= assetsCount)
                    {
                    
                        int userId = GetData.getUserId();

                        foreach (var item in query)
                        {
                            if (item.UserId == userId)
                            {
                                queryValue.Add(item.Value);
                                queryDescription.Add(item.Description);
                                queryDate.Add(item.Date);
                            }
                        }

                        if (this.arrValueLabel != null)
                        {
                            for (int i = 0; i < this.arrValueLabel.Length; i++)
                            {
                                this.Controls.Remove(this.arrValueLabel[i]);
                                this.Controls.Remove(this.arrDescriptionLabel[i]);
                                this.Controls.Remove(this.arrDate[i]);
                            }
                        }

                        this.arrValueLabel = new Label[numofrows];
                        this.arrDescriptionLabel = new Label[numofrows];
                        this.arrDate = new Label[numofrows];

                        for (int i = 0; i < arrValueLabel.Length; i++)
                        {
                            this.arrValueLabel[i] = new Label();
                            this.arrDescriptionLabel[i] = new Label();
                            this.arrDate[i] = new Label();

                            this.arrValueLabel[i].Text = queryValue[i];
                            this.arrValueLabel[i].Location = new Point(50, 150 + i * 25);
                            this.arrValueLabel[i].Size = new System.Drawing.Size(90, 19);
                            this.arrValueLabel[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrValueLabel[i]);


                            this.arrDescriptionLabel[i].Text = queryDescription[i];
                            this.arrDescriptionLabel[i].Location = new Point(180, 150 + i * 25);
                            this.arrDescriptionLabel[i].Size = new System.Drawing.Size(150, 19);
                            this.arrDescriptionLabel[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrDescriptionLabel[i]);


                            this.arrDate[i].Text = queryDate[i];
                            this.arrDate[i].Location = new Point(250, 150 + i * 25);
                            this.arrDate[i].Size = new System.Drawing.Size(50, 19);
                            this.arrDate[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                            this.Controls.Add(this.arrDate[i]);

                            Edit = new Button();
                            Edit.Text = "Edit";
                            Edit.Location = new Point(420, 150 + i * 25);
                            Edit.AutoSize = true;
                            Edit.Name = String.Format(queryDescription[i]);
                            Edit.Click += Edit_Click;
                            this.Controls.Add(Edit);

                            Delete = new Button();
                            Delete.Text = "Delete";
                            Delete.Location = new Point(520, 150 + i * 25);
                            Delete.AutoSize = true;
                            Delete.Name = String.Format(queryDescription[i]);
                            Delete.Click += Delete_Click;
                            this.Controls.Add(Delete);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number lower than or equal to " + assetsCount.ToString());
                    }


                }

            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                db.Database.ExecuteSqlCommand("Delete Assets where Description = {0}", btn.Name);
                MessageBox.Show("Contact Deleted Successfully!");
            };
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
