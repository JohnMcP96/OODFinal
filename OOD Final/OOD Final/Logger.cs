using System;
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
            string timestamp = DateTime.Now.ToString("g");
            entries.Add(timestamp + " - " + message);
        }

        public List<string> GetLogs()
        {
            return entries;
        }
    }
}

