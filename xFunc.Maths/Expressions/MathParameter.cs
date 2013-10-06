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
using System.Globalization;

namespace xFunc.Maths.Expressions
{

    /// <summary>
    /// Item of <see cref="MathParameterCollection"/>.
    /// </summary>
    public class MathParameter
    {

        private string key;
        private double value;
        private bool isReadOnly;

        /// <summary>
        /// Initializes a new instance of the <see cref="MathParameter"/> class.
        /// </summary>
        /// <param name="key">The name of parameter.</param>
        /// <param name="value">The value of parameter.</param>
        public MathParameter(string key, double value)
            : this(key, value, false) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MathParameter"/> class.
        /// </summary>
        /// <param name="key">The name of parameter.</param>
        /// <param name="value">The value of parameter.</param>
        /// <param name="isReadOnly">if set to <c>true</c> parameter is read-only.</param>
        public MathParameter(string key, double value, bool isReadOnly)
        {
            this.key = key;
            this.value = value;
            this.isReadOnly = isReadOnly;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this == obj)
                return true;

            var param = obj as MathParameter;
            if (param == null)
                return false;

            return key == param.key && value == param.value;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            int hash = 163;

            hash = hash * 41 + key.GetHashCode();
            hash = hash * 41 + value.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Returns a <see cref="String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}: {1} (Read-Only: {2})", key, value, isReadOnly);
        }

        /// <summary>
        /// Gets the name of parameter.
        /// </summary>
        /// <value>
        /// The name of parameter.
        /// </value>
        public string Key
        {
            get
            {
                return key;
            }
        }

        /// <summary>
        /// Gets or sets the value of parameter.
        /// </summary>
        /// <value>
        /// The value of parameter.
        /// </value>
        public double Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this variable is read-only.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this variable is read-only; otherwise, <c>false</c>.
        /// </value>
        public bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
        }

    }

}
