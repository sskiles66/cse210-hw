using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNum();
        int squared = SquareNum(num);
        DisplayResult(squared, name);

        
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");

    }

    static string PromptUserName(){
        Console.Write("What is your name?");
        return Console.ReadLine();
    }

    static int PromptUserNum(){
        Console.Write("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNum(int num){
        return num * num;
    }

   static void DisplayResult(int num, string name){
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}