using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class FanLaptop()
{
    public enum FanState
    {
        quiet,
        balanced,
        performance,
        turbo
    }

    private FanState state;

 
    public void quietToTurbo() 
    {
        if (state == FanState.quiet)
        {
            state = FanState.turbo;
            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
        }
        else {
            Console.WriteLine("State fan saat ini bukan Quiet!");
        }
    }

    public void turboToQuiet()
    {
        if (state == FanState.turbo)
        {
            state = FanState.quiet;
            Console.WriteLine("Fan Turbo berubah menjadi Quiet");
        }
        else 
        {
            Console.WriteLine("State fan saat ini bukan Turbo!");
        }
    }

    public void increaseFanMode() 
    {
        if (state == FanState.quiet)
        {
            state = FanState.balanced;
            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
        }
        else if (state == FanState.balanced)
        {
            state = FanState.performance;
            Console.WriteLine("Fan Balanced berubah menjadi Performance");
        }
        else if (state == FanState.performance)
        {
            state = FanState.turbo;
            Console.WriteLine("Fan Performance berubah menjadi Turbo");
        }
        else if (state == FanState.turbo) 
        {
            Console.WriteLine("Fan State sudah Turbo!");
        }
    }

    public  void decreaseFanMode()
    {
        if (state == FanState.quiet)
        {
            Console.WriteLine("Fan state saat ini sudah Quiet!");
        }
        else if (state == FanState.balanced)
        {
            state = FanState.quiet;
            Console.WriteLine("Fan Balanced berubah menjadi Quiet");
        }
        else if (state == FanState.performance)
        {
            state = FanState.balanced;
            Console.WriteLine("Fan Performance berubah menjadi Balanced");
        } else if (state == FanState.turbo) 
        {
            state = FanState.performance;
            Console.WriteLine("Fan Turbo beurbah menjadi Performance");
        }
    }
}