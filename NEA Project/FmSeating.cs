using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace NEA_Project
{
    public partial class FmSeating : Form
    {
        public FmSeating()
        {
            InitializeComponent();
        }

        private void FmSeating_Load(object sender, EventArgs e) //when the form is loaded
        {
            RefreshTables(); //refreshes/checks the tables that can be booked (if a table has already been booked it cannot be booked again until cleared)
            CheckIfBooked(); //checks if the current customer has already booked a table and blocks them from blocking another if they have
        }

        private void CheckIfBooked() //checks if the current customer has already booked a table and blocks them from blocking another if they have
        {
            string CustomerId = FmCustomer.customerID; //gets the customer id of the currently logged in customer
            string TableNumber = "";

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT TableNumber FROM Seating WHERE CustomerID = '{CustomerId}'";   //queries the customer table to see if an entry with the id of the currently logged in customer already exists
            OleDbDataReader reader = Cmd.ExecuteReader();                                   //

            while (reader.Read())
            {
                if (reader.HasRows) //if the customer has already booked a table
                {   
                    TableNumber = reader["TableNumber"].ToString(); //
                    lbTableNumber.Text = TableNumber;               // displays a group box telling the customer what table they're booked at, also blocking the user from accessing the form and boooking another table
                    gbTableBooked.Show();                           //
                }
            }
            reader.Close();
            Conn.Close();         
        }

        private void BtSave_Click(object sender, EventArgs e) //if the save button is pressed (the customer's trying to book a seat)
        {
            string TableNumber = "";
            int TableCapacity = 0;
            string CustomerId = FmCustomer.customerID; //gets the id of the currently logged in customer

            #region LotsOfIfStatements
            if (rbTable1.Checked)
            {
                TableNumber = "1";
                TableCapacity = 4;
            }
            if (rbTable2.Checked)
            {
                TableNumber = "2";
                TableCapacity = 6;
            }
            if (rbTable3.Checked)
            {
                TableNumber = "3";
                TableCapacity = 2;
            }
            if (rbTable4.Checked)
            {
                TableNumber = "4";
                TableCapacity = 4;
            }
            if (rbTable5.Checked)
            {
                TableNumber = "5";
                TableCapacity = 4;
            }
            if (rbTable6.Checked)
            {
                TableNumber = "6";
                TableCapacity = 2;
            }
            if (rbTable7.Checked)
            {
                TableNumber = "7";
                TableCapacity = 2;
            }
            if (rbTable8.Checked)
            {
                TableNumber = "8";
                TableCapacity = 6;
            }
            if (rbTable9.Checked)
            {
                TableNumber = "9";
                TableCapacity = 6;
            }
           #endregion

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"INSERT INTO Seating VALUES('{TableNumber}','{CustomerId}',{TableCapacity})"; // 
            Cmd.ExecuteNonQuery();                                                                           //inserts the seating booking into the seating table
            Conn.Close();                                                                                    //

            RefreshTables(); //refreshes the available tables to hide the one just booked

            CheckIfBooked();      //user has booked so they will now be blocked from booking again until their seating order is cleared
            gbTableBooked.Show(); //

        }

        private void RefreshTables() //refreshes/checks the tables that can be booked (if a table has already been booked it cannot be booked again until cleared)
        {
            List<string> bookedTables = new List<string>(); //creates a list used to store the already booked tables

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = "SELECT TableNumber FROM Seating";      //queries the seating table for all booked tables
            OleDbDataReader reader = Cmd.ExecuteReader();   //

            while (reader.Read())
            {
                bookedTables.Add(reader["TableNumber"].ToString()); //adds the numbers of the booked tables to the list
            }
            reader.Close();
            Conn.Close();

            #region LotsOfIfStatements - Gets the already booked tables and hides the corresponding radio buttons
            if (bookedTables.Contains("1"))
            {
                rbTable1.Hide();
            }
            if (bookedTables.Contains("2"))
            {
                rbTable2.Hide();
            }
            if (bookedTables.Contains("3"))
            {
                rbTable3.Hide();
            }
            if (bookedTables.Contains("4"))
            {
                rbTable4.Hide();
            }
            if (bookedTables.Contains("5"))
            {
                rbTable5.Hide();
            }
            if (bookedTables.Contains("6"))
            {
                rbTable6.Hide();
            }
            if (bookedTables.Contains("7"))
            {
                rbTable7.Hide();
            }
            if (bookedTables.Contains("8"))
            {
                rbTable8.Hide();
            }
            if (bookedTables.Contains("9"))
            {
                rbTable9.Hide();
            }
            #endregion
        }

        private void btRefresh_Click(object sender, EventArgs e) //if refresh button is pressed
        {
            RefreshTables();
            CheckIfBooked();
        }

        private void btExit_Click(object sender, EventArgs e) //if exit button is pressed, closes form
        {
            Close();
        }
    }
}
