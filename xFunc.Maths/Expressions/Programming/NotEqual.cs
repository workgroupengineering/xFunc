﻿// Copyright 2012-2016 Dmitry Kischenko
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

namespace xFunc.Maths.Expressions.Programming
{

    /// <summary>
    /// Represents the inequality operator.
    /// </summary>
    public class NotEqual : BinaryExpression
    {

        internal NotEqual() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotEqual"/> class.
        /// </summary>
        /// <param name="left">The left (first) operand.</param>
        /// <param name="right">The right (second) operand.</param>
        public NotEqual(IExpression left, IExpression right)
            : base(left, right)
        { }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            if (m_parent is BinaryExpression)
                return ToString("({0} != {1})");

            return ToString("{0} != {1}");
        }

        /// <summary>
        /// Executes this expression.
        /// </summary>
        /// <param name="parameters">An object that contains all parameters and functions for expressions.</param>
        /// <returns>
        /// A result of the execution.
        /// </returns>
        /// <seealso cref="ExpressionParameters" />
        public override object Execute(ExpressionParameters parameters)
        {
            var leftValueObject = m_left.Execute(parameters);
            var rightValueObject = m_right.Execute(parameters);

            if (leftValueObject is double && rightValueObject is double)
                return (double)leftValueObject != (double)rightValueObject;

            if (leftValueObject is bool && rightValueObject is bool)
                return (bool)leftValueObject != (bool)rightValueObject;

            throw new NotSupportedException();
        }

        /// <summary>
        /// Creates the clone of this instance.
        /// </summary>
        /// <returns>
        /// Returns the new instance of <see cref="NotEqual" /> that is a clone of this instance.
        /// </returns>
        public override IExpression Clone()
        {
            return new Equal(m_left.Clone(), m_right.Clone());
        }

        /// <summary>
        /// Gets the type of the left parameter.
        /// </summary>
        /// <value>
        /// The type of the left parameter.
        /// </value>
        public override ExpressionResultType LeftType
        {
            get
            {
                return ExpressionResultType.Number | ExpressionResultType.Boolean;
            }
        }

        /// <summary>
        /// Gets the type of the right parameter.
        /// </summary>
        /// <value>
        /// The type of the right parameter.
        /// </value>
        public override ExpressionResultType RightType
        {
            get
            {
                return ExpressionResultType.Number | ExpressionResultType.Boolean;
            }
        }

        /// <summary>
        /// Gets the type of the result.
        /// </summary>
        /// <value>
        /// The type of the result.
        /// </value>
        public override ExpressionResultType ResultType
        {
            get
            {
                return ExpressionResultType.Boolean;
            }
        }

    }

}
