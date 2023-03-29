static class Game
{
    static private int _levelCount = 1;

    static public int GetLevel(){
        return _levelCount;
    }

    static public void SetLevel(int level){
        _levelCount = level;
    }


    static public void IncreaseLevel(){
        _levelCount = _levelCount + 1;
    }

    static public void Save(){
        Console.Write("What file do you want to save to?: ");
        string inputString = Console.ReadLine();
        string fileName = inputString;

        using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        outputFile.WriteLine(GetLevel());
        outputFile.WriteLine(Player.GetHealth());
        outputFile.WriteLine(Player.GetStrength());
        outputFile.WriteLine(Player.GetPoints());

        }
    }


    static public void Load(){
        Console.Write("Name the file that you want to load: ");

        string _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);
    
        string levelString = lines[0];
        int result = Int32.Parse(levelString);
        SetLevel(result);

        string healthString = lines[1];
        result = Int32.Parse(healthString);
        Player.SetHealth(result);

        string strengthString = lines[2];
        result = Int32.Parse(strengthString);
        Player.SetStrength(result);

        string pointsString = lines[3];
        result = Int32.Parse(pointsString);
        Player.SetPoints(result);
    
    }
}