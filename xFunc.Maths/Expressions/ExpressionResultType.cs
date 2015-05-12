﻿// Copyright 2012-2015 Dmitry Kischenko
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
    /// Represents results of expressions.
    /// </summary>
    [Flags]
    public enum ExpressionResultType
    {

        /// <summary>
        /// An expression doesn't return anything.
        /// </summary>
        None = 0x0,
        /// <summary>
        /// An expression returns undefined result.
        /// </summary>
        Undefined = 0x1,
        /// <summary>
        /// An expression returns a number.
        /// </summary>
        Number = 0x2,
        /// <summary>
        /// An expression returns a boolean (true or false).
        /// </summary>
        Boolean = 0x4,
        /// <summary>
        /// An expression returns a matrix or a vector.
        /// </summary>
        Matrix = 0x8,
        /// <summary>
        /// An expression returns an expression.
        /// </summary>
        Expression = 0x10,
        /// <summary>
        /// Combines other parameters.
        /// </summary>
        All = Undefined | Number | Boolean | Matrix | Expression

    }

}
