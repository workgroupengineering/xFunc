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
using xFunc.Maths.Expressions.LogicalAndBitwise;
using Xunit;

namespace xFunc.Test.Expressions.Maths.Bitwise
{
    
    public class NOrTest
    {

        [Fact]
        public void CalculateTest1()
        {
            var nor = new NOr(new Bool(false), new Bool(true));

            Assert.Equal(false, nor.Calculate());
        }

        [Fact]
        public void CalculateTest2()
        {
            var nor = new NOr(new Bool(false), new Bool(false));

            Assert.Equal(true, nor.Calculate());
        }

    }

}