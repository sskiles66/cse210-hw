using System;

class Program
{
    private static Reference reference = new Reference();
    static void Main(string[] args)
    {
        Text text = new Text();
        
        int index = RandIndex();

        Scripture scripture = new Scripture(reference.RandReference(index), text.RandText(index));

        scripture.Display();

        Console.WriteLine();

        while(true){
            Console.WriteLine("Press enter to continue or 'exit' to exit.");

            Console.Write("");
            string inputString = Console.ReadLine();

            if (inputString == "exit"){
                Environment.Exit(0);
            }else{
                scripture.Clear();
                scripture.HideWords();
                scripture.Display();
            }
        }
    }

    private static int RandIndex(){

        var random = new Random();

        return random.Next(reference.GetListCount());
        
    }
}