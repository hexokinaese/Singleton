using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class Logger
    {
        private static Logger instance;
        DocumentSaver documentSaver = DocumentSaver.GetInstance();
        List<string> logs = new List<string>();

        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public void Info(string log)
        {
            logs.Add(log + "; ");
        }

        public void Save()
        {
            documentSaver.SaveToFile(logs);
        }
    }
}
