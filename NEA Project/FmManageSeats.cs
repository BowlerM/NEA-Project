using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace NEA_Project
{
    public partial class FmManageSeats : Form
    {
        public FmManageSeats()
        {
            InitializeComponent();
        }

        private void FmManageSeats_Load(object sender, EventArgs e) //when the form is loaded
        {
            RefreshForm(); //(re)displays the table containing the orders 
        }

        private void btRefresh_Click(object sender, EventArgs e) //when the refresh button is pressed (if the user wants/needs to refresh the table) 
        {           
            RefreshForm();
        }

        private void btClear_Click(object sender, EventArgs e) //when the clear button is pressed (the user wants to clear a table e.g. the customer has left the restaurant)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //


            EmailReceipt(); //used to send an email receipt to the user 

            Cmd.CommandText = $"DELETE FROM Seating WHERE Tablenumber = '{cbTables.Text}'"; //
            Cmd.ExecuteNonQuery();                                                          // deletes the seating entry according to the order number the user selected
            Conn.Close();                                                                   //

            RefreshForm(); //refreshes the form to display the updated table and combo box

        }

        private void EmailReceipt() //used to send the user an email receipt of them being sat at the restaurant
        {
            DateTime CurrentDateTime = DateTime.Now; 
            string Firstname = "";
            string Surname = "";
            string Email = "";
            string OrderName = "";
            double OrderPrice = 0;
            bool OrderedAnOrder = false;
            var mailMessage = new MailMessage();

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT Firstname, Surname, Email FROM Customers, Seating WHERE Customers.CustomerID = Seating.CustomerID AND TableNumber = '{cbTables.Text}'"; //queries both the customer and seating table to get the details of the customer where the id of the customer sat at the table matches the one in the customers table
            OleDbDataReader reader = Cmd.ExecuteReader();
            while (reader.Read())
            {
                Firstname = reader["Firstname"].ToString(); //
                Surname = reader["Surname"].ToString();     // stores the customers details in variables to be used when sending them an email
                Email = reader["Email"].ToString();         //
            }
            reader.Close();

            string timeNow = DateTime.Now.ToString("HH:mm:ss");
            string timeHourBeforeNow = (DateTime.Now + TimeSpan.FromHours(-1)).ToString("HH:mm:ss");

            Cmd.CommandText = $"SELECT OrderItems, Amount FROM Transactions, Seating WHERE Transactions.CustomerID = Seating.CustomerID AND TableNumber = '{cbTables.Text}' AND TransTime BETWEEN #{timeHourBeforeNow}# AND #{timeNow}#"; //queries both the transactions and seating table to get the food that the customer ordered where the id of the customer sat at the table matches the one in the transcations table and where the transactions was within 1 hour of clearing the seat
            reader = Cmd.ExecuteReader(); 
            while (reader.Read())
            {
                if (reader.HasRows) //if the entry exists (the customer did order something)
                {
                    OrderName = reader["OrderItems"].ToString();             //gets the contents and
                    OrderPrice = Convert.ToDouble(reader["Amount"]);    //price of the order
                    
                    OrderedAnOrder = true; //used to determine what type of email should be sent
                }
            }
            reader.Close();
            Conn.Close();


            string appEmail = ConfigurationManager.AppSettings["SMTP_EMAIL"];
            string password = ConfigurationManager.AppSettings["SMTP_PASSWORD"];
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(appEmail, password),
                EnableSsl = true,
            }; //creates an smtpClient used to send the email, email sent from email set up by me with credentials shown above ^


            if(OrderedAnOrder == true) //if the customer ordered a meal then they will recieve an email with the contents and price of the order
            {
                mailMessage = new MailMessage //creates a mail message 
                {
                    From = new MailAddress(appEmail),
                    Subject = "Seating Receipt",
                    Body = "<body style='background-color:Cornsilk;'>" +
                    $"<h1 style='font-size:60px; color:DarkGoldenRod;'> Hello {Firstname} {Surname} </h1> " +
                    $"<p style = 'color:GoldenRod;'> You sat at our restaurant at {CurrentDateTime} and ordered {OrderName} which cost £{OrderPrice} </p>" +
                    "</body>", //uses the variables defined earlier to create the body of the email
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(Email); //adds the message to a list of emails to be sent to the customer
            }
            else //if the customer didnt order a meal then they will recieve a default email
            {
                mailMessage = new MailMessage //creates a mail message
                {
                    From = new MailAddress(appEmail),
                    Subject = "Seating Receipt",
                    Body = "<body style='background-color:Cornsilk;'>" +
                    $"<h1 style='font-size:60px; color:DarkGoldenRod;'> Hello {Firstname} {Surname} </h1> " +
                    $"<p style = 'color:GoldenRod;'> You sat at our restaurant at {CurrentDateTime} </p>" +
                    "</body>", //uses the variables defined earlier to create the body of the email
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(Email); //adds the message to a list of emails to be sent to the customer
            }

            smtpClient.Send(mailMessage); //sends the email to the user

            //vital that the users email is a valid email e.g. ....@gmail.com this is handled when registering an account in FmRegister
            //if a valid email is entered it is the smptClient that deals with the sending of an email so a valid email could be entered but its not an email that exists, this is also handled in FmRegister
        }

        private void RefreshForm() //(re)displays the table containing the orders and updates the combo box for table number selection
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          // 
            Cmd.Connection = Conn;                                          //

            cbTables.SelectedIndex = -1; //clears an resets the combo box 
            cbTables.Items.Clear();      //that contains the order numbers avaialable for selection

            Cmd.CommandText = "SELECT TableNumber FROM Seating";      //selects all entries in the order table
            OleDbDataReader reader = Cmd.ExecuteReader();   //

            while (reader.Read())
            {
                string tableNumber = reader["TableNumber"].ToString(); //gets the table numbers in the seating table and
                cbTables.Items.Add(tableNumber);                       //adds them to the combo box for selection
            }
            reader.Close(); 

            Cmd.CommandText = "SELECT * FROM Seating";              //
            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);   //
            DataTable table = new DataTable();                      // displays the contents of the orders table to the user
            adapter.Fill(table);                                    //
            grid.DataSource = table;                                //
            
            Conn.Close();
        }


        private void btExit_Click(object sender, EventArgs e) //closes the form
        {
            Close();
        }

        
        private void cbTables_SelectionChangeCommitted(object sender, EventArgs e) //when the user selects a table number from the drop down list the button to clear seating is shown
        {
            btClear.Show();
        }
    }
}
