using ModeAnalyzerAssignment;
using System.Diagnostics.SymbolStore;

namespace TestCaseMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1_1()
        {
            string input="I am in Sad Mood";
            string expected = "SAD";


            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            
          string actual= moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }

        
    }
}
