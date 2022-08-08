using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class Calculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1">
        /// Input Double Number
        /// </param>
        /// <param name="num2">
        /// Input Double Number
        /// </param>
        /// <param name="operator">
        /// Dependency RelationShip With IOperator . You Can use All Of (( Child class )) of IOperator
        /// </param>
        /// <returns></returns>
        public double OperateCalculator(double num1,double num2,IOperator @operator)
        {
            return @operator.Operate(num1,num2);
        }

    }
}
