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

            /*Console.WriteLine("Please enter your first number to be added.");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your first number to be added.");
            int numberTwo = int.Parse(Console.ReadLine());

            int answer = ADD(numberOne, numberTwo);
            Console.WriteLine("The sum of your numbers is : " + answer);*/

            /*RobotWarning("Will Robinson");

            string myBirthMonth = "September";
            string myFriendBirthMonth = "october";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendVehicle = Vehicle(myFriendBirthMonth);
            Console.WriteLine("My futrue vehicle is {0} and Jordan's" +
                " future vehicle is {1}", myVehicle,myFriendVehicle);

        }*/

            //access modifier, (static means we don't have to worry about objects), 
            //return type, Method name in Pascal Case, Parentheses (sometimes with parameters)
            /*public static int ADD(int firstNumber, int secondNumber) //method header
            {
                //Method body
                //A complete method - header and body - is called a method declaraion.

                int sum = firstNumber + secondNumber;

                return sum;

            }*/
            //void for a method that does not need to return a value.  When you use void return
            //tpye, we don't need to use the keyword "return" type.
            /*public static void RobotWarning(string name)
            {
                Console.WriteLine("Danger, " + name + " !!");
            }
            public static string Vehicle(string birthMonth)
            {
                string vehicleFortune;
                if (birthMonth.ToLower() == "september" || birthMonth.ToLower() == "october")
                {
                    vehicleFortune = "Hoverboard";
                }
                else
                {
                    vehicleFortune = "SUV";
                }
                return vehicleFortune;
            }*/
            //FavoriteFood("Mike" , "steak");
            //RetirementCalculator(48);
            /*double hoursWorked = 42.3d;
            double hourlyWage = 12.50d;

            Console.WriteLine( "Your monthly wage is {0}" ,WageCalculator(hoursWorked, hourlyWage));
            */
            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();
            //fullName(firstName, lastName);


            //Console.WriteLine("Your current balance is: {0}", BankAccount(120000, 119000, 35));


            //Create a method called FavoriteFood
            //It should take 2 string parameters.  One representing a name,
            //and the other representing a favorite food

            //the return type should be void
            //the method should concatenate.
            /*public static void FavoriteFood(string name, string foodName)
            {
                Console.WriteLine(name + " " + foodName);
            }*/
            //Create a method called RetirementCalculator
            //It should take an int as a parameter representing the user's age
            //The method should calculate how many more years until the user 
            //retires using 65 as the age of retirement.
            //the return type should be void.
            //Once it calculates the user's retirement age, it should print
            //"The user will retire in X years" where X represents the value that 
            //was calculated
            /*public static void RetirementCalculator(int userAge)
            {
                int retirementAge = 65 - userAge;
                Console.WriteLine("The user will retire in {0} years", retirementAge);
            }        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
            {
                double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
                return monthlyWage;
            }*/
            /*public static double BankAccount(double amount, double bills ,double lateCharge)
            {
                double totalAmount = amount - bills - lateCharge;
                return totalAmount;
            }
            public static void fullName(string firstName, string lastName)
            {
                Console.WriteLine("Customer's full name is: {0} {1}", firstName, lastName);
            }*/
            //public static void SayHello(string firstName, string lastName)
            //{            
            //    Console.WriteLine("Hello " + firstName + lastName);
            //}
            //public static void SayGoodbye(string firstName, string lastName)
            //{
            //    Console.WriteLine("Goodbye " + firstName + lastName);
            //}


            //problem 3 homework  
            //sayHello("John");

            //problem 4 homework   sum of an array
            /*int[] numberInArray = { 4, 5, 10, 12, 23 };
            Sum(numberInArray);*/

            //problem 5 homework    double an int
            /*Console.WriteLine("Please enter a number to see what it is doubled.");
            int numberToDouble = int.Parse(Console.ReadLine());

            Console.WriteLine("Your number doubled is " + DoubleIt(numberToDouble));*/

            //problem 6 homework    sum of all digits in an int
            /*            int num;
            Console.WriteLine("Please enter a number greater than 10.");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigits(num));*/

            //problem 7 homework  find array.Max   
            int[] data = { 87, 90, 23 };
            Console.WriteLine(FindMaximum(data));

        }

        //problem 7 homework
        public static int FindMaximum(int[] data)
        {
            int max = data.Max();
            return max;
        }


        //problem 6 homework
        /*public static int SumDigits(int num)
        {
            int sum = 0;
            
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }*/

        //problem 5 homework
        /*public static int DoubleIt(int numberToDouble)
        {            
            int doubleIt = numberToDouble * 2;
            return doubleIt;
        }*/

        //problem 4 homework    
        /*static public void Sum(int[]myarray)
        {
            int sum = 0;
            for(int i = 0; i < myarray.Length; i++)
            {
                sum += myarray[i];
            }
            Console.WriteLine(sum);
        }*/

        //problem 3 homework
        /*static public void sayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }*/
    }
}
