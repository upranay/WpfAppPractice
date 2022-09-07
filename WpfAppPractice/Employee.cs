using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPractice
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public string FullAddress { get; }

        public Employee(string firstName, string lastName, int id, string email, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Email = email;
            FullAddress = address;
        }
    }
}
