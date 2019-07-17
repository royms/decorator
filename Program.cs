using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula startNumber = new StartNumber(5.5);

            IFormula add = new AddFormula(startNumber, 5.5);
            Console.WriteLine(add.GetFormula() + " = " + add.GetResult().ToString());

            IFormula sub = new SubFormula(add, 5.0);
            Console.WriteLine(sub.GetFormula() + " = " + sub.GetResult().ToString());

            IFormula mul = new MulFormula(sub, 4);
            Console.WriteLine(mul.GetFormula() + " = " + mul.GetResult().ToString());

            IFormula div = new DivFormula(mul, 2.0);
            Console.WriteLine(div.GetFormula() + " = " + div.GetResult().ToString());

            ((StartNumber)startNumber).ModifyNumber(94.5);
            Console.WriteLine(div.GetFormula() + " = " + div.GetResult().ToString());
        }
    }
}
