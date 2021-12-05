using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); 
            string[] subs = s.Split(' ');
            double a = Convert.ToInt32(subs[0]);
            double b = Convert.ToInt32(subs[2]);
            string c = Convert.ToString(subs[1]);
            double results;
            switch (subs[1])
            {
                case "/":
                    results = a / b;
                    Console.WriteLine(results);
                    break;
                case "*":
                    results = a * b;
                    Console.WriteLine(results);
                    break;
                case "+":
                    results = a + b;
                    Console.WriteLine(results);
                    break;
                case "-":
                    results = a - b;
                    Console.WriteLine(results);
                    break;
                default:
                    Console.WriteLine("Ты наркоман что-ли?");
                    break;
            }
            Console.ReadLine();
        }   
     }
}
