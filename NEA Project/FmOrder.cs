using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NEA_Project
{
    public partial class FmOrder : Form
    {
        //Meal = 1.20      
        //LargeMeal = 0.40
        //constants that represent additional costs of ordering a meal or large meal

        private bool isBreakfast; //used throughout the code if the time is breakfast time (5am - 11am)

        public FmOrder()
        {
            InitializeComponent();
        }



        private void btMenu_Click(object sender, EventArgs e) //when the menu button is pressed, shows the form displaying the food/drink menu
        {
            FmMenu fmMenu = new FmMenu();
            fmMenu.ShowDialog();
        }
        
        private void FmOrder_Load(object sender, EventArgs e)
        {
            SetTimeLabel(); //displays the time to the user on the form as a label

            CheckTime(); //checks whether it is breakfast or afternoon which affects the whole layout and dynamic of the form
        }

        private void CheckTime()
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            isBreakfast = (DateTime.Now.TimeOfDay < new TimeSpan(11, 00, 00) && DateTime.Now.TimeOfDay >= new TimeSpan(5, 0, 0)) ? true : false; //determines whether it is breakfast or not and sets the variable appropriately


            //sets up the form depenedant on whether it is breakfast time or not
            //----------------------------------------------------------------------
            if (isBreakfast)
            {
                cbAfternoonMain.Hide();
                cbAfternoonSide.Hide();

                cbBreakfastMain.Show();
                cbBreakfastSide.Show();
            }
            else
            {
                cbAfternoonMain.Show();
                cbAfternoonSide.Show();

                cbBreakfastMain.Hide();
                cbBreakfastSide.Hide();
            }
            //----------------------------------------------------------------------
        }

        private void btConfirm_Click(object sender, EventArgs e)    //when the confirm button is clicked, the user wants to confirm their order
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            bool mealSelected = false;
            double orderPrice = 0;



            //error checking for form in breakfast format
            //----------------------------------------------------------------------
            if (isBreakfast)
            {
                if (cbBreakfastMain.SelectedIndex == -1 && cbBreakfastSide.SelectedIndex == -1 && cbDrink.SelectedIndex == -1) //displays error if nothing is selected at all
                {
                    cbBreakfastMain.BackColor = Color.FromArgb(233, 99, 70);
                    cbBreakfastSide.BackColor = Color.FromArgb(233, 99, 70);
                    cbDrink.BackColor = Color.FromArgb(233, 99, 70);
                    lbNoInput.Show();
                    return;
                }
            }
            //----------------------------------------------------------------------

            //error checking and dealing with price for meals for form when not in breakfast format
            //----------------------------------------------------------------------
            else
            {
                if (cbAfternoonMain.SelectedIndex == -1 && cbAfternoonSide.SelectedIndex == -1 && cbDrink.SelectedIndex == -1) //displays error if nothing is selected at all
                {
                    cbAfternoonMain.BackColor = Color.FromArgb(233, 99, 70);
                    cbAfternoonSide.BackColor = Color.FromArgb(233, 99, 70);
                    cbDrink.BackColor = Color.FromArgb(233, 99, 70);
                    lbNoInput.Show();
                    return;
                }
                if (rbMeal.Checked) //displays an error if they're trying to order a meal with no side and drink
                {
                    if (cbAfternoonSide.SelectedIndex == -1)
                    {
                        cbAfternoonSide.BackColor = Color.FromArgb(233, 99, 70);
                        lbNoSide.Show();
                        return;
                    }
                    if (cbDrink.SelectedIndex == -1)
                    {
                        cbDrink.BackColor = Color.FromArgb(233, 99, 70);
                        lbNoDrink.Show();
                        return;
                    }

                    orderPrice += 1.20; //add the constant price for meals to the order price

                    if (rbLarge.Checked) //adds the constant price for large meals to the order price if large is selected
                    {
                        orderPrice += 0.40;
                    }

                    mealSelected = true;
                }
            }
            //----------------------------------------------------------------------


            List<string> items = GetSelectedItems(); //gets the order as a list of strings
            double additionalPrice = GetPrice(items,mealSelected); //gets the price of the order based on what's been ordered
            string customerId = FmCustomer.customerID; 



            string itemsAsOneLine = "";
            foreach(var Item in items)          //puts the items of the order into one string value used later on
            {
                itemsAsOneLine += Item + " ";
            }

            string orderID = GenerateOrderId(); //generates a random order id

            SetTimeLabel(); //updates time label so form shows right time and matches with receipt
            orderPrice += additionalPrice; //adds the calculated order price to get the overall price of the order

            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            Cmd.CommandText = $"SELECT * FROM Offers WHERE CustomerID = '{customerId}' AND ActiveOffer = '✓'"; 
            OleDbDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows) //checks if the user has an active offer
            {
                reader.Close();
                DialogResult result = MessageBox.Show("You are eligible for 25% off this order do you want to use your offer?", "25% off", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //asks them whether they want to use it
                if (result == DialogResult.Yes) //if they select yes
                {
                    double amountOff = orderPrice * 0.25;  //calculates 25% of the order price
                    orderPrice = orderPrice - amountOff;   //and sets the order price to 25% off

                    Cmd.CommandText = $"UPDATE Offers SET ActiveOffer = 'X' WHERE CustomerID = '{customerId}'"; //sets offer as no longer active as it has just been used
                    Cmd.ExecuteNonQuery();
                }
            }

            reader.Close();

            Cmd.CommandText = $"INSERT INTO Orders VALUES('{orderID}','{customerId}','{itemsAsOneLine}',#{currentTime}#,{orderPrice})"; //inserts order into order table
            Cmd.ExecuteNonQuery();
            Conn.Close();

            GenerateReceipt(items, orderPrice, orderID, mealSelected); //generates a receipt which is displayed in a text box
            RecordTransaction(customerId, orderPrice, itemsAsOneLine, mealSelected); //adds order to transactions table

            gbOrderMade.Show();

        }


        private string GenerateTransId() //generates a random large transaction id (large as transactions table will keep track of all transactions made by all customers so will be pretty filled)
        {
            Random rnd = new Random();
            int Num = rnd.Next(0, 1000000000);
            string transId = Num.ToString();   //generates random id

            bool validTransId = ValidateTransId(transId); //checks if valid

            while (validTransId == false)//keeps looping until a valid id is created
            {
                Num = rnd.Next(0, 1000000000);
                transId = Num.ToString();
                validTransId = ValidateOrderID(transId);
            }

            return transId;
        }

        private bool ValidateTransId(string transId) //checks if the generated id already exists if so returns false if not returns true
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;

            Cmd.CommandText = $"SELECT * FROM Transactions WHERE TransID ='{transId}'";
            OleDbDataReader IDReader = Cmd.ExecuteReader();
            if (IDReader.HasRows)
            {
                Conn.Close();
                IDReader.Close();
                return false;
            }
            else
            {
                Conn.Close();
                IDReader.Close();
                return true;
            }
        }

        private void RecordTransaction(string customerId, double orderPrice, string order, bool mealSelected) //adds order to transactions table used for data analysis for offers
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");   
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            string transId = GenerateTransId(); //generates an id to be used

            if (mealSelected) //checks if they have ordered a meal and updates the meal collumn in the table respectively, used for data analysis on how many meals a customer has ordered
            {
                Cmd.CommandText = $"INSERT INTO Transactions VALUES('{transId}','{customerId}',{orderPrice},#{currentDate}#,#{currentTime}#,'{order}','✓')";
                Cmd.ExecuteNonQuery();
            }
            else
            {
                Cmd.CommandText = $"INSERT INTO Transactions VALUES('{transId}','{customerId}',{orderPrice},#{currentDate}#,#{currentTime}#,'{order}','')";
                Cmd.ExecuteNonQuery();
            }

            Conn.Close();
        }


        private List<string> GetSelectedItems() //gets the values of the combo boxes and returns them as a list
        {
            List<string> Items = new List<string>();

            if (isBreakfast) //if its breakfast
            {
                if (cbBreakfastMain.SelectedIndex != -1) //used to check if something is actually selected
                {
                    Items.Add(cbBreakfastMain.Text); //adds the item to the list
                }
                if (cbBreakfastSide.SelectedIndex != -1)
                {
                    Items.Add(cbBreakfastSide.Text);
                }
                if (cbDrink.SelectedIndex != -1)
                {
                    Items.Add(cbDrink.Text);
                }
            }
            else //if it is not breakfast
            {
                if (cbAfternoonMain.SelectedIndex != -1)
                {
                    Items.Add(cbAfternoonMain.Text);
                }
                if (cbAfternoonSide.SelectedIndex != -1)
                {
                    Items.Add(cbAfternoonSide.Text);
                }
                if (cbDrink.SelectedIndex != -1)
                {
                    Items.Add(cbDrink.Text);
                }
            }

            return Items;
        }

        private double GetPrice(List<string> Items, bool MealSelected) //gets the price of the order using the list of items ordered
        {
            double Price = 0;

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            if(MealSelected) //if they have selected a meal then only the main item of that meal matters as the sides and drink are covered by the constants defined earlier
            {
                Cmd.CommandText = $"SELECT Price FROM Menu WHERE Name = '{Items[0]}'"; //selects only the main item of the meal from the menu table
                OleDbDataReader reader = Cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Price += Convert.ToDouble(reader["Price"]); //reads the price of that item
                    }
                }
                reader.Close();
                Conn.Close();

                return Price; //returns the price of the main item
            }


            foreach(var Item in Items) //not a meal so has to get the sum of the prices of every item in the order so loops through each item
            {
                Cmd.CommandText = $"SELECT Price FROM Menu WHERE Name ='{Item}'";
                OleDbDataReader reader = Cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Price += Convert.ToDouble(reader["Price"]); //gets the price of the item and adds it to the total price
                    }
                }
                reader.Close();
            }
            Conn.Close();

            return Price; //returns the sum of the prices of every item in the order
        }

        private string GenerateOrderId() //generates random number to be used as order id
        {
            Random rnd = new Random();
            int Num = rnd.Next(10, 100);
            string orderID = Num.ToString(); //generates random number to be used as id

            bool validOrderID = ValidateOrderID(orderID); //checks if already exists

            while (validOrderID == false)//keeps looping until a valid id is created
            {
                Num = rnd.Next(10, 100);
                orderID = Num.ToString();
                validOrderID = ValidateOrderID(orderID);
            }

            return orderID;
        }

        private bool ValidateOrderID(string OrderID)//checks if randomly generated id has already been generated and assigned to an order is so returns false if not returns true
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;

            Cmd.CommandText = $"SELECT * FROM Orders WHERE OrderNumber ='{OrderID}'";
            OleDbDataReader IDReader = Cmd.ExecuteReader();
            if (IDReader.HasRows)
            {
                Conn.Close();
                IDReader.Close();
                return false;
            }
            else
            {
                Conn.Close();
                IDReader.Close();
                return true;
            }
        }

        private void SetTimeLabel() //updates time label to dislay current time
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private string GetItemPrice(string Item) //returns the price of a single item, used to display the prices of the individual items in the receipt
        {
            double DoublePrice = 0;

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            Cmd.CommandText = $"SELECT Price FROM Menu WHERE Name ='{Item}'"; //selects the item from the menu table
            OleDbDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DoublePrice = Convert.ToDouble(reader["Price"]); //gets the price of that item
                }
            }
            string Price = DoublePrice.ToString("0.00"); //formats the price in the correct format of a price

            return Price; //returns the price of the item
        }

        private void GenerateReceipt(List<string> Items, double Price, string OrderNumber, bool MealSelected) //updates the receipt text box to display a receipt of the order after it has been ordered
        {
            string currentTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if(MealSelected == false) //if they have not selected a meal then the individual prices of every item needs to worked out to display on the receipt
            {
                foreach(var Item in Items) //for every item in the list of items
                {
                    string ItemPrice = GetItemPrice(Item); //gets the price of the current item
                    txOrder.AppendText($"{Item} - £{ItemPrice}" + Environment.NewLine); //displays the item and its price on the receipt
                }
                txOrder.AppendText(Environment.NewLine);                            //
                txOrder.AppendText("====================" + Environment.NewLine);   // formatting to look nice
                txOrder.AppendText(Environment.NewLine);                            //

                txOrder.AppendText($" Total = £ {Price.ToString("0.00")}                     {currentTime}" + Environment.NewLine); //adds total price of order and time of order to receipt

                txOrder.AppendText(Environment.NewLine);                                //
                txOrder.AppendText(Environment.NewLine);                                //
                txOrder.AppendText(Environment.NewLine);                                // more formatting
                txOrder.AppendText("====================" + Environment.NewLine);       //
                txOrder.AppendText(Environment.NewLine);                                //

                txOrder.AppendText($"Order Number: {OrderNumber}"); //adds the order number of the order to the receipt
            }
            else //if the user has selected a meal then the individual prices of the items will not relate to the price of the order and will not be needed to be calculated
            {
                if (rbLarge.Checked) //if the order is a large meal
                {
                txOrder.AppendText($"{Items[0]} Meal - Large" + Environment.NewLine); //adds the main item of the meal and text to go with it e.g. 6 McNugget Meal - Large
                }
                else //if the order is a normal meal
                {
                    txOrder.AppendText($"{Items[0]} Meal" + Environment.NewLine); //adds the main item of the meal and text to go with it e.g. 6 McNugget Meal
                }

                foreach (var Item in Items) //used to add the sub items of the meal to the receipt
                {
                    txOrder.AppendText($" - {Item}" + Environment.NewLine);
                }

                txOrder.AppendText(Environment.NewLine);                            //
                txOrder.AppendText("====================" + Environment.NewLine);   // formatting to look nice
                txOrder.AppendText(Environment.NewLine);                            //

                txOrder.AppendText($" Total = £ {Price.ToString("0.00")}                     {currentTime}" + Environment.NewLine); //adds total price of order and time of order to receipt

                txOrder.AppendText(Environment.NewLine);                                //
                txOrder.AppendText(Environment.NewLine);                                //
                txOrder.AppendText(Environment.NewLine);                                // more formatting
                txOrder.AppendText("====================" + Environment.NewLine);       //
                txOrder.AppendText(Environment.NewLine);                                //

                txOrder.AppendText($"Order Number: {OrderNumber}"); //adds the order number of the order to the receipt
            }

            btPrint.Show(); //shows the previously hidden print button allowing the user to print the newely made receipt
        }

        private void btPrint_Click(object sender, EventArgs e) //if the user presses the print button
        {
            PrintDocument myDoc = new PrintDocument();
            PrintDialog ptDialog = new PrintDialog();
            ptDialog.Document = myDoc;         
            myDoc.PrintPage += new PrintPageEventHandler(PrintLines);
            if (ptDialog.ShowDialog() == DialogResult.OK) //if user confirms print
            {
                myDoc.Print(); //prints the document
            }
        }

        private void PrintLines(object sender, PrintPageEventArgs e) //used to get the lines to be printed, gets the lines from the receipt text box
        {
            string LineToPrint = "";
            float leftMargin = e.MarginBounds.Left;//get margins for printer
            float topMargin = e.MarginBounds.Top;
            Font printFont = new Font("Courier New", 12);

            //Work out the number of lines per page, using the MarginBounds and the height of the font chosen
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            float yPosition;
            Brush myBrush = new SolidBrush(Color.Black);
            yPosition = topMargin;

            LineToPrint = "";
            for (int i = 0; i < txOrder.Lines.Length; i++) // for each line in the text box
            {
                LineToPrint = txOrder.Lines[i]; //get the line from the textbox
                yPosition = topMargin + (i * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(LineToPrint, printFont, myBrush, leftMargin, yPosition);
            }
            myBrush.Dispose();
            printFont.Dispose();
        }

//DISPLAY/CUSTOMISATION
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void cbAfternoonMain_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearCbBackColours();
            if(cbAfternoonMain.Text == "6 McNuggets" || cbAfternoonMain.Text == "3 Selects" || cbAfternoonMain.Text == "5 Selects" || cbAfternoonMain.Text == "Big Mac" || cbAfternoonMain.Text == "Fillet-O-Fish") //if the main item selected can be ordered as a meal
            {
                gbMeal.Show();          //show controls for seleting meals
                btClearMeals.Show();    //
            }
            else //if the main item selected cant be ordered as a meal
            {
                gbMeal.Hide();              //
                gbLarge.Hide();             // hide and reset controls for selecting meals
                rbMeal.Checked = false;     //
                rbLarge.Checked = false;    //
            }
            btClearMain.Show(); 
        }

        //when user selects an item from the combo boxes, displays clear buttons which are used to deselect items/clear the combo box
        //also resets back colours as a result of errors being made
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        private void cbSide_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearCbBackColours();
            btClearSide.Show();
        }

        private void cbDrink_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearCbBackColours();
            btClearDrink.Show();
        }

        private void cbBreakfastMain_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearCbBackColours();
            btClearMain.Show();
        }

        private void cbBreakfastSide_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearCbBackColours();
            btClearSide.Show();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------

        //clear buttons when pressed sets selected index of respective combo box to -1, deselecting the item and resetting the box
        //if breakfast clears breakfast related controls and if not clears afternoon/evening controls
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        private void btClearMain_Click(object sender, EventArgs e)
        {
            if (isBreakfast)
            {
                cbBreakfastMain.SelectedIndex = -1;
            }
            else
            {
                cbAfternoonMain.SelectedIndex = -1;
                gbMeal.Hide();
                gbLarge.Hide();
                rbMeal.Checked = false;
                rbLarge.Checked = false;
            }

            btClearMain.Hide();
            btClearMeals.Hide();
        }

        private void btClearSide_Click(object sender, EventArgs e)
        {
            if (isBreakfast)
            {
                cbBreakfastSide.SelectedIndex = -1;
            }
            else
            {
                cbAfternoonSide.SelectedIndex = -1;
            }

            btClearSide.Hide();
            btClearMeals.Hide();
        }

        private void btClearDrink_Click(object sender, EventArgs e)
        {
            cbDrink.SelectedIndex = -1;
            btClearDrink.Hide();
            btClearMeals.Hide();
        }

        private void btClearMeals_Click(object sender, EventArgs e)
        {
            rbMeal.Checked = false;
            rbLarge.Checked = false;
            gbLarge.Hide();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------


        private void rbMeal_Click(object sender, EventArgs e) //if meal is selected option for large meal shown 
        {
            gbLarge.Show();
        }

        private void ClearCbBackColours() //clears back colours of text boxes that the user may have encounter during an error
        {
            cbAfternoonMain.BackColor = SystemColors.Window;
            cbAfternoonSide.BackColor = SystemColors.Window;
            cbDrink.BackColor = SystemColors.Window;
            cbBreakfastMain.BackColor = SystemColors.Window;
            cbBreakfastSide.BackColor = SystemColors.Window;
            lbNoInput.Hide();
            lbNoSide.Hide();
            lbNoDrink.Hide();
        }


        private void btExit_Click(object sender, EventArgs e) //closes the form when exit button pressed
        {
            Close();
        }


    }
}
