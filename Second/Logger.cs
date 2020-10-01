using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    abstract class Logger
    {
        public Logger Next { get; set; }

        public Level level { get; set; }
        public Logger(Level level)
        {
            this.level = level;
        }
        public  void Log(string message, Level level)
        {
            if (this.level == Level.Info)
                Logging(message);
            if (this.level == Level.Debug &&( level == Level.Debug || level == Level.Error ))
                Logging(message);
            if (this.level == Level.Error && level == Level.Error)
                Logging(message);
            if(Next!=null)
                Next.Log(message, level);
        }

        public abstract void Logging(string message);
    }
}
