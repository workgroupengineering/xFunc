﻿// Copyright 2012-2014 Dmitry Kischenko
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
using xFunc.UnitConverters.Resources;

namespace xFunc.UnitConverters
{

    /// <summary>
    /// Represents the length converter.
    /// </summary>
    public class LengthConverter : Converter<LengthUnits>
    {

        static LengthConverter()
        {
            BaseUnit = LengthUnits.Metres;

            RegisterConversion(LengthUnits.Nanometres, l => l / 0.000000001, l => l * 0.000000001);
            RegisterConversion(LengthUnits.Micrometers, l => l / 0.000001, l => l * 0.000001);
            RegisterConversion(LengthUnits.Millimeters, l => l / 0.001, l => l * 0.001);
            RegisterConversion(LengthUnits.Centimeters, l => l / 0.01, l => l * 0.01);
            RegisterConversion(LengthUnits.Kilometers, l => l / 1000, l => l * 1000);
            RegisterConversion(LengthUnits.Inches, l => l / 0.0254, l => l * 0.0254);
            RegisterConversion(LengthUnits.Feet, l => l / 0.3048, l => l * 0.3048);
            RegisterConversion(LengthUnits.Yards, l => l / 0.9144, l => l * 0.9144);
            RegisterConversion(LengthUnits.Miles, l => l / 1609.344, l => l * 1609.344);
            RegisterConversion(LengthUnits.NauticalMiles, l => l / 1852, l => l * 1852);
            RegisterConversion(LengthUnits.Fathoms, l => l / 1.82880, l => l * 1.82880);
            RegisterConversion(LengthUnits.Chains, l => l / 20.1168, l => l * 20.1168);
            RegisterConversion(LengthUnits.Rods, l => l * 0.198838782, l => l / 0.198838782);
            RegisterConversion(LengthUnits.AstronomicalUnits, l => l / 149597870700, l => l * 149597870700);
            RegisterConversion(LengthUnits.LightYears, l => l / 9460528400000000, l => l * 9460528400000000);
            RegisterConversion(LengthUnits.Parsecs, l => l / 30856775800000000, l => l * 30856775800000000);
        }

        /// <summary>
        /// Gets the name of this converter.
        /// </summary>
        /// <value>
        /// The name of this converter.
        /// </value>
        public override string Name
        {
            get
            {
                return Resource.LengthConverterName;
            }
        }

    }

}
