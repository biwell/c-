using System;


namespace loops // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            loops allow us to repeat code depending on the situation
            2 type of loops 
            for loop = repeat code for a certain number of time (iterations) 

            for (int i = 0; i < 10; i++)
            {

            }

            while loop = repeat code until condition is met 
            */

            //examples of a for loop that writes number 1 to 10
            /*
           for (int i = 0; i < 10; i++)
           {
               Console.WriteLine(i+1);
           }
           for (int i = 1; i <= 10; i++)
           {
               Console.WriteLine(i);
           }
           */

           //example of a for loop that decriments 10 to 1 instead of increment
           /*
           for (int i = 10; i > 0; i--)
           {
               Console.WriteLine(i);
           }
           */

           
           /*Console.Write("how many print should be done?");
           int count = Convert.ToInt32(Console.ReadLine());

           for (int i = 1;  i <= count;  i++)
           {
               double result = Math.Pow(2,i);
               Console.WriteLine(result);
           }


            //dice roll how many roll for a 6
            Random numberGen = new Random();

            int roll = 0;
            int attempt = 0;

            Console.WriteLine("Press enter to roll the die");

           while (roll != 6)
           {
                Console.ReadKey();
                roll = numberGen.Next(1,7);
                Console.WriteLine("you rolled " + roll);
                attempt++;
           }

           Console.WriteLine("it took " + attempt + " attempts to roll a 6");
           */

           //weekly challenge : roll 2 dice and say how many attemps needed to roll a double
            Random numberGen = new Random();
            int roll1 = 0, roll2 = 1;
            
            int attempt = 0;
            

            Console.WriteLine("Press enter to roll the dice");

            while (roll1 != roll2)
            {
                attempt ++;
                Console.ReadKey();
                roll1 = numberGen.Next(1,7);
                roll2 = numberGen.Next(1,7);
                Console.WriteLine("dice 1: " + roll1);
                Console.WriteLine("dice 2: " + roll2);
                Console.WriteLine("attempt #" + attempt);

                
                 
            }
            Console.WriteLine("it took " + attempt + " attempts to roll a double");


           Console.ReadKey();
        }
    }
}