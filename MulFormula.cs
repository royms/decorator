using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MulFormula : FormulaDecoratorBase
    {
        public MulFormula(IFormula formula, double number) : base(formula)
        {
            this.Number = number;
        }

        public override string GetFormula()
        {
            return this.Formula.GetFormula() + " * " + this.Number.ToString();
        }

        public override double GetResult()
        {
            return this.Formula.GetResult() * this.Number;
        }
    }
}
