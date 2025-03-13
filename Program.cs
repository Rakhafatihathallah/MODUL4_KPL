// See https://aka.ms/new-console-template for more information
public class Program()
{
    public static void Main(string[] args)
    {

        /*
        string namaProduk = Console.ReadLine();
       
        Console.WriteLine(KodeProduk.getKodeProduk(namaProduk));
        */

        FanLaptop fanLaptop = new FanLaptop();
        Console.WriteLine("State Fan saat ini adalah Quiet!");
        fanLaptop.increaseFanMode();
        fanLaptop.increaseFanMode();
        fanLaptop.increaseFanMode();
        Console.WriteLine();
        fanLaptop.decreaseFanMode();
        fanLaptop.decreaseFanMode();
        fanLaptop.decreaseFanMode();
        fanLaptop.quietToTurbo();
        fanLaptop.turboToQuiet();
        
    }
}
