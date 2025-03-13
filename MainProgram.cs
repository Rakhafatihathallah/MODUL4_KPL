using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modul4_103022300130;

public class MainProgram()
{
    public static void Main(string[] args) 
    {
        string namaProduk = Console.ReadLine();
       
        Console.WriteLine(KodeProduk.getKodeProduk(namaProduk));
    }
}
