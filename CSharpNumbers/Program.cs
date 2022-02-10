using System; 

namespace CSharpNumbers
{
    public static class Program 
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 % 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 - 8 + 4 * 4);
            Console.WriteLine(5 - (8 + 4) * 4); //PEMDAS
            Console.WriteLine(5 + 8.1); //you will get an integer value back.

            //we can store number inside a variable
            int num = 6;
            num++;
            num--;
            Console.WriteLine( num );


            //math methods
            //basic math operation methods
            //when you do Math. it should show all these different methods we can do. 
            //any major math operations you want to do this Math. will help you.
            Console.WriteLine(Math.Abs(-40));// shpw 40
            Console.WriteLine(Math.Pow(3, 2)); //show 9, 3 to the power of 2
            Console.WriteLine(Math.Pow(3, 2)); //show 9 
            Console.WriteLine(Math.Sqrt(36)); //show 6
            Console.WriteLine(Math.Max(4, 90)); //show which number is the biggest
            Console.WriteLine(Math.Min(4, 90)); //show which number is the lowest
            Console.WriteLine(Math.Round(4.3)); //this will round the number



            Console.ReadLine();




        }



    }

}

/*
 Topic: What is number?

//different math operations. we can use exponents and square roots and would be able to do inside our program which is called methods.
we can call a method and perform a specific functions.
//extremely important and how they interact with each other.


 */