using System;

class Program
{
    private static Journal journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this journal program!");
        bool cont = false;
        while (cont == false){
            DisplayMenu();
        
        }
    }


    static void DisplayMenu(){
        
        Console.WriteLine("Here are your options.");
        Console.WriteLine("1: Write \n2: Display \n3: Save \n4: Load \n5: Quit");
        Console.Write("Enter the number of what option you want. ");

        string inputString = Console.ReadLine();
        int inputNum = int.Parse(inputString);
        
        if (inputNum == 1){
            Entry entry = new Entry();

            entry._prompt = entry.GetPrompt();
            entry._inputString = entry.GetInput();
            entry._date = entry.GetDate();
            entry._quality = entry.getQual();
            
            journal.AddQuality(entry._quality);
            journal.AddEntry(entry);
               
        }

        else if (inputNum == 2){
            journal.DisplayJournal();
        }

        else if (inputNum == 3){
            journal.WriteJournal();
        }

        else if (inputNum == 4){
            journal.ReadJournal();
        }

        else if (inputNum == 5){
            Environment.Exit(0);
        }
    }


   
    
}