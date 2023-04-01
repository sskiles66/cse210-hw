using System;

static class Player
{

    static public int _health = 10;

    static public int _totalPoints = 0;

    static public int _strength = 10;

    static public void AddHealth(){
        _health = _health + 1;
    }

    static public int GetPoints(){
        return _totalPoints;
    }

    static public void SetPoints(int points){
        _totalPoints = points;
    }

    static public int GetHealth(){
        return _health;
    }

    static public void SetHealth(int health){
        _health = health;
    }

    static public int GetStrength(){
        return _strength;
    }

    static public void SetStrength(int strength){
       _strength = strength;
    }


    static public void AddPoints(int points){
        _totalPoints = _totalPoints + points;
    }

    static public void Damage(int points){
        _health = _health - points;
    }

    static public void GainHealth(int health){
        _health = _health + health;
    }

    static public void GainStrength(int strength){
       _strength = _strength + strength;
    }
    
}