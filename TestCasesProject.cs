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

        /*[TestMethod]
        public void Refactor1_1()
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.msg;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Refactor1_2()
        {
            string input = "I am in Happy Mood";
            string expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.msg;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UseCase2_1()
        {
            string input = "null";
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(input);
            string actual = moodAnalyser.analyseMood1();
            Assert.AreEqual(expected, actual);
        }*/

        [TestMethod]
        public void UseCase3_1()
        {
            try
            {
                string input = null;
                MoodAnalyser md = new MoodAnalyser(input);
                string actual = md.analyseMood1();
              
            }
            catch (Exception e)
            {


                Assert.AreEqual("Mood can not be Null.", e.Message);
            }
        }

        [TestMethod]
        public void UseCase3_2()
        {
            try
            {
                MoodAnalyser analyze = new MoodAnalyser("");
                string Returned_Message = analyze.analyseMood1();
                
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Mood can not be Empty.", Exception.Message);
            }
        }

        [TestMethod]
        public void UseCase4_1()
        {
            object expected = new MoodAnalyser();
            object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.MoodAnalyser", "MoodAnalyser");
            expected.Equals(returned);
        }
        [TestMethod]
        public void UseCase4_2()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.Mood", "Mood");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Class not found", Exception.Message);
            }
        }

        [TestMethod]
        public void UseCase4_3()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.MoodAnalyser", "MoodAnalyz");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Constructor not found", Exception.Message);
            }
        }

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

        [TestMethod]
        public void UseCase6_1()
        {
            string mood = Mood_Aanalyzer_Factory.invokeAnalyzeMood("Happy", "MoodAnalyser");
            Assert.AreEqual("HAPPY", mood);
        }

       [TestMethod]
        public void UseCase6_2()
        {
            try
            {
                string mood = Mood_Aanalyzer_Factory.invokeAnalyzeMood("Happy", "mood_analyser");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Method not found", Exception.Message);
            }
        }

          [TestMethod]
        [DataRow("Happy", "analyseMood1")]
        [DataRow("Happy", "MoodAnalyze")]
        [DataRow(null, "analyseMood1")]

       
        public void When_Given_Proper_DynamicMessageThroughReflection_Should_ReturnHappy_or_Throw_Exception(string Message, string FieldName)
        {

           
            try
            {
                string mood = Mood_Aanalyzer_Factory.SetField(Message, FieldName);
                Assert.AreEqual("HAPPY", mood);
            }
            catch (MoodAnalyzerNullException Exception)
            {
                if (Exception.Message == "Field not Found")
                    Assert.AreEqual("Field not Found", Exception.Message);
                else Assert.AreEqual("Mood can not be null.", Exception.Message);
            }
        }

        
    }
}
