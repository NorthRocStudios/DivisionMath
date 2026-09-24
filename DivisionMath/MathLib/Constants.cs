//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
namespace DivisionEngine.MathLib
{
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public static partial class math
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        /// <summary>
        /// The ratio of the circumference of a circle to its diameter,
        /// </summary>
        public const float PI = 3.14159265f;

        /// <summary>
        /// 2 PI
        /// </summary>
        public const float Tau = 2f * PI;

        /// <summary>
        /// E = 2.718281828
        /// </summary>
        public const float E = 2.718281828f;

        /// <summary>
        /// Multiply degrees by this to convert them to radians.
        /// </summary>
        public const float Deg2Rad = Tau / 360f;

        /// <summary>
        /// Multiply radians by this to convert them to degrees.
        /// </summary>
        public const float Rad2Deg = 360f / Tau;
    }
}
