using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyzerAssignment
{
    public class MoodAnalyzer
    {
        public string analyseMood(string message)
        {
            if (message == "I am in Sad Mood")
            {
                message = "SAD";
                return message;

            }
            else
            {
                message = "HAPPY";
                return message;
            }
        }

    }
    public class MoodAnalyser
    {

        public string msg;
       
        public MoodAnalyser(string msg1)
        {
            this.msg = msg1;

        }



       public string analyseMood1()
        {
           
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);
           //msg = "";
            try
            {
                if (msg.Equals(string.Empty))
                {

                    throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.EMPTY_MOOD, "Mood can not be Empty.");
                }
                else if (msg.ToUpper().Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
            }
            catch (NullReferenceException)
            {
                //return "HAPPY";
                throw new MoodAnalyzerNullException(MoodAnalyzerNullException.Exception_Type.NULL_MOOD, "Mood can not be Null.");
            }
           
        }

    }

}
