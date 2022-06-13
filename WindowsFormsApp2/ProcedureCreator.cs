using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class ProcedureCreator
    {
        internal void AddIntoTable()
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("InvDatabaseDB")))
            {
                string tableProcedure;
                tableProcedure = "CREATE PROCEDURE dbo.People_Insert @FirstName nvarchar(50), @LastName nvarchar(30), @EmailAddress nvarchar(100), @PhoneNumber varchar(25) " +
                    "AS " +
                    "BEGIN " +
                    "SET NOCOUNT ON; " +
                    "INSERT INTO dbo.People(FirstName, LastName, EmailAddress, PhoneNumber) " +
                    "VALUES(@FirstName, @LastName, @EmailAddress, @PhoneNumber) " +
                    "END ";
                SqlCommand CreateProcedureCommand = new SqlCommand(tableProcedure);
                connection.Execute(tableProcedure);

               


            }
        }
    }
}