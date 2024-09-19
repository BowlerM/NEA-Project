using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace NEA_Project
{
    public partial class FmMenu : Form
    {
        public FmMenu()
        {
            InitializeComponent();
        }

        private void FmMenu_Load(object sender, EventArgs e) //when the form is loaded
        {
            string SQL = "";

            lbTime.Text = DateTime.Now.ToString("HH:mm");

            OleDbConnection Conn = new OleDbConnection(Program.connString); //
            Conn.Open();                                                    // opens a connection to the database
            OleDbCommand Cmd = new OleDbCommand();                          //
            Cmd.Connection = Conn;                                          //

            if (DateTime.Now.TimeOfDay < new TimeSpan(11,00,00) && DateTime.Now.TimeOfDay >= new TimeSpan(5, 0, 0)) //if the breakfast menu is active (5am - 11am)
            {
                SQL = "SELECT FoodType, Name, Description, Price, Mealable FROM Menu WHERE FoodType = 'Breakfast' OR FoodType = 'Drink' ORDER BY FoodType ASC";
            }
            else //if its not breakfast time
            {
                SQL = "SELECT FoodType, Name, Description, Price, Mealable FROM Menu WHERE FoodType <> 'Breakfast'";
            }
            Cmd.CommandText = SQL; //selects the relevant info a customer will need from the menu table depending if it's breakfast or afternoon

            OleDbDataAdapter adapter = new OleDbDataAdapter(Cmd);   //
            DataTable table = new DataTable();                      //
            adapter.Fill(table);                                    // displays the selected contents of the menu table
            grid.DataSource = table;                                //
            Conn.Close();                                           //
        }


        private void btExit_Click(object sender, EventArgs e) //closes form when exit button is pressed
        {
            Close();
        }
    }
}
