using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class FormulaDecoratorBase : IFormula
    {
        public double Number;

        protected IFormula Formula;

        public abstract string GetFormula();

        public abstract double GetResult();

        public FormulaDecoratorBase(IFormula formula)
        {
            this.Formula = formula;
        }
    }
}
