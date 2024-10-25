using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("give a grade 0-100");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 100)
        {
            Console.WriteLine("A+");
            Console.WriteLine("Wow! 100... That's impressive!");

        }
        else if (grade >= 90)
        {
            Console.WriteLine("A");
            Console.WriteLine("Very nice!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
            Console.WriteLine("Keep it up!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
            Console.WriteLine("You got this, keep working!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
            Console.WriteLine("Keep trying!");
        }
        else if (grade < 50)
        {
            Console.WriteLine("E");
            Console.WriteLine("Don't give up!");


        }
    }

}
