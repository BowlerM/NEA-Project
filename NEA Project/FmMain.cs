using System;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace NEA_Project
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }


        private void BtCustomer_Click(object sender, EventArgs e) //opens the customer form
        {
            FmCustomer fmCustomer = new FmCustomer();
            fmCustomer.ShowDialog();
        }

        private void BtAdmin_Click(object sender, EventArgs e) //opens the admin form
        {
            FmAdmin fmAdmin = new FmAdmin();
            fmAdmin.ShowDialog();
        }

        private void BtRegister_Click(object sender, EventArgs e) //opens the register form
        {
            FmRegister fmRegister = new FmRegister();
            fmRegister.ShowDialog();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            FmCustomer.customerID = null; //sets the customer id to null

            if(File.Exists("NEADatabase.accdb") == false) //if the database doesnt exist when the program is run it is created here
            {
                ADOX.Catalog cat = new ADOX.Catalog();  //creates the database
                cat.Create(Program.connString);         //with connection string declared in Program.cs

                OleDbConnection Conn = new OleDbConnection(Program.connString); //
                Conn.Open();                                                    // opens a connection to the database
                OleDbCommand Cmd = new OleDbCommand();                          //
                Cmd.Connection = Conn;                                          //
                

                //creates admin accounts table and inserts the accounts
                Cmd.CommandText = "CREATE TABLE Admins(AdminID CHAR(6), Username VARCHAR(15), Pword VARCHAR(15), PRIMARY KEY (AdminID))"; 
                Cmd.ExecuteNonQuery();                                                                                                    
                Cmd.CommandText = "INSERT INTO Admins VALUES('259361','Admin','Password123')";
                Cmd.ExecuteNonQuery();

                //creates the customers table
                Cmd.CommandText = "CREATE TABLE Customers(CustomerID CHAR(4), Username VARCHAR(15), Pword VARCHAR(15), Firstname VARCHAR(255), Surname VARCHAR(255), Email VARCHAR(50), PRIMARY KEY (CustomerID))"; 
                Cmd.ExecuteNonQuery();


                //creates the orders table
                Cmd.CommandText = "CREATE TABLE Orders(OrderNumber CHAR(2), CustomerID CHAR(4), OrderName VARCHAR(255), OrderTime DATE, OrderPrice MONEY, FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID), PRIMARY KEY(OrderNumber))";
                Cmd.ExecuteNonQuery();

                //creates the menu table and inserts the menu
                Cmd.CommandText = "CREATE TABLE Menu(FoodID VARCHAR(3), Foodtype VARCHAR(10), Name VARCHAR(50), Description VARCHAR(255), Price MONEY, Mealable CHAR(1), PRIMARY KEY (FoodID))";
                Cmd.ExecuteNonQuery();
                #region Insert Menu
                Cmd.CommandText = "INSERT INTO Menu VALUES('A','Main','6 McNuggets','McDonald’s 6 piece Chicken McNuggets are made with 100% chicken breast meat in a deliciously crispy coating, just waiting to be dipped. A firm favourite with everyone.',3.19,'✓')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('B','Main','3 Selects','Strips of tender chicken breast in a seasoned, crispy coating.',3.29,'✓')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('C','Main','5 Selects','Strips of tender chicken breast in a seasoned, crispy coating.',4.29,'✓')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('D','Main','Big Mac','Two 100% beef patties, a slice of cheese, lettuce, onion and pickles. And the sauce. That unbeatable, tasty Big Mac® sauce. You know you want to.',3.19,'✓')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('E','Main','Fillet-O-Fish','Delicious white Hoki or Pollock fish in crispy breadcrumbs, with cheese and tartare sauce, in a steamed bun.',3.19,'✓')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('F','Main','20 McNuggets ShareBox', '100% chicken breast meat in a deliciously crispy coating. Served with your choice of four dips, they are perfect for sharing.',4.99,'X')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('G','Main','Mayo Chicken','Think crispy coated chicken with lettuce and cool mayo in a deliciously soft bun. How can you resist?',0.99,'X')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('H','Side','Fries','Fluffy on the inside and crispy on the outside, our fries are cut from whole potatoes. That is why they are so delicious.',1.09,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('I','Side','Apple Slices','For a tasty snack on the go, try our Apple Splices Fruit Bag.',0.79,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('J','Side','Carrot Bag','Crunchy, fun and one of your five-a-day, this carrot bag is a great on-the-go snack. ',0.79,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('K','Side','Melon Bag','For a fruity snack on the go, our Melon Fruit Bag is ideal.',0.79,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('L','Drink','Cola','A classic, since 1886. Enjoy it with a meal or on its own as a refreshing drink.',1.00,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('M','Drink','Coffee','Take a double shot of Arabica bean espresso and mix it with organic, semi-skimmed milk from UK dairies, steamed to perfection.',1.60,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('N','Drink','Orange Juice','A bottle of real orange juice that is great with your meal.',1.00,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('O','Drink','Water','Spring water.',0.80,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('P','Breakfast','Pancakes','Any day that begins with three pancakes drizzled in golden, delicious syrup is gearing up to be a pretty good one.',2.29,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('Q','Breakfast','Sausage & Egg McMuffin','A pork sausage patty, lightly seasoned with herbs, a free-range egg and a slice of cheese, in a hot, toasted English muffin. Perfect.',2.69,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('R','Breakfast','Bacon & Egg McMuffin','Delicious bacon with a free-range egg, a slice of cheese and one of our toasted English muffins. Delicious every time.',2.69,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('S','Breakfast','Double Sausage & Egg McMuffin','Two pork sausage patties seasoned with herbs, a free-range egg and a slice of cheese, in one of our toasted English muffins, thats what great breakfasts are made of.',2.79,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('T','Breakfast','Double Bacon & Egg McMuffin','Start the morning right with two slices of bacon, a free-range egg, and a slice of cheese, in one of our freshly toasted English muffins.',2.79,'')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Menu VALUES('U','Breakfast','Hash Brown','A delicious hash brown is great on its own or as a side at breakfast time. Crispy on the outside and served until 11am, they are what mornings were made for.',0.89,'')";
                Cmd.ExecuteNonQuery();
                #endregion

                //creates the seating table
                Cmd.CommandText = "CREATE TABLE Seating(TableNumber CHAR(1), CustomerID CHAR(4), SeatingCapacity INTEGER, FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID), PRIMARY KEY(TableNumber))";
                Cmd.ExecuteNonQuery();               

                //creates the transactions
                Cmd.CommandText = "CREATE TABLE Transactions(TransID VARCHAR(255), CustomerID CHAR(4), Amount MONEY, TransDate DATE, TransTime DATE, OrderItems VARCHAR(255), Meal CHAR(1), FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID), PRIMARY KEY(TransID))";
                Cmd.ExecuteNonQuery();

                //creates the offers table
                Cmd.CommandText = "CREATE TABLE Offers(CustomerID CHAR(4), OfferDate DATE, ActiveOffer CHAR(1), PRIMARY KEY(CustomerID))";
                Cmd.ExecuteNonQuery();

                //creates the failed logins table
                Cmd.CommandText = "CREATE TABLE FailedLogins(LoginAttempt INTEGER, AttemptTime DATE, PRIMARY KEY(LoginAttempt))";
                Cmd.ExecuteNonQuery();

                Conn.Close(); //closes the connection
            }
        }

        private void btExit_Click(object sender, EventArgs e) //closes the form and as a result the program
        {
            Close();
        }
    }
}
