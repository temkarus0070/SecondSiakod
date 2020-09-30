using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class FileLogger : Logger
    {
        public FileLogger(Level level) : base(level)
        {
        }

        public override void Log(string message, Level level)
        {
            throw new NotImplementedException();
        }
    }
}
