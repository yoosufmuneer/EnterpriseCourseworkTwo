using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EnterpriseCourseworkTwo
{
    public partial class ReportView : Form
    {

        //Initialize vars required to calculate and display report
        decimal incomeTotal = 0;
        decimal expenseTotal = 0;
        decimal assetsTotal = 0;
        decimal liabilitesTotal = 0;
        decimal netAssets = 0;
        decimal netIncome = 0;

        public ReportView()
        {
            
            InitializeComponent();

            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                //Rerieve Income Data from Database
                var query = from u in db.Incomes select u;

                //Rerieve Expense Data from Database
                var queryExpense = from u in db.Expenses select u;

                //Rerieve Assets from Database
                var queryAssets = from u in db.Assets select u;

                //Rerieve Liabilites from Database
                var queryLiabilites = from u in db.Liabilities select u;


                //Iterate through query result and total all income
                foreach (var i in query)
                {
                    if(i.UserId == GetData.getUserId())
                    {
                        var income = int.Parse(i.Amount);
                        incomeTotal = incomeTotal + income;
                    }                    
                }

                //Iterate through query result and total all expenses
                foreach (var j in queryExpense)
                {
                    if(j.UserId == GetData.getUserId())
                    {
                        var expense = int.Parse(j.Amount);
                        expenseTotal = expenseTotal + expense;
                    }
                }

                //Calculate Net Income
                netIncome = incomeTotal - expenseTotal;

                if (netIncome < 0)
                {
                    this.NetIncome.Text = "-"+netIncome;
                }
                else
                {
                    this.NetIncome.Text = netIncome.ToString();
                }

                //Calculate Total Assets
                foreach(var i in queryAssets)
                {
                    if(i.UserId == GetData.getUserId())
                    {
                        int asset = int.Parse(i.Value);
                        assetsTotal = assetsTotal + asset;
                    }
                }

                foreach(var i in queryLiabilites)
                {
                    if(i.UserId == GetData.getUserId())
                    {
                        int liabilites = int.Parse(i.Value);
                        liabilitesTotal = liabilitesTotal + liabilites;
                    }

                }

                netAssets = assetsTotal - liabilitesTotal;
                               

            }
            this.TotalIncome.Text = incomeTotal.ToString();
            this.TotalExpense.Text = expenseTotal.ToString();
            this.TotalAssets.Text = assetsTotal.ToString();
            this.TotalLiabilities.Text = liabilitesTotal.ToString();
            this.NetAssets.Text = netAssets.ToString();


            //create new thread and assign the function to be run inside the thread
            ThreadStart threadStart = new ThreadStart(FileWriteReport);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start(); //Start thread
        }

        public void FileWriteReport()
        {
                //XML File Location
                string FilePath = @"D:\report.xml";

                //Delete report if it exists already
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }
                //Create XML Textwriter and write to XML File
                XmlTextWriter textWriter = new XmlTextWriter(FilePath, Encoding.Unicode);

                // Start the document
                textWriter.WriteStartDocument();
                
                // Write Title element to the file
                textWriter.WriteStartElement("Report");

                // Write Income element to the file
                textWriter.WriteStartElement("Income");
                textWriter.WriteString(incomeTotal.ToString());
                textWriter.WriteEndElement();

                // Write Total Expense element to the file
                textWriter.WriteStartElement("Expense");
                textWriter.WriteString(expenseTotal.ToString());
                textWriter.WriteEndElement();
            
                // Write Net Income element to the file
                textWriter.WriteStartElement("Net Income");
                textWriter.WriteString(netIncome.ToString());
                textWriter.WriteEndElement();
            
                // Write Assets element to the file
                textWriter.WriteStartElement("Assets");
                textWriter.WriteString(assetsTotal.ToString());
                textWriter.WriteEndElement();
            
                // Write Liabilities element to the file
                textWriter.WriteStartElement("Liabilities");
                textWriter.WriteString(liabilitesTotal.ToString());
                textWriter.WriteEndElement();

                // Write Last End Element
                textWriter.WriteEndElement();

                // Ends the document.
                textWriter.WriteEndDocument();

                // Close the writer
                textWriter.Close();
                Console.ReadLine();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalIncome_Click(object sender, EventArgs e)
        {
            

        }

        private void TotalExpense_Click(object sender, EventArgs e)
        {

        }
    }
}
