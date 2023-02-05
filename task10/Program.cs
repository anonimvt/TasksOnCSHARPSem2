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
            if(!input.Equals("exit"))
                Console.WriteLine(input[1]);
        }

    }
}