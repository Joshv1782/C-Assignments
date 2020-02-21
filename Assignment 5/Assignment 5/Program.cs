using System;

/**
* Without modifying anything other than the lines specified:
* make it so that this program when ran will print out the desired output
*
*
*
*
* EXPECTED OUTPUT
* good
* good
* good
* good
* :)
*
*/

class MainClass
{
    public static void Main(string[] args)
    {
        bool a = true;
        bool b = false;

        int int_1 = 1;
        int int_2 = 2;

        string string_1 = "hello";
        string string_2 = "goodbye :)";


        if (string_1 == string_2)
        { //Modify this line's conditional to enter this conditional.
            Console.WriteLine("good"); // Used https://www.w3schools.com/cs/cs_conditions.asp

            if (!a)
            { //Modify this line's conditional to go to the else statement.
                Console.WriteLine(":(");

            }
            else
            {
                Console.WriteLine("good");

                //Modify this if-then-else-if-else block to enter the 2nd else if statement.
                if (!a)
                {
                    Console.WriteLine(":(");

                }
                else if (true)
                {
                    Console.WriteLine(":(");

                }
                else if (string_2 == string_1)
                {
                    Console.WriteLine("good");

                    //Modify this block so that it goes to the final else statement
                    if (false)
                    {
                        Console.WriteLine(":(");

                    }
                    else if (true)
                    {
                        Console.WriteLine(":(");

                    }
                    else if (!true)
                    {
                        Console.WriteLine(":(");
                    }
                    else if (true)
                    {
                        Console.WriteLine(":(");
                    }
                    else
                    {
                        Console.WriteLine("good");
                    }
                }
                else
                {
                    Console.WriteLine(":(");
                }

            }
        }

        Console.WriteLine(":(");

    }
}