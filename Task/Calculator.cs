using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon
{
    public delegate double Operator(double d);
    class Calculator
    {
        List<Operator> operations = new List<Operator>();
        public void Add(Operator o)
        {
            operations.Add(o);
        }
        public double Execute(double d)
        {
            foreach (var value in operations)
            {
                d = value(d);
            }
            return d;
        }

    }

}
