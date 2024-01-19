using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Sales
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string adress;
        private string zipCode;
        private string city;

        public Customer(string FirstName, string LastName, string PhoneNumber, string Adresss, string ZipCode, string City)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.phoneNumber = PhoneNumber;
            this.adress = Adresss;
            this.zipCode = ZipCode;
            this.city = City;
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public string Adress
        {
            get { return adress; }
        }
        public string ZipCode
        {
            get { return zipCode; }
        }
        public string City
        {
            get { return city; }
        }
    }
}
