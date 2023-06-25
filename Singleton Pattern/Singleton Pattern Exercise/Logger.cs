using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern_Exercise
{
    public class Logger
    {

        private static Dictionary<string, Logger> dict = new Dictionary<string, Logger>();


        private Logger()
        {

        }

        private static Logger instance = new Logger();

        public static Logger getInstance(string filename)
        {
            Logger logger;
            if (!dict.ContainsKey(filename))
            {
                Console.WriteLine("Filename dosenot exist creating new logger");
                dict.Add(filename, new Logger());
                dict.TryGetValue(filename, out logger);
                return logger;
            }
            Console.WriteLine("Filename exist returning old logger");
            dict.TryGetValue(filename, out logger);
            return logger;
        }


        public void write(string message)
        {
            Console.WriteLine($"Writing a message to the log.");
        }
    }
}
