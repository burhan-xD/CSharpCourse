
using Interfaces;

//InterfaceIntro();
//IsSqlChoose();

ICustomerDal[] customerDals = new ICustomerDal[3] 
{
    new SqlServerCustomerDal(), 
    new OracleCustomerDal(), 
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

Console.ReadKey();

static void InterfaceIntro()
{
    PersonManager personManager = new PersonManager();
    Customer customer = new Customer();
    customer.FirstName = "Burhan";
    customer.LastName = "xD";
    personManager.Add(customer);

    Student student = new Student();
    personManager.Add(new Student { FirstName = "Engin", LastName = "Gürkan" });
}

static void IsSqlChoose()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}

class Student : IPerson
{
    // not 1a: interface eklenmiş class'larda implementation işlemi yapılmalı. yöntem 2
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string University { get; set; }

}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}
