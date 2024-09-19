using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NEA_Project
{
    public partial class FmManageAccounts : Form
    {
        public FmManageAccounts()
        {
            InitializeComponent();
        }

        private string tempId;

        private void btShow_Click(object sender, EventArgs e) //when the show button is pressed
        {
            string typeOfValidation = "";
            bool valid = true;

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //
            
            string SQL = "";

            if (rbShowAll.Checked) //if show all is selected 
            {
                SQL = "SELECT * FROM Customers"; //sql statement set to show all entries in Customers table
            }
            if (rbIdSearch.Checked) //if searching by id is selected
            {
                typeOfValidation = "ID"; //what we are validating in this case the ID
                valid = Validation(typeOfValidation); //calls Validation() to see if the value being searched for exists
                
                if(valid == true) //if the account exists
                {
                    SQL = $"SELECT * FROM Customers WHERE CustomerID = '{txId.Text}'";  //sql statement set to show all entries in Customers table where the Id matches the one being searched for
                }
                else //account doesnt exist
                {
                    txId.BackColor = Color.FromArgb(233, 99, 70);   //tells the user
                    lbInvalidId.Show();                             //the id they entered is wrong
                    return;
                }
            }
            if (rbNameSearch.Checked) //if searching by name is selected
            {
                typeOfValidation = "Name"; //validating name
                valid = Validation(typeOfValidation); //checks to see if account with the name the user entered exists
                if (valid == true) //if account exists
                {
                    SQL = $"SELECT * FROM Customers WHERE Firstname = '{txFirstName.Text}' AND Surname = '{txSecondName.Text}'"; //sql statement set to show all entries with that name
                }
                else //account doesnt exist
                {
                    txFirstName.BackColor = Color.FromArgb(233, 99, 70);    //tells the user
                    txSecondName.BackColor = Color.FromArgb(233, 99, 70);   //the name they entered is wrong
                    lbInvalidName.Show();                                   //
                    return;
                }
            }
            if (rbEmailSearch.Checked) //if searching by email is selected
            {
                typeOfValidation = "Email"; //validating email
                valid = Validation(typeOfValidation); //checks to see if account with the email the user entered exists
                if (valid == true) //if account exists
                {
                    SQL = $"SELECT * FROM Customers WHERE Email = '{txEmail.Text}'"; //sql statement set to show all entries with that email
                }
                else //account doesnt exist
                {   
                    txEmail.BackColor = Color.FromArgb(233, 99, 70);    //tells the user
                    lbInvalidEmail.Show();                              //the email they entered is wrong
                    return;
                }
            } 

            //if passed all validation checks and the entry is confirmed to exist
            Cmd.CommandText = SQL;                                  //
            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);   //
            DataTable table = new DataTable();                      //  creates a new Datatable to store the results
            adapter.Fill(table);                                    //  and sets the datasource of the datagrid control to that table
            grid.DataSource = table;                                //  then displays the datagrid which shows the results of the search
            grid.Show();                                            //

            Conn.Close();   //closes the connection
  
            ClearInvalids_Display();    //clears any error messages
            ClearTextBoxes_Display();   //the user may have encountered from searching for something that doesnt exist
           
        }

        private bool Validation(string typeOfValidation) //validation method to validate the entry trying to be accessed exists
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            switch (typeOfValidation) //switch case used on the type of validation to validate what entry is being used depending on what the user is doing:
            {
                //if they are searching via an id
                case "ID": 
                    Cmd.CommandText = $"SELECT * FROM Customers WHERE CustomerID ='{txId.Text}'";
                    OleDbDataReader idReader = Cmd.ExecuteReader();
                    if (idReader.HasRows)
                    {
                        Conn.Close();
                        idReader.Close();
                        return true;
                    }
                    Conn.Close();
                    idReader.Close();
                    return false;

                //if they are trying to delete an entry (using an id) (uses different control to get the id being deleted hence it being its own case - ID2)
                case "ID2": 
                    Cmd.CommandText = $"SELECT * FROM Customers WHERE CustomerID ='{txIdDelete.Text}'";
                    OleDbDataReader idReader2 = Cmd.ExecuteReader();
                    if (idReader2.HasRows)
                    {
                        Conn.Close();
                        idReader2.Close();
                        return true;
                    }
                    Conn.Close();
                    idReader2.Close();
                    return false;

                //if they are trying to edit an entry (using an id) (uses different control to get the id being edited hence it being its own case - ID3)
                case "ID3":
                    Cmd.CommandText = $"SELECT * FROM Customers WHERE CustomerID ='{txIdEdit.Text}'";
                    OleDbDataReader idReader3 = Cmd.ExecuteReader();
                    if (idReader3.HasRows)
                    {
                        Conn.Close();
                        idReader3.Close();
                        return true;
                    }
                    Conn.Close();
                    idReader3.Close();
                    return false;

                //if they are searching via a name
                case "Name":
                    Cmd.CommandText = $"SELECT * FROM Customers WHERE Firstname ='{txFirstName.Text}' AND Surname = '{txSecondName.Text}'";
                    OleDbDataReader nameReader = Cmd.ExecuteReader();
                    if (nameReader.HasRows)
                    {
                        Conn.Close();
                        nameReader.Close();
                        return true;
                    }
                    Conn.Close();
                    nameReader.Close();
                    return false;

                //if they are searching via an email
                case "Email":
                    Cmd.CommandText = $"SELECT * FROM Customers WHERE Email ='{txEmail.Text}'";
                    OleDbDataReader emailReader = Cmd.ExecuteReader();
                    if (emailReader.HasRows)
                    {
                        Conn.Close();
                        emailReader.Close();
                        return true;
                    }
                    Conn.Close();
                    emailReader.Close();
                    return false;
                
                //default case as function believes not all code paths return a value
                default:
                    Conn.Close();
                    return true;
            }
        }

        private void btDelete_Click(object sender, EventArgs e) //when delete button is pressed
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            bool valid = Validation("ID2"); //validates the account trying to be deleted exists

            if(valid) //if it exists
            {
                RemoveActiveRecords(txIdDelete.Text); //removes the accounts relations with other tables (e.g. past/current orders, seating and transactions)
                
                Cmd.CommandText = $"DELETE FROM Customers WHERE CustomerID = '{txIdDelete.Text}'"; //deletes entry that the user specifies with its id
                Cmd.ExecuteNonQuery();
                Conn.Close();
                
                lbSuccessfullyDeleted.Show(); //shows that the deletion was successful

                ClearInvalids_Display();    //hides any error labels the user may have encountered when using an invalid id
                ClearTextBoxes_Display();   //sets the text of text boxes back to blank 
            }
            else //it it doesnt exist
            {
                txIdDelete.BackColor = Color.FromArgb(233, 99, 70); //errors shown to tell user
                lbInvalidIdDelete.Show();                           //they entered something wrong
            }
        }

        private void RemoveActiveRecords(string ID) //Removes any active seating and orders or any past transactions made by the customer
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database  
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            //sees if there are any records related to the customer in the Seating table
            Cmd.CommandText = $"SELECT * FROM Seating WHERE CustomerID ='{ID}'"; 
            OleDbDataReader IDReader = Cmd.ExecuteReader();
            if (IDReader.HasRows)
            {
                IDReader.Close();
                Cmd.CommandText = $"DELETE FROM Seating WHERE CustomerID = '{ID}'"; //deletes all related records
                Cmd.ExecuteNonQuery();
            }
            IDReader.Close();

            //sees if there are any records related to the customer in the Orders table
            Cmd.CommandText = $"SELECT * FROM Orders WHERE CustomerID ='{ID}'";
            IDReader = Cmd.ExecuteReader();
            if (IDReader.HasRows)
            {
                IDReader.Close(); 
                Cmd.CommandText = $"DELETE FROM Orders WHERE CustomerID = '{ID}'"; //deletes all related records
                Cmd.ExecuteNonQuery();
            }
            IDReader.Close();

            //sees if there are any records related to the customer in the Transactions table
            Cmd.CommandText = $"SELECT * FROM Transactions WHERE CustomerID ='{ID}'";
            IDReader = Cmd.ExecuteReader();
            if (IDReader.HasRows)
            {
                IDReader.Close();
                Cmd.CommandText = $"DELETE FROM Transactions WHERE CustomerID = '{ID}'"; //deletes all related records
                Cmd.ExecuteNonQuery();
            }
            IDReader.Close();

            //sees if there are any records related to the customer in the Offers table
            Cmd.CommandText = $"SELECT * FROM Offers WHERE CustomerID ='{ID}'";
            IDReader = Cmd.ExecuteReader();
            if (IDReader.HasRows)
            {
                IDReader.Close();
                Cmd.CommandText = $"DELETE FROM Offers WHERE CustomerID = '{ID}'"; //deletes all related records
                Cmd.ExecuteNonQuery();
            }
            IDReader.Close();

            Conn.Close(); //closes the connection
        }

        private void btFind_Click(object sender, EventArgs e) //when the find button is pressed (to find an account to edit)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            bool Valid = Validation("ID3"); //validates the account trying to be edited exists
            if(Valid == true) //if it does
            {
                Cmd.CommandText = $"SELECT * FROM Customers WHERE CustomerID = '{txIdEdit.Text}'"; //
                OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);                              //
                DataTable table = new DataTable();                                                 //
                adapter.Fill(table);                                                               //shows the user the account (and its details) that they are editing
                grid.DataSource = table;                                                           //
                Conn.Close();                                                                      //
                grid.Show();                                                                       //

                ClearInvalids_Edit(); //hides any error labels the user may have encountered when trying to edit a non-existant account
                
                tempId = txIdEdit.Text; //temporary value of the id of the account to be edited, used when the Change but is pressed

                txIdEdit.Clear(); 

                ShowChangeItems(); //displays all the radio buttons which correspond to the things the user can edit
            }
            else //if the account doesnt exist
            {
                lbInvalidIdEdit.Show();                             //displays an error to the user
                txIdEdit.BackColor = Color.FromArgb(233, 99, 70);   //that they're trying to edit an account that doesnt exist
            }
        }

        private void btChange_Click(object sender, EventArgs e) //when the change button is pressed (the user confirms the changes they want to make)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            string SQL = "";


            if (rbChangeFirstName.Checked) //if theyre updating the first name
            {
                if (txChangeFirstName.Text.Trim() == "")
                {
                    lbIsNull.Show();
                    return;
                }
                SQL = $"UPDATE Customers SET Firstname = '{txChangeFirstName.Text}' WHERE CustomerID = '{tempId}'";
            }
            if (rbChangeSecondName.Checked) //if theyre updating the second name
            {
                if (txChangeSecondName.Text.Trim() == "")
                {
                    lbIsNull.Show();
                    return;
                }
                SQL = $"UPDATE Customers SET Surname = '{txChangeSecondName.Text}' WHERE CustomerID = '{tempId}'";
            }
            if (rbChangePassword.Checked) //if theyre updating the password
            {
                if (txChangePassword.Text.Trim() == "")
                {
                    lbIsNull.Show();
                    return;
                }
                SQL = $"UPDATE Customers SET Pword = '{txChangePassword.Text}' WHERE CustomerID = '{tempId}'";
            }

            lbSuccessfullyChanged.Show(); //displays to the user the changes where successful

            Cmd.CommandText = SQL;  //
            Cmd.ExecuteNonQuery();  //executes the command to make the changes
            Conn.Close();           //

            ClearTextBoxes_Edit(); //clears contents of all textboxes
        }

        private void btExit_Click(object sender, EventArgs e) //closes form when exit button pressed
        {
            Close();
        }

        //DISPLAY/CUSTOMISATION
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        
        //hides error labels and resets colours of textboxes used in the display section of the form
        private void ClearInvalids_Display()
        {
            lbInvalidEmail.Hide();
            lbInvalidId.Hide();
            lbInvalidName.Hide();
            txEmail.BackColor = SystemColors.Window;
            txFirstName.BackColor = SystemColors.Window;
            txSecondName.BackColor = SystemColors.Window;
            txId.BackColor = SystemColors.Window;

        }

        //clears contents of the textboxes used in the display section of the form
        private void ClearTextBoxes_Display()
        {
            txId.Clear();
            txFirstName.Clear();
            txSecondName.Clear();
            txEmail.Clear();
        }

        //hides error labels and resets colours of textboxes used in the edit section of the form
        private void ClearInvalids_Edit()
        {
            lbInvalidIdDelete.Hide();
            txIdDelete.BackColor = SystemColors.Window;
            lbInvalidIdEdit.Hide();
            txIdEdit.BackColor = SystemColors.Window;
        }

        //clears contents of the textboxes used in the edit section of the form
        private void ClearTextBoxes_Edit()
        {
            txIdDelete.Clear();
            txChangeFirstName.Clear();
            txChangeSecondName.Clear();
            txChangePassword.Clear();
        }

        //displays controls for selecting the thing to be changed and the button to change them
        private void ShowChangeItems()
        {
            rbChangeFirstName.Show();
            rbChangeSecondName.Show();
            rbChangePassword.Show();
            btChange.Show();

        }

        //hides text boxes not related to whats being searched for and clears error labels
        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            txId.Hide();
            txEmail.Hide();
            txFirstName.Hide();
            txSecondName.Hide();
            lbFirstName.Hide();
            lbSecondName.Hide();
            ClearInvalids_Display();
        }

        //hides text boxes not related to whats being searched for and clears error labels
        private void rbIdSearch_CheckedChanged(object sender, EventArgs e)
        {
            txId.Show();
            txEmail.Hide();
            txFirstName.Hide();
            txSecondName.Hide();
            lbFirstName.Hide();
            lbSecondName.Hide();
            ClearInvalids_Display();
        }

        //hides text boxes not related to whats being searched for and clears error labels
        private void rbNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            txFirstName.Show();
            txSecondName.Show();
            lbFirstName.Show();
            lbSecondName.Show();
            txId.Hide();
            txEmail.Hide();
            ClearInvalids_Display();
        }

        //hides text boxes not related to whats being searched for and clears error labels
        private void rbEmailSearch_CheckedChanged(object sender, EventArgs e)
        {
            txEmail.Show();
            txId.Hide();
            txFirstName.Hide();
            txSecondName.Hide();
            lbFirstName.Hide();
            lbSecondName.Hide();
            ClearInvalids_Display();
        }

        private void txId_Click(object sender, EventArgs e)             //
        {                                                               //
            ClearInvalids_Display();                                    //
        }                                                               //
                                                                        //
        private void txFirstName_Click(object sender, EventArgs e)      //
        {                                                               //
            ClearInvalids_Display();                                    //
        }                                                               //  
                                                                        //
        private void txSecondName_Click(object sender, EventArgs e)     //
        {                                                               //
            ClearInvalids_Display();                                    //
        }                                                               // hides error labels and changes text boxes colour when the user clicks them
                                                                        //                      (they're going to re-enter the value)
        private void txEmail_Click(object sender, EventArgs e)          //
        {                                                               //
            ClearInvalids_Display();                                    //
        }                                                               //
                                                                        //
        private void txIdDelete_Click(object sender, EventArgs e)       //
        {                                                               //
            ClearInvalids_Edit();                                       //
        }                                                               //
                                                                        //
        private void txIdEdit_Click(object sender, EventArgs e)         //
        {                                                               //
            ClearInvalids_Edit();                                       //
        }                                                               //

        //hides controls that shouldnt be accessed/shown when user is deleting an account and shows what should be able to be accessed
        private void rbDeleteAccount_CheckedChanged(object sender, EventArgs e)
        {
            txIdDelete.Show();
            btDelete.Show();
            lbIdDelete.Show();
            lbIdEdit.Hide();
            txIdEdit.Hide();
            btFind.Hide();
            rbChangeFirstName.Hide();
            rbChangeSecondName.Hide();
            rbChangePassword.Hide();
            txChangeFirstName.Hide();
            txChangeSecondName.Hide();
            txChangePassword.Hide();
        }

        //hides controls that shouldnt be accessed/shown when user is changing an account and shows what should be able to be accessed
        private void rbChangeDetails_CheckedChanged(object sender, EventArgs e)
        {
            txIdDelete.Hide();
            btDelete.Hide();
            lbIdDelete.Hide();
            lbIdEdit.Show();
            txIdEdit.Show();
            btFind.Show();
        }

        //hides text boxes for inputs that arent the one selected and shows the one that is
        private void rbChangeEmail_CheckedChanged(object sender, EventArgs e)
        {
            txChangeFirstName.Hide();
            txChangeSecondName.Hide();
            txChangePassword.Hide();
        }


        //hides text boxes for inputs that arent the one selected and shows the one that is
        private void rbChangeFirstName_CheckedChanged(object sender, EventArgs e)
        {
            txChangeFirstName.Show();
            txChangeSecondName.Hide();
            txChangePassword.Hide();
        }

        //hides text boxes for inputs that arent the one selected and shows the one that is
        private void rbChangeSecondName_CheckedChanged(object sender, EventArgs e)
        {
            txChangeFirstName.Hide();
            txChangeSecondName.Show();
            txChangePassword.Hide();
        }

        //hides text boxes for inputs that arent the one selected and shows the one that is
        private void rbChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            txChangeFirstName.Hide();
            txChangeSecondName.Hide();
            txChangePassword.Show();
        }

        //hides any errors encountered with change details of account when corresponding text boxes are pressed (user is going to enter something different)
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        private void txChangeFirstName_Click(object sender, EventArgs e)
        {
            lbIsNull.Hide();
        }

        private void txChangeSecondName_Click(object sender, EventArgs e)
        {
            lbIsNull.Hide();
        }

        private void txChangePassword_Click(object sender, EventArgs e)
        {
            lbIsNull.Hide();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
