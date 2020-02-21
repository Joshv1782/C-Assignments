using System;

/**
* The purpose of this assignment is to build a foundation of knowledge about working with boolean operators.
* In software, so-called "boolean logic" acts as a massive component of deciding what the program will do.
*
* This will combine knowledge of basic greater than (>) less than (<) and equals (==) operators alongside
* boolean operators AND (&&) OR (||) and NOT (!).
* 
* There will be a quick set of examples just to pin down some topics. 
* And because this section is a bit trickier to really make a task for since it's all true/false.
*/
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----------SIMPLE BOOLEANS----------");
        int int_1 = 1;
        int int_2 = 2;

        Console.WriteLine(int_1 > int_2); //This should print false. As 1 is "less than" 2.

        string string_1 = "I am string 1";
        string string_2 = "I am string 2";

        Console.WriteLine(string_1 == string_2); //This should also print as false. As these strings contain different values.

        //In this part let's combine these two statements together and assign them to variables.
        bool stringsComparison = string_1 == string_2; //We know this is FALSE from above. As string 1 is NOT EQUAL TO string 2.
        bool intComparison = int_1 > int_2; //We know this is FALSE from above.

        //Therefore if we ask are these equal? We get that being TRUE.
        Console.WriteLine(stringsComparison == intComparison);

        //But we have more operators for interacting with true or false statements. AND, OR and NOT statements.
        //If we add an "!" before stringsComparison, which was previously FALSE. We now have "flipped" the value to be TRUE.
        //So this statement should return as FALSE. As !stringsComparison is now "TRUE" and "TRUE" is not equal to false. 
        //So this entire statement is now false.
        Console.WriteLine("----------NOT OPERATIONS----------");
        Console.WriteLine(!stringsComparison == intComparison);

        //But if we add the ! operator and flip both, both are now TRUE. And true == true so this should return TRUE.
        Console.WriteLine(!stringsComparison == !intComparison);

        //Or if we want to keep it very simple, we can just flip the boolean value alone.
        Console.WriteLine(!stringsComparison);

        //Let's talk about the OR operator || if either of the statements to the right or left is true this will return TRUE.
        //If both of them are FALSE then it will return FALSE.
        Console.WriteLine("----------OR OPERATIONS----------");
        Console.WriteLine(!stringsComparison || !intComparison); //This will return "TRUE" as both statements are true.
        Console.WriteLine(stringsComparison || !intComparison); //This will return "TRUE" as !intComparison is == true.
        Console.WriteLine(stringsComparison || intComparison); //However this will return "FALSE" as both values are FALSE.

        //Now let's talk about the AND && operator. This will return true IF AND ONLY IF BOTH VALUES TO THE RIGHT AND LEFT ARE TRUE.
        Console.WriteLine("----------AND OPERATIONS----------");
        Console.WriteLine(!stringsComparison && !intComparison); //This will return "TRUE" as both statements are true.
        Console.WriteLine(stringsComparison && !intComparison); //This will return "FALSE" as stringsComparison is == false. 
                                                                //                                                      Regardless of intComparison being true.
        Console.WriteLine(stringsComparison && intComparison); //However this will return "FALSE" as both values are FALSE.

        //Lastly a note is that you can absolutely build operators ontop of one another based around operator precedence.
        //But generally beware operator precedence. 
        //[A good rule of thumb is use brackets if you aren't 100% sure. Brackets also make it easier to read imo.]
        //https://www.programiz.com/csharp-programming/operator-precedence-associativity
    }
}