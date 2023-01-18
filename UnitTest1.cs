using ModeAnalyzerAssignment;
//using MoodAnalyzer;
using System.Diagnostics.SymbolStore;
using System.Reflection;

namespace TestCaseMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void UseCase5_1()
        {
            object expected = new MoodAnalyser();
            object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze_Parameter_Constructor("ModeAnalyzerAssignment.MoodAnalyser", "MoodAnalyser");
            expected.Equals(returned);
        }

     

    }
}
