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
        public List<Person> GetPeople(string LastName)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("InvDatabaseDB")))
            {
                var output = connection.Query<Person>($"SELECT * FROM People where LastName = '{ LastName }'").ToList();
                return output;
            }
        }
    }
}
