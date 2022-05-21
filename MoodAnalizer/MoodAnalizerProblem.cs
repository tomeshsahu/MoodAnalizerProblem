using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class MoodAnalizerProblem
    {
        string message;
        public MoodAnalizerProblem(string message)
        {
            this.message = message;
        }
        public string Mood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
                return message;
            }
            catch (Exception)
            {
                return "Happy";
            }
        }
    }
}
