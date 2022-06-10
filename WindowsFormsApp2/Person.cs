using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }


        public string FullInfo
        {
            get { 
                return $"{ FirstName } { LastName } [{ EmailAddress }] <{PhoneNumber}>"; 
                }
        }

    }
}
