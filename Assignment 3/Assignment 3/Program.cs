using System;

/**
* The purpose of this exercise is to familiarize you with the various operators and how
* they can interact with variables. 
*
* While not modifying the value of the variables, attempt to combine the variables together
* in order to obtain the following output:
*
* 
* String Value: I used string contatenation to put two string values together into one string!
* Integer Value 1: 42
* Integer Value 2: 5
* Double Value 1: 21.6
* Double Value 2: 102.01
*
*/
class MainClass
{
    public static void Main(string[] args)
    {
        //Using only these values combine them below to get the expected output...
        int int_1 = 3;
        int int_2 = 14;
        double double_1 = 10.0;
        double double_2 = 7.2;

        string string_1 = "I used string contatenation";
        string string_2 = "into one string!";
        string string_3 = "to put two string values together";


        //Modify these variables here. This will change the output.
        string output_string = "string_1" + "string_2" + "string_3";
        int output_integer_1 = int_1 * int_2;
        int output_integer_2 = int_2 - int_1 - int_1 - int_1; // This is where I hit a wall. Am I on the right track?
        double output_double_1 = double_2 * int_1; // After reviewing the solutions I know see that it was my poor math that was the problem -_-
        double output_double_2 = double_1 * double_1;

        //Please do not modify these statements!
        Console.WriteLine(output_string);
        Console.WriteLine("Integer Value 1: {0}", output_integer_1);
        Console.WriteLine("Integer Value 2: {0}", output_integer_1);
        Console.WriteLine("Double Value 1: {0}", output_double_1);
        Console.WriteLine("Double Value 2: {0}", output_double_2);
    }
}