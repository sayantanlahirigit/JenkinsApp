using System;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins App");
            Console.WriteLine("This is the first time use of Jenkins");
            Console.ReadLine();
            MyMaths math = new MyMaths();
            int sum = math.add(10, 20);
            int mult = math.mult(10, 20);
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The product is: {mult}");
            Console.ReadLine();
        }
    }
}
