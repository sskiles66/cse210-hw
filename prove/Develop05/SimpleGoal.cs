using System;

class SimpleGoal : Goal
{
    
    private string _type;
    private bool _isDone = false;

    public SimpleGoal(string type){
        _type = type;
    }

    public override void Display(){
        if (_isDone == false){
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
        }else{
             Console.WriteLine($"[X] {GetName()} ({GetDescription()})");
        }
    }
    
    public override string GetFormattedGoal(){
        return $"{_type}|||{GetName()}|||{GetDescription()}|||{GetPoints()}|||{_isDone}";
    }

    public override void RecordEvent(){
        int points = GetPoints(); 
        if (_isDone == true){
            Console.WriteLine("You have already done this goal");
            SetPoints(0); 
        }else{
            Console.WriteLine($"You receive {points} points!");
            _isDone = true; 
        }
    }

    

    public void SetIsDone(bool done){
        _isDone = done;
    }


}