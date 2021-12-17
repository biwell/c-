using System;


namespace variables // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            variables
            int = whole number
            float = decilmal number 7 digits
            double = decimal number 16 digits
            string = text
            bool = true or false
            syntax of variable goes:
            type name = value
            var for unknown variables
            */

            //example of string entered by the user 
            /*
            Console.WriteLine("what is your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + ", nice to meet you!");
            /*


            /* example of a program that would multiply 2 integer, problem is if you imput a decimal it crashes
            int num01;//declaring variable
            int num02;
            Console.WriteLine("input a number");
            //convert the input from string -> integer 
            num01 = Convert.ToInt32( Console.ReadLine());

            Console.Write("imput a second number");
            num02 = Convert.ToInt32(Console.ReadLine());
            //multiply the 2 imputed numbers 
            int result = num01 * num02;
            //show the result
            Console.WriteLine("the result is " + result );
            */

            /*same program but with decimals
            double num01;//declaring variable
            double num02;
            Console.WriteLine("input a number");
            //convert the input from string -> double 
            num01 = Convert.ToDouble( Console.ReadLine());

            Console.Write("imput a second number");
            num02 = Convert.ToDouble(Console.ReadLine());
            //multiply the 2 imputed numbers 
            double result = num01 * num02;
            //show the result
            Console.WriteLine("the result is " + result );
            */

            //goal:input 3 numbers and show the average 
            //declare variables
            double num01, num02, num03;


            //input variables
            Console.WriteLine("imput number 1");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("imput number 2");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("imput number 3");
            num03 = Convert.ToDouble(Console.ReadLine());


            //calculate the input in background
            double total = num01 + num02 + num03;
            double average = total / 3;


            //show the average 
            Console.WriteLine("The average of the number you chose is " + average);

            

            //end of program (pause b4 exit)
            Console.ReadKey();

        }
    }
}