class Journal 
{
    public static List<Entry> _entries = new List<Entry>();

    public List<string> _qualities = new List<string>();

    public static string _fileName;

    public void WriteJournal(){
        //Save Journal
        Console.Write("Name the file that you want to save: ");
        _fileName = Console.ReadLine();
    

    using (StreamWriter outputFile = new StreamWriter(_fileName)){
    // You can add text to the file with the WriteLine method

    
    foreach (Entry entry in _entries){
        
            Console.WriteLine();
            outputFile.WriteLine(entry.GetEntry());
            Console.WriteLine();
        }
}
    }

    public void ReadJournal(){
        //Load Journal

        Console.Write("Name the file that you want to load: ");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        

        foreach (string line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split("|||");

            entry._prompt = parts[1];
            entry._inputString = parts[2];
            entry._date = parts[0];
            entry._quality = parts[3];

            Journal journal = new Journal();

            _qualities.Add(entry._quality);
            journal.AddEntry(entry);
        }
    }

    public void DisplayJournal(){
        //Foreach in _entries, print out entries.
        foreach (Entry entry in _entries){
            Console.WriteLine();
            entry.DisplayEntry();
            Console.WriteLine();

        }

        

        List<int> qualities_int = new List<int>();

        foreach (string num in _qualities){
            int num_int = Int16.Parse(num);
            qualities_int.Add(num_int);

        }
    

        if (qualities_int.Count != 0){
            double qualAvg = qualities_int.Average();
            Console.WriteLine($"You average quality from 1 - 10 is: {qualAvg} ");
        }

    }

    public void AddEntry(Entry entry){
        _entries.Add(entry);
    }

    public void AddQuality(string quality){
        _qualities.Add(quality);
    }
}