using System;

class Program
{
    static void Main(string[] args)
    {
        bool over = false;
        while (over == false){
            int count = 1;
            Random randNum = new Random();
            int number = randNum.Next(1, 101);
            //Console.WriteLine(number);
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessInt = Int16.Parse(guess);
            //Console.WriteLine(guess);
            while (number != guessInt){
                if (guessInt > number){
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess = Console.ReadLine();
                    guessInt = Int16.Parse(guess);
                    count++;
                }else if(guessInt < number){
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = Console.ReadLine();
                    guessInt = Int16.Parse(guess);
                    count++;
                }
            }
            Console.WriteLine("You got it!");
            Console.WriteLine($"It took {count} tries.");
            Console.Write("Would you like to play again? ");
            string ans = Console.ReadLine();
            if (ans == "yes"){
                over = false;
            }else{
                over = true;
            }
        }
    }
}