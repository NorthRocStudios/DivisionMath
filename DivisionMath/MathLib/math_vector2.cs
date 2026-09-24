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
        #region float

        /// <summary>
        /// Returns the component-wise absolute value of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the absolute value of each component of <paramref name="x"/>.</returns>
        public static float2 abs(float2 x) => new float2(float.Abs(x.x), float.Abs(x.y));
        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static float2 clamp(float2 x, float2 min, float2 max) => new float2(float.Clamp(x.x, min.x, max.x), float.Clamp(x.y, min.y, max.y));
        /// <summary>
        /// Clamps each component of the specified vector to the specified minimum and maximum scalar range.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The minimum value applied to each component.</param>
        /// <param name="max">The maximum value applied to each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static float2 clamp(float2 x, float min, float max) => new float2(float.Clamp(x.x, min, max), float.Clamp(x.y, min, max));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a scalar interpolation factor.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The interpolation factor, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static float2 lerp(float2 x, float2 y, float t) => new float2(float.Lerp(x.x, y.x, t), float.Lerp(x.y, y.y, t));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a per-component interpolation factor vector.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The per-component interpolation factors, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static float2 lerp(float2 x, float2 y, float2 t) => new float2(float.Lerp(x.x, y.x, t.x), float.Lerp(x.y, y.y, t.y));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float2 max(float2 x, float2 y) => new float2(float.Max(x.x, y.x), float.Max(x.y, y.y));
        /// <summary>
        /// Selects the greater of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float2 max(float2 x, float y) => new float2(float.Max(x.x, y), float.Max(x.y, y));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float2 min(float2 x, float2 y) => new float2(float.Min(x.x, y.x), float.Min(x.y, y.y));
        /// <summary>
        /// Selects the lesser of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float2 min(float2 x, float y) => new float2(float.Min(x.x, y), float.Min(x.y, y));
        /// <summary>
        /// Clamps each component of the specified vector to the range [0, 1].
        /// </summary>
        /// <param name="x">The vector to saturate.</param>
        /// <returns>A vector with each component clamped to the range [0, 1].</returns>
        public static float2 saturate(float2 x) => new float2(float.Clamp(x.x, 0f, 1f), float.Clamp(x.y, 0f, 1f));
        /// <summary>
        /// Returns the sign of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is -1, 0, or 1 depending on the sign of the corresponding component of <paramref name="x"/>.</returns>
        public static float2 sign(float2 x) => new float2(float.Sign(x.x), float.Sign(x.y));
        /// <summary>
        /// Returns the ceiling of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise ceiling of <paramref name="x"/>.</returns>
        public static float2 ceil(float2 x) => new float2(float.Ceiling(x.x), float.Ceiling(x.y));
        /// <summary>
        /// Returns the floor of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise floor of <paramref name="x"/>.</returns>
        public static float2 floor(float2 x) => new float2(float.Floor(x.x), float.Floor(x.y));
        /// <summary>
        /// Rounds each component of the specified vector to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise rounded values of <paramref name="x"/>.</returns>
        public static float2 round(float2 x) => new float2(float.Round(x.x), float.Round(x.y));
        /// <summary>
        /// Truncates each component of the specified vector toward zero to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise integral parts of <paramref name="x"/>.</returns>
        public static float2 trunc(float2 x) => new float2(float.Truncate(x.x), float.Truncate(x.y));
        /// <summary>
        /// Returns the fractional part of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static float2 frac(float2 x) => new float2(x.x - float.Floor(x.x), x.y - float.Floor(x.y));
        /// <summary>
        /// Returns the base-e exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-e exponentials of <paramref name="x"/>.</returns>
        public static float2 exp(float2 x) => new float2(float.Exp(x.x), float.Exp(x.y));
        /// <summary>
        /// Returns the base-2 exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 exponentials of <paramref name="x"/>.</returns>
        public static float2 exp2(float2 x) => new float2(float.Exp2(x.x), float.Exp2(x.y));
        /// <summary>
        /// Returns the natural logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise natural logarithms of <paramref name="x"/>.</returns>
        public static float2 log(float2 x) => new float2(float.Log(x.x), float.Log(x.y));
        /// <summary>
        /// Returns the base-2 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 logarithms of <paramref name="x"/>.</returns>
        public static float2 log2(float2 x) => new float2(float.Log2(x.x), float.Log2(x.y));
        /// <summary>
        /// Returns the base-10 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-10 logarithms of <paramref name="x"/>.</returns>
        public static float2 log10(float2 x) => new float2(float.Log10(x.x), float.Log10(x.y));
        /// <summary>
        /// Raises each component of a vector to the power of the corresponding component of another vector.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The exponent vector.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static float2 pow(float2 x, float2 y) => new float2(float.Pow(x.x, y.x), float.Pow(x.y, y.y));
        /// <summary>
        /// Raises each component of a vector to the power of a scalar value.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The scalar exponent.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static float2 pow(float2 x, float y) => new float2(float.Pow(x.x, y), float.Pow(x.y, y));
        /// <summary>
        /// Returns the reciprocal of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocals of <paramref name="x"/>.</returns>
        public static float2 rcp(float2 x) => new float2(1f / x.x, 1f / x.y);
        /// <summary>
        /// Returns the reciprocal of the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocal square roots of <paramref name="x"/>.</returns>
        public static float2 rsqrt(float2 x) => new float2(1f / float.Sqrt(x.x), 1f / float.Sqrt(x.y));
        /// <summary>
        /// Returns the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise square roots of <paramref name="x"/>.</returns>
        public static float2 sqrt(float2 x) => new float2(float.Sqrt(x.x), float.Sqrt(x.y));
        /// <summary>
        /// Returns the arccosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arccosines of <paramref name="x"/>, in radians.</returns>
        public static float2 acos(float2 x) => new float2(float.Acos(x.x), float.Acos(x.y));
        /// <summary>
        /// Returns the arcsine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arcsines of <paramref name="x"/>, in radians.</returns>
        public static float2 asin(float2 x) => new float2(float.Asin(x.x), float.Asin(x.y));
        /// <summary>
        /// Returns the arctangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="x"/>, in radians.</returns>
        public static float2 atan(float2 x) => new float2(float.Atan(x.x), float.Atan(x.y));
        /// <summary>
        /// Returns the component-wise arctangent of two vectors, using the signs of both to determine the quadrant of each result.
        /// </summary>
        /// <param name="y">The y-coordinate vector.</param>
        /// <param name="x">The x-coordinate vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="y"/> / <paramref name="x"/>, in radians.</returns>
        public static float2 atan2(float2 y, float2 x) => new float2(float.Atan2(y.x, x.x), float.Atan2(y.y, x.y));
        /// <summary>
        /// Returns the cosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise cosines of <paramref name="x"/>.</returns>
        public static float2 cos(float2 x) => new float2(float.Cos(x.x), float.Cos(x.y));
        /// <summary>
        /// Returns the sine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise sines of <paramref name="x"/>.</returns>
        public static float2 sin(float2 x) => new float2(float.Sin(x.x), float.Sin(x.y));
        /// <summary>
        /// Returns the tangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise tangents of <paramref name="x"/>.</returns>
        public static float2 tan(float2 x) => new float2(float.Tan(x.x), float.Tan(x.y));
        /// <summary>
        /// Converts each component of the specified vector from degrees to radians.
        /// </summary>
        /// <param name="x">The vector of angles in degrees.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to radians.</returns>
        public static float2 radians(float2 x) => new float2(float.DegreesToRadians(x.x), float.DegreesToRadians(x.y));
        /// <summary>
        /// Converts each component of the specified vector from radians to degrees.
        /// </summary>
        /// <param name="x">The vector of angles in radians.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to degrees.</returns>
        public static float2 degrees(float2 x) => new float2(float.RadiansToDegrees(x.x), float.RadiansToDegrees(x.y));
        /// <summary>
        /// Determines whether each component of the specified vector is finite.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is finite.</returns>
        public static bool2 isfinite(float2 x) => new bool2(float.IsFinite(x.x), float.IsFinite(x.y));
        /// <summary>
        /// Determines whether each component of the specified vector is an infinity.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is positive or negative infinity.</returns>
        public static bool2 isinf(float2 x) => new bool2(float.IsInfinity(x.x), float.IsInfinity(x.y));
        /// <summary>
        /// Determines whether each component of the specified vector is Not-a-Number (NaN).
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is NaN.</returns>
        public static bool2 isnan(float2 x) => new bool2(float.IsNaN(x.x), float.IsNaN(x.y));

        // Vector geometry
        /// <summary>
        /// Computes the dot product of two vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The scalar dot product of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float dot(float2 x, float2 y) => x.x * y.x + x.y * y.y;
        /// <summary>
        /// Computes the length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The length of <paramref name="x"/>.</returns>
        public static float length(float2 x) => float.Sqrt(dot(x, x));
        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static float lengthsq(float2 x) => dot(x, x);
        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The distance between <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float distance(float2 x, float2 y) => length(x - y);
        /// <summary>
        /// Returns a normalized (unit length) version of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A unit-length vector in the same direction as <paramref name="x"/>, or <see cref="float2.zero"/> if <paramref name="x"/> has zero length.</returns>
        public static float2 normalize(float2 x)
        {
            float len = length(x);
            return len > 0 ? x / len : float2.zero;
        }

        // Component reduction
        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static float cmin(float2 x) => float.Min(x.x, x.y);
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static float cmax(float2 x) => float.Max(x.x, x.y);
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static float csum(float2 x) => x.x + x.y;

        // Reflection and refraction
        /// <summary>
        /// Computes the reflection of an incident vector around a normal vector.
        /// </summary>
        /// <param name="i">The incident vector.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <returns>The reflected vector.</returns>
        public static float2 reflect(float2 i, float2 n) => i - 2f * dot(n, i) * n;
        /// <summary>
        /// Computes the refraction of an incident vector through a surface with the specified normal and ratio of indices of refraction.
        /// </summary>
        /// <param name="i">The incident vector, which is assumed to be normalized.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <param name="eta">The ratio of indices of refraction between the two media.</param>
        /// <returns>The refracted vector, or <see cref="float2.zero"/> if total internal reflection occurs.</returns>
        public static float2 refract(float2 i, float2 n, float eta)
        {
            float ndoti = dot(n, i);
            float k = 1f - eta * eta * (1f - ndoti * ndoti);
            return k < 0 ? float2.zero : eta * i - (eta * ndoti + float.Sqrt(k)) * n;
        }
        /// <summary>
        /// Returns a vector facing the same direction as the normal, based on the sign of the dot product with the incident vector.
        /// </summary>
        /// <param name="n">The normal vector.</param>
        /// <param name="i">The incident vector.</param>
        /// <param name="ng">The geometric normal vector.</param>
        /// <returns><paramref name="n"/> if the dot product of <paramref name="ng"/> and <paramref name="i"/> is negative; otherwise, the negation of <paramref name="n"/>.</returns>
        public static float2 faceforward(float2 n, float2 i, float2 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two edge vectors.
        /// </summary>
        /// <param name="edge0">The vector of lower edges of the transition.</param>
        /// <param name="edge1">The vector of upper edges of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static float2 smoothstep(float2 edge0, float2 edge1, float2 x)
        {
            float2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float2(3f, 3f) - 2f * t);
        }
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two scalar edges.
        /// </summary>
        /// <param name="edge0">The lower edge of the transition.</param>
        /// <param name="edge1">The upper edge of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static float2 smoothstep(float edge0, float edge1, float2 x)
        {
            float2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float2(3f, 3f) - 2f * t);
        }

        // Step
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against the corresponding component of an edge vector.
        /// </summary>
        /// <param name="edge">The vector of edge values.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to that of <paramref name="edge"/>, and 0 otherwise.</returns>
        public static float2 step(float2 edge, float2 x) => new float2(x.x >= edge.x ? 1f : 0f, x.y >= edge.y ? 1f : 0f);
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against a scalar edge value.
        /// </summary>
        /// <param name="edge">The scalar edge value.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to <paramref name="edge"/>, and 0 otherwise.</returns>
        public static float2 step(float edge, float2 x) => new float2(x.x >= edge ? 1f : 0f, x.y >= edge ? 1f : 0f);

        // Modf (split into integer and fractional parts)
        /// <summary>
        /// Splits each component of the specified vector into its integral and fractional parts.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="intPart">When this method returns, contains the component-wise integral parts of <paramref name="x"/>.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static float2 modf(float2 x, out float2 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (returns scalar for float2 in HLSL)
        /// <summary>
        /// Computes the 2D cross product of two vectors, which is the scalar z-component of the 3D cross product.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>The scalar cross product of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static float cross(float2 a, float2 b) => a.x * b.y - a.y * b.x;

        // Determinant (alias for cross)
        /// <summary>
        /// Computes the determinant of two 2D vectors, which is equivalent to their 2D cross product.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>The determinant of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static float determinant(float2 a, float2 b) => cross(a, b);

        #endregion float
        #region double

        /// <summary>
        /// Returns the component-wise absolute value of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the absolute value of each component of <paramref name="x"/>.</returns>
        public static double2 abs(double2 x) => new double2(double.Abs(x.x), double.Abs(x.y));
        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static double2 clamp(double2 x, double2 min, double2 max) => new double2(double.Clamp(x.x, min.x, max.x), double.Clamp(x.y, min.y, max.y));
        /// <summary>
        /// Clamps each component of the specified vector to the specified minimum and maximum scalar range.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The minimum value applied to each component.</param>
        /// <param name="max">The maximum value applied to each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static double2 clamp(double2 x, double min, double max) => new double2(double.Clamp(x.x, min, max), double.Clamp(x.y, min, max));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a scalar interpolation factor.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The interpolation factor, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static double2 lerp(double2 x, double2 y, double t) => new double2(double.Lerp(x.x, y.x, t), double.Lerp(x.y, y.y, t));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a per-component interpolation factor vector.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The per-component interpolation factors, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static double2 lerp(double2 x, double2 y, double2 t) => new double2(double.Lerp(x.x, y.x, t.x), double.Lerp(x.y, y.y, t.y));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double2 max(double2 x, double2 y) => new double2(double.Max(x.x, y.x), double.Max(x.y, y.y));
        /// <summary>
        /// Selects the greater of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double2 max(double2 x, double y) => new double2(double.Max(x.x, y), double.Max(x.y, y));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double2 min(double2 x, double2 y) => new double2(double.Min(x.x, y.x), double.Min(x.y, y.y));
        /// <summary>
        /// Selects the lesser of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double2 min(double2 x, double y) => new double2(double.Min(x.x, y), double.Min(x.y, y));
        /// <summary>
        /// Clamps each component of the specified vector to the range [0, 1].
        /// </summary>
        /// <param name="x">The vector to saturate.</param>
        /// <returns>A vector with each component clamped to the range [0, 1].</returns>
        public static double2 saturate(double2 x) => new double2(double.Clamp(x.x, 0.0, 1.0), double.Clamp(x.y, 0.0, 1.0));
        /// <summary>
        /// Returns the sign of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is -1, 0, or 1 depending on the sign of the corresponding component of <paramref name="x"/>.</returns>
        public static double2 sign(double2 x) => new double2(double.Sign(x.x), double.Sign(x.y));
        /// <summary>
        /// Returns the ceiling of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise ceiling of <paramref name="x"/>.</returns>
        public static double2 ceil(double2 x) => new double2(double.Ceiling(x.x), double.Ceiling(x.y));
        /// <summary>
        /// Returns the floor of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise floor of <paramref name="x"/>.</returns>
        public static double2 floor(double2 x) => new double2(double.Floor(x.x), double.Floor(x.y));
        /// <summary>
        /// Rounds each component of the specified vector to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise rounded values of <paramref name="x"/>.</returns>
        public static double2 round(double2 x) => new double2(double.Round(x.x), double.Round(x.y));
        /// <summary>
        /// Truncates each component of the specified vector toward zero to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise integral parts of <paramref name="x"/>.</returns>
        public static double2 trunc(double2 x) => new double2(double.Truncate(x.x), double.Truncate(x.y));
        /// <summary>
        /// Returns the fractional part of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static double2 frac(double2 x) => new double2(x.x - double.Floor(x.x), x.y - double.Floor(x.y));
        /// <summary>
        /// Returns the base-e exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-e exponentials of <paramref name="x"/>.</returns>
        public static double2 exp(double2 x) => new double2(double.Exp(x.x), double.Exp(x.y));
        /// <summary>
        /// Returns the base-2 exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 exponentials of <paramref name="x"/>.</returns>
        public static double2 exp2(double2 x) => new double2(double.Exp2(x.x), double.Exp2(x.y));
        /// <summary>
        /// Returns the natural logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise natural logarithms of <paramref name="x"/>.</returns>
        public static double2 log(double2 x) => new double2(double.Log(x.x), double.Log(x.y));
        /// <summary>
        /// Returns the base-2 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 logarithms of <paramref name="x"/>.</returns>
        public static double2 log2(double2 x) => new double2(double.Log2(x.x), double.Log2(x.y));
        /// <summary>
        /// Returns the base-10 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-10 logarithms of <paramref name="x"/>.</returns>
        public static double2 log10(double2 x) => new double2(double.Log10(x.x), double.Log10(x.y));
        /// <summary>
        /// Raises each component of a vector to the power of the corresponding component of another vector.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The exponent vector.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static double2 pow(double2 x, double2 y) => new double2(double.Pow(x.x, y.x), double.Pow(x.y, y.y));
        /// <summary>
        /// Raises each component of a vector to the power of a scalar value.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The scalar exponent.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static double2 pow(double2 x, double y) => new double2(double.Pow(x.x, y), double.Pow(x.y, y));
        /// <summary>
        /// Returns the reciprocal of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocals of <paramref name="x"/>.</returns>
        public static double2 rcp(double2 x) => new double2(1.0 / x.x, 1.0 / x.y);
        /// <summary>
        /// Returns the reciprocal of the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocal square roots of <paramref name="x"/>.</returns>
        public static double2 rsqrt(double2 x) => new double2(1.0 / double.Sqrt(x.x), 1.0 / double.Sqrt(x.y));
        /// <summary>
        /// Returns the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise square roots of <paramref name="x"/>.</returns>
        public static double2 sqrt(double2 x) => new double2(double.Sqrt(x.x), double.Sqrt(x.y));
        /// <summary>
        /// Returns the arccosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arccosines of <paramref name="x"/>, in radians.</returns>
        public static double2 acos(double2 x) => new double2(double.Acos(x.x), double.Acos(x.y));
        /// <summary>
        /// Returns the arcsine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arcsines of <paramref name="x"/>, in radians.</returns>
        public static double2 asin(double2 x) => new double2(double.Asin(x.x), double.Asin(x.y));
        /// <summary>
        /// Returns the arctangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="x"/>, in radians.</returns>
        public static double2 atan(double2 x) => new double2(double.Atan(x.x), double.Atan(x.y));
        /// <summary>
        /// Returns the component-wise arctangent of two vectors, using the signs of both to determine the quadrant of each result.
        /// </summary>
        /// <param name="y">The y-coordinate vector.</param>
        /// <param name="x">The x-coordinate vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="y"/> / <paramref name="x"/>, in radians.</returns>
        public static double2 atan2(double2 y, double2 x) => new double2(double.Atan2(y.x, x.x), double.Atan2(y.y, x.y));
        /// <summary>
        /// Returns the cosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise cosines of <paramref name="x"/>.</returns>
        public static double2 cos(double2 x) => new double2(double.Cos(x.x), double.Cos(x.y));
        /// <summary>
        /// Returns the sine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise sines of <paramref name="x"/>.</returns>
        public static double2 sin(double2 x) => new double2(double.Sin(x.x), double.Sin(x.y));
        /// <summary>
        /// Returns the tangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise tangents of <paramref name="x"/>.</returns>
        public static double2 tan(double2 x) => new double2(double.Tan(x.x), double.Tan(x.y));
        /// <summary>
        /// Converts each component of the specified vector from degrees to radians.
        /// </summary>
        /// <param name="x">The vector of angles in degrees.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to radians.</returns>
        public static double2 radians(double2 x) => new double2(double.DegreesToRadians(x.x), double.DegreesToRadians(x.y));
        /// <summary>
        /// Converts each component of the specified vector from radians to degrees.
        /// </summary>
        /// <param name="x">The vector of angles in radians.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to degrees.</returns>
        public static double2 degrees(double2 x) => new double2(double.RadiansToDegrees(x.x), double.RadiansToDegrees(x.y));
        /// <summary>
        /// Determines whether each component of the specified vector is finite.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is finite.</returns>
        public static bool2 isfinite(double2 x) => new bool2(double.IsFinite(x.x), double.IsFinite(x.y));
        /// <summary>
        /// Determines whether each component of the specified vector is an infinity.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is positive or negative infinity.</returns>
        public static bool2 isinf(double2 x) => new bool2(double.IsInfinity(x.x), double.IsInfinity(x.y));
        /// <summary>
        /// Determines whether each component of the specified vector is Not-a-Number (NaN).
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is NaN.</returns>
        public static bool2 isnan(double2 x) => new bool2(double.IsNaN(x.x), double.IsNaN(x.y));

        // Vector geometry
        /// <summary>
        /// Computes the dot product of two vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The scalar dot product of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double dot(double2 x, double2 y) => x.x * y.x + x.y * y.y;
        /// <summary>
        /// Computes the length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The length of <paramref name="x"/>.</returns>
        public static double length(double2 x) => double.Sqrt(dot(x, x));
        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static double lengthsq(double2 x) => dot(x, x);
        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The distance between <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double distance(double2 x, double2 y) => length(x - y);
        /// <summary>
        /// Returns a normalized (unit length) version of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A unit-length vector in the same direction as <paramref name="x"/>, or <see cref="double2.zero"/> if <paramref name="x"/> has zero length.</returns>
        public static double2 normalize(double2 x)
        {
            double len = length(x);
            return len > 0 ? x / len : double2.zero;
        }

        // Component reduction
        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static double cmin(double2 x) => double.Min(x.x, x.y);
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static double cmax(double2 x) => double.Max(x.x, x.y);
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static double csum(double2 x) => x.x + x.y;

        // Reflection and refraction
        /// <summary>
        /// Computes the reflection of an incident vector around a normal vector.
        /// </summary>
        /// <param name="i">The incident vector.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <returns>The reflected vector.</returns>
        public static double2 reflect(double2 i, double2 n) => i - 2.0 * dot(n, i) * n;
        /// <summary>
        /// Computes the refraction of an incident vector through a surface with the specified normal and ratio of indices of refraction.
        /// </summary>
        /// <param name="i">The incident vector, which is assumed to be normalized.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <param name="eta">The ratio of indices of refraction between the two media.</param>
        /// <returns>The refracted vector, or <see cref="double2.zero"/> if total internal reflection occurs.</returns>
        public static double2 refract(double2 i, double2 n, double eta)
        {
            double ndoti = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ndoti * ndoti);
            return k < 0 ? double2.zero : eta * i - (eta * ndoti + double.Sqrt(k)) * n;
        }
        /// <summary>
        /// Returns a vector facing the same direction as the normal, based on the sign of the dot product with the incident vector.
        /// </summary>
        /// <param name="n">The normal vector.</param>
        /// <param name="i">The incident vector.</param>
        /// <param name="ng">The geometric normal vector.</param>
        /// <returns><paramref name="n"/> if the dot product of <paramref name="ng"/> and <paramref name="i"/> is negative; otherwise, the negation of <paramref name="n"/>.</returns>
        public static double2 faceforward(double2 n, double2 i, double2 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two edge vectors.
        /// </summary>
        /// <param name="edge0">The vector of lower edges of the transition.</param>
        /// <param name="edge1">The vector of upper edges of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static double2 smoothstep(double2 edge0, double2 edge1, double2 x)
        {
            double2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double2(3.0, 3.0) - 2.0 * t);
        }
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two scalar edges.
        /// </summary>
        /// <param name="edge0">The lower edge of the transition.</param>
        /// <param name="edge1">The upper edge of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static double2 smoothstep(double edge0, double edge1, double2 x)
        {
            double2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double2(3.0, 3.0) - 2.0 * t);
        }

        // Step
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against the corresponding component of an edge vector.
        /// </summary>
        /// <param name="edge">The vector of edge values.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to that of <paramref name="edge"/>, and 0 otherwise.</returns>
        public static double2 step(double2 edge, double2 x) => new double2(x.x >= edge.x ? 1.0 : 0.0, x.y >= edge.y ? 1.0 : 0.0);
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against a scalar edge value.
        /// </summary>
        /// <param name="edge">The scalar edge value.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to <paramref name="edge"/>, and 0 otherwise.</returns>
        public static double2 step(double edge, double2 x) => new double2(x.x >= edge ? 1.0 : 0.0, x.y >= edge ? 1.0 : 0.0);

        // Modf (split into integer and fractional parts)
        /// <summary>
        /// Splits each component of the specified vector into its integral and fractional parts.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="intPart">When this method returns, contains the component-wise integral parts of <paramref name="x"/>.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static double2 modf(double2 x, out double2 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (returns scalar for double2 in HLSL)
        /// <summary>
        /// Computes the 2D cross product of two vectors, which is the scalar z-component of the 3D cross product.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>The scalar cross product of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static double cross(double2 a, double2 b) => a.x * b.y - a.y * b.x;

        // Determinant (alias for cross)
        /// <summary>
        /// Computes the determinant of two 2D vectors, which is equivalent to their 2D cross product.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>The determinant of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static double determinant(double2 a, double2 b) => cross(a, b);

        #endregion double
        #region half

        // No equivalent in C#, will automatically translate correctly regardless

        #endregion half
        #region int

        /// <summary>
        /// Returns the component-wise absolute value of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the absolute value of each component of <paramref name="x"/>.</returns>
        public static int2 abs(int2 x) => new int2(int.Abs(x.x), int.Abs(x.y));
        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static int2 clamp(int2 x, int2 min, int2 max) => new int2(int.Clamp(x.x, min.x, max.x), int.Clamp(x.y, min.y, max.y));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static int2 max(int2 x, int2 y) => new int2(int.Max(x.x, y.x), int.Max(x.y, y.y));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static int2 min(int2 x, int2 y) => new int2(int.Min(x.x, y.x), int.Min(x.y, y.y));
        /// <summary>
        /// Returns the sign of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is -1, 0, or 1 depending on the sign of the corresponding component of <paramref name="x"/>.</returns>
        public static int2 sign(int2 x) => new int2(int.Sign(x.x), int.Sign(x.y));

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static int cmin(int2 x) => int.Min(x.x, x.y);
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static int cmax(int2 x) => int.Max(x.x, x.y);
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static int csum(int2 x) => x.x + x.y;

        #endregion int
        #region uint

        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static uint2 clamp(uint2 x, uint2 min, uint2 max) => new uint2(uint.Clamp(x.x, min.x, max.x), uint.Clamp(x.y, min.y, max.y));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static uint2 max(uint2 x, uint2 y) => new uint2(uint.Max(x.x, y.x), uint.Max(x.y, y.y));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static uint2 min(uint2 x, uint2 y) => new uint2(uint.Min(x.x, y.x), uint.Min(x.y, y.y));

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static uint cmin(uint2 x) => uint.Min(x.x, x.y);
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static uint cmax(uint2 x) => uint.Max(x.x, x.y);
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static uint csum(uint2 x) => x.x + x.y;

        #endregion uint
        #region bool

        /// <summary>
        /// Determines whether any component of the specified boolean vector is <see langword="true"/>.
        /// </summary>
        /// <param name="x">The input boolean vector.</param>
        /// <returns>A boolean vector representing the component-wise result of the any operation.</returns>
        public static bool2 any(bool2 x) => x.any;
        /// <summary>
        /// Determines whether all components of the specified boolean vector are <see langword="true"/>.
        /// </summary>
        /// <param name="x">The input boolean vector.</param>
        /// <returns>A boolean vector representing the component-wise result of the all operation.</returns>
        public static bool2 all(bool2 x) => x.all;

        #endregion bool
        #region interpretation

        /// <summary>
        /// Reinterprets the bit pattern of each component of a <see cref="float2"/> as a signed 32-bit integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="int"/> values.</returns>
        public static int2 asint(float2 x) => new int2(BitConverter.SingleToInt32Bits(x.x), BitConverter.SingleToInt32Bits(x.y));
        /// <summary>
        /// Reinterprets the bit pattern of each component of a <see cref="float2"/> as an unsigned 32-bit integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="uint"/> values.</returns>
        public static uint2 asuint(float2 x) => new uint2(BitConverter.SingleToUInt32Bits(x.x), BitConverter.SingleToUInt32Bits(x.y));
        /// <summary>
        /// Reinterprets the bit pattern of each component of an <see cref="int2"/> as a <see cref="float"/>.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="float"/> values.</returns>
        public static float2 asfloat(int2 x) => new float2(BitConverter.Int32BitsToSingle(x.x), BitConverter.Int32BitsToSingle(x.y));
        /// <summary>
        /// Reinterprets the bit pattern of each component of a <see cref="uint2"/> as a <see cref="float"/>.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="float"/> values.</returns>
        public static float2 asfloat(uint2 x) => new float2(BitConverter.UInt32BitsToSingle(x.x), BitConverter.UInt32BitsToSingle(x.y));

        #endregion interpretation
        #region noise

        /// <summary>
        /// Returns itself, noise is not deterministic and varies per GPU device.
        /// </summary>
        /// <returns>Input (x)</returns>
        /// <remarks>This is only for compatibility and is not useful on the C# CPU side</remarks>
        public static float2 noise(float2 x) => x;
        // Implement true noise here later

        #endregion noise
    }
}
