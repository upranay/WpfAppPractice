using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPractice
{
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Locality { get; set; }
        public string Landmark { get; set; }

        [Phone]
        public string Phone { get; set; }
        public string PinCode { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Address(int id, string addressLine1, string addressLine2, string locality, string landmark, string pinCode)
        {
            ID = id;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Locality = locality;
            Landmark = landmark;
            PinCode = pinCode;
        }   
    }
}
