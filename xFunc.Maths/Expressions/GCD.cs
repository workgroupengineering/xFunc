﻿// Copyright 2012-2013 Dmitry Kischenko
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

namespace xFunc.Maths.Expressions
{

    /// <summary>
    /// Represents a greatest common divisor.
    /// </summary>
    public class GCD : BinaryMathExpression
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GCD"/> class.
        /// </summary>
        internal GCD() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GCD"/> class.
        /// </summary>
        /// <param name="firstMathExpression">The first operand.</param>
        /// <param name="secondMathExpression">The second operand.</param>
        public GCD(IMathExpression firstMathExpression, IMathExpression secondMathExpression)
            : base(firstMathExpression, secondMathExpression)
        {

        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode(2087, 1283);
        }

        /// <summary>
        /// Converts this expression to the equivalent string.
        /// </summary>
        /// <returns>The string that represents this expression.</returns>
        public override string ToString()
        {
            return ToString("gcd({0}, {1})");
        }

        /// <summary>
        /// Calculates this mathemarical expression. Don't use this method if your expression has variables or functions.
        /// </summary>
        /// <returns>
        /// A result of the calculation.
        /// </returns>
        public override double Calculate()
        {
            return MathExtentions.GCD(left.Calculate(), right.Calculate());
        }

        /// <summary>
        /// Calculates this mathemarical expression.
        /// </summary>
        /// <param name="parameters">An object that contains all parameters and functions for expressions.</param>
        /// <returns>
        /// A result of the calculation.
        /// </returns>
        /// <seealso cref="ExpressionParameters" />
        public override double Calculate(ExpressionParameters parameters)
        {
            return MathExtentions.GCD(left.Calculate(parameters), right.Calculate(parameters));
        }

        /// <summary>
        /// Clones this instance of the <see cref="GCD"/>.
        /// </summary>
        /// <returns>Returns the new instance of <see cref="GCD"/> that is a clone of this instance.</returns>
        public override IMathExpression Clone()
        {
            return new GCD(left.Clone(), right.Clone());
        }

        /// <summary>
        /// Always throws <see cref="NotSupportedException" />.
        /// </summary>
        /// <param name="variable"></param>
        /// <returns>
        /// Throws an exception.
        /// </returns>
        /// <seealso cref="Variable" />
        /// <exception cref="NotSupportedException">Always.</exception>
        public override IMathExpression Differentiate(Variable variable)
        {
            throw new NotSupportedException();
        }

    }

}
