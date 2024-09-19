using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NEA_Project
{
    public partial class FmCustomer : Form
    {
        public FmCustomer()
        {
            InitializeComponent();
        }

        public static string customerID; //public variable customerID will be called in forms it is required

        private void FmCustomer_Load(object sender, EventArgs e)
        {
            customerID = null;
        }

        private void btOrder_Click(object sender, EventArgs e) //opens order form
        {
            FmOrder fmOrder = new FmOrder();
            fmOrder.ShowDialog();
        }

        private void btBookSeating_Click(object sender, EventArgs e) //opens seating form
        {
            FmSeating fmSeating = new FmSeating();
            fmSeating.ShowDialog();
        }

        private void btOffers_Click(object sender, EventArgs e)
        {
            FmCustomerOffers fmCustomerOffers = new FmCustomerOffers();
            fmCustomerOffers.ShowDialog();
        }

        private void btOk_Click(object sender, EventArgs e) //when 'Ok' button is pressed
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    //opens a connection to database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT * FROM Customers WHERE Username ='{txUsername.Text}'"; //queries customer table for an entry which has the same username as the one the user entered
            OleDbDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows) //if an entry is found
            {
                reader.Read();
                if(txPassword.Text == reader["Pword"].ToString()) //if the password stored with the account is the same as the one the user entered
                {
                    string customerIdFromTable = reader["CustomerID"].ToString(); //gets the customer id of the related account and
                    customerID = customerIdFromTable;                             //sets the id of the current 'session' to that id
                    gbLogin.Hide();
                }
                else //if the user entered the incorrect password
                {
                    lbInvalidPassword.Show();                           //label to show their password is wrong
                    txPassword.BackColor = Color.FromArgb(233, 99, 70); //changes colour of text box to red to indicated that entry is wrong
                }
            }
            else //if the username the user entered isnt found in the table 
            {
                lbInvalidUsername.Show();                           //label to show their username is wrong
                txUsername.BackColor = Color.FromArgb(233, 99, 70); //changes colour of text box to red to indicated that entry is wrong
            }
            reader.Close();
            Conn.Close();
        }

        private void btExit_Click(object sender, EventArgs e) //closes the form
        {
            Close();
        }

        //DISPLAY/CUSTOMISATION
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        
        private void txUsername_Click(object sender, EventArgs e)   //
        {                                                           //
            txUsername.BackColor = SystemColors.Window;             //
            lbInvalidUsername.Hide();                               //
        }                                                           // hides label telling user they entered a wrong login
                                                                    // when the control is pressed (the user is going to attempt again)
        private void txPassword_Click(object sender, EventArgs e)   //
        {                                                           //
            txPassword.BackColor = SystemColors.Window;             //
            lbInvalidPassword.Hide();                               //
        }                                                           //

   
        private void btShow_Click(object sender, EventArgs e) //changes the password char to not hide the text when the show button is pressed to reveal the password being entered
        {
            txPassword.PasswordChar = '\0';
            btShow.Hide();
            btHide.Show();
        }

        private void btHide_Click(object sender, EventArgs e) //changes the password char to hide the text when the hide button is pressed to hide the password being entered
        {
            txPassword.PasswordChar = '*';
            btHide.Hide();
            btShow.Show();
        }

    }
}
