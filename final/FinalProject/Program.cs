using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine();

        while (true){

            if(Game.GetLevel() == 11){
                break;
            }
            
            Console.WriteLine($"You are at level {Game.GetLevel()}.");
            Console.WriteLine($"You have {Player.GetPoints()} points.");
            Console.WriteLine($"You have {Player.GetHealth()} health.");
            Console.WriteLine($"You have {Player.GetStrength()} strength.");
            Console.WriteLine();

            Console.WriteLine("You can do the following options: ");
            Console.WriteLine("1: Play");
            Console.WriteLine("2: Save Game");
            Console.WriteLine("3: Load Previous Game");
            Console.WriteLine("4: Quit");
            Console.Write("Choose one of the options: ");
            string inputString = Console.ReadLine();

            Console.Clear();

            if (inputString == "1"){
                Level level = new Level("Default", 0, 0, 0);
                level.RandomizeLevel();
                Game.IncreaseLevel();
            }

            if (inputString == "2"){
                Game.Save();
            }

            if (inputString == "3"){
                Game.Load();
            }

            if (inputString == "4"){
                Environment.Exit(0);
            }else{
                while(inputString != "1" && inputString != "2" && inputString != "3" && inputString != "4"){
                    Console.WriteLine("Unknown Input");
                    Console.Write("Press 1 key to try again: ");
                    inputString = Console.ReadLine();
                    Console.WriteLine();
                }
            }

        }

        Console.WriteLine($"You survived with {Player.GetPoints()} points.");


    }
}