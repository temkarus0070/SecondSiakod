using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class DataBaseLogger : Logger
    {
        public DataBaseLogger(Level level) : base(level)
        {
        }

        public override void Logging(string message)
        {
            Console.WriteLine($"Логируем в бд {message}");
        }

    }
}
