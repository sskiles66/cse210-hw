using System;

class MidRiskLevel : Level
{

    public MidRiskLevel(string description, int points, int min, int max) : base(description,points,min,max){

    }
    
    public override void Execute(){
        DisplayDescription();

        Battle();

        CheckLife();

        Continue();
    }
}