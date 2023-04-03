using System;

class Level
{

    private string _description;

    private int _points;

    private int _min;

    private int _max;

    public Level(string description, int points, int min, int max){
        _description = description;
        _points = points;
        _min = min;
        _max = max;
    }

    
    public int GetPoints(){
        return _points;
    }


    public void RandomizeLevel(){

        var levels = new Dictionary<int, string>(){
	    {0, "Health Level"},
	    {1, "Low Risk Level"},
	    {2, "Medium Risk Level"},
        {3, "High Risk Level"},
        {4, "Strength Level"}
        };

        var random = new Random();

        int val = random.Next(5);
        int val2 = random.Next(5);

        while (val == val2){
            val2 = random.Next(5);
        }

        IDictionary<int, string> choices = new Dictionary<int, string>();

        choices.Add(1, levels[val]);
        choices.Add(2, levels[val2]);

        Console.WriteLine($"You have a choice between a {choices[1]} and a {choices[2]}.");

        foreach(var element in choices){
            Console.WriteLine($"{element.Key}: {element.Value}");
        }

        Console.Write("What is your choice?: ");
        string inputString = Console.ReadLine();
        int result = Int32.Parse(inputString);

        while (result != 1 && result != 2){
            Console.WriteLine("Unknown Input");
            Console.Write("What is your choice?: ");
            inputString = Console.ReadLine();
            result = Int32.Parse(inputString);
        }

        if (choices[result] == "Health Level"){
            HealthLevel healthLevel = new HealthLevel("For this level, you gain health but receive no points.", 0, 0, 0);
            healthLevel.Execute();
        }
        else if (choices[result] == "Low Risk Level"){
            LowRiskLevel lowLevel = new LowRiskLevel("For this level, you will have a low chance of taking damage but you will not receive many points.", 10, 6, 14);
            lowLevel.Execute();
        }
        else if (choices[result] == "Medium Risk Level"){
            MidRiskLevel mediumLevel = new MidRiskLevel("For this level, you will have a medium chance of taking damage and you will receive a decent amount of points.", 20, 8, 16);
            mediumLevel.Execute();
        }
        else if (choices[result] == "High Risk Level"){
            HighRiskLevel highLevel = new HighRiskLevel("For this level, you will have a high chance of taking damage but you will receive many points.", 30, 9, 18);
            highLevel.Execute();
        }
        else if (choices[result] == "Strength Level"){
            StrengthLevel strengthLevel = new StrengthLevel("For this level, there is a chance that you will gain strength but receive no points.", 0, 0, 0);
            strengthLevel.Execute();
        }
    }

    public void DisplayDescription(){
        Console.Clear();
        Console.WriteLine(_description);
    }

    public int RandomizeValue(int min, int max){
        var random = new Random();

        int val = random.Next(min, max);
        return val;
    }

    public virtual void Execute(){

    }

    public void CheckLife(){
        if (Player.GetHealth() <= 0){
            Console.WriteLine("You died.");
            Environment.Exit(0);

        }else{
            Player.AddPoints(GetPoints());
            Console.WriteLine($"You receive {GetPoints()} points.");
            
        }
    }

    public void Battle(){

        int obsStr = RandomizeValue(_min, _max);
        
        if (obsStr <= Player.GetStrength()){
            Console.WriteLine("You have managed to get through unharmed.");
        }else{
            Console.WriteLine("You were damaged.");
            int damage = obsStr - Player.GetStrength();
            Console.WriteLine($"You lost {damage} health points.");
            Player.Damage(damage);
            
        }
    }

    public void Continue(){
        Console.Write("Press any key to continue: ");
        string inputString = Console.ReadLine();
        Console.Clear();
    }
    
}