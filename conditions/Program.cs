using System;


namespace conditions // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
             /*if statement: check for condition and do different code depending if it is true or false 
             == means is equal to
             != means is not equal to
             > greater than <less than
             >= greater or equal to <= less than or equal to
             */

             /* cinema ticket example
             Console.WriteLine("welcome tickets are 5$ please insert cash!");
             int cash = Convert.ToInt32(Console.ReadLine());


             if (cash < 5) 
             {
                 Console.WriteLine("that's not enough money");
             }

             else if (cash == 5)
             {
                 Console.WriteLine("here is your ticket");
             }

             else
             {
                 int change = cash - 5;
                 Console.WriteLine("Here is your ticket and " + change + " dollars in change");
             }
             */

             /*amusement park
             int age, height;
             Console.Write("please input age: ");
             age = Convert.ToInt32(Console.ReadLine());

             Console.Write("please input height (cm): ");
             height = Convert.ToInt32(Console.ReadLine());

             if(age >= 18 && height >=160) {

                Console.WriteLine("you can enter!");
             }
             else{
                 Console.WriteLine("you dont meet the requirements.");
             }
             */

             /*
             switch statement 
             switch (num) {
                case 1:
                  Console.WriteLine("One");
                  break;
                case 2:
                  Console.WriteLine("two");
                  break;
                case 3:
                  Console.WriteLine("three");
                  break;
                case 4:
                  Console.WriteLine("four");
                  break;
                case 5:
                  Console.WriteLine("five");
                  break;
                default:
                    Console.WriteLine("default");
                    break;
             }
             */

             //challenge create a game where solve math problem
                int answer;
                int point = 0;
                Console.WriteLine("answer these equations");


                //1st operation
                Console.WriteLine("2 x 5 x 8 = ");
                answer = Convert.ToInt32(Console.ReadLine());
                if(answer == 2 * 5 * 8){
                    Console.WriteLine("correct, point up");
                    point = point + 1;
                }
                else{
                    Console.WriteLine("incorrect, no point");
                }
                Console.WriteLine("your score is " + point + " points");

                //2nd operation
                Console.WriteLine("(6 x 8) + 23");
                answer = Convert.ToInt32(Console.ReadLine());
                if(answer == (6*8)+23){
                    Console.WriteLine("correct, point up");
                    point = point + 1;
                }
                else{
                    Console.WriteLine("incorrect, no point");
                }
                Console.WriteLine("your score is " + point + " points");

                //last operation
                 Console.WriteLine("(20 + 10) / 3 ");
                answer = Convert.ToInt32(Console.ReadLine());
                int good = (20+10)/3;
                if(answer == good) {
                    Console.WriteLine("correct, point up");
                    point = point + 1;
                }
                else{
                    Console.WriteLine("incorrect, no point");
                }
                Console.WriteLine("your score is " + point + " points");

             //wait before closing
             Console.ReadKey();
        
        }
    }
}    