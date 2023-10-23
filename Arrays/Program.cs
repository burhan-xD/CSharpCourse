// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Arrays
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD

Console.Title = "istanbulKodluyor - burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Arrays *****");
Console.WriteLine("*************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("*************************************");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

// aynı tipteki değerlerin kolay yönetimi, erişimi için kullanılır
//string[] şeklinde köşeli parantezler ile tanımlanabilir

string[] students = new string[3];  // tanımlama 1
students[0] = "Elif";
students[1] = "Gürkan";
students[2] = "Kader";

string[] teachers = new []{"Elif, Kader, Gürkan"};

foreach (string student in students)
{
    Console.WriteLine(student);
}
foreach (string teacher in teachers)
{
    Console.WriteLine(teacher);
}

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** çok boyutlu diziler *****");
Console.WriteLine("");
// çok boyutlu diziler

string[,] regions = new string[7, 3]
{
    {"istanbul","edirne","çanakkale" },
    {"izmir","manisa","muğla" },
    {"antalya","mersin","adana" },
    {"artvin","rize","samsun" },
    {"ankara","konya","kırıkkale" },
    {"gaziantep","hakkari","van" },
    {"kars","ağrı","erzurum" },
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
}

Console.ReadLine();