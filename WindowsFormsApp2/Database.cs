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
    public partial class InvDatabase : Form
    {
        List<Person> people = new List<Person>();
        public InvDatabase()
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
            
            TableCreator db = new TableCreator();
            try
            {
                db.CreateTable(NameYourTableBox.Text);
                MessageBox.Show("TABLE \"" + NameYourTableBox.Text + "\" is Created Successfully", "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void NameYourTableBox_TextChanged(object sender, EventArgs e)
        {
            /*TableCreator db = new TableCreator();
            db.TableName = NameYourTableBox.Text;
            people = db.GetPeople(LastNameText.Text);
            UpdateBinding();*/
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboSearchBox.SelectedIndex == -1)
                MessageBox.Show("Please select a search option.");

            AccessData db = new AccessData();
            if (comboSearchBox.SelectedIndex == 0)
            {
                db.Choice = "FirstName";
            }
            if (comboSearchBox.SelectedIndex == 1)
            {
                db.Choice = "LastName";
            }
            if (comboSearchBox.SelectedIndex == 2)
            {
                db.Choice = "EmailAddress";
            }
            if (comboSearchBox.SelectedIndex == 3)
            {
                db.Choice = "PhoneNumber";
            }
            if (comboSearchBox.SelectedIndex != -1)
            {
                people = db.GetData(LastNameText.Text);
                UpdateBinding();
            }
        
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AccessData db = new AccessData();
            db.InsertData(FirstNameInsTxt.Text, LastNameInsTxt.Text, EmailInsTxt.Text, TelNumberInsTxt.Text);
        }

        private void btnCreateInsertProcedure_Click(object sender, EventArgs e)
        {
            ProcedureCreator ins = new ProcedureCreator();
            try
            {
                ins.AddIntoTable();
                MessageBox.Show("Procedure is Created Successfully", "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

         void LastNameInsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This button will create a new table within InvDatabase. 
This new table, with a name of your choosing, will have 5 columns: Person ID, Last Name, First Name, Email Address, Phone Number", "InvProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}