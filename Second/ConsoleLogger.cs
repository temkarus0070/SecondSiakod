﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class ConsoleLogger : Logger
    {
        public ConsoleLogger(Level level) : base(level)
        {
        }



        public override void Logging(string message)
        {
            Console.WriteLine($"Логируем в консоль: {message}");
        }
    }
}
