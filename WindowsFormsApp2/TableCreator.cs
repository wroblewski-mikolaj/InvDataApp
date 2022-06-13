using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class TableCreator
    {
        
        public void CreateTable(string TableName)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("InvDatabaseDB")))
            {
                string tablecreate;
                tablecreate = $"CREATE TABLE {TableName} " +
                  " (PersonID " +
                  "int, " +
                  "LastName nvarchar(50), " +
                  "FirstName nvarchar(30), " +
                  "EmailAddress nvarchar(100), " +
                  "PhoneNumber varchar(25)) ";
                SqlCommand CreateProcedureCommand = new SqlCommand(tablecreate);
                connection.Execute(tablecreate);




            }
        }
    }
}