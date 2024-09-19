using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NEA_Project
{
    public partial class FmAdmin : Form
    {
        public FmAdmin()
        {
            InitializeComponent();
        }

        private void BtSeating_Click(object sender, EventArgs e) //Opens managing seating form
        {
            FmManageSeats fmManageSeats = new FmManageSeats();
            fmManageSeats.ShowDialog();
        }

        private void btAccounts_Click(object sender, EventArgs e) //Opens managing accounts form
        {
            FmManageAccounts fmManageAccounts = new FmManageAccounts();
            fmManageAccounts.ShowDialog();
        }

        private void btOrder_Click(object sender, EventArgs e) //Opens managing orders form
        {
            FmManageOrder fmManageOrder = new FmManageOrder();
            fmManageOrder.ShowDialog();
        }
        private void BtTrans_Click(object sender, EventArgs e) //Opens managing transactions form
        {
            FmManageTransactions fmManageTransactions = new FmManageTransactions();
            fmManageTransactions.ShowDialog();
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {
            FmStatistics fmStatistics = new FmStatistics();
            fmStatistics.ShowDialog();
        }

        private void FmAdmin_Load(object sender, EventArgs e) //When the form is loaded
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = "SELECT * FROM FailedLogins"; //queries the database for all failed login attempts and orders by LoginAttempt in ascending order
            OleDbDataReader reader = Cmd.ExecuteReader();
            
            int lastLoginAttempt = 0;

            if (reader.HasRows) //if the table is not empty
            {
                reader.Close(); //closes reader as no longer needed
                DateTime lastFailedLoginTime = new DateTime(); //updated with the time of the last login attempt

                DateTime currentTime = DateTime.Now; //gets the time right now
                string strCurrentTime = currentTime.ToString("HH:mm:ss"); //converts current time to hours:mins:seconds
                TimeSpan currentTimeSpan = Convert.ToDateTime(strCurrentTime).TimeOfDay; //converts the string value of current time to a time span

                Cmd.CommandText = "SELECT LoginAttempt FROM FailedLogins ORDER BY LoginAttempt DESC"; //gets value of last login attempt
                lastLoginAttempt = Convert.ToInt16(Cmd.ExecuteScalar()); //updates variable last login attempt with the last value of LoginAttempt on the last row of the table (will always be last row as the SELECT statement is ordered in ascending order)

                Cmd.CommandText = "SELECT AttemptTime FROM FailedLogins ORDER BY LoginAttempt DESC"; //same as above but for time
                lastFailedLoginTime = Convert.ToDateTime(Cmd.ExecuteScalar()); //same as above but for time              


                TimeSpan lastfailedLoginAttemptTimeSpan = lastFailedLoginTime.TimeOfDay; //converts DateTime value of lastFailedLoginTime into a TimeSpan

                TimeSpan differenceBetweenTimes = currentTimeSpan - lastfailedLoginAttemptTimeSpan; //calculates the difference between the current time and the time of the last failed login attempt

                TimeSpan fiveMinTimeSpan = TimeSpan.FromMinutes(5); //creates a new time span of 5 minutes             
                
                if(differenceBetweenTimes < fiveMinTimeSpan && lastLoginAttempt >= 5) //if the last failed login attempt was 5 mins or less ago and it was their 5th attempt then the LockLogins() method is called stopping them from attempting to login
                {
                    TimeSpan timerStart = fiveMinTimeSpan - differenceBetweenTimes; //used in method LockLogins() to determine how long they should be locked out from logging in for
                    LockLogins(timerStart);
                    return;
                }
                else if (differenceBetweenTimes > fiveMinTimeSpan) //'cooldown' system if the last failed login attempt was more than 5 mins ago then the failed attempts are deleted and the user gets 5 attempts back
                {
                    Cmd.CommandText = "DELETE FROM FailedLogins";
                    Cmd.ExecuteNonQuery();
                }
            }
            Conn.Close(); //close connection to database
        }

        private void btLogin_Click(object sender, EventArgs e) //when the login button is pressed
        {
            if(txId.Text == "" || txPassword.Text == "" || txUsername.Text == "") //null checking if they leave a text box empty then a label is displayed telling them so
            {
                lbLoginFailed.Show();
                return;
            }

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT * FROM Admins WHERE Username ='{txUsername.Text}'"; //queries the admins table for a username equivalent to the one the user entered (null checking above handles if this is blank)
            OleDbDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows) //if a result is found
            {
                reader.Read();
                if (txPassword.Text == reader["Pword"].ToString() && txId.Text == reader["AdminID"].ToString()) //if the password and id the user entered is equal to the one attached to the account with said username then they are logged in
                {
                    gbLogin.Hide(); //hides box stopping them from accessing the controls on the form
                    DeleteFailedAttempts(); //deletes any failed attempts the user made as they have made a successful one

                    Conn.Close();
                    reader.Close();
                }
                else //if the password and id are not correct
                {
                    lbLoginFailed.Show(); //used to tell user they have failed the login

                    Conn.Close();
                    reader.Close();

                    HandleFailedAttempt(); //method for handling what happens when a failed attempt occurs 
                }
            }
            else //if the username is not correct (reader cannot find any results)
            {
                lbLoginFailed.Show(); //used to tell user they have failed the login

                Conn.Close();
                reader.Close();

                HandleFailedAttempt(); //method for handling what happens when a failed attempt occurs 
            }
        }

        private void HandleFailedAttempt() //what happens when a failed login attempt occurs (handles tracking how many failed attempts have happened and locking the user out at 5 attempts)
        {

            string currentTime = DateTime.Now.ToString("HH:mm:ss"); //gets current time and converts it to HH:mm:ss
            string SQL = "";
            int lastLoginAttempt = 0; 
            DateTime lastFailedLoginTime = new DateTime();

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a conncetion to database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //


            Cmd.CommandText = "SELECT * FROM FailedLogins"; //queries the database for all failed login attempts and orders by LoginAttempt in ascending order
            OleDbDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows) //if the table isnt empty
            {
                reader.Close();

                Cmd.CommandText = "SELECT LoginAttempt FROM FailedLogins ORDER BY LoginAttempt DESC";
                lastLoginAttempt = Convert.ToInt16(Cmd.ExecuteScalar()); //updates variable last login attempt with the last value of LoginAttempt on the last row of the table (will always be last row as the SELECT statement is ordered in ascending order)

                Cmd.CommandText = "SELECT AttemptTime FROM FailedLogins ORDER BY LoginAttempt DESC";
                lastFailedLoginTime = Convert.ToDateTime(Cmd.ExecuteScalar()); //same as above but for time      



                TimeSpan lastfailedLoginAttemptTimeSpan = lastFailedLoginTime.TimeOfDay; //converts time it happened to TimeSpan

                TimeSpan differenceBetweenTimes = Convert.ToDateTime(currentTime).TimeOfDay - lastfailedLoginAttemptTimeSpan; //calculates difference between current time and time of last failed attempt (how long ago the last failed attempt was)

                
                if (lastLoginAttempt >= 5) //if the user has had 5 or more failed attempts they are locked out
                {
                    TimeSpan timerStart = TimeSpan.FromMinutes(5) - differenceBetweenTimes; //used in LockLogins()  to determine how long a user should be locked out for
                    LockLogins(timerStart);
                    return;
                }
                int currentLoginAttempt = lastLoginAttempt + 1; //calculates the current failed attempt value (e.g. if the last failed attempt was the 2nd attempt then this attempt is the 3rd)
                SQL = $"INSERT INTO FailedLogins VALUES({currentLoginAttempt},#{DateTime.Now.ToString("HH:mm:ss")}#)"; //adds the failed attempt to FailedLogins table               
            }
            else //if the table is empty
            {
                SQL = $"INSERT INTO FailedLogins VALUES({1},#{DateTime.Now.ToString("HH:mm:ss")}#)"; //adds this failed attempt as the first failed attempt
                reader.Close();
            }

            lbLoginAttempts.Text = (5 - lastLoginAttempt).ToString(); //
            lbLoginAttemptsText.Show();                               //used to calculate and display how many attempts the user has left until they are locked out
            lbLoginAttempts.Show();                                   //
                
            Cmd.CommandText = SQL; //executes sql statement to insert the failed attempt 
            Cmd.ExecuteNonQuery(); //into the failed attempts table
            Conn.Close();
        }
        
        private void LockLogins(TimeSpan timerStart) //function that stops the user from logging in
        {
            gbLockedLogin.Show(); //shows a group box blocking them from accessing controls of login group box
            lbLoginFailed.Hide();
            lbCountdown.Text = timerStart.ToString(); //sets the countdown label to how long the user is locked out for
            timer.Enabled = true; //starts the timer control
            timer.Interval = 1000; //sets it to tick in intervals of 1000ms (every second) and triggers a timer tick event z
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan oneSecond = new TimeSpan(0, 0, 1); //TimeSpan of 1 second
            TimeSpan countdown = Convert.ToDateTime(lbCountdown.Text).TimeOfDay; //gets the value of the countdown label and stores it as a TimeSpan
            lbCountdown.Text = (countdown - oneSecond).ToString(); //sets countdown label text to 1 second less of what it currently is
            if(countdown - oneSecond == new TimeSpan(0, 0, 0)) //if the countdown reaches 0mins 0seconds
            {
                timer.Enabled = false; //disables timer
                timer.Dispose(); //disposes timer

                gbLockedLogin.Hide(); //hides the groupbox allowing the user to attempt to login again
                DeleteFailedAttempts(); //clears failed login attempts table
            }
        }

        private void DeleteFailedAttempts() //used to wipe login attempts table (set failed login attempts to none)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;

            Cmd.CommandText = "DELETE FROM FailedLogins";
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

        private void btExit_Click(object sender, EventArgs e) //closes admin form
        {
            Close();
        }

        //DISPLAY/CUSTOMISATION
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void txId_Click(object sender, EventArgs e)             //
        {                                                               //
            lbLoginFailed.Hide();                                       //
        }                                                               //
                                                                        //
        private void txUsername_Click(object sender, EventArgs e)       //
        {                                                               // hides the label telling the user they failed a login attempt
            lbLoginFailed.Hide();                                       // when the user clicks the text box (to re-attempt a login)
        }                                                               //
                                                                        //
        private void txPassword_Click(object sender, EventArgs e)       //
        {                                                               //
            lbLoginFailed.Hide();                                       //
        }                                                               //

    }
}
