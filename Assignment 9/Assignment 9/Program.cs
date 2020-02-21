/**
* Let's take this concept a bit further with methods.
* Methods can be used to not only get data but also modify data.
* This is a fundamental concept that is a very common industry standard
* known as using "getters/setters". 
* 
* A full discussion of why we use these "getters/setters" is far outside of the scope 
* of the current introduction. But I can promise you that you'll see a ton
* of it in industry code and in this course.
*
* So you'll notice this file is structured where we have
* a single String variable called 'UserName' located outside of this method.
* Due to C#'s scoping, this means that this is accessible by both methods.
* At present it has the bogus value of "NOTANAME".
* 
* Next up you have the main method, this is where you will modify the code
* and submit the exercise. 
* After that you have two methods, one is 'getUserName' and the other
* is called 'setUserName'.
* 
* These methods are how you will GET the username into the main method,
* and these methods are how you will SET the username into the main method.
* 
* "Why not just access the username variable? That seems easier." 
* We will get into that later as that involves a discussion about 
* Object Orriented Programming and more specifically encapsulation. 
* But for now it's a gentle introduction to the idea.
* 
* So taking these methods:
* 1: Set the UserName variable to "John Doe" by invoking the method setUsername("John Doe"); 
* 
* 2: Now access the UserName variable by setting the variable to the result 
* of the method "getUsername()". eg: var userNameForExample = getUsername();
* 
* 3: Console.WriteLine this userNameForExample to display the value.
*
* EXPECTED OUTPUT: 
* John Doe
*
* */

class MainClass
{
    static string UserName = "NOTANAME";

    public static void Main(string[] args)
    {
        setUserName("John Doe");
        var userNameValue = getUserName();
        Console.WriteLine(userNameValue);
    }
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
    public static string getUserName()
    {
        return UserName;
    }

    public static void setUserName(string username)
    {
        UserName = username; //Remember these are different because of capitalization!
    }
}