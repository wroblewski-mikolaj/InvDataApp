using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Database : Form
    {
        List<Person> people = new List<Person>();
        public Database()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            str = "CREATE DATABASE InvDatabase";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string TableName = NameYourTableBox.Text;
            String str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;Database=InvDatabase");

            str = "CREATE TABLE " + TableName +
                  "(PersonID int," +
                  "LastName nvarchar(50)," +
                  "FirstName nvarchar(30)," +
                  "EmailAddress nvarchar(100)," +
                  "PhoneNumber varchar(25))";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("TABLE \""+ TableName + "\" is Created Successfully", "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void NameYourTableBox_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AccessData db = new AccessData();
            people = db.GetPeople(LastNameText.Text);
            UpdateBinding();
        }
    }
}