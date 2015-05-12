/*Problem 15.* Age after 10 Years

    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/
using System;

class Age
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday (yyyy, mm, dd)");
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        DateTime today = DateTime.Now;

        int age = today.Year - birthday.Year;

        if (today < birthday.AddYears(age)) age--;

        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old.", age + 10);

    }
}