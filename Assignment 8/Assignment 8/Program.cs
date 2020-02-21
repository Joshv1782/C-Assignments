using System;
/**
* For this first task you are going to be introduced to the 
* basic usage of methods. From the main method please call
* the getUserStringData() method and store this value
* into a variable of type 'var'. Then pass this 'var'
* into the Console.WriteLine() statement already in the main method.
* Reference for 'var':
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var
* 
* C# features the ability to use the keyword 'var' to 
* assume the type of that variable based upon whatever
* the returning method is returning to the user. 
*
* This is one of the ways that the C# language minimizes so-called
* 'boilerplate' code-- or rather known as code that is 
* repeated over and over again redundantly.**
* 
* EXPECTED OUTPUT::
* This is the user string data...!
**/

class MainClass
{
    public static void Main(string[] args)
    {
        var userStringdata = getUserStringData();
        Console.WriteLine(userStringdata);
    }

    public static string getUserStringData()
    {
        return "This is the user string data...!";
    }
}