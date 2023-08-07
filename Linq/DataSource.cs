using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
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
                tempCustomer.DateOfBirth = FakeData.DateTimeData.GetDatetime();

                customers.Add(tempCustomer);
            }
            return customers;
        }
    }
}
