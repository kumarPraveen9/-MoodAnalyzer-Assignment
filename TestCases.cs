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
            string input = "I am in Sad Mood";
            string expected = "SAD";


            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase1_2()
        {
            string input = "I am in Any Mood";
            string expected = "HAPPY";


            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }

       

       
        [TestMethod]
        public void UseCase3_1()
        {
            try
            {
               string input = null;
               var analyze = new MoodAnalyser(input);
            }
            catch (NullReferenceException Exception)
            {
                Assert.AreEqual("Mood can not be Null.", Exception.Message);
            }
        }

    }
}
