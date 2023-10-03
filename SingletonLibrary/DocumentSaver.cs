using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SingletonLibrary
{
    public class DocumentSaver
    {
        private static DocumentSaver instance;

        public static DocumentSaver GetInstance()
        {
            if (instance == null)
                instance = new DocumentSaver();
            return instance;
        }

        public void SaveToFile(List<string> log)
        {
            string folder = @"C:\Users\reminiscence\Downloads\diooidsj\кпз\Singleton\Singleton\Logs\Logs";
            string fileName = "log.txt";
            string fullPath = folder + fileName;

            try
            {
                File.WriteAllLines(fullPath, log);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
