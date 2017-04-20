using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Logger
    {
        List<Action<string>> list = new List<Action<string>>();
        public void Add(Action<string> msg)
        {
            list.Add(msg);
        }

        public void Log(string msg)
        {
            foreach (var value in list)
            {
                value(msg);
            }
        }

    }
}
