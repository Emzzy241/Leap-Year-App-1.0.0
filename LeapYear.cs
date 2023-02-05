// LET's build an Application still with forloop that will help us determine the leap years, our users
// have experienced ever since the year they were born.... Come along and have Fun :)

using System;
using System.Collections.Generic;

class LeapYear
{
    static void Main()
    {

        // Let's write the code now

        // first, we take in the Year our user was born
        Console.WriteLine("Dear User, Please input your Age: ");

        // picking up me user's age: first(using a Console.ReadLine() method that works only on strings, and storing it in a string variable)
        string usersBirthInStringFormat = Console.ReadLine();

        // converting that user's birth Year that is in a string format into an integer format

        int myUserBirthYear = int.Parse(usersBirthInStringFormat);

        // NOW C# understands that we're working with an integer now, we can use integer operations on it

        // first, inputting a message to me lovely user
        Console.WriteLine("You were alive during these leap years: ");

        // now running our powerful forloop
        // this forloop purpose is to keep increasing the year, if the year is less than or equal to 2023(the year we are in :)  
        // we tell the loop to stop running when year <= 2023 is no longer true i.e we do not want to exceed the year we are in
        // and finally, we tell the loop to add 1 to our year for every iteration of the loop

        for (int year = myUserBirthYear; year <= 2023; year++)
        {
            // running a branch that determines if any of the Years my user has lived had a leapyear
            // FOR EACH iteration of the loop, we run this code:
            if (year % 4 == 0)
            {
                Console.WriteLine(year);
                // for every year that is divisible by 4, the modulo(remainder) comes out to be 0, which makes 
                // year % 4 == 0 evaluate to true.... Every year, divisible by 4 is a leap year... so wer print Console.WriteLine(year);
                // ALTHOUGH THERE ARE SOME EXCEPTIONS TO THIS RULE--- Later on, we will do another exercise later to deal with all the complexities of the leap years

            }
        }

        // GOING THROUGH WHAT WE DID WITH OUR forloop
        // we initialize the year variable, setting it to the user's birth year
        // we tell the loop to stop running when year <= 2023

    }
}