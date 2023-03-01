public class ReflectionActivity : Activity{

    private int _time;

    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _usedPrompts = new List<string>{};

    private List<string> _usedQuestions = new List<string>{};


    public ReflectionActivity(string activity, string description, int time) : base(activity, description){
        _time = time;
        
    }


    private string GetRandomPrompt(){

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

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press any key to continue.");
        string inputString = Console.ReadLine();
        DisplayQuestions();

    }

    private string GetRandQuestion(){

        string question = _questions[GetRandIndex(_questions.Count())];
        while (_usedQuestions.Contains(question)){
            question = _questions[GetRandIndex(_questions.Count())];
            if (_usedQuestions.Count() == _questions.Count()){
                _usedQuestions.Clear();
            }
        }
        _usedQuestions.Add(question);
        return question;

    }

    private void DisplayQuestions(){

        Console.WriteLine();
        Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
        Console.WriteLine();
        Console.WriteLine("Begin in ");

        StartTimer(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        
        while (DateTime.Now < endTime){
            Console.WriteLine(GetRandQuestion());
            StartTimer(10);
        }

    }

}