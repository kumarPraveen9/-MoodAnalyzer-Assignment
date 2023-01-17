namespace ModeAnalyzerAssignment
{
     public class Program
     {
        public static void Main(string[] args)
        {
            string message;
            Random random= new Random();
            int mood = random.Next(2);

            if (mood == 1) 
            {
                 message = "Happy";
            }
            else
            {
                 message = "Sad";

            }
            Console.WriteLine(MoodAnalyzer.analyseMood(message));
        }
     }
}
