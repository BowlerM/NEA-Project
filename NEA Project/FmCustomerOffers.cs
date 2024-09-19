using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Project
{
    public partial class FmCustomerOffers : Form
    {
        public FmCustomerOffers()
        {
            InitializeComponent();
        }


        private void FmCustomerOffers_Load(object sender, EventArgs e) //everything happens when the form is loaded
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            string customerId = FmCustomer.customerID;
            double amountSpentInPastMonth = 0;
            int amountOfMealsOrdered = 0;
            DateTime dateOfOffer ;
            string today = DateTime.Now.ToString("dd/MM/yyyy");

            Cmd.CommandText = $"SELECT * FROM Offers WHERE CustomerID = '{customerId}' AND ActiveOffer = '✓'";    //checks if the customer has an active offer
            OleDbDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows) //if so tells them they have an active offer
            {
                lbEligible.Show();
                reader.Close();
            }
            else
            {
                reader.Close();

                Cmd.CommandText = $"SELECT * FROM Offers WHERE CustomerID = '{customerId}'"; //if the customer has had an offer and has used it so no longer active
                reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows) //works out and displays how long until the user is eligible for their next offer
                    {
                        dateOfOffer = Convert.ToDateTime(reader["OfferDate"]);
                        reader.Close();
                        int daysUntilNextEligibleForOffer = 30 - (Convert.ToDateTime(today) - dateOfOffer).Days;
                        lbDateLabel.Text = $"Eligible for next offer in {daysUntilNextEligibleForOffer} days";
                        gbNotEligibleByTime.Show();
                        return;
                    }
                    reader.Close();
                }
                reader.Close();


                //if the user has not recently had an offer
                Cmd.CommandText = $"SELECT * FROM Transactions WHERE CustomerID = '{customerId}'";
                reader = Cmd.ExecuteReader();

                if (reader.HasRows) //gets variables (amount of money spent in past month and amount of items ordered by customer) to be used in calculation
                {
                    reader.Close();
                    today = DateTime.Now.ToString("MM/dd/yyyy");
                    string startOfMonth = DateTime.Now.AddMonths(-1).ToString("MM/dd/yyyy");

                    Cmd.CommandText = $"SELECT SUM(Amount) AS TotalSpentRecently FROM Transactions WHERE TransDate BETWEEN #{startOfMonth}# AND #{today}# AND CustomerID = '{customerId}'";
                    amountSpentInPastMonth = Convert.ToDouble(Cmd.ExecuteScalar());

                    Cmd.CommandText = $"SELECT COUNT(Meal) AS MealsOrdered FROM Transactions WHERE Meal = '✓' AND CustomerID = '{customerId}'";
                    amountOfMealsOrdered = Convert.ToInt32(Cmd.ExecuteScalar());
                }

                lbItems.Text = $"You need to order {10 - (amountOfMealsOrdered % 10)} more meals";          //works out how many more items until next offer and displays it
                lbTotalSpent.Text = $"You need to spend £{(30 - amountSpentInPastMonth).ToString("0.00")} more this month";    //works out how much more to spend this month til next offer and displays it

                gbNotEligible.Show();
            }
        }

        private void btExit_Click(object sender, EventArgs e) //if exit button press, closes form
        {
            Close();
        }

    }
}
