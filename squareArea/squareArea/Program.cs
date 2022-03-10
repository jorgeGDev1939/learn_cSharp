using System;

namespace SquareArea
{
    class Program
    {
        static void Main(String[] args)
        {
            //this program calculation rectangle area
            float sideA, sideB, square_area;
            Console.WriteLine("input a number: ");
            sideA = float.Parse(Console.ReadLine());
            Console.WriteLine("input a second number: ");
            sideB = float.Parse(Console.ReadLine());
            square_area = sideA * sideB;
            Console.WriteLine("the square area is: " + square_area);
        }
    }
}