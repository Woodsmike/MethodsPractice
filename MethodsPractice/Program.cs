using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //methods are tools for us to create re-useable pieces of code
            //methods are a way for us to collect a series of instructions
            //and then call them when we need them.

            //methods are always part of a class.  Methods are always children
            //of classes.
            //This means a method will never be created inside another method or
            //memmber of the class.

            Console.WriteLine("Please enter your first number to be added.");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your first number to be added.");
            int numberTwo = int.Parse(Console.ReadLine());

            int answer = ADD(numberOne, numberTwo);
            Console.WriteLine("The sum of your numbers is : " + answer);

        }

        //access modifier, (static means we don't have to worry about objects), 
        //return type, Method name in Pascal Case, Parentheses (sometimes with parameters)
        public static int ADD(int firstNumber, int secondNumber) //method header
        {
            //Method body
            //A complete method - header and body - is called a method declaraion.

            int sum = firstNumber + secondNumber;

            return sum;
            //void for a method that does not need to return a value.  When you use void return
            //tpye, we don't need to use the keyword "return" type.
        }

    }
}
