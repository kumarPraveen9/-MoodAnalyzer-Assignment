using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyzerAssignment
{
    

    public class MoodAnalyzerNullException : Exception
        {
        Exception_Type type;
        public enum Exception_Type
        {
            EMPTY_MOOD,
            NULL_MOOD,
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR,
             NO_SUCH_METHOD
        }
        
        public MoodAnalyzerNullException(Exception_Type type, string msg) : base(msg)
            {
            this.type = type;
        }
        }
    
}
