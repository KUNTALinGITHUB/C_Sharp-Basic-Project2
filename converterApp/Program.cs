using System;
using System.Threading;

class Conveter
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("   " + " Currency and Temperature Converter App " + "   ");
        System.Console.WriteLine("Select the option:");
        Thread.Sleep(1000);
        System.Console.WriteLine("1. Currency Converter(Rs to $ and $ to Rs)");
        Thread.Sleep(1000);
        System.Console.WriteLine("2. Temperature Converter");
        string? option = System.Console.ReadLine();
        if (option == "1")
        {
            System.Console.WriteLine("ok.. you choose the Currency Converter...");
            System.Console.WriteLine("Now choose the primary Currency:(A/B)");
            Thread.Sleep(1000);
            System.Console.WriteLine("A. Rupee");
            Thread.Sleep(1000);
            System.Console.WriteLine("B. Dollar");

            string? Currency = System.Console.ReadLine();
            if (Currency == "A")
            {
                System.Console.WriteLine("Enter the amount(in Rupee):");
                float Rupee = (float)Convert.ToDecimal(System.Console.ReadLine());
                double Dollar = Rupee * 0.012;
                Thread.Sleep(1000);
                System.Console.WriteLine("Rs:{0} = {1}$", Rupee, Dollar);
            }
            else if(Currency=="B")
            {
                System.Console.WriteLine("Enter the amount(in Doller):");
                float Doller = (float)Convert.ToDecimal(System.Console.ReadLine());
                double Rupee = Doller * 83.59;
                Thread.Sleep(1000);
                System.Console.WriteLine("{0}$ = Rs:{1}", Doller, Rupee);
            }
            else
            {
                System.Console.WriteLine("Invalid input by user......");
            }
        }
        else if (option == "2")
        {
            System.Console.WriteLine("ok.. you choose the Temperature Converter...");
            System.Console.WriteLine("Now choose Celsius(C) or Fahrenheit(F):");
            string? Temperature = System.Console.ReadLine();
            if(Temperature=="C")
            {
                System.Console.WriteLine("Enter the temperature(in celsius):");
                float Celsius = (float)Convert.ToDecimal(System.Console.ReadLine());
                double Fahrenheit = (Celsius*9/5)+32;
                Thread.Sleep(1000);
                System.Console.WriteLine("{0} Celsius = {1} Fahrenheit", Celsius, Fahrenheit);    
            }
            else if(Temperature=="F")
            {
                {
                System.Console.WriteLine("Enter the temperature(in Fahrenheit):");
                float Fahrenheit = (float)Convert.ToDecimal(System.Console.ReadLine());
                double Celsius = (Fahrenheit - 32)*5/9;
                Thread.Sleep(1000);
                System.Console.WriteLine("{0} Fahrenheit = {1} Celsius",Fahrenheit, Celsius);    
            }
            }
            else
            {
                System.Console.WriteLine("Invalid input....");
            }

        }
        else
        {
            System.Console.WriteLine("Invalid input....");
        }
    }
}
