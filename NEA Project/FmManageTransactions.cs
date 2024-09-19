using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace NEA_Project
{
    public partial class FmManageTransactions : Form
    {
        public FmManageTransactions()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e) //closes the form when the exit button is pressed
        {
            Close();
        }
        private void FmManageTransactions_Load(object sender, EventArgs e) //when the form is loaded
        {
            RefreshGrid(); //displaying all transactions made by all customers at any time and the total of those transactions
        }

        private void RefreshGrid() //displaying all transactions made by all customers at any time and the total of those transactions
        {
            double total = GetTotalTransactions("", null); //gets overall total of transactions, parameter 1: "" is used to represent the default value of a textbox, parameter 2: set to null as no date filters should be used
            lbTotal.Text = "Total: £" + total.ToString("0.00"); //updates a label to display the total

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = "SELECT * FROM Transactions";         //selects everything in the transactions table

            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);   //
            DataTable table = new DataTable();                      // 
            adapter.Fill(table);                                    // displays the whole transcations table
            grid.DataSource = table;                                //
            Conn.Close();                                           //
        }

        private void txSearchId_TextChanged(object sender, EventArgs e) //when the user types something into the textbox, used as a kind of 'live' search as it displays the records as they are being typed and requires no button press to search
        {
            double Total;

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);
            DataTable table = new DataTable();

            if (txSearchId.Text.Trim() == "")  //if the textbox is blank (the user deleted their search)
            {
                RefreshGrid();
            }
            else if (txSearchId.Text.Length != 4) //optimising as all ids are 4 characters long so if the entered id is less than 4 then it shouldn't query the database
            {
                grid.DataSource = null;
                lbTotal.Text = "Total: £0";
            }
            else //if the text box isnt empty (there is an id in there or part of one)
            {
                Cmd.CommandText = $"SELECT * FROM Transactions WHERE CustomerID = '{txSearchId.Text}'"; //searches for all transactions related to the id being searched for

                adapter.Fill(table);        //
                grid.DataSource = table;    // displays all the results (if the id isnt fully type in, because this event is triggered every text change, then the display will be nothing, until a full id is entered, as expected)
                Conn.Close();               //

                Total = GetTotalTransactions(txSearchId.Text, null); //gets total transactions made by that particular customer
                lbTotal.Text = "Total: £" + Total.ToString("0.00"); //updates the label to display the total
            }
        }

        private double GetTotalTransactions(string customerId, string date) //uses the contents of the transactions table to workout the total money
        {
            string SQL;

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            //getting transactions based on customers
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if(customerId == "") //if total transactions by a customer is not being searched for
            {
                SQL = "SELECT SUM(Amount) FROM Transactions"; //gets total transactions by every customer
            }
            else //if total transactions by a customer is being searched for
            {
                SQL = $"SELECT SUM(Amount) FROM Transactions WHERE CustomerID = '{customerId}'"; //gets total transactions by the customer with the customer id being searched with
            }
            // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            string today = DateTime.Now.ToString("MM/dd/yyyy"); //gets current date time (in MM/dd/yyyy form as sql works with dates in that form)

            //getting transactions based on dates
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (date == "Today") //if the user wants the total of the transactions today
            {
                SQL = $"SELECT SUM(Amount) FROM Transactions WHERE TransDate = #{today}#"; //selects the transactions made today
            }
            else if(date == "ThisWeek") //if the user wants the total of the transactions made in the last 7 days
            {
                string startOfWeek = DateTime.Now.AddDays(-7).ToString("MM/dd/yyyy"); //workouts the date 7 days before today

                SQL = $"SELECT SUM(Amount) FROM Transactions WHERE TransDate BETWEEN #{startOfWeek}# AND #{today}#"; //selects the transactions made between 7 days ago and today
            }
            else if(date == "ThisMonth") //if the user wants the total of the transactions made in the last month
            {
                string startOfMonth = DateTime.Now.AddMonths(-1).ToString("MM/dd/yyyy"); //workouts the date 1 month before today

                SQL = $"SELECT SUM(Amount) FROM Transactions WHERE TransDate BETWEEN #{startOfMonth}# AND #{today}#"; //selects the transactions made between a month ago and today
            }
            else if(date == "ThisYear") //if the user wants the total of the transactions made in the last year
            {
                string startOfYear = DateTime.Now.AddYears(-1).ToString("MM/dd/yyyy"); //workouts the date 1 year before today

                SQL = $"SELECT SUM(Amount) FROM Transactions WHERE TransDate BETWEEN #{startOfYear}# AND #{today}#"; //selects the transactions made between 1 year ago and today
            }
            // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Have to convert date to MM/dd/yyyy becauses thats what the BETWEEN statement uses

            double totalTransactions = 0;
            Cmd.CommandText = SQL;
            try
            {
                totalTransactions = Convert.ToDouble(Cmd.ExecuteScalar());
                return totalTransactions;
            }
            catch
            {
                return 0;
            }



             //returns the total calculated
        }



        private void btShow_Click(object sender, EventArgs e) //when the show button is pressed (the user wants to display the transactions within a date/time)
        {
            double total = 0;
            string SQL = "";

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //
            
            string today = DateTime.Now.ToString("MM/dd/yyyy"); //gets current date time (in MM/dd/yyyy form as sql works with dates in that form)

            if (rbToday.Checked) //if the user selected transactions today
            {
                SQL = $"SELECT * FROM Transactions WHERE TransDate = #{today}#"; //selects transactions made today
                total = GetTotalTransactions(null, "Today"); //gets total of transcations made today
            }
            else if (rbThisWeek.Checked) //if the user selected transactions within the last week
            {
                string startOfWeek = DateTime.Now.AddDays(-7).ToString("MM/dd/yyyy"); //workouts date 7 days ago from today

                SQL = $"SELECT * FROM Transactions WHERE TransDate BETWEEN #{startOfWeek}# AND #{today}#"; //selects transactions made between today and 7 days ago
                total = GetTotalTransactions(null, "ThisWeek"); //gets total of transactions made in past week
            }
            else if (rbThisMonth.Checked) //if the user selected transactions within the last month
            {
                string startOfMonth = DateTime.Now.AddMonths(-1).ToString("MM/dd/yyyy"); //workouts date 1 month ago from today

                SQL = $"SELECT * FROM Transactions WHERE TransDate BETWEEN #{startOfMonth}# AND #{today}#"; //selects transactions made between today and 1 month ago
                total = GetTotalTransactions(null, "ThisMonth"); //gets total of transactions made in past month
            }
            else if (rbThisYear.Checked) //if the user selected transactions within the last year
            {
                string startOfYear = DateTime.Now.AddYears(-1).ToString("MM/dd/yyyy"); //workouts date 1 year ago from today

                SQL = $"SELECT * FROM Transactions WHERE TransDate BETWEEN #{startOfYear}# AND #{today}#"; //selects transactions made between today and 1 year ago
                total = GetTotalTransactions(null, "ThisYear"); //gets total of transactions made in past year
            }
            //Have to convert date to MM/dd/yyyy becauses thats what the BETWEEN statement uses
            //parameter1 of GetTotalTransactions: set to null as we do not want to search by any customer id filters and null != blank ("")

            Cmd.CommandText = SQL; //sql statement to be used

            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);   // 
            DataTable table = new DataTable();                      // displays the transactions table based on the time filters in the sql statement
            adapter.Fill(table);                                    //
            grid.DataSource = table;                                //
            
            Conn.Close();

            lbTotal.Text = lbTotal.Text = "Total: £" + total.ToString("0.00"); //updates the label to the value worked out in the if statements to display the total within that timeframe

            btShow.Hide();          //hides the show button to
            btClearFilter.Show();   //allow for the clear filter button to be seen and pressed to clear search filter        
        }

        private void btRemove_Click(object sender, EventArgs e) //when the remove button is pressed (the admin wants to remove a transcation made by a customer)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            bool valid = ValidateTransId(); // validates the id of the customer's record that the admin entered exists

            if (valid) //if it does exist
            {
                Cmd.CommandText = $"DELETE FROM Transactions WHERE TransID = '{txTransId.Text}'"; //delets transaction from table
                Cmd.ExecuteNonQuery();                                                            //
            }
            else //if it doesn't exist
            {
                txTransId.BackColor = Color.FromArgb(233, 99, 70);  //displays error telling admin he entered the id wrong/no relative transcation exists
                lbInvalidTransId.Show();                            //
            }
            
            Conn.Close();

            btRemove.Hide(); //hides remove button (design choice, button will reappear when the admin starts typing an id in the textbox)

            RefreshGrid(); //refreshes grid to show updated version
        }

        private bool ValidateTransId() //used to validate if the entered id exists
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT * FROM Transactions WHERE TransID ='{txTransId.Text}'";  //queries transactions table to see if theres an entry with the id the user is trying to delete 
            OleDbDataReader reader = Cmd.ExecuteReader();                                       //

            if (reader.HasRows) //if there are records
            {
                Conn.Close();
                reader.Close();
                return true; //valid so returns true
            }

            Conn.Close();
            reader.Close();
            return false; //if not valid returns false
        }

        private void btClearFilter_Click(object sender, EventArgs e) //when the clear filter button is pressed (the user wants to deselect/unsearch by any time filters)
        {
            RefreshGrid(); //refreshes the grid to show all transactions again (not just the ones searched by by filter)
            btClearFilter.Hide(); //hides button until show button pressed again

            rbToday.Checked = false;        //
            rbThisWeek.Checked = false;     // unchecks all time filter related radio buttons
            rbThisMonth.Checked = false;    //
            rbThisYear.Checked = false;     //
        }

        //DISPLAY/CUSTOMISATION
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        //when user selects a time filter radio button the show button to search by that filter is shown to the user
        //---------------------------------------------------------------------------------------------------------------
        private void rbToday_CheckedChanged(object sender, EventArgs e) 
        {
            if (rbToday.Checked)
            {
                btShow.Show();
            }
        }

        private void rbThisWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThisWeek.Checked)
            {
                btShow.Show();
            }
        }

        private void rbThisMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThisMonth.Checked)
            {
                btShow.Show();
            };
        }

        private void rbThisYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThisYear.Checked)
            {
                btShow.Show();
            }
        }
        //---------------------------------------------------------------------------------------------------------------

        private void txTransId_TextChanged(object sender, EventArgs e) //when user starts entering an id the button to remove by that id appears
        {
            btRemove.Show();
        }

        private void txTransId_Click(object sender, EventArgs e) //when the user clicks the textbox to enter an id (they're going to enter/re-enter an id)
        {
            lbInvalidTransId.Hide();            //hides any errors they may have encountered from past id entries
            txTransId.BackColor = Color.White;  //
        }
    }
}
