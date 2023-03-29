using System;

class LowRiskLevel : Level
{
    public LowRiskLevel(string description, int points, int min, int max) : base(description,points,min,max){

    }
    public override void Execute(){

        DisplayDescription();

        Battle();

        CheckLife();

        Continue();

        //Console.WriteLine($"You gain {_healthBonus} health.");
        //Player.SetHealth(_healthBonus);
    }
}