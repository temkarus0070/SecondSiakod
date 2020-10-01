using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new ConsoleLogger(Level.Info);
            logger.Next = new DataBaseLogger(Level.Debug);
            logger.Next.Next = new FileLogger(Level.Error);
            logger.Log("Всё хорошо", Level.Info);
        }
    }
}
