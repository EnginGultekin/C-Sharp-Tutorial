// See https://aka.ms/new-console-template for more information


// Implicit Conversion 
Console.WriteLine("***********Implicit Conversion*************");

float a; int b = 25; a = b;
Console.WriteLine(a);

short x = 10; int y; y = x;
Console.WriteLine(y);


byte byt = 5;
sbyte sbyt = 30;
short c = 10;

int d = byt+sbyt+c;
Console.WriteLine(d);


string s = "luganhan";
char f = 'k';
object ob = s+f+d;   // string + char + integer 

Console.WriteLine(ob);

// Yukarıdaki örnek sorunsuz çalışır. Çünkü float integer'a, 
// integer da short veri tipine göre daha büyük sayıları saklayabiliyor.


// Explicit Conversion
Console.WriteLine("***********Explicit Conversion*************");

int xi  = 4;
byte yi = (byte)xi;       // cast ettik dönüşümü yapsın diye
Console.WriteLine(yi);


float  fl = 10.3f;
byte v = (byte)fl;
Console.WriteLine(fl);







