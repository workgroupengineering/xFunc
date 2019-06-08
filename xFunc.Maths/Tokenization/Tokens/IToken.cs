﻿// Copyright 2012-2019 Dmitry Kischenko
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

namespace xFunc.Maths.Tokenization.Tokens
{
 
    /// <summary>
    /// Represents a token.
    /// </summary>
    public interface IToken
    {

        /// <summary>
        /// Gets a priority of current token.
        /// </summary>
        int Priority { get; }

    }

}
