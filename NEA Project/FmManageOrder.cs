using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NEA_Project
{
    public partial class FmManageOrder : Form
    {
        public FmManageOrder()
        {
            InitializeComponent();
        }


        private void FmManageOrder_Load(object sender, EventArgs e) //when the form is loaded
        {
            RefreshForm(); //(re)displays the table containing the orders
        }

        private void btRefresh_Click(object sender, EventArgs e) //when the refresh button is pressed (if the user wants/needs to refresh the table) 
        {
            RefreshForm();
        }

        private void RefreshForm() //(re)displays the table containing the orders and updates the combo box for order number selection
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            cbOrders.SelectedIndex = -1; //clears an resets the combo box
            cbOrders.Items.Clear();      //that contains the order numbers avaialable for selection

            Cmd.CommandText = "SELECT * FROM Orders";       //selects all entries in the order table
            OleDbDataReader reader = Cmd.ExecuteReader();   //

            while (reader.Read())
            {
                string OrderNumber = reader["OrderNumber"].ToString(); //gets the order numbers in the orders table
                cbOrders.Items.Add(OrderNumber);                       //and adds them to the combo box so they can be selected
            }
            reader.Close();

            Cmd.CommandText = "SELECT * FROM Orders";               //
            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);   //
            DataTable table = new DataTable();                      // displays the contents of the orders table to the user
            adapter.Fill(table);                                    //
            grid.DataSource = table;                                //

            Conn.Close();
        }

        private void btClear_Click(object sender, EventArgs e) //when the clear button is pressed (the user wants to clear an order e.g. the customer has just collected it and left the restaurant)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"DELETE FROM Orders WHERE OrderNumber = '{cbOrders.Text}'" ; //
            Cmd.ExecuteNonQuery();                                                          // deletes the order entry according to the order number the user selected
            Conn.Close();                                                                   //

            RefreshForm(); //refreshes the table and combo box to store the updated values of the orders table
        }

        private void btExit_Click(object sender, EventArgs e) //closes the form
        {
            Close();
        }

        private void cbOrders_SelectionChangeCommitted(object sender, EventArgs e) //when the user selects an order number from the drop down list the button to clear orders is shown
        {
            btClear.Show();
        }
    }
}
