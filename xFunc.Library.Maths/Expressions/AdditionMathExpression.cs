﻿// Copyright 2012 Dmitry Kischenko
//
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
// express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
using System;

namespace xFunc.Library.Maths.Expressions
{

    public class AdditionMathExpression : BinaryMathExpression
    {

        public AdditionMathExpression() : base(null, null) { }

        public AdditionMathExpression(IMathExpression firstOperand, IMathExpression secondOperand) : base(firstOperand, secondOperand) { }

        public override string ToString()
        {
            if (parentMathExpression != null && parentMathExpression is BinaryMathExpression)
            {
                return ToString("({0} + {1})");
            }

            return ToString("{0} + {1}");
        }

        public override double Calculate(MathParameterCollection parameters)
        {
            return firstMathExpression.Calculate(parameters) + secondMathExpression.Calculate(parameters);
        }

        public override IMathExpression Derivative(VariableMathExpression variable)
        {
            var first = MathParser.HasVar(firstMathExpression, variable);
            var second = MathParser.HasVar(secondMathExpression, variable);

            if (first && second)
            {
                return new AdditionMathExpression(firstMathExpression.Clone().Derivative(variable), secondMathExpression.Derivative(variable).Clone());
            }
            else if (first)
            {
                return firstMathExpression.Clone().Derivative(variable);
            }
            else if (second)
            {
                return secondMathExpression.Derivative(variable).Clone();
            }
            else
            {
                return new NumberMathExpression(0);
            }
        }

        public override IMathExpression Clone()
        {
            return new AdditionMathExpression(firstMathExpression.Clone(), secondMathExpression.Clone());
        }

    }

}
