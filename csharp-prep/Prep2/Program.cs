using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageString = Console.ReadLine();
        int percentage = int.Parse(percentageString);
        Console.WriteLine(percentage);
        string letter = "";
        string sign = "";
        if (percentage >= 90){
            letter = "A";
        }
        else if (percentage >= 80){
            letter = "B";
        }
        else if (percentage >= 70){
            letter = "C";
        }
        else if (percentage >= 60){
            letter = "D";
        }else{
            letter = "F";
        }

        if (letter == "A" || letter == "B" || letter == "C"){
            Console.WriteLine("You passed!");
        }else{
            Console.WriteLine("Better luck next time.");
        }

        int find_sign = percentage % 10;

        if (find_sign >= 7 && letter != "A" && letter != "F"){
            sign = "+";
        }
        else if (find_sign < 3 && letter != "F"){
            sign = "-";
        }else{
            sign = "";
        }

        Console.WriteLine($"{letter}{sign}");
    }
}