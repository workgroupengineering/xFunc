// Copyright 2012-2020 Dmytro Kyshchenko
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
using xFunc.Maths.Expressions.Angles;

namespace xFunc.Maths
{
    /// <summary>
    /// Extension method for <see cref="AngleValue"/>.
    /// </summary>
    internal static class AngleExtensions
    {
        /// <summary>
        /// The 'sin' function.
        /// </summary>
        /// <param name="angleValue">The angle number.</param>
        /// <returns>The result of sine function.</returns>
        public static double Sin(this AngleValue angleValue)
        {
            var value = angleValue.Normalize().Value;

            // 0
            if (MathExtensions.Equals(value, 0))
                return MathExtensions.Zero;

            // 30
            if (MathExtensions.Equals(value, Math.PI / 6))
                return MathExtensions.Half;

            // 45
            if (MathExtensions.Equals(value, Math.PI / 4))
                return MathExtensions.Sqrt2By2;

            // 60
            if (MathExtensions.Equals(value, Math.PI / 3))
                return MathExtensions.Sqrt3By2;

            // 90
            if (MathExtensions.Equals(value, Math.PI / 2))
                return MathExtensions.One;

            // 120
            if (MathExtensions.Equals(value, 2 * Math.PI / 3))
                return MathExtensions.Sqrt3By2;

            // 135
            if (MathExtensions.Equals(value, 3 * Math.PI / 4))
                return MathExtensions.Sqrt2By2;

            // 150
            if (MathExtensions.Equals(value, 5 * Math.PI / 6))
                return MathExtensions.Half;

            // 180
            if (MathExtensions.Equals(value, Math.PI))
                return MathExtensions.Zero;

            // 210
            if (MathExtensions.Equals(value, 7 * Math.PI / 6))
                return -MathExtensions.Half;

            // 225
            if (MathExtensions.Equals(value, 5 * Math.PI / 4))
                return -MathExtensions.Sqrt2By2;

            // 240
            if (MathExtensions.Equals(value, 4 * Math.PI / 3))
                return -MathExtensions.Sqrt3By2;

            // 270
            if (MathExtensions.Equals(value, 3 * Math.PI / 2))
                return -MathExtensions.One;

            // 300
            if (MathExtensions.Equals(value, 5 * Math.PI / 3))
                return -MathExtensions.Sqrt3By2;

            // 315
            if (MathExtensions.Equals(value, 7 * Math.PI / 4))
                return -MathExtensions.Sqrt2By2;

            // 330
            if (MathExtensions.Equals(value, 11 * Math.PI / 6))
                return -MathExtensions.Half;

            return Math.Sin(angleValue.Value);
        }

        /// <summary>
        /// The 'cos' function.
        /// </summary>
        /// <param name="angleValue">The angle number.</param>
        /// <returns>The result of cosine function.</returns>
        public static double Cos(this AngleValue angleValue)
        {
            var value = angleValue.Normalize().Value;

            // 0
            if (MathExtensions.Equals(value, 0))
                return MathExtensions.One;

            // 30
            if (MathExtensions.Equals(value, Math.PI / 6))
                return MathExtensions.Sqrt3By2;

            // 45
            if (MathExtensions.Equals(value, Math.PI / 4))
                return MathExtensions.Sqrt2By2;

            // 60
            if (MathExtensions.Equals(value, Math.PI / 3))
                return MathExtensions.Half;

            // 90
            if (MathExtensions.Equals(value, Math.PI / 2))
                return MathExtensions.Zero;

            // 120
            if (MathExtensions.Equals(value, 2 * Math.PI / 3))
                return -MathExtensions.Half;

            // 135
            if (MathExtensions.Equals(value, 3 * Math.PI / 4))
                return -MathExtensions.Sqrt2By2;

            // 150
            if (MathExtensions.Equals(value, 5 * Math.PI / 6))
                return -MathExtensions.Sqrt3By2;

            // 180
            if (MathExtensions.Equals(value, Math.PI))
                return -MathExtensions.One;

            // 210
            if (MathExtensions.Equals(value, 7 * Math.PI / 6))
                return -MathExtensions.Sqrt3By2;

            // 225
            if (MathExtensions.Equals(value, 5 * Math.PI / 4))
                return -MathExtensions.Sqrt2By2;

            // 240
            if (MathExtensions.Equals(value, 4 * Math.PI / 3))
                return -MathExtensions.Half;

            // 270
            if (MathExtensions.Equals(value, 3 * Math.PI / 2))
                return MathExtensions.Zero;

            // 300
            if (MathExtensions.Equals(value, 5 * Math.PI / 3))
                return MathExtensions.Half;

            // 315
            if (MathExtensions.Equals(value, 7 * Math.PI / 4))
                return MathExtensions.Sqrt2By2;

            // 330
            if (MathExtensions.Equals(value, 11 * Math.PI / 6))
                return MathExtensions.Sqrt3By2;

            return Math.Cos(angleValue.Value);
        }

        /// <summary>
        /// The 'tan' function.
        /// </summary>
        /// <param name="angleValue">The angle number.</param>
        /// <returns>The result of tangent function.</returns>
        public static double Tan(this AngleValue angleValue)
        {
            var value = angleValue.Normalize().Value;

            // 0
            if (MathExtensions.Equals(value, 0))
                return MathExtensions.Zero;

            // 30
            if (MathExtensions.Equals(value, Math.PI / 6))
                return MathExtensions.Sqrt3By3;

            // 45
            if (MathExtensions.Equals(value, Math.PI / 4))
                return MathExtensions.One;

            // 60
            if (MathExtensions.Equals(value, Math.PI / 3))
                return MathExtensions.Sqrt3;

            // 90
            if (MathExtensions.Equals(value, Math.PI / 2))
                return double.PositiveInfinity;

            // 120
            if (MathExtensions.Equals(value, 2 * Math.PI / 3))
                return -MathExtensions.Sqrt3;

            // 135
            if (MathExtensions.Equals(value, 3 * Math.PI / 4))
                return -MathExtensions.One;

            // 150
            if (MathExtensions.Equals(value, 5 * Math.PI / 6))
                return -MathExtensions.Sqrt3By3;

            // 180
            if (MathExtensions.Equals(value, Math.PI))
                return MathExtensions.Zero;

            // 210
            if (MathExtensions.Equals(value, 7 * Math.PI / 6))
                return MathExtensions.Sqrt3By3;

            // 225
            if (MathExtensions.Equals(value, 5 * Math.PI / 4))
                return MathExtensions.One;

            // 240
            if (MathExtensions.Equals(value, 4 * Math.PI / 3))
                return MathExtensions.Sqrt3;

            // 270
            if (MathExtensions.Equals(value, 3 * Math.PI / 2))
                return double.PositiveInfinity;

            // 300
            if (MathExtensions.Equals(value, 5 * Math.PI / 3))
                return -MathExtensions.Sqrt3;

            // 315
            if (MathExtensions.Equals(value, 7 * Math.PI / 4))
                return -MathExtensions.One;

            // 330
            if (MathExtensions.Equals(value, 11 * Math.PI / 6))
                return -MathExtensions.Sqrt3By3;

            return Math.Tan(angleValue.Value);
        }

        /// <summary>
        /// The 'cot' function.
        /// </summary>
        /// <param name="angleValue">The angle number.</param>
        /// <returns>The result of cotangent function.</returns>
        public static double Cot(this AngleValue angleValue)
        {
            var value = angleValue.Normalize().Value;

            // 0
            if (MathExtensions.Equals(value, 0))
                return double.PositiveInfinity;

            // 30
            if (MathExtensions.Equals(value, Math.PI / 6))
                return MathExtensions.Sqrt3;

            // 45
            if (MathExtensions.Equals(value, Math.PI / 4))
                return MathExtensions.One;

            // 60
            if (MathExtensions.Equals(value, Math.PI / 3))
                return MathExtensions.Sqrt3By3;

            // 90
            if (MathExtensions.Equals(value, Math.PI / 2))
                return MathExtensions.Zero;

            // 120
            if (MathExtensions.Equals(value, 2 * Math.PI / 3))
                return -MathExtensions.Sqrt3By3;

            // 135
            if (MathExtensions.Equals(value, 3 * Math.PI / 4))
                return -MathExtensions.One;

            // 150
            if (MathExtensions.Equals(value, 5 * Math.PI / 6))
                return -MathExtensions.Sqrt3;

            // 180
            if (MathExtensions.Equals(value, Math.PI))
                return double.PositiveInfinity;

            // 210
            if (MathExtensions.Equals(value, 7 * Math.PI / 6))
                return MathExtensions.Sqrt3;

            // 225
            if (MathExtensions.Equals(value, 5 * Math.PI / 4))
                return MathExtensions.One;

            // 240
            if (MathExtensions.Equals(value, 4 * Math.PI / 3))
                return MathExtensions.Sqrt3By3;

            // 270
            if (MathExtensions.Equals(value, 3 * Math.PI / 2))
                return MathExtensions.Zero;

            // 300
            if (MathExtensions.Equals(value, 5 * Math.PI / 3))
                return -MathExtensions.Sqrt3;

            // 315
            if (MathExtensions.Equals(value, 7 * Math.PI / 4))
                return -MathExtensions.One;

            // 330
            if (MathExtensions.Equals(value, 11 * Math.PI / 6))
                return -MathExtensions.Sqrt3By3;

            return MathExtensions.Cot(angleValue.Value);
        }

        /// <summary>
        /// The 'cot' function.
        /// </summary>
        /// <param name="angleValue">The angle number.</param>
        /// <returns>The result of secant function.</returns>
        public static double Sec(this AngleValue angleValue)
        {
            var value = angleValue.Normalize().Value;

            // 0
            if (MathExtensions.Equals(value, 0))
                return MathExtensions.One;

            // 30
            if (MathExtensions.Equals(value, Math.PI / 6))
                return MathExtensions.Sqrt3By3By2;

            // 45
            if (MathExtensions.Equals(value, Math.PI / 4))
                return MathExtensions.Sqrt2;

            // 60
            if (MathExtensions.Equals(value, Math.PI / 3))
                return MathExtensions.Two;

            // 90
            if (MathExtensions.Equals(value, Math.PI / 2))
                return double.PositiveInfinity;

            // 120
            if (MathExtensions.Equals(value, 2 * Math.PI / 3))
                return -MathExtensions.Two;

            // 135
            if (MathExtensions.Equals(value, 3 * Math.PI / 4))
                return -MathExtensions.Sqrt2;

            // 150
            if (MathExtensions.Equals(value, 5 * Math.PI / 6))
                return -MathExtensions.Sqrt3By3By2;

            // 180
            if (MathExtensions.Equals(value, Math.PI))
                return -MathExtensions.One;

            // 210
            if (MathExtensions.Equals(value, 7 * Math.PI / 6))
                return -MathExtensions.Sqrt3By3By2;

            // 225
            if (MathExtensions.Equals(value, 5 * Math.PI / 4))
                return -MathExtensions.Sqrt2;

            // 240
            if (MathExtensions.Equals(value, 4 * Math.PI / 3))
                return -MathExtensions.Two;

            // 270
            if (MathExtensions.Equals(value, 3 * Math.PI / 2))
                return double.PositiveInfinity;

            // 300
            if (MathExtensions.Equals(value, 5 * Math.PI / 3))
                return -MathExtensions.Two;

            // 315
            if (MathExtensions.Equals(value, 7 * Math.PI / 4))
                return MathExtensions.Sqrt2;

            // 330
            if (MathExtensions.Equals(value, 11 * Math.PI / 6))
                return MathExtensions.Sqrt3By3By2;

            return MathExtensions.Sec(angleValue.Value);
        }

        /// <summary>
        /// The 'csc' function.
        /// </summary>
        /// <param name="angleValue">The angle number.</param>
        /// <returns>The result of cosecant function.</returns>
        public static double Csc(this AngleValue angleValue)
        {
            var value = angleValue.Normalize().Value;

            // 0
            if (MathExtensions.Equals(value, 0))
                return double.PositiveInfinity;

            // 30
            if (MathExtensions.Equals(value, Math.PI / 6))
                return MathExtensions.Two;

            // 45
            if (MathExtensions.Equals(value, Math.PI / 4))
                return MathExtensions.Sqrt2;

            // 60
            if (MathExtensions.Equals(value, Math.PI / 3))
                return MathExtensions.Sqrt3By3By2;

            // 90
            if (MathExtensions.Equals(value, Math.PI / 2))
                return MathExtensions.One;

            // 120
            if (MathExtensions.Equals(value, 2 * Math.PI / 3))
                return MathExtensions.Sqrt3By3By2;

            // 135
            if (MathExtensions.Equals(value, 3 * Math.PI / 4))
                return MathExtensions.Sqrt2;

            // 150
            if (MathExtensions.Equals(value, 5 * Math.PI / 6))
                return MathExtensions.Two;

            // 180
            if (MathExtensions.Equals(value, Math.PI))
                return double.PositiveInfinity;

            // 210
            if (MathExtensions.Equals(value, 7 * Math.PI / 6))
                return -MathExtensions.Two;

            // 225
            if (MathExtensions.Equals(value, 5 * Math.PI / 4))
                return -MathExtensions.Sqrt2;

            // 240
            if (MathExtensions.Equals(value, 4 * Math.PI / 3))
                return -MathExtensions.Sqrt3By3By2;

            // 270
            if (MathExtensions.Equals(value, 3 * Math.PI / 2))
                return -MathExtensions.One;

            // 300
            if (MathExtensions.Equals(value, 5 * Math.PI / 3))
                return MathExtensions.Sqrt3By3By2;

            // 315
            if (MathExtensions.Equals(value, 7 * Math.PI / 4))
                return MathExtensions.Sqrt2;

            // 330
            if (MathExtensions.Equals(value, 11 * Math.PI / 6))
                return MathExtensions.Two;

            return MathExtensions.Csc(angleValue.Value);
        }
    }
}