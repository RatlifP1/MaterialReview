using System;
using System.Threading;

namespace Startingover
{
    enum DayOfTheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    class Program
    {
        static void Main(string[] args)
        {
            //Bindings
            //Appply a name to a value
            double unassigned; //Create an unassigned binding called "unassigned"
            int i = 7; //explicit i is a value bound initially to the value 7. Type language. 
            //var can be used as a type and the system will determine what kind of type of data the var will be based on how you use it.
            var x = 8; //implecet type initializing
            unassigned = 42.0; //Bindings can be assigned after being declared
            i = 42; // Variable bindings can be reassigned


            var @is = 7; //is and as are keywords to C#. 
            var @as = 9; //you can use the @ to make them a data value name if needed



            const string cs = "Hello World!"; // const binding is not variable

            Console.WriteLine(cs);

            //this isn't allowed. Consts can't be on the left side of an assignment equals sign
            //cs = "Goodbye, it's the end of the class";
            Console.WriteLine(unassigned); //ctrl shift space to see what other ways to evoke
            Console.WriteLine("print out x: ", +x);

            //Everything in C# is an object
            //Every object cane be covereted to a string using the .ToString() method
            string iAsAString = i.ToString();

            //Most types can be convereted from a string

            i = int.Parse(iAsAString);



            //i starts as 7
            int j = i++; //j = 42, i = 43post increment will run after the satement has completed then 1 added
            int k = ++i; //k = 44, i =44 pre incremenent 

            Console.WriteLine($"print out x: {i} + {j} + {k}");




            //Conditional statements,
            //a fundemental part of structured proframming
            //bool proposition = true; //proposition can either be true or false but can't be true and false or false and ture at the same time
            //if (!proposition) //==true
            //{
            //    Console.WriteLine(true);

            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            DayOfTheWeek today = DayOfTheWeek.Monday;
            //Enums can hold an invaild value, so always check in the default case
            //today = (DayOfTheWeek)17;
            switch (today)
            {
                case DayOfTheWeek.Monday:
                    Console.WriteLine("Happy Monday");
                    break;
                case DayOfTheWeek.Tuesday:
                    Console.WriteLine("It is Tuesday");
                    break;
                case DayOfTheWeek.Wednesday:
                    Console.WriteLine("Hm day");
                    break;
                case DayOfTheWeek.Thursday:
                    Console.WriteLine("Thursday");
                    break;


                case DayOfTheWeek.Friday:
                    Console.WriteLine("TGIF");

                    break;
                case DayOfTheWeek.Saturday:
                    Console.WriteLine("Sat");

                    break;
                case DayOfTheWeek.Sunday:
                    Console.WriteLine("Sunday Funday");

                    break;
                default:
                    Console.WriteLine("Stop cheating cheater");
                    break;
            }


            //Unconditional jumps
            //using GoTOs are not good to use
            goto A_PLACE_TO_JUMP;

            Console.WriteLine("This line never runs");

        A_PLACE_TO_JUMP:

            Console.WriteLine("We jumped here");
            {
                //conditional jumps ---> loops
                int counter = 0;
            //i want to count from 1 to 5
            //Printing to the console every time
            LOOP:
                //act
                Console.WriteLine(counter + 1);

                //Update
                counter += 1;
                //Conditional jump
                if (counter < 5) goto LOOP;
                Console.WriteLine("Done!");

            }
            {
                //Now, with a do-while loop
                int counter = 0;
                //i want to count from 1 to 5
                //Printing to the console every time
                do
                {
                    //act
                    Console.WriteLine(counter + 1);

                    //Update
                    counter += 1;
                    //Conditional jump
                } while (counter < 5) ;
                    Console.WriteLine("Done!");

               
            }
            //Now, let's do that with a for loop
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine(counter + 1);
            }
            Console.WriteLine("Done!");
            //Now, doing it with a while loop
            {
                int counter = 0;
                while (counter < 5)
                {
                    Console.WriteLine(++counter);
                }
                Console.WriteLine("Done!");
            }
        }
    }
}
