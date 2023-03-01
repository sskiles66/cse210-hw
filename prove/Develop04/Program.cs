using System;

class Program
{
    static void Main(string[] args)
    {
        while (true){

            Console.WriteLine();
            Console.WriteLine("Here are your options: ");
            Console.WriteLine();

            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: Exit");

            Console.WriteLine();
            Console.Write("Enter the number of the activity that you would like to do? ");
            string inputString = Console.ReadLine();

            if (inputString == "1"){

                string descrip = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

                Activity Activity = new Activity("Breathing", descrip);
                Activity.DisplayWelcomeMessage();
                Activity.DisplayDescription();
                
                int duration = Activity.GetTimeInput();
                BreathingActivity BrActivity = new BreathingActivity("Breathing", descrip, duration);

                BrActivity.DisplayGetReady();
                BrActivity.DisplayBreathing();
                BrActivity.DisplayEndMessage(duration);

                Console.Clear();       
            }

            else if (inputString == "2"){
                
                Console.WriteLine("2");
                string descrip = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                Activity Activity = new Activity("Reflecting", descrip);
                Activity.DisplayWelcomeMessage();
                Activity.DisplayDescription();

                int duration = Activity.GetTimeInput();
                ReflectionActivity ReActivity = new ReflectionActivity("Reflecting", descrip, duration);

                ReActivity.DisplayGetReady();
                ReActivity.DisplayPrompt();
                ReActivity.DisplayEndMessage(duration);

                Console.Clear();
            }

            else if (inputString == "3"){

                Console.WriteLine("3");
                string descrip = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                Activity Activity = new Activity("Listing", descrip);
                Activity.DisplayWelcomeMessage();
                Activity.DisplayDescription();

                int duration = Activity.GetTimeInput();
                ListingActivity LiActivity = new ListingActivity("Listing", descrip, duration);

                LiActivity.DisplayGetReady();
                LiActivity.DisplayPrompt();
                LiActivity.DisplayEndMessage(duration);
                
                Console.Clear();

            }

            else if (inputString == "4"){

                Environment.Exit(0);
            }else{

                Console.WriteLine("Unknown");
            }
        }
    }
}