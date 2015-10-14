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
using Xunit;

namespace xFunc.Tests.Expressions.Maths
{
    
    public class RoundTest
    {

        [Fact]
        public void CalculateRoundWithoutDigits()
        {
            var round = new Round(new Number(5.555555));
            var result = round.Calculate();
            var expected = 6.0;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateRoundWithDigits()
        {
            var round = new Round(new Number(5.555555), new Number(2));
            var result = round.Calculate();
            var expected = 5.56;

            Assert.Equal(expected, result);
        }

    }

}
