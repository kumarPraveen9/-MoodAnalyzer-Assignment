namespace ModeAnalyzerAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = "I am in Sad Mood";
            string message1 = "I am in Any Mood";
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer();
            moodAnalyzer1.analyseMood(message);

        }
    }
}


