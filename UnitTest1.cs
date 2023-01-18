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

        [TestMethod]
        public void UseCase5_2()
        {
            try
            {
                
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze_Parameter_Constructor("ModeAnalyzerAssignment.MoodAnaler", "MoodAnalyser");
            }
            catch(MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Class not found",Exception.Message);
            }
        }
      [TestMethod]
        public void UseCase5_3()
        {
            try
            {

                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze_Parameter_Constructor("ModeAnalyzerAssignment.MoodAnalyser", "MoodAnar");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Constructor not found", Exception.Message);
            }
        }

    }
}
