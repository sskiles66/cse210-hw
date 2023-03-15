using System;

class EternalGoal : Goal
{
    private string _type;
    public EternalGoal(string type){
        _type = type;
        
    }

    public override string GetFormattedGoal(){
        return $"{_type}|||{GetName()}|||{GetDescription()}|||{GetPoints()}";
    }

    public override void RecordEvent(){
        int points = GetPoints(); 
        Console.WriteLine($"You receive {points} points!");
    }
}