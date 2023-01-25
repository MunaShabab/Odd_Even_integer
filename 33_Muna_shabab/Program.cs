//chapter 3 Exercise 33
//written by Muna Shabab
//date: 9-10-2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise33
{
    class Program
    {
        static void Main(string[] args)
        {
            //explaining the program
            Console.WriteLine("This application accepts a number entered by the user and determines if it is odd or even");

            //getting a number from the user
            Console.WriteLine("Please enter an integer:");
            int number = int.Parse(Console.ReadLine());

            //determine if it is even
            if ((number%2)==0)
            {
                Console.WriteLine($"{number:n0} is even");
            }

            //or odd
            else
            {
                Console.WriteLine($"{number:n0} is odd");
            }

            Console.ReadLine();
        }
    }
}
