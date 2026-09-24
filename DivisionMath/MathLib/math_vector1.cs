//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
using System.Numerics;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Provides static methods for scalar, vector, and matrix math operations that closely mirror the functionality and
    /// naming conventions of HLSL (High-Level Shading Language) intrinsic functions. Supports a wide range of
    /// mathematical operations for use in graphics, simulation, and numerical applications.
    /// </summary>
    /// <remarks>The methods in this class are designed to offer familiar HLSL-style APIs for C# developers
    /// working with mathematical types such as float, int, float2, float3, float4, and related matrix and boolean
    /// vector types. This enables easier porting of shader code and mathematical logic between HLSL and C#. All methods
    /// are static and stateless. Thread safety is guaranteed as no instance or static state is maintained. Some methods
    /// may return default values (such as zero vectors) in cases where mathematical operations are undefined (e.g.,
    /// normalization of a zero-length vector).</remarks>
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public static partial class math
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        #region float

        /// <summary>
        /// Returns the absolute value of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The absolute value of <paramref name="x"/>.</returns>
        public static float abs(float x) => float.Abs(x);
        /// <summary>
        /// Clamps the specified value to the specified minimum and maximum range.
        /// </summary>
        /// <param name="x">The value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The clamped value, which lies in the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static float clamp(float x, float min, float max) => float.Clamp(x, min, max);
        /// <summary>
        /// Performs a linear interpolation between two values.
        /// </summary>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="t">The interpolation factor, typically in the range [0, 1].</param>
        /// <returns>The result of the linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static float lerp(float x, float y, float t) => float.Lerp(x, y, t);
        /// <summary>
        /// Selects the greater of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The greater of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float max(float x, float y) => float.Max(x, y);
        /// <summary>
        /// Selects the lesser of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The lesser of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float min(float x, float y) => float.Min(x, y);
        /// <summary>
        /// Clamps the specified value to the range [0, 1].
        /// </summary>
        /// <param name="x">The value to saturate.</param>
        /// <returns>The value clamped to the range [0, 1].</returns>
        public static float saturate(float x) => float.Clamp(x, 0f, 1f);
        /// <summary>
        /// Returns the sign of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>-1 if <paramref name="x"/> is negative, 1 if positive, and 0 if <paramref name="x"/> is zero.</returns>
        public static float sign(float x) => float.Sign(x);
        /// <summary>
        /// Returns the smallest integer value that is greater than or equal to the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The ceiling of <paramref name="x"/>.</returns>
        public static float ceil(float x) => float.Ceiling(x);
        /// <summary>
        /// Returns the largest integer value that is less than or equal to the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The floor of <paramref name="x"/>.</returns>
        public static float floor(float x) => float.Floor(x);
        /// <summary>
        /// Rounds the specified value to the nearest integer.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The value of <paramref name="x"/> rounded to the nearest integer.</returns>
        public static float round(float x) => float.Round(x);
        /// <summary>
        /// Truncates the specified value toward zero to the nearest integer.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The integral part of <paramref name="x"/>, with the fractional part removed.</returns>
        public static float trunc(float x) => float.Truncate(x);
        /// <summary>
        /// Returns the fractional part of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The fractional portion of <paramref name="x"/>, computed as <c>x - floor(x)</c>.</returns>
        public static float frac(float x) => x - float.Floor(x);
        /// <summary>
        /// Returns the base-e exponential of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The value of <c>e</c> raised to the power of <paramref name="x"/>.</returns>
        public static float exp(float x) => float.Exp(x);
        /// <summary>
        /// Returns the base-2 exponential of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The value of 2 raised to the power of <paramref name="x"/>.</returns>
        public static float exp2(float x) => float.Exp2(x);
        /// <summary>
        /// Returns the natural logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The natural logarithm of <paramref name="x"/>.</returns>
        public static float log(float x) => float.Log(x);
        /// <summary>
        /// Returns the base-2 logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The base-2 logarithm of <paramref name="x"/>.</returns>
        public static float log2(float x) => float.Log2(x);
        /// <summary>
        /// Returns the base-10 logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The base-10 logarithm of <paramref name="x"/>.</returns>
        public static float log10(float x) => float.Log10(x);
        /// <summary>
        /// Returns <paramref name="x"/> raised to the power of <paramref name="y"/>.
        /// </summary>
        /// <param name="x">The base value.</param>
        /// <param name="y">The exponent value.</param>
        /// <returns>The value of <paramref name="x"/> raised to the power of <paramref name="y"/>.</returns>
        public static float pow(float x, float y) => float.Pow(x, y);
        /// <summary>
        /// Returns the reciprocal of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The reciprocal of <paramref name="x"/>, computed as <c>1 / x</c>.</returns>
        public static float rcp(float x) => float.ReciprocalEstimate(x);
        /// <summary>
        /// Returns the reciprocal of the square root of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The reciprocal square root of <paramref name="x"/>, computed as <c>1 / sqrt(x)</c>.</returns>
        public static float rsqrt(float x) => float.ReciprocalSqrtEstimate(x);
        /// <summary>
        /// Returns the square root of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The square root of <paramref name="x"/>.</returns>
        public static float sqrt(float x) => float.Sqrt(x);
        /// <summary>
        /// Returns the arccosine of the specified value.
        /// </summary>
        /// <param name="x">The input value, which should be in the range [-1, 1].</param>
        /// <returns>The arccosine of <paramref name="x"/>, in radians.</returns>
        public static float acos(float x) => float.Acos(x);
        /// <summary>
        /// Returns the arcsine of the specified value.
        /// </summary>
        /// <param name="x">The input value, which should be in the range [-1, 1].</param>
        /// <returns>The arcsine of <paramref name="x"/>, in radians.</returns>
        public static float asin(float x) => float.Asin(x);
        /// <summary>
        /// Returns the arctangent of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The arctangent of <paramref name="x"/>, in radians.</returns>
        public static float atan(float x) => float.Atan(x);
        /// <summary>
        /// Returns the arctangent of two values, using the signs of both to determine the quadrant of the result.
        /// </summary>
        /// <param name="y">The y-coordinate.</param>
        /// <param name="x">The x-coordinate.</param>
        /// <returns>The arctangent of <paramref name="y"/> / <paramref name="x"/>, in radians.</returns>
        public static float atan2(float y, float x) => float.Atan2(y, x);
        /// <summary>
        /// Returns the cosine of the specified value.
        /// </summary>
        /// <param name="x">The input angle, in radians.</param>
        /// <returns>The cosine of <paramref name="x"/>.</returns>
        public static float cos(float x) => float.Cos(x);
        /// <summary>
        /// Returns the sine of the specified value.
        /// </summary>
        /// <param name="x">The input angle, in radians.</param>
        /// <returns>The sine of <paramref name="x"/>.</returns>
        public static float sin(float x) => float.Sin(x);
        /// <summary>
        /// Returns the tangent of the specified value.
        /// </summary>
        /// <param name="x">The input angle, in radians.</param>
        /// <returns>The tangent of <paramref name="x"/>.</returns>
        public static float tan(float x) => float.Tan(x);
        /// <summary>
        /// Converts the specified value from degrees to radians.
        /// </summary>
        /// <param name="x">The angle in degrees.</param>
        /// <returns>The angle <paramref name="x"/> converted to radians.</returns>
        public static float radians(float x) => float.DegreesToRadians(x);
        /// <summary>
        /// Converts the specified value from radians to degrees.
        /// </summary>
        /// <param name="x">The angle in radians.</param>
        /// <returns>The angle <paramref name="x"/> converted to degrees.</returns>
        public static float degrees(float x) => float.RadiansToDegrees(x);
        /// <summary>
        /// Determines whether the specified value is finite.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is finite; otherwise, <see langword="false"/>.</returns>
        public static bool isfinite(float x) => float.IsFinite(x);
        /// <summary>
        /// Determines whether the specified value is an infinity.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is positive or negative infinity; otherwise, <see langword="false"/>.</returns>
        public static bool isinf(float x) => float.IsInfinity(x);
        /// <summary>
        /// Determines whether the specified value is Not-a-Number (NaN).
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is NaN; otherwise, <see langword="false"/>.</returns>
        public static bool isnan(float x) => float.IsNaN(x);

        // Implement in future:
        //public static float frexp(float x, out int exp)
        //{
        //    if (float.IsNaN(x) || float.IsInfinity(x) || x == 0f)
        //    {
        //        exp = 0;
        //        return x;
        //    }

        //    // Get the bits
        //    int bits = BitConverter.SingleToInt32Bits(x);
        //    int exponent = (bits >> 23) & 0xFF;
        //    int mantissa = bits & 0x7FFFFF;

        //    // Extract exponent (biased)
        //    exponent = exponent - 127;

        //    // Normalize denormals
        //    if (exponent == -127)
        //    {
        //        // Denormal number - find the true exponent
        //        int leadingZeros = 0;
        //        int temp = mantissa;
        //        while ((temp & 0x400000) == 0)
        //        {
        //            temp <<= 1;
        //            leadingZeros++;
        //        }
        //        mantissa <<= (leadingZeros + 1);
        //        exponent = -126 - leadingZeros;
        //    }

        //    exp = exponent;

        //    // Build the mantissa result
        //    // Set sign bit, exponent = 0 (biased to 127), keep mantissa
        //    int resultBits = (int)((bits & 0x80000000) | (0x7F << 23) | (mantissa & 0x7FFFFF));
        //    return BitConverter.Int32BitsToSingle(resultBits);
        //}

        #endregion float
        #region double

        /// <summary>
        /// Returns the absolute value of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The absolute value of <paramref name="x"/>.</returns>
        public static double abs(double x) => double.Abs(x);
        /// <summary>
        /// Clamps the specified value to the specified minimum and maximum range.
        /// </summary>
        /// <param name="x">The value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The clamped value, which lies in the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static double clamp(double x, double min, double max) => double.Clamp(x, min, max);
        /// <summary>
        /// Performs a linear interpolation between two values.
        /// </summary>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="t">The interpolation factor, typically in the range [0, 1].</param>
        /// <returns>The result of the linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static double lerp(double x, double y, double t) => double.Lerp(x, y, t);
        /// <summary>
        /// Selects the greater of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The greater of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double max(double x, double y) => double.Max(x, y);
        /// <summary>
        /// Selects the lesser of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The lesser of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double min(double x, double y) => double.Min(x, y);
        /// <summary>
        /// Clamps the specified value to the range [0, 1].
        /// </summary>
        /// <param name="x">The value to saturate.</param>
        /// <returns>The value clamped to the range [0, 1].</returns>
        public static double saturate(double x) => double.Clamp(x, 0.0, 1.0);
        /// <summary>
        /// Returns the sign of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>-1 if <paramref name="x"/> is negative, 1 if positive, and 0 if <paramref name="x"/> is zero.</returns>
        public static double sign(double x) => double.Sign(x);
        /// <summary>
        /// Returns the smallest integer value that is greater than or equal to the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The ceiling of <paramref name="x"/>.</returns>
        public static double ceil(double x) => double.Ceiling(x);
        /// <summary>
        /// Returns the largest integer value that is less than or equal to the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The floor of <paramref name="x"/>.</returns>
        public static double floor(double x) => double.Floor(x);
        /// <summary>
        /// Rounds the specified value to the nearest integer.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The value of <paramref name="x"/> rounded to the nearest integer.</returns>
        public static double round(double x) => double.Round(x);
        /// <summary>
        /// Truncates the specified value toward zero to the nearest integer.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The integral part of <paramref name="x"/>, with the fractional part removed.</returns>
        public static double trunc(double x) => double.Truncate(x);
        /// <summary>
        /// Returns the fractional part of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The fractional portion of <paramref name="x"/>, computed as <c>x - floor(x)</c>.</returns>
        public static double frac(double x) => x - double.Floor(x);
        /// <summary>
        /// Returns the base-e exponential of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The value of <c>e</c> raised to the power of <paramref name="x"/>.</returns>
        public static double exp(double x) => double.Exp(x);
        /// <summary>
        /// Returns the base-2 exponential of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The value of 2 raised to the power of <paramref name="x"/>.</returns>
        public static double exp2(double x) => double.Exp2(x);
        /// <summary>
        /// Returns the natural logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The natural logarithm of <paramref name="x"/>.</returns>
        public static double log(double x) => double.Log(x);
        /// <summary>
        /// Returns the base-2 logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The base-2 logarithm of <paramref name="x"/>.</returns>
        public static double log2(double x) => double.Log2(x);
        /// <summary>
        /// Returns the base-10 logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The base-10 logarithm of <paramref name="x"/>.</returns>
        public static double log10(double x) => double.Log10(x);
        /// <summary>
        /// Returns <paramref name="x"/> raised to the power of <paramref name="y"/>.
        /// </summary>
        /// <param name="x">The base value.</param>
        /// <param name="y">The exponent value.</param>
        /// <returns>The value of <paramref name="x"/> raised to the power of <paramref name="y"/>.</returns>
        public static double pow(double x, double y) => double.Pow(x, y);
        /// <summary>
        /// Returns the reciprocal of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The reciprocal of <paramref name="x"/>, computed as <c>1 / x</c>.</returns>
        public static double rcp(double x) => double.ReciprocalEstimate(x);
        /// <summary>
        /// Returns the reciprocal of the square root of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The reciprocal square root of <paramref name="x"/>, computed as <c>1 / sqrt(x)</c>.</returns>
        public static double rsqrt(double x) => double.ReciprocalSqrtEstimate(x);
        /// <summary>
        /// Returns the square root of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The square root of <paramref name="x"/>.</returns>
        public static double sqrt(double x) => double.Sqrt(x);
        /// <summary>
        /// Returns the arccosine of the specified value.
        /// </summary>
        /// <param name="x">The input value, which should be in the range [-1, 1].</param>
        /// <returns>The arccosine of <paramref name="x"/>, in radians.</returns>
        public static double acos(double x) => double.Acos(x);
        /// <summary>
        /// Returns the arcsine of the specified value.
        /// </summary>
        /// <param name="x">The input value, which should be in the range [-1, 1].</param>
        /// <returns>The arcsine of <paramref name="x"/>, in radians.</returns>
        public static double asin(double x) => double.Asin(x);
        /// <summary>
        /// Returns the arctangent of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The arctangent of <paramref name="x"/>, in radians.</returns>
        public static double atan(double x) => double.Atan(x);
        /// <summary>
        /// Returns the arctangent of two values, using the signs of both to determine the quadrant of the result.
        /// </summary>
        /// <param name="y">The y-coordinate.</param>
        /// <param name="x">The x-coordinate.</param>
        /// <returns>The arctangent of <paramref name="y"/> / <paramref name="x"/>, in radians.</returns>
        public static double atan2(double y, double x) => double.Atan2(y, x);
        /// <summary>
        /// Returns the cosine of the specified value.
        /// </summary>
        /// <param name="x">The input angle, in radians.</param>
        /// <returns>The cosine of <paramref name="x"/>.</returns>
        public static double cos(double x) => double.Cos(x);
        /// <summary>
        /// Returns the sine of the specified value.
        /// </summary>
        /// <param name="x">The input angle, in radians.</param>
        /// <returns>The sine of <paramref name="x"/>.</returns>
        public static double sin(double x) => double.Sin(x);
        /// <summary>
        /// Returns the tangent of the specified value.
        /// </summary>
        /// <param name="x">The input angle, in radians.</param>
        /// <returns>The tangent of <paramref name="x"/>.</returns>
        public static double tan(double x) => double.Tan(x);
        /// <summary>
        /// Converts the specified value from degrees to radians.
        /// </summary>
        /// <param name="x">The angle in degrees.</param>
        /// <returns>The angle <paramref name="x"/> converted to radians.</returns>
        public static double radians(double x) => double.DegreesToRadians(x);
        /// <summary>
        /// Converts the specified value from radians to degrees.
        /// </summary>
        /// <param name="x">The angle in radians.</param>
        /// <returns>The angle <paramref name="x"/> converted to degrees.</returns>
        public static double degrees(double x) => double.RadiansToDegrees(x);
        /// <summary>
        /// Determines whether the specified value is finite.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is finite; otherwise, <see langword="false"/>.</returns>
        public static bool isfinite(double x) => double.IsFinite(x);
        /// <summary>
        /// Determines whether the specified value is an infinity.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is positive or negative infinity; otherwise, <see langword="false"/>.</returns>
        public static bool isinf(double x) => double.IsInfinity(x);
        /// <summary>
        /// Determines whether the specified value is Not-a-Number (NaN).
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is NaN; otherwise, <see langword="false"/>.</returns>
        public static bool isnan(double x) => double.IsNaN(x);

        #endregion double
        #region half

        // No equivalent in C#, will automatically translate correctly regardless

        #endregion half
        #region int

        /// <summary>
        /// Returns the absolute value of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The absolute value of <paramref name="x"/>.</returns>
        public static int abs(int x) => int.Abs(x);
        /// <summary>
        /// Clamps the specified value to the specified minimum and maximum range.
        /// </summary>
        /// <param name="x">The value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The clamped value, which lies in the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static int clamp(int x, int min, int max) => int.Clamp(x, min, max);
        /// <summary>
        /// Selects the greater of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The greater of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static int max(int x, int y) => int.Max(x, y);
        /// <summary>
        /// Selects the lesser of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The lesser of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static int min(int x, int y) => int.Min(x, y);
        /// <summary>
        /// Returns the sign of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>-1 if <paramref name="x"/> is negative, 1 if positive, and 0 if <paramref name="x"/> is zero.</returns>
        public static int sign(int x) => int.Sign(x);
        /// <summary>
        /// Returns the base-2 logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The base-2 logarithm of <paramref name="x"/>.</returns>
        public static int log2(int x) => int.Log2(x);

        /// <summary>
        /// Counts the number of set bits in the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The population count (number of bits set to 1) of <paramref name="x"/>.</returns>
        public static int countbits(int x) => BitOperations.PopCount((uint)x);
        /// <summary>
        /// Returns the location of the first set bit, starting from the highest order bit.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The zero-based index of the highest-order set bit in <paramref name="x"/>, or -1 if no bits are set.</returns>
        public static int firstbithigh(int x) => 31 - BitOperations.LeadingZeroCount((uint)x);
        /// <summary>
        /// Returns the location of the first set bit, starting from the lowest order bit.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The zero-based index of the lowest-order set bit in <paramref name="x"/>, or 32 if no bits are set.</returns>
        public static int firstbitlow(int x) => BitOperations.TrailingZeroCount((uint)x);
        //public static int reversebits(int x) => (int)BitOperations.ReverseBits((uint)x); - Finish implementing this

        #endregion int
        #region uint

        /// <summary>
        /// Clamps the specified value to the specified minimum and maximum range.
        /// </summary>
        /// <param name="x">The value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The clamped value, which lies in the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static uint clamp(uint x, uint min, uint max) => uint.Clamp(x, min, max);
        /// <summary>
        /// Selects the greater of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The greater of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static uint max(uint x, uint y) => uint.Max(x, y);
        /// <summary>
        /// Selects the lesser of two values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>The lesser of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static uint min(uint x, uint y) => uint.Min(x, y);
        /// <summary>
        /// Returns the base-2 logarithm of the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The base-2 logarithm of <paramref name="x"/>.</returns>
        public static uint log2(uint x) => uint.Log2(x);

        /// <summary>
        /// Counts the number of set bits in the specified value.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The population count (number of bits set to 1) of <paramref name="x"/>.</returns>
        public static int countbits(uint x) => BitOperations.PopCount(x);
        /// <summary>
        /// Returns the location of the first set bit, starting from the highest order bit.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The zero-based index of the highest-order set bit in <paramref name="x"/>, or -1 if no bits are set.</returns>
        public static int firstbithigh(uint x) => 31 - BitOperations.LeadingZeroCount(x);
        /// <summary>
        /// Returns the location of the first set bit, starting from the lowest order bit.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The zero-based index of the lowest-order set bit in <paramref name="x"/>, or 32 if no bits are set.</returns>
        public static int firstbitlow(uint x) => BitOperations.TrailingZeroCount(x);
        //public static uint reversebits(uint x) => BitOperations.ReverseBits(x); - Finish implementing this

        #endregion uint
        #region bool

        /// <summary>
        /// Determines whether the specified boolean value is <see langword="true"/>.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is <see langword="true"/>; otherwise, <see langword="false"/>.</returns>
        public static bool any(bool x) => x;
        /// <summary>
        /// Determines whether the specified boolean value is <see langword="true"/>.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns><see langword="true"/> if <paramref name="x"/> is <see langword="true"/>; otherwise, <see langword="false"/>.</returns>
        public static bool all(bool x) => x;

        #endregion bool
        #region interpretation

        /// <summary>
        /// Reinterprets the bit pattern of a <see cref="float"/> as a signed 32-bit integer.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The bit pattern of <paramref name="x"/> reinterpreted as an <see cref="int"/>.</returns>
        public static int asint(float x) => BitConverter.SingleToInt32Bits(x);
        /// <summary>
        /// Reinterprets the bit pattern of a <see cref="float"/> as an unsigned 32-bit integer.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The bit pattern of <paramref name="x"/> reinterpreted as a <see cref="uint"/>.</returns>
        public static uint asuint(float x) => BitConverter.SingleToUInt32Bits(x);
        /// <summary>
        /// Reinterprets the bit pattern of a signed 32-bit integer as a <see cref="float"/>.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The bit pattern of <paramref name="x"/> reinterpreted as a <see cref="float"/>.</returns>
        public static float asfloat(int x) => BitConverter.Int32BitsToSingle(x);
        /// <summary>
        /// Reinterprets the bit pattern of an unsigned 32-bit integer as a <see cref="float"/>.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The bit pattern of <paramref name="x"/> reinterpreted as a <see cref="float"/>.</returns>
        public static float asfloat(uint x) => BitConverter.UInt32BitsToSingle(x);

        #endregion interpretation
        #region noise

        /// <summary>
        /// Returns itself, noise is not deterministic and varies per GPU device.
        /// </summary>
        /// <returns>Input (x)</returns>
        /// <remarks>This is only for compatibility and is not useful on the C# CPU side</remarks>
        public static float noise(float x) => x;
        // Implement true noise here later

        #endregion noise
    }
}
