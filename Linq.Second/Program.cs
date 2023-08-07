using Linq.Second; // This is the namespace that contains the Customer class

DataSource dataSource = new DataSource();

List<Customer> customerList = dataSource.CustomerList();


int output = 0;

output = customerList.Where(I => I.FirstName.StartsWith("A")).Count();

Console.WriteLine(output);

int secoundOutput = 0;

secoundOutput = (from I in customerList
                 where I.FirstName.StartsWith("A")
                 select I).Count();

Console.WriteLine(secoundOutput);

Console.ReadLine();