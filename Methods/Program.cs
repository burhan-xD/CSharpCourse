// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Methods
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD

Console.Title = "istanbulKodluyor - burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Methods *****");
Console.WriteLine("*************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("*************************************");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

Add();
Add();
Add();
Add();
Add();

var result = Add02(5, 4); // return edilen methods mutlaka değişkene atanmalı.
Console.WriteLine(result);

var result02 = Add03(4); // default parametreli method. default değer alan değişken mutlaka en sonda olmalı
Console.WriteLine(result02);

static void Add()
{
    Console.WriteLine("Added...");
}

static int Add02(int num1, int num2)
{
    return num1 + num2;
}

static int Add03(int num1, int num2 = 11) // default parametreli method. default değer alan değişken mutlaka en sonda olmalı
{
    return num1 + num2;
}

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** ref keyword ile çalışmak *****");
Console.WriteLine("");

int num11 = 20;     // ref yerine out kullanılabilir. out kullanılacaksa ilk değer ataması olmak sonunda değil. method içinde tanımlama yapılabilir.
int num22 = 100;
// var result03 = Add04(num11, num22); ref kullanılmadan yapıldığında num11'in değeri sadece method içinde değişir.
var result03 = Add04(ref num11, num22);
Console.WriteLine(result03);
Console.WriteLine(num11); // ref olmazsa 20, ref olursa 30

static int Add04(ref int num11, int num22)
{
    num11 = 30;
    return num11 + num22;
}

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** method overloading && params *****");
Console.WriteLine("");

MOT overloadingTest = new MOT();
var x = overloadingTest.Multiply(4, 5, 2);
Console.WriteLine(x);

PARAMS AddParams = new PARAMS();
var y = AddParams.ADD01(3, 8, 9, 7, 10, 11);
Console.WriteLine(y);

// Aynı isimli method'lar farklı sayıda parametreler.
class MOT
{
    public int Multiply(int num1, int num2)
    {
        return (num1 * num2);
    }

    public int Multiply(int num1, int num2, int num3)
    {
        return num1 * num2 * num3;
    }
}

class PARAMS
{
    public int ADD01(params int[] nums)
    {
        return nums.Sum();
    }
}