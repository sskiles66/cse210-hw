using System;

class HealthLevel : Level
{
    private int _healthBonus;

    public HealthLevel(string description, int points, int min, int max) : base(description,points, min, max){

    }

    public override void Execute(){
        
        DisplayDescription();
        
        _healthBonus = RandomizeValue(1, 6);
        Console.WriteLine($"You gain {_healthBonus} health.");
        Player.GainHealth(_healthBonus);

        Continue();
        

    }
    
}