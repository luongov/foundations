//Homework 3: Write a program that takes seconds and converts it into days, hours, minutes, and seconds.By Veronica Luongo

using System;

class DaysHoursMinutes
{
    static void Main()
    {

        Console.WriteLine("Hello. Please enter a number of seconds and we will convert them into days, hours, minutes, and seconds");
        string Stringseconds = Console.ReadLine();
        int seconds = int.Parse(Stringseconds);
        int num_days = 0;
        int num_hours = 0;
        int num_minutes= 0;
        int num_seconds = 0;
        int divider = 0;

        if (seconds >= (divider = 86400)) // 86400 is number of seconds per day
        {
            num_days = (seconds / divider);
            seconds = seconds % divider;
        }
        if (seconds >= (divider = 3600)) //3600 seconds per hour
        {
            num_hours = (seconds / divider);
            seconds = seconds % divider;
        }
        if (seconds >= (divider = 60)) //60 seconds per minute
        {
            num_minutes = (seconds / divider); 
            seconds = seconds % divider;
        }
        num_seconds = seconds;


        Console.WriteLine("The number of days is {0}", num_days);
        Console.WriteLine("The number of hours is {0}", num_hours);
        Console.WriteLine("The number of minutes is {0}", num_minutes);
        Console.WriteLine("The number of seconds is {0}", num_seconds);
        Console.ReadLine();
    }
}