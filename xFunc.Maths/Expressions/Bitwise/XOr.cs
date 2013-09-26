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

namespace xFunc.Maths.Expressions.Bitwise
{

    /// <summary>
    /// Represents a bitwise XOR operation.
    /// </summary>
    public class XOr : BinaryMathExpression
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="XOr"/> class.
        /// </summary>
        internal XOr() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="XOr"/> class.
        /// </summary>
        /// <param name="firstMathExpression">The left operand.</param>
        /// <param name="secondMathExpression">The right operand.</param>
        /// <seealso cref="IMathExpression"/>
        public XOr(IMathExpression firstMathExpression, IMathExpression secondMathExpression)
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
            return base.GetHashCode(3371, 2833);
        }

        /// <summary>
        /// Converts this expression to the equivalent string.
        /// </summary>
        /// <returns>The string that represents this expression.</returns>
        public override string ToString()
        {
            if (parent is BinaryMathExpression)
            {
                return ToString("({0} xor {1})");
            }

            return ToString("{0} xor {1}");
        }

        /// <summary>
        /// Calculates this bitwise XOR expression. Don't use this method if your expression has variables.
        /// </summary>
        /// <returns>A result of the calculation.</returns>
        public override double Calculate()
        {
            return (int)Math.Round(left.Calculate(), MidpointRounding.AwayFromZero) ^ (int)Math.Round(right.Calculate(), MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Calculates this bitwise XOR expression.
        /// </summary>
        /// <param name="parameters">A collection of variables that are used in the expression.</param>
        /// <returns>A result of the calculation.</returns>
        public override double Calculate(MathParameterCollection parameters)
        {
            return (int)Math.Round(left.Calculate(parameters), MidpointRounding.AwayFromZero) ^ (int)Math.Round(right.Calculate(parameters), MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Calculates this bitwise XOR expression.
        /// </summary>
        /// <param name="parameters">A collection of variables that are used in the expression.</param>
        /// <param name="functions">A collection of user-defined functions.</param>
        /// <returns>A result of the calculation.</returns>
        public override double Calculate(MathParameterCollection parameters, MathFunctionCollection functions)
        {
            return (int)Math.Round(left.Calculate(parameters, functions), MidpointRounding.AwayFromZero) ^ (int)Math.Round(right.Calculate(parameters, functions), MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Clones this instance of the <see cref="XOr"/>.
        /// </summary>
        /// <returns>Returns the new instance of <see cref="IMathExpression"/> that is a clone of this instance.</returns>
        public override IMathExpression Clone()
        {
            return new XOr(left.Clone(), right.Clone());
        }

        /// <summary>
        /// This method always throws the <see cref="NotSupportedException"/> exception.
        /// </summary>
        /// <param name="variable">This method always throws the <see cref="NotSupportedException"/> exception.</param>
        /// <returns>This method always throws the <see cref="NotSupportedException"/> exception.</returns>
        /// <exception cref="NotSupportedException">Always is thrown.</exception>
        public override IMathExpression Differentiate(Variable variable)
        {
            throw new NotSupportedException();
        }

    }

}
