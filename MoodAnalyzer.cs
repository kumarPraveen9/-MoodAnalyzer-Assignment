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
}
