using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern_Exercise
{
    public class Logger
    {
        public string fileName;


        private Logger()
        {

        }

        private static Logger instance = new Logger();

        public static Logger getInstance()
        {
            return instance;
        }

        public void setFileName(string name)
        {
            fileName = name;
        }


        public string getFileNAme()
        {
            return fileName;
        }

        public void write(string message)
        {
            Console.WriteLine($"Writing a message to the log. Filename = {fileName}");
        }
    }
}
