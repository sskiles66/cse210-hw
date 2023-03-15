using System;

class ChecklistGoal : Goal
{
    
    private int _bonus;

    private int _completeNum;

    private int _currentNum;

    private string _type;


    public ChecklistGoal(string type){
        _type = type;
    }
   

    public override void CreateGoal(){
        Console.Write("What is the name of the goal? ");
        string inputString = Console.ReadLine();
        SetName(inputString);
        
        Console.Write("What is the description of the goal? ");
        inputString = Console.ReadLine();
        SetDescription(inputString);
        
        Console.Write("How many points for each time this goal is completed? ");
        inputString = Console.ReadLine();
        int result = Int32.Parse(inputString);
        SetPoints(result);

        Console.Write("How many times do you want to do this goal before completion? ");
        inputString = Console.ReadLine();
        result = Int32.Parse(inputString);
        _completeNum = result;

        Console.Write("How many points should you receive when you finish? ");
        inputString = Console.ReadLine();
        result = Int32.Parse(inputString);
        _bonus = result;

        _currentNum = 0;
    
    }
    

    public override void Display(){
        if (_currentNum == _completeNum){
            Console.WriteLine($"[X] {GetName()} ({GetDescription()})  {_currentNum}/{_completeNum}");
        }else{
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()})  {_currentNum}/{_completeNum}");
        }
    }

    public override string GetFormattedGoal(){
        return $"{_type}|||{GetName()}|||{GetDescription()}|||{GetPoints()}|||{_currentNum}|||{_completeNum}|||{_bonus}";
    }

    public override void RecordEvent(){
        if (_currentNum == _completeNum){
            Console.WriteLine("You have already completed this goal.");
            SetPoints(0); 
        }else{

            int points = GetPoints(); 
            Console.WriteLine($"You receive {points} points!");
            _currentNum = _currentNum + 1;

            if (_currentNum == _completeNum){
                Console.WriteLine($"You completed this goal!!");
                Console.WriteLine($"You receive {_bonus} points!");
                SetPoints(points + _bonus);
            }   
        }
    }

    public void SetBonus(int bonus){
        _bonus = bonus;
    }

    public void SetCurrentNum(int currentNum){
        _currentNum = currentNum;
    }

    public void SetCompleteNum(int completeNum){
        _completeNum = completeNum;
    }
}