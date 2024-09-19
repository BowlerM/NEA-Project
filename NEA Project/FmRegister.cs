using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace NEA_Project
{
    public partial class FmRegister : Form
    {
        public FmRegister()
        {
            InitializeComponent();
        }

        public string confirmationCode = "";

        private void btNext_Click(object sender, EventArgs e) //when the next button is pressed (the customer has entered their name and contact details successfully)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            if (txFirstName.Text.Trim() == "" || txSurname.Text.Trim() == "")
            {
                lbInvalidName.Show();
                txFirstName.BackColor = Color.FromArgb(233, 99, 70);
                txSurname.BackColor = Color.FromArgb(233, 99, 70);
                return;
            }

  
            //validates that the entered email doesn't already exist
            //---------------------------------------------------------------------------------------------------------------------------------------
            Cmd.CommandText = $"SELECT * FROM Customers WHERE Email ='{txEmail.Text}'"; 
            OleDbDataReader Emailreader = Cmd.ExecuteReader();
            if (Emailreader.HasRows)
            {
                txEmail.BackColor = Color.FromArgb(233, 99, 70);
                lbEmailTaken.Show();
                return;
            }
            Emailreader.Close();
            //---------------------------------------------------------------------------------------------------------------------------------------

            
            bool validEmail = ValidateEmail(txEmail.Text); //validates that entered email is in email format

            if (!validEmail) //if not in email format
            {
                txEmail.BackColor = Color.FromArgb(233, 99, 70);    //displays error to user that it is not in valid format
                lbInvalidEmail.Show();                              //
                return;
            }

            if (!txConfirmationCode.Visible) //if the user has not encountered the two step registration yet (they have not recieved or entered a confirmation code via email)
            {
                SendConfirmationCode(txEmail.Text); //sends the user an email with their verification code
                
                txConfirmationCode.Show();      //
                lbEnterConfirmationCode.Show(); // shows controls for entering an confirming code
                btConfirm.Show();               //

                MessageBox.Show("A confirmation code has been sent to your email please enter it on the form."); //displays a message box telling the user that they've been sent an email with the confirmation code
                
                btNext.Hide(); //hides the ability to continue until valid code entered
                txEmail.ReadOnly = true; //sets email textbox to readonly so the user cant change the email they entered this remains even after the confirmation code has been entered, to enter/change email after this point to form has to be reloaded

                return;
            }


            gbRegister.Hide();                      //once all conditions are met the user can continue to the next part by hiding the group box for entering credentials here the user can enter the username and password they want
            lbRegister.Text = "Create Account:";    //
           
        }

        private bool ValidateEmail(string email) //used to validate that the email that the registering customer entered is in email format and starts process of two step registration
        {
            string appEmail = ConfigurationManager.AppSettings["SMTP_EMAIL"];
            string password = ConfigurationManager.AppSettings["SMTP_PASSWORD"];
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(appEmail, password),
                EnableSsl = true,
            };



            try //If an invalid email address has been enetered (not in the form of an email address) then this code will break (as its trying to add a message to be sent to an email that is not in email format) so I use this to my advantage by using a try catch as if it is invalid (and would break the code) then false is returned in the catch statement
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SendConfirmationCode(string email) //sends the user a confirmation code via the email they entered
        {
            Random rnd = new Random();                  //
            int twoStepCode = rnd.Next(1000, 10000);    // generates a 4 digit confirmation code that the user is emailed to validate its an existing email/the customers email
            confirmationCode = twoStepCode.ToString();  //

            string appEmail = ConfigurationManager.AppSettings["SMTP_EMAIL"];
            string password = ConfigurationManager.AppSettings["SMTP_PASSWORD"];
            var smtpClient = new SmtpClient("smtp.gmail.com")  
            {
                Port = 587,
                Credentials = new NetworkCredential(appEmail, password),
                EnableSsl = true,
            }; //creates an smtpClient used to send the email, email sent from email set up by me with credentials shown above ^

            var mailMessage = new MailMessage //creates a mail message
            {
                From = new MailAddress("mcdonaldsneasystem@gmail.com"),
                Subject = "Confirm Email",
                Body =
                "<body style='background-color:Cornsilk;'>" +
                $"<h1 style='font-size:60px; color:DarkGoldenRod;'> <u> Hello {txFirstName.Text} {txSurname.Text} </u> </h1>" +
                $"<p style = 'color:GoldenRod;'> Thank you for registering an account with us. <br> Please enter this confirmation code on the form: </p>" +
                $"<p> {twoStepCode.ToString()} <br> <br> <br> <br> </p>" +
                "</body>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email); //adds the message to a list of emails to be sent to the customer

            smtpClient.Send(mailMessage); //sends the user the email
        }

        private void btConfirm_Click(object sender, EventArgs e) //when the confirm button is pressed (the user has entered a confirmation code)
        {
            if(txConfirmationCode.Text == confirmationCode) //if the confirmation code the user entered matches the one they were sent
            {
                lbIncorrectCode.Hide(); //hides any incorrect code errors
                lbCorrectCode.Show();   //displays the user entered the right code

                txConfirmationCode.ReadOnly = true; //sets confirmation code text box to readonly so the user cannot change it as they do not need to anymore
                btNext.Show(); //redisplays the next button allowing the user to progress to entering a username and password
            }
            else // if the confirmation code entered does not match the one sent to the user
            {
                lbIncorrectCode.Show(); //displays an error message to the user telling them the code is incorrect
            }
        }

        private void btBack_Click(object sender, EventArgs e) //allows the user to go back to previous group box to change the credentials they entered if they click the back button 
        {
            gbRegister.Show();
            lbRegister.Text = "Enter Details:";
        }





        private void BtSave_Click(object sender, EventArgs e)
        { 
            string customerID = GenerateCustomerId(); //generates id

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT * FROM Customers WHERE Username ='{txUsername.Text}'"; //queries database to see if an account with entered username already exists
            OleDbDataReader Usernamereader = Cmd.ExecuteReader();                             //



            if (Usernamereader.HasRows) //if it does
            {
                txUsername.BackColor = Color.FromArgb(233, 99, 70); //display error informing user that the username is taken
                lbInvalidUsername.Show();                                   //
                return; //early return so code below is not executed
            }
            Usernamereader.Close();

            //checks if user left box blank and displays error telling them it cant be empty
            //----------------------------------------------------------------------------------------
            if(txUsername.Text == "")
            {
                txUsername.BackColor = Color.FromArgb(233, 99, 70);
                lbIsNull.Show();
                return;
            }

            if (txPassword.Text == "")
            {
                txPassword.BackColor = Color.FromArgb(233, 99, 70);
                lbIsNull.Show();
                return;
            }
            //----------------------------------------------------------------------------------------


            Cmd.CommandText = $"INSERT INTO Customers VALUES('{customerID}', '{txUsername.Text.Trim()}', '{txPassword.Text.Trim()}', '{txFirstName.Text.Trim()}', '{txSurname.Text.Trim()}', '{txEmail.Text.Trim()}')";    //
            Cmd.ExecuteNonQuery();                                                                                                                                                                              // inserts account into table (creates account)
            Conn.Close();                                                                                                                                                                                       //

            ClearTextBoxes();           //clears text of all text boxes
            gbAccountCreated.Show();    //shows group box telling user that the account was successfully created and prevents them from registering another account (unless form is closed an reopened)

        }

        private string GenerateCustomerId() //Geneates random 4 digit number to be used as customer id
        {
            Random rnd = new Random();
            int Num = rnd.Next(1000, 10000);
            string customerID = Num.ToString();

            bool validCustomerId = ValidateCustomerID(customerID);

            while(validCustomerId == false)
            {
                Num = rnd.Next(1000, 10000);
                customerID = Num.ToString();
                validCustomerId = ValidateCustomerID(customerID);
            }

            return customerID;
        }

        private bool ValidateCustomerID(string CustomerID)//checks if randomly generated id already exists/has been assigned to an account
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT * FROM Customers WHERE CustomerID ='{CustomerID}'";  //queries database to check if a record with the generated id already exists
            OleDbDataReader IDReader = Cmd.ExecuteReader();                                 //

            if (IDReader.HasRows) //if it does
            {
                Conn.Close();
                IDReader.Close();
                return false; //not valid returns false
            }

            Conn.Close();
            IDReader.Close();
            return true; //if it does, valid returns true
        }

        private void btExit_Click(object sender, EventArgs e) //if the exit button is pressed, closes the form
        {
            Close();
        }

        //DISPLAY/CUSTOMISATION
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btHide_Click(object sender, EventArgs e) //hides password being entered with password character '*'
        {
            txPassword.PasswordChar = '*';
            btHide.Hide();
            btShow.Show();
        } 


        //if the user encountered any errors when entering things into text boxes these will be hidden when the user clicks the text box (as in they're going to re-enter a value)
        //----------------------------------------------------------------------------
        private void txEmail_Click(object sender, EventArgs e)
        {
            lbEmailTaken.Hide();
            lbInvalidEmail.Hide();
            txEmail.BackColor = SystemColors.Window;
        }
        private void txUsername_Click(object sender, EventArgs e)
        {
            txUsername.BackColor = SystemColors.Window;
            lbInvalidUsername.Hide();
            lbIsNull.Hide();
        }
        private void txPassword_Click(object sender, EventArgs e)
        {
            txUsername.BackColor = SystemColors.Window;
            lbInvalidUsername.Hide();
            lbIsNull.Hide();
        }
        private void txFirstName_Click(object sender, EventArgs e)
        {
            txFirstName.BackColor = SystemColors.Window;
            txSurname.BackColor = SystemColors.Window;
            lbInvalidName.Hide();
        }

        private void txSurname_Click(object sender, EventArgs e)
        {
            txFirstName.BackColor = SystemColors.Window;
            txSurname.BackColor = SystemColors.Window;
            lbInvalidName.Hide();
        }

        //----------------------------------------------------------------------------

        private void ClearTextBoxes() //clears text of all text boxes
        {
            txUsername.Clear();
            txPassword.Clear();
            txFirstName.Clear();
            txSurname.Clear();
            txEmail.Clear();
        }


        private void FmRegister_Load(object sender, EventArgs e)
        {
            lbRegister.Text = "Enter Details";
        }

        private void btShow_Click(object sender, EventArgs e) //shows the password being entered into the password text box
        {
            txPassword.PasswordChar = '\0';
            btShow.Hide();
            btHide.Show();
        }

    }
}
