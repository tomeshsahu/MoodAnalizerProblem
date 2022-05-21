﻿using System;
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
                if (message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "message is Null");
                }
                if (message.Equals(""))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "message is Empty");

                }
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (MoodAnalyzerException ex)
            {
                return ex.Message;
            }
        }
    }
}
