using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Second
{
    public class DataSource
    {
        List<Customer> customers;

        public DataSource()
        {
            customers = new List<Customer>();
        }

        public List<Customer> CustomerList()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Customer tempCustomer = new Customer();
                tempCustomer.CustomerNumber = i;
                tempCustomer.FirstName = FakeData.NameData.GetFirstName();
                tempCustomer.LastName = FakeData.NameData.GetSurname();
                tempCustomer.DateOfBirth = FakeData.DateTimeData.GetDatetime(new DateTime (1984, 01, 01), new DateTime (1999, 01, 01));
                tempCustomer.Country = FakeData.PlaceData.GetCountry();
                tempCustomer.City = FakeData.PlaceData.GetCity();
                
                tempCustomer.Email = $"{tempCustomer.FirstName}.{tempCustomer.LastName}@{FakeData.NetworkData.GetDomain()}";
                
                tempCustomer.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();

                customers.Add(tempCustomer);
            }
            return customers;
        }
    }
}
