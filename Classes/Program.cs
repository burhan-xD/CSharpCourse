// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Conditionals
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD

using Classes;

Console.Title = "istanbulKodluyor - burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Class *****");
Console.WriteLine("*************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("*************************************");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

                                                             // not 1a:
CustomerManager customerManager = new CustomerManager();    // class'lar ile HEAP bölgesinde yeni bir tür oluşturmuş oluyoruz. onu kullanabilmek için 
ProductManager productManager = new ProductManager();      // stack bölgesinden referans noktası oluşturmak gerekiyor. bunu bu şekilde yapıyoruz.

customerManager.Add();
customerManager.Update();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("*************************************");
Console.ForegroundColor = ConsoleColor.White;
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Test";            // not 2a: atama işlemi yapıldığı zaman property'deki set işlemi çalışır
customer.LastName = "Control";
customer.City = "Zonguldak";

Customer customer2 = new Customer
{
    Id = 2,
    FirstName = "Control",
    LastName = "Test",
    City = "Antalya"
};

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("*************************************");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine(customer.City);       // not 2b: atanmış değer kullanıldığı zaman property içindeki get işlemi çalışır
Console.WriteLine(customer2.City);

// not 3a: Class'lar ayrı birer dosya olarak tutulabilir.

//class CustomerManager
//{
//    public void Add()
//    {
//        Console.WriteLine("Customer Added...");
//    }

//    public void Update() 
//    {
//        Console.WriteLine("Customer Updated...");
//    }
//}
//class ProductManager
//{
//    public void Add()
//    {
//        Console.WriteLine("Product Added...");
//    }

//    public void Update()
//    {
//        Console.WriteLine("Product Updated...");
//    }
//}
