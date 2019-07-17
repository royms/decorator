using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StartNumber : IFormula
    {
        public double Number { get; set; }

        public StartNumber(double n)
        {
            this.Number = n;
        }

        public string GetFormula()
        {
            return this.Number.ToString();
        }

        public double GetResult()
        {
            return this.Number;
        }

        public void ModifyNumber(double n)
        {
            Number = n;
        }
    }
}
