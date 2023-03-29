using System;

class StrengthLevel : Level
{
    
    private int _strengthBonus;
    public StrengthLevel(string description, int points, int min, int max) : base(description,points,min, max){

    }
    public override void Execute(){
        
        DisplayDescription();
        
        _strengthBonus = RandomizeValue(0, 2);
        Console.WriteLine($"You gain {_strengthBonus} strength.");
        Player.GainStrength(_strengthBonus);

        Continue();
    }
}