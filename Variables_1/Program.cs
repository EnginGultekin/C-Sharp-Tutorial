// See https://aka.ms/new-console-template for more information


int deger = 2;
string variable = null;


Console.WriteLine(deger);

byte b = 5;  // 1 byte

sbyte c = 5;  // 1 byte

short s = 4;  // 2 byte

ushort us = 6; // 2 byte (0 dan küçük veri alamaz)

Int16 i16 = 2;   // 2 byte
int i = 5;      // 4 byte
Int32 i32 = 8;  // 4 byte
Int64 i64 = 2;  // 8 byte

uint ui = 2;  // negatif olmaz 4 bytes

// float : 4b , double: 8b, decimal: 16b

char ch = '5'; // 2 byte
string str2 = "fvb"; // sınırsız

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

DateTime bugun = DateTime.Today;
Console.WriteLine(bugun); 

DateTime ozelTarih = new DateTime(2024, 11, 11, 14, 30, 0);
Console.WriteLine(ozelTarih);


object o1 = "x";    // string
object o2 = 'x';    // char
object o3 =  4;


 // Objeye istediğimiz veri türünü atabiliriz 


 string str_1 = string.Empty;
 str_1 = "Lugan Han";
 Console.WriteLine(str_1);

 string ad = "ad";
 string soyad = "soyad";

 string tam_isim = ad + " " + soyad;
 Console.WriteLine(tam_isim);


 // Tip değişimleri `` Convert.To...() `` şeklinde yapılır
 // integer dönüşümü `` int.parse() ``


// int degisken = 5;
// string degisken = "merhaba";
//Console.WriteLine(degisken);

