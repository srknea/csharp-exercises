using Linq; // This is the namespace that contains the Customer class

DataSource dataSource = new DataSource();

List<Customer> customerList = dataSource.CustomerList();
Console.WriteLine(customerList.Count);
Console.WriteLine("*********************************************************************");

//Number of customers whose name starts with A
int counter = 0;

for (int i = 0; i < customerList.Count; i++)
{
    if (customerList[i].FirstName[0] == 'A')
    {
        counter++;
    }
}

Console.WriteLine("Number of customers whose name starts with A in the list: {0}",counter);
Console.WriteLine("*********************************************************************");

int output = 0;

output = customerList.Where(x => x.FirstName.StartsWith("A")).Count();

Console.WriteLine("Number of customers whose name starts with A in the list: {0}", output);

Console.ReadLine();