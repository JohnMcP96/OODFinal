using System.Collections.Generic;

namespace OOD_Final
{
    public class Logger
    {
        private List<string> entries;

        public Logger()
        {
            entries = new List<string>();
        }

        public void Log(string message)
        {
            entries.Add(message);
        }

        public List<string> GetLogs()
        {
            return entries;
        }
    }
}

