using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Threading.Tasks;
using ModeAnalyzerAssignment;

namespace Mood_Analyzer
{
    /// <summary>
    /// UC 4: Creating a method to make an object of Mood_Analyzer_Program class
    /// </summary>
    public class Mood_Aanalyzer_Factory
    {
        public static object CreateMoodAnalyze(string className, string constructorName)
        {                     
            
            if (className.Equals(constructorName))
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyzeType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
        }
    
     public static object CreateMoodAnalyze_Parameter_Constructor(string className, string constructorName)  
        {
            Type type = typeof(MoodAnalyser);   //namspace.classname
            if (type.Name.Equals(className) || type.FullName.Equals(className))   //(MoodAnalyser==MoodAnalyser)
            {
                if (type.Name.Equals(constructorName))  //(MoodAnalyser==MoodAnar)
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
            else throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NO_SUCH_CLASS, "Class not found");
        }
    
    }
}
