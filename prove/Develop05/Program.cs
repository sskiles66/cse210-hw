using System;

class Program
{
    
    private static Game game = new Game();

    
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Eternal Quest");
        
        while(true){

            int points = game.GetTotalPoints();
            double level = game.GetLevel();

            Console.WriteLine();
            Console.WriteLine($"You are level {level}.");
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string inputString = Console.ReadLine();
            Console.WriteLine();

            if (inputString == "1"){
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternity Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Select a choice from the menu: ");
                string inputString2 = Console.ReadLine();
                Console.Clear();

                if (inputString2 == "1"){
                    Console.Clear();
                    SimpleGoal simGoal = new SimpleGoal("Simple");
                    simGoal.CreateGoal();
                    game.Add(simGoal);
                }

                if (inputString2 == "2"){
                    Console.Clear();
                    EternalGoal eterGoal = new EternalGoal("Eternity");
                    eterGoal.CreateGoal();
                    game.Add(eterGoal);
                }

                if (inputString2 == "3"){
                    Console.Clear();
                    ChecklistGoal checkGoal = new ChecklistGoal("Checklist");
                    checkGoal.CreateGoal();
                    game.Add(checkGoal);
                }

                
                }
            if (inputString == "2"){
                Console.Clear();
                int i = 1;
                    foreach (Goal goal in game.GetGoals()){
                        Console.Write($"{i}:");
                        goal.Display();
                        i = i + 1;
                }
            }
            if (inputString == "3"){
                
                game.SaveGoals();
            }

            if (inputString == "4"){
                
                game.LoadGoals();
            }
            if (inputString == "5"){
                
                int i = 1;
                    foreach (Goal goal in game.GetGoals()){
                        Console.Write($"{i}:");
                        goal.Display();
                        i = i + 1;
                }

                Console.WriteLine();
                Console.Write("What goal did you complete: ");
                inputString = Console.ReadLine();
                int result = Int32.Parse(inputString);
                Goal newGoal = game.GetGoals()[result - 1];
                newGoal.RecordEvent();
                int goalPoints = newGoal.GetPoints(); 
                game.AddPoints(goalPoints);
                
            }
            if (inputString == "6"){
                Environment.Exit(0);
            }
        }
    }
}