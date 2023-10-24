// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Loops
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD

using System;

Console.Title = "istanbulKodluyor - burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Loops *****");
Console.WriteLine("*************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("*************************************");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("for");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("do while");
int y = 1;
do                          // şart uymasa bile 1 kez çalışır.
{
    Console.WriteLine(y);
    y++;
} while (y <= 10);

Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("while");
whileLoop(); // while döngüsü method içinde tanımlandı
//forLoops();   // for döngüleri method içinde tanımlandı
Console.WriteLine("*************************************");
Console.WriteLine("");

//foreach döngüsü. çoğunlukla dizilerde kullanılır.
Console.WriteLine("foreach\n_____________________________________");
string[] students = new string[3];
students[0] = "Elif";
students[1] = "Gürkan";
students[2] = "Kader";

foreach (string student in students) // dizinin tüm elemanları tek tek dolaşılır. her seferinde student içine atanır. student her döngüde sonraki değeri alır
{
    //student = "Pelin"; // foreach readonly olduğundan döngü içinde değişkenin değeri değişemez.
    Console.WriteLine(student);
}

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** isPrime Basic App *****");
Console.WriteLine("");
Console.WriteLine("*************************************");

if (PrimeNumber(7))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This isn't a prime number");
}

Console.ReadLine();

static bool PrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}
static void forLoops()
{
    //çift sayılar geriye doğru
    for (int i = 100; i >= 0; i -= 2)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("");
    Console.WriteLine("*************************************");
    Console.WriteLine("");

    //tek sayılar
    for (int i = 1; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
}
static void whileLoop()
{
    // while döngüsü
    int x = 0;
    while (x <= 5)
    {
        Console.WriteLine(x);
        x++;    // while döngüsünde koşul içindeki değer değişmezse sonsuz döngü oluşabilir!
    }
    Console.WriteLine("Now is x: {0}", x); // döngü içinde son işlem olarak x++ yapıldığından x'in son değeri 6 olur. şart sağlanmadığından döngü çalışmaz.
}