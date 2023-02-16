public class Scripture{

    private string _reference;
    private string _text;

    private List<string> _words = new List<string>();

    private List<int> _nums = new List<int>();

    public Scripture(string reference, string text){
        _reference = reference;
        _text = text;
    }

    public void Display(){
        Console.WriteLine();
        Console.WriteLine($"{_reference}: {_text}");
        Console.WriteLine();
    }

    public void Clear(){
        Console.Clear();
    }

    private void Split(){
       _words = _text.Split(" ").ToList();
    }

    public void HideWords(){
        Split();
        int i = 0; 
        if (_words.Count() - _nums.Count() == 2){
            i = 1;
        }
        if (_words.Count() - _nums.Count() == 1){
            i = 2;
        }
        while (i < 3){
            var random = new Random();
            int randInt = random.Next(_words.Count());
            if (_nums.Contains(randInt)){
                random = new Random();
                randInt = random.Next(_words.Count());
                 if (_nums.Count == _words.Count()){
                    Display();
                    Environment.Exit(0);
                }
            }else{
                i = i + 1;
                _nums.Add(randInt);
                int wordCount =  _words[randInt].Count();
                string newString = new string('-', wordCount);
                _words[randInt] = newString;
            }
        }
        
        string combinedString = string.Join( " ", _words.ToArray() );
        _text = combinedString;
    }


}