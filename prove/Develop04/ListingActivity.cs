public class ListingActivity : Activity{

    private int _time;

    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _usedPrompts = new List<string>{};

    private int _count = 0;

    public ListingActivity(string activity, string description, int time) : base(activity, description){
        _time = time;
        
    }
  
  
    private string GetPrompt(){
        
        string prompt = _prompts[GetRandIndex(_prompts.Count())];
        while (_usedPrompts.Contains(prompt)){
            prompt = _prompts[GetRandIndex(_prompts.Count())];
            if (_usedPrompts.Count() == _prompts.Count()){
                _usedPrompts.Clear();
            }
        }
        _usedPrompts.Add(prompt);
        return prompt;

    }

    public void DisplayPrompt(){

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("Begin in ");
        StartTimer(5);
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        
        while (DateTime.Now < endTime){

            Console.Write(">");
            Console.ReadLine();
            _count = _count + 1;
            
        }

        DisplayCount();
    }



    private void DisplayCount(){
        Console.WriteLine();
        Console.WriteLine($"You wrote {_count} responses.");
        Console.WriteLine();
    }

}