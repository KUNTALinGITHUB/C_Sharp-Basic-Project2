using System;
using System.Threading;
class Calculator{
    public static void Main(string[] args){
        Console.WriteLine("      "+"Wel Come to My Calculator"+"    ");
        Console.Write("Enter the first Value : ");
        float val1 = (float)Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter the secound Value : ");
        float val2 = (float)Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Select which operation you want to use:");
        Thread.Sleep(1000);
        Console.Write("+ ");
        Thread.Sleep(1000);
        Console.Write("- ");
        Thread.Sleep(1000);
        Console.Write("x ");
        Thread.Sleep(1000);
        Console.WriteLine("/ ");

        // this bellow link i need to understand more.....about it 
         string? oper = Console.ReadLine();
        if (string.IsNullOrEmpty(oper))
        {
            Console.WriteLine("Invalid input. Please enter a valid operation.");
            return;
        }
        if(oper=="+"){
            float sum= val1+val2;
            Console.WriteLine("sum of {0} and {1} is: {2}",val1,val2,sum);
        }
        else if(oper == "-"){
            float subs = val1 - val2;
            Console.WriteLine("sub of {0} and {1} is: {2}",val1,val2,subs);
        }

        else if(oper == "x"){
            float mult = val1 * val2;
            Console.WriteLine("multi of {0} and {1} is: {2}",val1,val2,mult);
        }

        else if(oper == "/"){
            float div = val1 / val2;
            Console.WriteLine("div of {0} and {1} is: {2}",val1,val2,div);
        }

        else{
            Console.WriteLine("invelid input...");
        }

    }
}
