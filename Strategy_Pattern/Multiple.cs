using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class Multiple : IOperator
    {
        public double Operate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
