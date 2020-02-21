using System;
using System.Linq;
using System.Collections.Generic;

/*
* This one is going to be a bit more tricky.
*
*  I give you an Array of values similar to the previous challenge
*
* Firstly: Split this array into two separate lists. One is for even numbers, the other for odd numbers.
* 
* Secondly: For the even numbers list, subtract 7 from each number.
* 
* Thirdly: For the odd numbers list, add 10 to each number above 15.
* 
* Fourthly: For the odd numbers list, subtract 5 from each number below 40.
* 
* Fifthly: For the even numbers list, REMOVE any numbers between 20 and 30.
* 
* Sixthly: Combine the odd and even list together into one single list.
* 
* Seventhly: Loop over the list until it is empty, putting the highest value into a brand new list.
* 
* Eighthly: Print out the 7th to 10th value in the new list from step 7. [!!! Beware indexes start at 0!]
*
*
* EXPECTED OUTPUT:
* 97
* 95
* 93
* 91
*/
class MainClass
{
    public static void Main(string[] args)
    {
        int[] array = Enumerable.Range(0, 100).ToArray();
    }

    // Much like the prevous assignment, I am completely lost. 