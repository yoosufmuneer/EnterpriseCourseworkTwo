using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseCourseworkTwo
{
    public partial class PredictionView : Form
    {
        public PredictionView()
        {
            InitializeComponent();
        }

        private void TotalIncome_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var income = 0;
            var expense = 0;
            var incomeTotal = 0;
            var expenseTotal = 0;

            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                var query = from u in db.Incomes select u;
                var queryExpense = from u in db.Expenses select u;

                foreach (var i in query)
                {
                    if (i.UserId == GetData.getUserId())
                    {
                        income = int.Parse(i.Amount);
                        incomeTotal = incomeTotal + income;
                    }
                }

                foreach (var j in queryExpense)
                {
                    if (j.UserId == GetData.getUserId())
                    {
                        expense = int.Parse(j.Amount);
                        expenseTotal = expenseTotal + expense;
                    }
                }

                var netIncome = incomeTotal - expenseTotal;
            }
            //Set Date value
            var date = this.dateTimePicker1.Value;
            //Get Month From The Date
            var currentDay = DateTime.Today.Month;
            
            var predictedIncome = 0;
            var predictedExpense = 0;
            var predictedNetIncome = 0;

            if (currentDay<date.Month)
            {
                //Get the number of days in the selected month as the divider
                int divider = DateTime.DaysInMonth(date.Year, date.Month);

                
                predictedIncome = incomeTotal / 30 * divider;
                //Display Predicted Total Income
                this.TotalIncome.Text = predictedIncome.ToString();

                predictedExpense = expenseTotal / 30 * divider;

                //Display Predicted Total Expense
                this.TotalExpense.Text = predictedExpense.ToString();

                predictedNetIncome = predictedIncome - predictedExpense;

                //Display Predicted Net Income
                this.NetIncome.Text = predictedNetIncome.ToString();
            }
        }
    }
}
