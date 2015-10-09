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
using xFunc.Maths.Expressions;
using xFunc.Maths.Expressions.Collections;
using xFunc.Maths.Expressions.Programming;
using Xunit;

namespace xFunc.Test.Expressions.Maths.Programming
{
    
    public class OrTest
    {

        [Fact]
        public void CalculateOrTrueTest1()
        {
            var parameters = new ParameterCollection() { new Parameter("x", 0) };
            var lessThen = new LessThan(new Variable("x"), new Number(10));
            var greaterThen = new GreaterThan(new Variable("x"), new Number(-10));
            var or = new Or(lessThen, greaterThen);

            Assert.Equal(true, or.Calculate(parameters));
        }

        [Fact]
        public void CalculateOrTrueTest2()
        {
            var parameters = new ParameterCollection() { new Parameter("x", 0) };
            var lessThen = new LessThan(new Variable("x"), new Number(-10));
            var greaterThen = new GreaterThan(new Variable("x"), new Number(-10));
            var or = new Or(lessThen, greaterThen);

            Assert.Equal(true, or.Calculate(parameters));
        }

    }

}