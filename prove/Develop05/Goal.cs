using System;

class Goal
{
    

    private string _name;

    private string _description;

    private int _points;

    
    public virtual void CreateGoal(){
        Console.Write("What is the name of the goal? ");
        string inputString = Console.ReadLine();
        _name = inputString;
        
        Console.Write("What is the description of the goal? ");
        inputString = Console.ReadLine();
        _description = inputString;
        
        Console.Write("How many points should be associated with this goal? ");
        inputString = Console.ReadLine();
        int result = Int32.Parse(inputString);
        _points = result;
    }

    public virtual void RecordEvent(){

    }

    public virtual void Display(){
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public virtual string GetFormattedGoal(){
        return "";
    }

    
    public string GetDescription(){
        
        return _description;
    }

    public void SetDescription(string description){
        
        _description = description;
    }

    public int GetPoints(){
        
        return _points;
    }

    public void SetPoints(int points){
        
        _points = points;
    }

    public string GetName(){
        
        return _name;
    }

    public void SetName(string name){
        
        _name = name;
    }

    
}