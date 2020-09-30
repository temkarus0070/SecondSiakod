using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    abstract class Logger
    {
        public Level level { get; set; }
        public Logger(Level level)
        {
            this.level = level;
        }
        public abstract void Log(string message, Level level);
    }
}
