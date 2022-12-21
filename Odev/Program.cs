using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        // Bir dikdörtgen alanını ve  çevresini hesaplamak için gerekli olan bilgileri kullanıcıdan düzgün bir şekilde alınız
        // ve sonucunu ekrana düzgün şekilde yazınız


        int kenar1, kenar2, alan =0 ,cevre=0 ;
        Console.WriteLine("ilk sayıyı giriniz :");
        kenar1= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ikinci sayıyı giriniz :");
        kenar2= Convert.ToInt32(Console.ReadLine());

        alan= (kenar1*kenar2);
        Console.WriteLine("Dikdörtgen alanı :" + alan);

        cevre = (kenar1*2) + (kenar2*2);
        Console.WriteLine("Dikdörtgenin çevre uzunlugu :" + cevre);



        Console.ReadKey();

      

    }
}