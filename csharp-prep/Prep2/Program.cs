using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage:");
        string percentage = Console.ReadLine();

        int grade = int.Parse(percentage);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}.");
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the class.");
        }
        //Stretch Challenge 1 Add a "+" or "-". 
        string sign = "";
        int lastDigit = grade * 10;

        if (lastDigit>= 7)
        {
            sign = "+";
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }   
        else if (lastDigit<= 3)
        {
            sign = "-"; //The value in this variable is not updating.
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }        
        else
        {
            sign = "";
        } 
        //Stretch Challenge 2&3 no A+ or F+ and F-  This isn't working right either but don't have time to mess with it yet.
        if (grade >=93)
        {
            sign = "";
        }  
        if (letter == "F")
        {
            sign = "";
        }
  
    }
}