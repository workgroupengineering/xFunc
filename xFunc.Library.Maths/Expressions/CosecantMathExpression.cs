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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xFunc.Library.Maths.Expressions
{

    public class CosecantMathExpression : TrigonometryMathExpression
    {

        public CosecantMathExpression()
            : base(null)
        {

        }

        public CosecantMathExpression(IMathExpression firstMathExpression)
            : base(firstMathExpression)
        {

        }

        public override string ToString()
        {
            return ToString("csc({0})");
        }

        public override double CalculateDergee(MathParameterCollection parameters)
        {
            var radian = firstMathExpression.Calculate(parameters) * Math.PI / 180;

            return 1 / Math.Sin(radian);
        }

        public override double CalculateRadian(MathParameterCollection parameters)
        {
            return 1 / Math.Sin(firstMathExpression.Calculate(parameters));
        }

        public override double CalculateGradian(MathParameterCollection parameters)
        {
            var radian = firstMathExpression.Calculate(parameters) * Math.PI / 200;

            return 1 / Math.Sin(radian);
        }

        protected override IMathExpression _Derivative(VariableMathExpression variable)
        {
            UnaryMinusMathExpression unary = new UnaryMinusMathExpression(firstMathExpression.Clone().Derivative(variable));
            CotangentMathExpression cot = new CotangentMathExpression(firstMathExpression.Clone());
            CosecantMathExpression csc = new CosecantMathExpression(firstMathExpression.Clone());
            MultiplicationMathExpression mul1 = new MultiplicationMathExpression(cot, csc);
            MultiplicationMathExpression mul2 = new MultiplicationMathExpression(unary, mul1);

            return mul2;
        }

        public override IMathExpression Clone()
        {
            return new CosecantMathExpression(firstMathExpression.Clone());
        }

    }

}
