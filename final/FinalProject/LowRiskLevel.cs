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

    }
}