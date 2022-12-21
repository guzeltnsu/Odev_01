internal class Program
{
    private static void Main(string[] args)
    {

        int number = 0;
        Console.WriteLine("lütfen bir sayı giriniz :");

        number = int.Parse(Console.ReadLine()); // önce ekrandan okunuyor. Anında pars metodu ile int'e çevrilir

        Console.WriteLine("Girdiğiniz olduğunuz sayı: {0}", number);

        Console.WriteLine("lütfen programdan çıkmak için bir tuşa basınız...");

        Console.ReadKey();
    }
}