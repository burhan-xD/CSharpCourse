// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Types and Variables
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD

using TypesAndVariables;

Console.Title = "istanbulKodluyor - burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Types And Variables *****");
Console.WriteLine("*************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("*************************************");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;
// Integer
// integer: value type
// int ile tanımlanır
// 32 bit

Console.WriteLine("***** INTEGER *****");
Console.WriteLine("");
int num1 = 1907;
Console.WriteLine(num1);
Console.WriteLine("Number1 is {0}", num1);
Console.WriteLine($"Number1 is {num1}");

Console.WriteLine("Integer Max Value: {0}", int.MaxValue);  // 2147483647
Console.WriteLine("Integer Min Value: {0}", int.MinValue); // -2147483648

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** LONG *****");
Console.WriteLine("");

// long integer
// long: value type
// long ile tanımlanır
// bellekte int'e göre iki katı yer kaplar: 64 bit

long num2 = 214748364799;
Console.WriteLine(num2);
Console.WriteLine("Long Max Value: {0}", long.MaxValue);    // 9223372036854775807
Console.WriteLine("Long Min Value: {0}", long.MinValue);   // -9223372036854775808

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** SHORT *****");
Console.WriteLine("");

// short integer
// short: value type
// short ile tanımlanır
// 16 bit

short num3 = -1923;
Console.WriteLine(num3);
Console.WriteLine("Short Max Value: {0}", short.MaxValue);   // 32767
Console.WriteLine("Short Min Value: {0}", short.MinValue);  // -32768

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** BYTE *****");
Console.WriteLine("");

// byte integer
// byte: value type
// byte ile tanımlanır
// 8 bit

byte num4 = 155;
Console.WriteLine(num4);
Console.WriteLine("Byte Max Value: {0}", byte.MaxValue);   // 255
Console.WriteLine("Byte Min Value: {0}", byte.MinValue);  //  0

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** BOOL *****");
Console.WriteLine("");

// bool mantıksal
// value type
// bool ile tanımlanır - true veya false alabilir
// 8 bit

bool condition = false;
bool condi02 = true;
Console.WriteLine(condition);
Console.WriteLine(condi02);

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** CHAR *****");
Console.WriteLine("");

// char character-ASCII
// value type
// char ile tanımlanır. tek karakter alabilir. '' tek tırnaklar arasında değer alabilir.
// 16 bit

char character = 'a';
Console.WriteLine($"Character is {character}");
Console.WriteLine("Character - ASCII: {0}", (int)character);

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** DOUBLE *****");
Console.WriteLine("");

// double float
// double: value type
// double ile tanımlanır. sona d ya da D eklenebilir, default olduğundan zorunluluk yok.
// 64 bit

double num5 = 1111.155;
Console.WriteLine(num5);
Console.WriteLine("Double Max Value: {0}", double.MaxValue);    // 1.7976931348623157E+308
Console.WriteLine("Double Min Value: {0}", double.MinValue);   // -1.7976931348623157E+308

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** DECIMAL *****");
Console.WriteLine("");

// decimal float
// decimal: value type
// decimal ile tanımlanır. sona m ya da M eklenmesi gerekir!
// 128 bit
// Finans işleri gibi hassas konularda kullanılır

decimal num6 = 668.7897M;
Console.WriteLine(num6);
Console.WriteLine("Decimal Max Value: {0}", decimal.MaxValue);   // 79228162514264337593543950335
Console.WriteLine("Decimal Min Value: {0}", decimal.MinValue);  // -79228162514264337593543950335 

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** ENUM *****");
Console.WriteLine("");

// enum alınabilecek değerler belliyse kullanılabilir. haftanın günleri, il plakalı gibi
// enum: value type
// enum ile tanımlanır
// Days adında bir class yaratıldı. enum orada tanımlandı. kullanımı burada yapıldı.

Console.WriteLine(Days.Friday);
Console.WriteLine(Days.Saturday);

if ((int)Days.Sunday == 7)
{
Console.WriteLine("Bugün tatil...");
}

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** VAR *****");
Console.WriteLine("");

// var variable değildir.
// var değişken tutmak için kullanılır.
// alabileceği belli value types yoktur. char, int, bool alabilir.

var num7 = 9;
Console.WriteLine(num7);
var bool02 = true;
Console.WriteLine(bool02);

Console.ReadLine();
