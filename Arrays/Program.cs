using System;
using System.Collections.Generic;//needed to use lists


namespace arrays // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            lists no fixed size (resizable) use a different namespace (using System.Collections.Generic)
            arrays store multiple values in the same variable (fixed sized)
            */

            /*
            string[] favourites = //creating a table of items winth each item having a number associated(index)
            {
                "quinn",//index 0
                "Viego",//index 1
                "udyr",//index 2
                "volibear"//index 3
            };
            Console.WriteLine(favourites[2]); //print the 3rd item on the list

            //use arrays with loops
            for (int i = 0; i < favourites.Length; i++)//will print all 4 of my favorite character 
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + favourites[i] );

            }

            //create an empty array that user can fill with input
            string[] movies = new string[4];
            Console.WriteLine("type in four movies");

            movies[0] = Console.ReadLine();
            movies[1] = Console.ReadLine();
            movies[2] = Console.ReadLine();
            movies[3] = Console.ReadLine();

            //or we can make a loop to enter the movies
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

        
            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            //create my first list
            List<string> shoppingList = new List<string>();
            
            // add items to the list
            shoppingList.Add("Dreams");
            shoppingList.Add("miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("pony");

            //print the list
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            
            //remove from the list
            shoppingList.Remove("Dreams");

            //remove index
            shoppingList.RemoveAt(1);
            */
            
            //challenge :let teacher add every student of a class and print them alphabetically
            Console.WriteLine("How many sudents do you have?");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[length];

            Console.WriteLine("entrez leurs noms");

            for (int i = 0; i < students.Length; i++)
            {
               students[i] = Console.ReadLine(); 
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("les voici en ordre alphabetique");
            Array.Sort(students);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }



            //enter to finish
            Console.ReadKey();
        }
    }
}