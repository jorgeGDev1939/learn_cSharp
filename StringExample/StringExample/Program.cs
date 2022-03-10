using System;

namespace StringExample
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("What's your name? Please Write your full name");
            string fullUserName = Console.ReadLine();

            Console.WriteLine("Hello " + fullUserName + " Welcome to Platzi");
        }
    }
}