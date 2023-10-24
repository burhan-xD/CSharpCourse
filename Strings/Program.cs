// istanbulKodluyor FullStack .NET Eğitimi - Grup 1B
// Arrays
// bunu yazan kişi öğrenme aşamasında ve kısıtlı ingilizce bilgisi olduğunda dolayı bazen türkçe, bazen ingilizce terimler, açıklamalar kullanmıştır.
// Author: burhan-xD

Console.Title = "istanbulKodluyor - burhan-xD";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Strings *****");
Console.WriteLine("*************************************");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("*************************************");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;

//string metinsel verileri tutmak için kullanılır
// çift tırnak ile atama yapılmalı
//string: referans type

string city = "Antalya";
//strings char dizileri olduğundan her harfe tek tek erişilebilir.
foreach (var item in city)
{
    Console.WriteLine(item);
}

string city2 = "Çanakkale";

Console.WriteLine(String.Format("{0} - {1}", city, city2));

Console.WriteLine("");
Console.WriteLine("*************************************");
Console.WriteLine("");

Console.WriteLine("***** string methods *****");
Console.WriteLine("");
Console.WriteLine("*************************************");

string sentence = "My name is Tobeto...";
var num = sentence.Length;
Console.WriteLine(num);
//LengthControl(sentence);

// bu yapı method haline getirildi => Lengthcontrol()
//int i = 1;
//foreach (var item in sentence)
//{
//    Console.WriteLine($"{i} - {item}");
//    i++;
//}

var sent02 = sentence.Clone();
Console.WriteLine(sent02);
sentence = "istanbulKodluyor...";   //sent02'nin içeriği değişmez. clone ile ayrı(bağımsız) bir değişken yaratıldı.
Console.WriteLine(sent02);
Console.WriteLine(sentence);

bool result01 = sentence.StartsWith("istanbul");
bool result02 = sentence.EndsWith("!");
Console.WriteLine($"{result01} - {result02}");
Console.WriteLine(sentence.GetType());
Console.WriteLine(sent02.GetType()); // string olmasına rağmen string methodlarını kullanamadım. hocaya sor!
Console.WriteLine(sentence.IndexOf("Kod")); // bulduğu ilk değerin index numarasını verir
Console.WriteLine(sentence.LastIndexOf("o")); // bulduğu son değerin index numarasını verir
//LengthControl(sentence);
Console.WriteLine(sentence.Insert(0, "Tobeto - ")); // belirtilen index'den itibaren ekleme yapar
Console.WriteLine(sentence.Substring(2,5)); // string parçalama için kullanılır. 2'inci index'den başla 5 karakter al
Console.WriteLine(sentence.Substring(8, 11)); // string parçalama için kullanılır. 8'inci index'den başla 9 karakter al
Console.WriteLine(sentence.ToLower()); // küçük harf
Console.WriteLine(sentence.ToUpper()); // büyük harf
Console.WriteLine(sentence.Replace(".", "!")); // değer değiştirme
Console.WriteLine(sentence.Replace("...", "!")); // değer değiştirme
Console.WriteLine(sentence.Remove(8));  // belirtilen index'den itibaren siliyor
Console.WriteLine(sentence.Remove(0,8)); // belirtilen index'den itibaren belirtilen sayı kadar siliyor

Console.ReadLine();

static void LengthControl(string sent)
{
    int k = 1;
    foreach (var item in sent)
    {
        Console.WriteLine($"{k} - {item}");
        k++;
    }
}
