//1-)İki sayının farkını bulan c# kodu
Console.WriteLine("1.Sayiyi giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.Sayiyi giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());   
int cikarma_islemi = sayi1 - sayi2;
Console.WriteLine("Çıkarma işleminin sonucu= " + cikarma_islemi);




//2-)5 sayısının karesini bulan c# kodu 
int sayi3 = 5;
int square = sayi3 * sayi3;
Console.WriteLine("5' in Karesi : " + square);




//3-)10 sayısının 3 ' e bölümünden kalanını bulan  c# kodu 
int sayi4 = 10;
int kalan = sayi4 % 3;
Console.WriteLine("10 sayısının 3 ile bölümünden kalan = " + kalan);




//4-)Klavyeden girilen 4 sayının toplamını ve çarpımını bulan c# kodu 
Console.WriteLine("1.Sayiyi giriniz: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.Sayiyi giriniz: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3.Sayiyi giriniz: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("4.Sayiyi giriniz: ");
int d = Convert.ToInt32(Console.ReadLine());

int toplam = a + b + c+ d;
int carpim = a * b * c * d;

Console.WriteLine("Toplam Sonucu:"+ toplam + " " + "Çarpım Sonucu:" + carpim);




//5-)Klavyeden girilen 2 sayının bölümünü bulan c# kodu
Console.WriteLine("1.Sayiyi giriniz: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("2.Sayiyi giriniz: ");
double y = Convert.ToDouble(Console.ReadLine());
double bölme = x / y ;
Console.WriteLine("Bölme Sonucu:" + bölme);




//6-)Klavyeden kenarları girilen dikdörtgenler prizmasının hacmini hesaplayan   c# kodu 
Console.WriteLine("Uzunluk giriniz:");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yükseklik giriniz:");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Genişlik giriniz:");
int m = Convert.ToInt32(Console.ReadLine());

int volume = k * l * m;
Console.WriteLine("Dikdörtgenler Prizmasının Hacmi:"+volume);
   