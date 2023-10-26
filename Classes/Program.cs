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


CustomerManager customerManager = new CustomerManager();    // class'lar ile HEAP bölgesinde yeni bir tür oluşturmuş oluyoruz. onu kullanabilmek için 
ProductManager productManager = new ProductManager();       // stack bölgesinden referans noktası oluşturmak gerekiyor. bunu bu şekilde yapıyoruz.

customerManager.Add();
customerManager.Update();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("*************************************");
Console.ForegroundColor = ConsoleColor.White;
productManager.Add();
productManager.Update();

// Class'lar aynı birer dosya olarak tutulabilir.

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
