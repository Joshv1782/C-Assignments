

2 of 6
Source files
Inbox
x

Aaron Champagne<achampag@ualberta.ca>
Attachments
Feb 12, 2020, 12:42 PM (1 day ago)
to me

Here you go
21 Attachments
Thanks!Got them, thanks!Awesome, thanks!

using System;
using System.Collections.Generic;
using System.Text;

/**
* For this assignment I want to go over some core concepts of methods through practice.
* 
* Please do all of this without modifying the main method.
* 
* 1: Firstly I want you to write a brand new method named "parseOutFirstValues()" that will loop over
* all items in a List<string> passed into your method and print them to the display. 
* (Follow the outline in the main method of how I am passing it in.).
* This method should then create a brand new List<string> that it will return that
* ONLY has the values BEFORE the ',' character in EACH of the entries of the list.
* (There are c# methods to do this, but I encourage you to manually loop over the values
* and use a stringbuilder to handle this. )
* 
* Stringbuilder reference:
* https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=netframework-4.8
*
* 2: Next up I want another method named parseOutOnlyBLetterItems() to be written that will take the returned list
* (I am invoking and passing the returned list and handling this in the main method) and
* it will then invoke console.writeline only on each item that starts with the letter 'b'.
* These items should also then be removed from that list for good.
* 
* 3: After that I want you to then take this list with all of the items with 
* the letter B and for you to print them to the terminal with ~ to the left and ~ to the right
* of each item. (Let's not forget Console.WriteLine IS a method in and of itself!)
* Do this third and final step in a new method that you create
* called prettyPrint()

* EXPECTED OUTPUT
item1, $500
blueberries, $900
apple pie, $4
bees, idk
peaches, $93
wood, $1
bongos, $43
blueberries
bees
bongos
~~~~~~~~~~~~~~~~~~~~~~~~~
~blueberries~
~bees~
~bongos~
* */

class MainClass
{
    public static void Main(string[] args)
    {
        var listOfItems = new List<string> {
    "item1, $500",
    "blueberries, $900",
    "apple pie, $4",
    "bees, idk",
    "peaches, $93",
    "wood, $1",
    "bongos, $43"
    };

        var parsedList = parseOutFirstValues(listOfItems);
        var bItemsOnly = parseOutOnlyBLetterItems(parsedList);
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
        prettyPrint(bItemsOnly);
    }

}