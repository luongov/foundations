// Write a program that allows the user to enter the number of factorials to display
using System;

class ShowFactorials
{
    static void Main()
    {

        Console.WriteLine("Hello. Please enter a number bigger than 0 and I tell you the factorials: ");
        string userstring = Console.ReadLine();
        ulong usernumber= ulong.Parse(userstring);  // number entered by the user
        ulong fct = 1;            // factorial initialized for 1!
        ulong x;                  // counter

        Console.WriteLine(" factorial 1! is 1");  //factorial 1! hardcoded as an exception

        for (x = 2; x <= usernumber; x++)    // from 2 to usernumber, calculate factorial, print, and add 1
        {
            fct = fct * x;
            Console.WriteLine(" factorial {0}! is {1}", x, fct);
        }
        
        Console.ReadLine();
   }
}

