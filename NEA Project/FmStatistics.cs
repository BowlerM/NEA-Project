using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Configuration;

namespace NEA_Project
{
    public partial class FmStatistics : Form
    {
        public FmStatistics()
        {
            InitializeComponent();
        }
    
        private void FmStatistics_Load(object sender, EventArgs e)
        {
            UpdateOffers();
            DisplayOffers();
            TotalChart();
        }

        private void UpdateOffers()
        {
            string customerId = "";
            int mealsOrdered = 0;
            double totalSpentInLastMonth;
            List<string> customersEligibleForOffers = new List<string>();

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            string today = DateTime.Now.ToString("MM/dd/yyyy");
            string startOfMonth = DateTime.Now.AddMonths(-1).ToString("MM/dd/yyyy");

            Cmd.CommandText = $"DELETE FROM Offers WHERE OfferDate < {startOfMonth}";   //deletes any active offers not used in past 30 days or any already used offers in past 30 days
            Cmd.ExecuteNonQuery();

            Cmd.CommandText = "SELECT CustomerID, COUNT(Meal) AS MealsOrdered FROM Transactions WHERE Transactions.Meal = '✓' GROUP BY CustomerID"; //calculates the number of items ordered by each customer
            OleDbDataReader reader = Cmd.ExecuteReader();

            while (reader.Read())
            {
                customerId = reader["CustomerID"].ToString();
                mealsOrdered = Convert.ToInt32(reader["MealsOrdered"]);

                if(mealsOrdered % 10 == 0) //if they have ordered an exact multiple of 10 they are eligible for an offer
                {
                    customersEligibleForOffers.Add(customerId);
                }          
            }
            reader.Close();
        
       



            Cmd.CommandText = $"SELECT CustomerID, SUM(Amount) AS TotalSpentRecently FROM Transactions WHERE TransDate BETWEEN #{startOfMonth}# AND #{today}# GROUP BY CustomerID"; //calculates the ammount spent by each customer in past 30 days
            reader = Cmd.ExecuteReader();

            while (reader.Read())
            {
                customerId = reader["CustomerID"].ToString();
                totalSpentInLastMonth = Convert.ToDouble(reader["TotalSpentRecently"]);

                if(totalSpentInLastMonth >= 30) //if they have spent £30 or more in last 30 days they are eligible for an offer
                {
                    customersEligibleForOffers.Add(customerId);
                }
            }
            reader.Close();

            foreach (string customer in customersEligibleForOffers) //for every eligible customer
            {
                Cmd.CommandText = $"SELECT * FROM Offers WHERE CustomerID = '{customer}'"; //checks if the user doesnt already have an (in)active offer
                reader = Cmd.ExecuteReader();

                if (!reader.HasRows) //if they dont
                {
                    reader.Close();
                    Cmd.CommandText = $"INSERT INTO Offers VALUES('{customer}','{today}','✓')"; //adds them to the offer table along with the active symbol (✓) and the date of the order
                    Cmd.ExecuteNonQuery();
                }
                reader.Close();
            }
            reader.Close();

        }

        private void btSendOffers_Click(object sender, EventArgs e) //when the send offers button is pressed
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = "SELECT Offers.CustomerID, Firstname, Surname, Email FROM Offers, Customers WHERE Offers.CustomerID = Customers.CustomerID AND ActiveOffer = '✓' GROUP BY Firstname, Surname, Email, Offers.CustomerID"; //gets the details of the customers eligible for an offer
            OleDbDataReader reader = Cmd.ExecuteReader();

            string firstname = "";
            string surname = "";
            string email = "";


            while (reader.Read())
            {
                firstname = reader["Firstname"].ToString();
                surname = reader["Surname"].ToString();
                email = reader["Email"].ToString();

                EmailCustomerOffer(firstname, surname, email); //uses the values to send the customers an email
            }
            reader.Close();
        }

        private void EmailCustomerOffer(string firstname, string surname, string email) //sends an email to the customers eligible for offers telling them they are eligble for an offer
        {
            string appEmail = ConfigurationManager.AppSettings["SMTP_EMAIL"];
            string password = ConfigurationManager.AppSettings["SMTP_PASSWORD"];
            
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(appEmail, password),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage //creates a mail message 
            {
                From = new MailAddress(appEmail),
                Subject = "25% Off Next Meal!",
                Body =
                "<body style='background-color:Cornsilk;'>" +
                $"<h1 style='font-size:60px; color:DarkGoldenRod;'> <u> Hello {firstname} {surname} </u> </h1>" +
                $"<p style = 'color:GoldenRod;'> for being such a great customer we have given you the option for 25% off your next order when you order using the NEA system. </p>" +
                $"</body>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);

            smtpClient.Send(mailMessage);
        }

        private void TotalChart() //shows top 5 customers who have spent the most in a chart
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //



            Cmd.CommandText = "SELECT TOP 5 Transactions.CustomerID, Username, SUM(Amount) AS TotalSpent FROM Transactions, Customers WHERE Transactions.CustomerID = Customers.CustomerID GROUP BY Transactions.CustomerID, Username"; //selects details of the top 5 customers who have spent the most in all time and how much they have spent
            OleDbDataReader reader = Cmd.ExecuteReader();

;           string customerId = "";
            string username = "";
            double totalSpent = 0;

            while (reader.Read())
            {
                customerId = reader["CustomerID"].ToString();   //values for x axis
                username = reader["Username"].ToString();       //

                totalSpent = Convert.ToDouble(reader["TotalSpent"]); //values for y axis

                chStats.Series["Total Spent"].Points.AddXY($"{username} \n ({customerId})", totalSpent); //plots the values on the chart
            }
            reader.Close();
            Conn.Close();

            
        }


        private void DisplayOffers() //displays the offers table on the form showing whos elgible for an offer
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = "SELECT * FROM Offers WHERE ActiveOffer = '✓'";

            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;

            Conn.Close();
        }


        private void btExit_Click(object sender, EventArgs e) //when the exit button is pressed, closes the form
        {
            Close();
        }

        private void btRefresh_Click(object sender, EventArgs e) //when the refresh button is pressed refreshes the offers table display, refreshes the top 5 total spent chart and re checks eligibililty of all customers for offers and updates the offers table respectively
        {
            UpdateOffers();
            DisplayOffers();
        }
    }
}
