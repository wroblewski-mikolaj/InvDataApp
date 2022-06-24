using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WindowsFormsApp2
{
    class AccessData
    {
        public string Choice;
    public List<Person> GetData(string lastName)
        {
            

                using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("InvDatabaseDB")))
            {
                var output = connection.Query<Person>($"SELECT * FROM People where {Choice} = '{ lastName }'").ToList();
                //Next one is the same but will use a stored procedure and (atm) works only with last name value, use interchangeably
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        internal void InsertData(string firstName, string lastName, string emailAddress, string telNumber)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("InvDatabaseDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EmailAddress = emailAddress,
                    PhoneNumber = telNumber
                });
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);

            }
        }
    }
}
