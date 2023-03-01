public class BreathingActivity : Activity{

    private int _time;
    
    public BreathingActivity(string activity, string description, int time) : base(activity, description){
        _time = time;
        
    }
  
    public void DisplayBreathing(){

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        
        while (DateTime.Now < endTime){
            
            Console.WriteLine("Breathe in");
            StartTimer(5);
            Console.WriteLine("Breathe out");
            StartTimer(5);
        
        }

    }

}