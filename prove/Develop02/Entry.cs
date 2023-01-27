class Entry
{
    public string _quality;

    public string _prompt;
    
    public  string _inputString;

    public string _date;

    
    public string GetDate(){
        DateTime currentTime = DateTime.Now;
        string dateString = currentTime.ToShortDateString();
        return dateString;
    }


    public string GetPrompt(){
        //grab random prompt
        //grab user input
        //have entry equal prompt and input and result of GetDate
        //append entry to journal

        Console.WriteLine("Respond to the prompt.");

        var random = new Random();

        var questions = new List<string>{
        "Did you meet anyone new today?",
        "What was the most significant thing that you did today?",
        "What blessings did you notice today?",
        "What could you have improved today?",
        "Were there any low moments today?"};

        int index = random.Next(questions.Count);
        string _prompt = questions[index];

        Console.WriteLine(_prompt);
        
        return _prompt;

    }

    public string GetInput(){
        Console.Write("Your response: ");
        string _inputString = Console.ReadLine();
        return _inputString;
    }

    public string getQual(){
        Console.Write("On a scale of 1 - 10, rate your day (10 being the best): ");
        string _quality = Console.ReadLine();
        return _quality;
        
    }


    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date} Prompt: {_prompt}\nAnswer: {_inputString}\nQuality: {_quality}");
    }

    public string GetEntry(){
        return $"{_date}||| {_prompt}|||{_inputString}|||{_quality}";
    }


}