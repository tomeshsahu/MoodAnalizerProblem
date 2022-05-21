using System.Runtime.Serialization;

namespace MoodAnalizer
{
    [Serializable]
    internal class MoodAnalyzerException : Exception
    {
        private object eMPTY_MOOD;
        private string v;

        public MoodAnalyzerException()
        {
        }

        public MoodAnalyzerException(string? message) : base(message)
        {
        }

        public MoodAnalyzerException(object eMPTY_MOOD, string v)
        {
            this.eMPTY_MOOD = eMPTY_MOOD;
            this.v = v;
        }

        public MoodAnalyzerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyzerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}