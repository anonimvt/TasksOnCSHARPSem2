using System;
using System.Linq;

namespace NewProgram;

public class Program
{
    public static void Main()
    {   
        Console.WriteLine("Введите число");
        while(true)
        {
            string? input = Console.ReadLine();
            if(input.Length > 2)
                Console.WriteLine(input[2]);
            else
            {
                Console.WriteLine("Третий цифры нет.");
            }
        }
    }
}