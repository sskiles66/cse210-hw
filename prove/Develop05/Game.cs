using System;
using System.IO; 

class Game
{

    private int _totalPoints = 0;

    private List<Goal> _goals = new List<Goal>();
    
    public void SaveGoals(){
        Console.Write("What file do you want to save to?: ");
        string inputString = Console.ReadLine();
        string fileName = inputString;

        using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        outputFile.WriteLine(GetTotalPoints());

        foreach (Goal goal in _goals){
        
            Console.WriteLine();
            outputFile.WriteLine(goal.GetFormattedGoal());
            Console.WriteLine();

            }
        }

    }

    public void LoadGoals(){
        Console.Write("Name the file that you want to load: ");

        string _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);
    
        foreach (string line in lines)
        {

            string[] parts = line.Split("|||");

            if (parts.Count() == 1){
                int result = Int32.Parse(parts[0]);
                SetTotalPoints(result);

            }

            if (parts[0] == "Simple"){
                SimpleGoal simgoal = new SimpleGoal("Simple");
                simgoal.SetName(parts[1]); 
                simgoal.SetDescription(parts[2]); 
                int result = Int32.Parse(parts[3]);
                simgoal.SetPoints(result);
                bool myBool = bool.Parse(parts[4]);
                simgoal.SetIsDone(myBool);
                Add(simgoal);
            }
            if (parts[0] == "Eternity"){
                EternalGoal etergoal = new EternalGoal("Eternity");
                etergoal.SetName(parts[1]); 
                etergoal.SetDescription(parts[2]); 
                int result = Int32.Parse(parts[3]);
                etergoal.SetPoints(result);
                Add(etergoal);
            }

            if (parts[0] == "Checklist"){
                ChecklistGoal checkgoal = new ChecklistGoal("Checklist");
                checkgoal.SetName(parts[1]); 
                checkgoal.SetDescription(parts[2]); 
                int result = Int32.Parse(parts[3]);
                checkgoal.SetPoints(result);
                result = Int32.Parse(parts[4]);
                checkgoal.SetCurrentNum(result);
                result = Int32.Parse(parts[4]);
                checkgoal.SetCurrentNum(result);
                result = Int32.Parse(parts[5]);
                checkgoal.SetCompleteNum(result);
                result = Int32.Parse(parts[6]);
                checkgoal.SetBonus(result);
                Add(checkgoal);
            }
        }

    }

    public void AddPoints(int points){
        _totalPoints = _totalPoints + points;
    }

    public int GetTotalPoints(){
        return _totalPoints;
    }

    public void SetTotalPoints(int points){
        _totalPoints = points;
    }

    public void Add(Goal goal){
        _goals.Add(goal);
    }

    public List<Goal> GetGoals(){
        return _goals;
    }

    public double GetLevel(){
        double level = Math.Floor(_totalPoints / 100.0);
        return level;
    }
}