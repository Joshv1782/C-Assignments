using System;

/**
* So now with that said and done lets start by having you write some methods!
*
* Do NOT touch the main method in this instance!
* 
* In this file you're given FOUR different methods to implement with the following
* guidelines. These will be invoked in the main method and their result will be printed out
* into the display by pre-written code!
*
* 1: add(int x, int y) <- takes 2 integers as parameters to the method.
*   This method will add them together and return the result. eg: var z = x + y. eg: return x + y.
*
* 2: subtract(int x, int y) <- takes 2 integers as parameters, subtracts the second from the first.
*   Eg: return x - y. 
*
* 3: multiply(int x. int y) <- takes 2 integers as parameters, multiples them together
*   eg: return x * y
*
* 4: isBothTrue(bool x, bool y) <- takes 2 booleans in as parameters, will return 
*       if they are BOTH true. Eg: x and y are both true. If one is false or both false, return false.
*   !!!Remeber boolean operators? NOT is ! AND is && OR is ||      :)
*
*
* Also while this may seem montonous, this actually introduces a very core concept we will
* touch in more detail later of "test driven development". Or, in more clear terms: developing
* methods against already-existing code that tests if the method behaves as expected :)
* 
* But we will talk about that more later, just for now trying to instill that idea in your mind
* that this is more relevant than me trying to be annoying! :)
*
* EXPECTED OUTPUT:
* true
* true
* true
* true
*
* */

class MainClass
{
    public static void Main(string[] args)
    {
        var firstStep = add(1, 1);
        Console.WriteLine(firstStep == 2); //Expect true.

        var secondStep = subtract(firstStep, 90001);
        Console.WriteLine(secondStep == -89999); //Expect true.

        var thirdStep = multiply(secondStep, -1);
        Console.WriteLine(thirdStep == 89999); //Expect true.

        var fourthStep = isBothTrue(!(secondStep == 8999), !(thirdStep == 8999));
        Console.WriteLine(fourthStep);

    }


    public static int add(int x, int y)
    {
        return x + y;
    }

    public static int subtract(int x, int y)
    {
        return x - y;
    }

    public static int multiply(int x, int y)
    {
        return x * y;
    }

    public static bool isBothTrue(bool x, bool y)
    {
        return x && y;
    }
}
// I don't fully understand how to do this one. I would need more time to figure this one out and most likely some aid.