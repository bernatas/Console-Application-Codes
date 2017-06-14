class Program
{
    static void Main(string[] args)
    {
        float mesafe, hız, sure;

        //Mesafeyi alma
        Console.WriteLine("Mesafeyi Giriniz:");
        mesafe = float.Parse(Console.ReadLine());

        //Hızı alma
        Console.WriteLine("Hızı Giriniz:");
        hiz = float.Parse(Console.ReadLine());

        //Süreyi hesaplama
        sure = mesafe / hiz;

        Console.WriteLine("Süre: "+sure+" saattir");
        Console.ReadLine();
    }
}
