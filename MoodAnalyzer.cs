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
            MoodAnalyser obja = new MoodAnalyser(msg);

            if (obja.msg == null)
            {
               
              obja.msg="Happy";
               
              
            }
            else
            {
                Console.WriteLine("Message is not NULL" + obja.msg);
            }
            obja.msg="Happy";
            return obja.msg;
        }

    }

}
