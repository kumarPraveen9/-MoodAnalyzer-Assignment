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
        public MoodAnalyser()
        {
            this.msg = "SAD";
        }
        public MoodAnalyser(string msg1)
        {
           this.msg = msg1;
            
        }
        
        public string analyseMood1()
        {
            MoodAnalyser obja = new MoodAnalyser();
            return obja.msg;
            
        }

    }

}

