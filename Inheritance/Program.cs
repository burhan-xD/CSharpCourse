// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Conditionals
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD


Customer customer = new Customer();
Person[] person = new Person[3]
{
    new Customer{FirstName="Burhan"},
    new Student{FirstName="xD"},
    new Person{FirstName="istanbulKodluyor"},
};

foreach (Person p in person)
{
    Console.WriteLine(p.FirstName);
}


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class Customer:Person
{
    public string City { get; set; }
}

class Student:Person
{
    public string University { get; set; }
}