// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Conditionals
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD


Console.Title = "istanbulKodluyor - burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Conditionals *****");
Console.WriteLine("*************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("*************************************");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

var number = 100;

if (number == 10)
{
    Console.WriteLine("Number is TEN");
}
else if (number == 100)
{
    Console.WriteLine("Number = 100");
}
else
{
    Console.WriteLine("Number isn't TEN");
}

var number2 = 10;
Console.WriteLine(number2 == 10 ? "Number is TEN" : "Number isn't TEN"); //  single line if

int number3 = 55;

switch (number3)
{
    case 5:
        Console.WriteLine("Number 5");
        break;
    case 10:
        Console.WriteLine("Number 10");
        break;
    case 15:
        Console.WriteLine("Number 15");
        break;
    default:
        Console.WriteLine("Unknow...");
        break;
}

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** Conditionals Basic App *****");
Console.WriteLine("");

int num = 9;

if (num >= 11 && num <= 100)
{
    Console.WriteLine("Number is between 11-100");
}
else if(num >= 101 && num <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (num >= 201 || num == 10)
{
    Console.WriteLine("Number is greater than 201 or equal to 10");
}
else
{
    Console.WriteLine("Number is between 0-10");
}



Console.ReadLine();