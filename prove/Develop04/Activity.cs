public class Activity{

    private string _activity;

    private string _description;


    public Activity(string activity, string description){
        _activity = activity;
        _description = description;
    }


    public void DisplayWelcomeMessage(){

        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_activity} activity.");
        Console.WriteLine();

    }

    public void DisplayDescription(){

        Console.WriteLine($"{_description}");
        Console.WriteLine();

    }

    public void DisplayGetReady(){

        Console.WriteLine("Get ready.");
        AnimateSpinner();
       
    }

    public void DisplayEndMessage(int time){

        Console.WriteLine("Well done!");
        AnimateSpinner();
        Console.WriteLine($"You have completed {time} seconds of the {_activity} activity.");
        AnimateSpinner();

    }

    public int GetTimeInput(){

        Console.Write("How long in seconds would you like to participate in this activity? ");
        string inputString = Console.ReadLine();
        Console.WriteLine();
        int result = Int32.Parse(inputString);
        return result;

    }

    public void AnimateSpinner(){

        Console.WriteLine();
        for (int i=5; i > 0; i--){
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public void StartTimer(int time){

        Console.WriteLine();
        for (int i=time; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (time > 9){
                Console.Write("\b\b \b");
            }
        }
        Console.WriteLine();

    }

    public int GetRandIndex(int listCount){

        var random = new Random();
        return random.Next(listCount);

    }
}