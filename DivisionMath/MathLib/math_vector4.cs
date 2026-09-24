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
        public static float4 abs(float4 x) => new float4(float.Abs(x.x), float.Abs(x.y), float.Abs(x.z), float.Abs(x.w));
        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static float4 clamp(float4 x, float4 min, float4 max) => new float4(float.Clamp(x.x, min.x, max.x), float.Clamp(x.y, min.y, max.y), float.Clamp(x.z, min.z, max.z), float.Clamp(x.w, min.w, max.w));
        /// <summary>
        /// Clamps each component of the specified vector to the specified minimum and maximum scalar range.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The minimum value applied to each component.</param>
        /// <param name="max">The maximum value applied to each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static float4 clamp(float4 x, float min, float max) => new float4(float.Clamp(x.x, min, max), float.Clamp(x.y, min, max), float.Clamp(x.z, min, max), float.Clamp(x.w, min, max));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a scalar interpolation factor.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The interpolation factor, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static float4 lerp(float4 x, float4 y, float t) => new float4(float.Lerp(x.x, y.x, t), float.Lerp(x.y, y.y, t), float.Lerp(x.z, y.z, t), float.Lerp(x.w, y.w, t));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a per-component interpolation factor vector.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The per-component interpolation factors, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static float4 lerp(float4 x, float4 y, float4 t) => new float4(float.Lerp(x.x, y.x, t.x), float.Lerp(x.y, y.y, t.y), float.Lerp(x.z, y.z, t.z), float.Lerp(x.w, y.w, t.w));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float4 max(float4 x, float4 y) => new float4(float.Max(x.x, y.x), float.Max(x.y, y.y), float.Max(x.z, y.z), float.Max(x.w, y.w));
        /// <summary>
        /// Selects the greater of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float4 max(float4 x, float y) => new float4(float.Max(x.x, y), float.Max(x.y, y), float.Max(x.z, y), float.Max(x.w, y));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float4 min(float4 x, float4 y) => new float4(float.Min(x.x, y.x), float.Min(x.y, y.y), float.Min(x.z, y.z), float.Min(x.w, y.w));
        /// <summary>
        /// Selects the lesser of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float4 min(float4 x, float y) => new float4(float.Min(x.x, y), float.Min(x.y, y), float.Min(x.z, y), float.Min(x.w, y));
        /// <summary>
        /// Clamps each component of the specified vector to the range [0, 1].
        /// </summary>
        /// <param name="x">The vector to saturate.</param>
        /// <returns>A vector with each component clamped to the range [0, 1].</returns>
        public static float4 saturate(float4 x) => new float4(float.Clamp(x.x, 0f, 1f), float.Clamp(x.y, 0f, 1f), float.Clamp(x.z, 0f, 1f), float.Clamp(x.w, 0f, 1f));
        /// <summary>
        /// Returns the sign of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is -1, 0, or 1 depending on the sign of the corresponding component of <paramref name="x"/>.</returns>
        public static float4 sign(float4 x) => new float4(float.Sign(x.x), float.Sign(x.y), float.Sign(x.z), float.Sign(x.w));
        /// <summary>
        /// Returns the ceiling of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise ceiling of <paramref name="x"/>.</returns>
        public static float4 ceil(float4 x) => new float4(float.Ceiling(x.x), float.Ceiling(x.y), float.Ceiling(x.z), float.Ceiling(x.w));
        /// <summary>
        /// Returns the floor of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise floor of <paramref name="x"/>.</returns>
        public static float4 floor(float4 x) => new float4(float.Floor(x.x), float.Floor(x.y), float.Floor(x.z), float.Floor(x.w));
        /// <summary>
        /// Rounds each component of the specified vector to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise rounded values of <paramref name="x"/>.</returns>
        public static float4 round(float4 x) => new float4(float.Round(x.x), float.Round(x.y), float.Round(x.z), float.Round(x.w));
        /// <summary>
        /// Truncates each component of the specified vector toward zero to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise integral parts of <paramref name="x"/>.</returns>
        public static float4 trunc(float4 x) => new float4(float.Truncate(x.x), float.Truncate(x.y), float.Truncate(x.z), float.Truncate(x.w));
        /// <summary>
        /// Returns the fractional part of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static float4 frac(float4 x) => new float4(x.x - float.Floor(x.x), x.y - float.Floor(x.y), x.z - float.Floor(x.z), x.w - float.Floor(x.w));
        /// <summary>
        /// Returns the base-e exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-e exponentials of <paramref name="x"/>.</returns>
        public static float4 exp(float4 x) => new float4(float.Exp(x.x), float.Exp(x.y), float.Exp(x.z), float.Exp(x.w));
        /// <summary>
        /// Returns the base-2 exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 exponentials of <paramref name="x"/>.</returns>
        public static float4 exp2(float4 x) => new float4(float.Exp2(x.x), float.Exp2(x.y), float.Exp2(x.z), float.Exp2(x.w));
        /// <summary>
        /// Returns the natural logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise natural logarithms of <paramref name="x"/>.</returns>
        public static float4 log(float4 x) => new float4(float.Log(x.x), float.Log(x.y), float.Log(x.z), float.Log(x.w));
        /// <summary>
        /// Returns the base-2 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 logarithms of <paramref name="x"/>.</returns>
        public static float4 log2(float4 x) => new float4(float.Log2(x.x), float.Log2(x.y), float.Log2(x.z), float.Log2(x.w));
        /// <summary>
        /// Returns the base-10 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-10 logarithms of <paramref name="x"/>.</returns>
        public static float4 log10(float4 x) => new float4(float.Log10(x.x), float.Log10(x.y), float.Log10(x.z), float.Log10(x.w));
        /// <summary>
        /// Raises each component of a vector to the power of the corresponding component of another vector.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The exponent vector.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static float4 pow(float4 x, float4 y) => new float4(float.Pow(x.x, y.x), float.Pow(x.y, y.y), float.Pow(x.z, y.z), float.Pow(x.w, y.w));
        /// <summary>
        /// Raises each component of a vector to the power of a scalar value.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The scalar exponent.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static float4 pow(float4 x, float y) => new float4(float.Pow(x.x, y), float.Pow(x.y, y), float.Pow(x.z, y), float.Pow(x.w, y));
        /// <summary>
        /// Returns the reciprocal of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocals of <paramref name="x"/>.</returns>
        public static float4 rcp(float4 x) => new float4(1f / x.x, 1f / x.y, 1f / x.z, 1f / x.w);
        /// <summary>
        /// Returns the reciprocal of the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocal square roots of <paramref name="x"/>.</returns>
        public static float4 rsqrt(float4 x) => new float4(1f / float.Sqrt(x.x), 1f / float.Sqrt(x.y), 1f / float.Sqrt(x.z), 1f / float.Sqrt(x.w));
        /// <summary>
        /// Returns the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise square roots of <paramref name="x"/>.</returns>
        public static float4 sqrt(float4 x) => new float4(float.Sqrt(x.x), float.Sqrt(x.y), float.Sqrt(x.z), float.Sqrt(x.w));
        /// <summary>
        /// Returns the arccosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arccosines of <paramref name="x"/>, in radians.</returns>
        public static float4 acos(float4 x) => new float4(float.Acos(x.x), float.Acos(x.y), float.Acos(x.z), float.Acos(x.w));
        /// <summary>
        /// Returns the arcsine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arcsines of <paramref name="x"/>, in radians.</returns>
        public static float4 asin(float4 x) => new float4(float.Asin(x.x), float.Asin(x.y), float.Asin(x.z), float.Asin(x.w));
        /// <summary>
        /// Returns the arctangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="x"/>, in radians.</returns>
        public static float4 atan(float4 x) => new float4(float.Atan(x.x), float.Atan(x.y), float.Atan(x.z), float.Atan(x.w));
        /// <summary>
        /// Returns the component-wise arctangent of two vectors, using the signs of both to determine the quadrant of each result.
        /// </summary>
        /// <param name="y">The y-coordinate vector.</param>
        /// <param name="x">The x-coordinate vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="y"/> / <paramref name="x"/>, in radians.</returns>
        public static float4 atan2(float4 y, float4 x) => new float4(float.Atan2(y.x, x.x), float.Atan2(y.y, x.y), float.Atan2(y.z, x.z), float.Atan2(y.w, x.w));
        /// <summary>
        /// Returns the cosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise cosines of <paramref name="x"/>.</returns>
        public static float4 cos(float4 x) => new float4(float.Cos(x.x), float.Cos(x.y), float.Cos(x.z), float.Cos(x.w));
        /// <summary>
        /// Returns the sine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise sines of <paramref name="x"/>.</returns>
        public static float4 sin(float4 x) => new float4(float.Sin(x.x), float.Sin(x.y), float.Sin(x.z), float.Sin(x.w));
        /// <summary>
        /// Returns the tangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise tangents of <paramref name="x"/>.</returns>
        public static float4 tan(float4 x) => new float4(float.Tan(x.x), float.Tan(x.y), float.Tan(x.z), float.Tan(x.w));
        /// <summary>
        /// Converts each component of the specified vector from degrees to radians.
        /// </summary>
        /// <param name="x">The vector of angles in degrees.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to radians.</returns>
        public static float4 radians(float4 x) => new float4(float.DegreesToRadians(x.x), float.DegreesToRadians(x.y), float.DegreesToRadians(x.z), float.DegreesToRadians(x.w));
        /// <summary>
        /// Converts each component of the specified vector from radians to degrees.
        /// </summary>
        /// <param name="x">The vector of angles in radians.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to degrees.</returns>
        public static float4 degrees(float4 x) => new float4(float.RadiansToDegrees(x.x), float.RadiansToDegrees(x.y), float.RadiansToDegrees(x.z), float.RadiansToDegrees(x.w));
        /// <summary>
        /// Determines whether each component of the specified vector is finite.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is finite.</returns>
        public static bool4 isfinite(float4 x) => new bool4(float.IsFinite(x.x), float.IsFinite(x.y), float.IsFinite(x.z), float.IsFinite(x.w));
        /// <summary>
        /// Determines whether each component of the specified vector is an infinity.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is positive or negative infinity.</returns>
        public static bool4 isinf(float4 x) => new bool4(float.IsInfinity(x.x), float.IsInfinity(x.y), float.IsInfinity(x.z), float.IsInfinity(x.w));
        /// <summary>
        /// Determines whether each component of the specified vector is Not-a-Number (NaN).
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is NaN.</returns>
        public static bool4 isnan(float4 x) => new bool4(float.IsNaN(x.x), float.IsNaN(x.y), float.IsNaN(x.z), float.IsNaN(x.w));

        // Vector geometry
        /// <summary>
        /// Computes the dot product of two 4D vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The scalar dot product of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float dot(float4 x, float4 y) => x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w;
        /// <summary>
        /// Computes the length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The length of <paramref name="x"/>.</returns>
        public static float length(float4 x) => float.Sqrt(dot(x, x));
        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static float lengthsq(float4 x) => dot(x, x);
        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The distance between <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static float distance(float4 x, float4 y) => length(x - y);
        /// <summary>
        /// Returns a normalized (unit length) version of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A unit-length vector in the same direction as <paramref name="x"/>, or <see cref="float4.zero"/> if <paramref name="x"/> has zero length.</returns>
        public static float4 normalize(float4 x)
        {
            float len = length(x);
            return len > 0 ? x / len : float4.zero;
        }

        // Component reduction
        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static float cmin(float4 x) => float.Min(x.x, float.Min(x.y, float.Min(x.z, x.w)));
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static float cmax(float4 x) => float.Max(x.x, float.Max(x.y, float.Max(x.z, x.w)));
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static float csum(float4 x) => x.x + x.y + x.z + x.w;

        // Reflection and refraction
        /// <summary>
        /// Computes the reflection of an incident vector around a normal vector.
        /// </summary>
        /// <param name="i">The incident vector.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <returns>The reflected vector.</returns>
        public static float4 reflect(float4 i, float4 n) => i - 2f * dot(n, i) * n;
        /// <summary>
        /// Computes the refraction of an incident vector through a surface with the specified normal and ratio of indices of refraction.
        /// </summary>
        /// <param name="i">The incident vector, which is assumed to be normalized.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <param name="eta">The ratio of indices of refraction between the two media.</param>
        /// <returns>The refracted vector, or <see cref="float4.zero"/> if total internal reflection occurs.</returns>
        public static float4 refract(float4 i, float4 n, float eta)
        {
            float ndoti = dot(n, i);
            float k = 1f - eta * eta * (1f - ndoti * ndoti);
            return k < 0 ? float4.zero : eta * i - (eta * ndoti + float.Sqrt(k)) * n;
        }
        /// <summary>
        /// Returns a vector facing the same direction as the normal, based on the sign of the dot product with the incident vector.
        /// </summary>
        /// <param name="n">The normal vector.</param>
        /// <param name="i">The incident vector.</param>
        /// <param name="ng">The geometric normal vector.</param>
        /// <returns><paramref name="n"/> if the dot product of <paramref name="ng"/> and <paramref name="i"/> is negative; otherwise, the negation of <paramref name="n"/>.</returns>
        public static float4 faceforward(float4 n, float4 i, float4 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two edge vectors.
        /// </summary>
        /// <param name="edge0">The vector of lower edges of the transition.</param>
        /// <param name="edge1">The vector of upper edges of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static float4 smoothstep(float4 edge0, float4 edge1, float4 x)
        {
            float4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float4(3f, 3f, 3f, 3f) - 2f * t);
        }
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two scalar edges.
        /// </summary>
        /// <param name="edge0">The lower edge of the transition.</param>
        /// <param name="edge1">The upper edge of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static float4 smoothstep(float edge0, float edge1, float4 x)
        {
            float4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float4(3f, 3f, 3f, 3f) - 2f * t);
        }

        // Step
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against the corresponding component of an edge vector.
        /// </summary>
        /// <param name="edge">The vector of edge values.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to that of <paramref name="edge"/>, and 0 otherwise.</returns>
        public static float4 step(float4 edge, float4 x) => new float4(x.x >= edge.x ? 1f : 0f, x.y >= edge.y ? 1f : 0f, x.z >= edge.z ? 1f : 0f, x.w >= edge.w ? 1f : 0f);
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against a scalar edge value.
        /// </summary>
        /// <param name="edge">The scalar edge value.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to <paramref name="edge"/>, and 0 otherwise.</returns>
        public static float4 step(float edge, float4 x) => new float4(x.x >= edge ? 1f : 0f, x.y >= edge ? 1f : 0f, x.z >= edge ? 1f : 0f, x.w >= edge ? 1f : 0f);

        // Modf
        /// <summary>
        /// Splits each component of the specified vector into its integral and fractional parts.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="intPart">When this method returns, contains the component-wise integral parts of <paramref name="x"/>.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static float4 modf(float4 x, out float4 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (not defined for float4 in HLSL, but included for completeness with 3D components)
        /// <summary>
        /// Computes a cross-product-like vector using the x, y, and z components of the input vectors; the w component of the result is set to zero.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>A vector whose x, y, and z components are the cross product of the corresponding components of <paramref name="a"/> and <paramref name="b"/>, and whose w component is zero.</returns>
        /// <remarks>The cross product is not defined for 4D vectors in HLSL; this overload exists for convenience when working with 4-component vectors whose first three components represent a 3D direction.</remarks>
        public static float4 cross(float4 a, float4 b) => new float4(
            a.y * b.z - a.z * b.y,
            a.z * b.x - a.x * b.z,
            a.x * b.y - a.y * b.x,
            0f
        );

        #endregion float
        #region double

        /// <summary>
        /// Returns the component-wise absolute value of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the absolute value of each component of <paramref name="x"/>.</returns>
        public static double4 abs(double4 x) => new double4(double.Abs(x.x), double.Abs(x.y), double.Abs(x.z), double.Abs(x.w));
        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static double4 clamp(double4 x, double4 min, double4 max) => new double4(double.Clamp(x.x, min.x, max.x), double.Clamp(x.y, min.y, max.y), double.Clamp(x.z, min.z, max.z), double.Clamp(x.w, min.w, max.w));
        /// <summary>
        /// Clamps each component of the specified vector to the specified minimum and maximum scalar range.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The minimum value applied to each component.</param>
        /// <param name="max">The maximum value applied to each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static double4 clamp(double4 x, double min, double max) => new double4(double.Clamp(x.x, min, max), double.Clamp(x.y, min, max), double.Clamp(x.z, min, max), double.Clamp(x.w, min, max));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a scalar interpolation factor.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The interpolation factor, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static double4 lerp(double4 x, double4 y, double t) => new double4(double.Lerp(x.x, y.x, t), double.Lerp(x.y, y.y, t), double.Lerp(x.z, y.z, t), double.Lerp(x.w, y.w, t));
        /// <summary>
        /// Performs a component-wise linear interpolation between two vectors using a per-component interpolation factor vector.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <param name="t">The per-component interpolation factors, typically in the range [0, 1].</param>
        /// <returns>The component-wise linear interpolation between <paramref name="x"/> and <paramref name="y"/> using <paramref name="t"/>.</returns>
        public static double4 lerp(double4 x, double4 y, double4 t) => new double4(double.Lerp(x.x, y.x, t.x), double.Lerp(x.y, y.y, t.y), double.Lerp(x.z, y.z, t.z), double.Lerp(x.w, y.w, t.w));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double4 max(double4 x, double4 y) => new double4(double.Max(x.x, y.x), double.Max(x.y, y.y), double.Max(x.z, y.z), double.Max(x.w, y.w));
        /// <summary>
        /// Selects the greater of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double4 max(double4 x, double y) => new double4(double.Max(x.x, y), double.Max(x.y, y), double.Max(x.z, y), double.Max(x.w, y));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double4 min(double4 x, double4 y) => new double4(double.Min(x.x, y.x), double.Min(x.y, y.y), double.Min(x.z, y.z), double.Min(x.w, y.w));
        /// <summary>
        /// Selects the lesser of each component of a vector and a scalar value.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="y">The scalar value to compare against each component.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double4 min(double4 x, double y) => new double4(double.Min(x.x, y), double.Min(x.y, y), double.Min(x.z, y), double.Min(x.w, y));
        /// <summary>
        /// Clamps each component of the specified vector to the range [0, 1].
        /// </summary>
        /// <param name="x">The vector to saturate.</param>
        /// <returns>A vector with each component clamped to the range [0, 1].</returns>
        public static double4 saturate(double4 x) => new double4(double.Clamp(x.x, 0.0, 1.0), double.Clamp(x.y, 0.0, 1.0), double.Clamp(x.z, 0.0, 1.0), double.Clamp(x.w, 0.0, 1.0));
        /// <summary>
        /// Returns the sign of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is -1, 0, or 1 depending on the sign of the corresponding component of <paramref name="x"/>.</returns>
        public static double4 sign(double4 x) => new double4(double.Sign(x.x), double.Sign(x.y), double.Sign(x.z), double.Sign(x.w));
        /// <summary>
        /// Returns the ceiling of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise ceiling of <paramref name="x"/>.</returns>
        public static double4 ceil(double4 x) => new double4(double.Ceiling(x.x), double.Ceiling(x.y), double.Ceiling(x.z), double.Ceiling(x.w));
        /// <summary>
        /// Returns the floor of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise floor of <paramref name="x"/>.</returns>
        public static double4 floor(double4 x) => new double4(double.Floor(x.x), double.Floor(x.y), double.Floor(x.z), double.Floor(x.w));
        /// <summary>
        /// Rounds each component of the specified vector to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise rounded values of <paramref name="x"/>.</returns>
        public static double4 round(double4 x) => new double4(double.Round(x.x), double.Round(x.y), double.Round(x.z), double.Round(x.w));
        /// <summary>
        /// Truncates each component of the specified vector toward zero to the nearest integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise integral parts of <paramref name="x"/>.</returns>
        public static double4 trunc(double4 x) => new double4(double.Truncate(x.x), double.Truncate(x.y), double.Truncate(x.z), double.Truncate(x.w));
        /// <summary>
        /// Returns the fractional part of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static double4 frac(double4 x) => new double4(x.x - double.Floor(x.x), x.y - double.Floor(x.y), x.z - double.Floor(x.z), x.w - double.Floor(x.w));
        /// <summary>
        /// Returns the base-e exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-e exponentials of <paramref name="x"/>.</returns>
        public static double4 exp(double4 x) => new double4(double.Exp(x.x), double.Exp(x.y), double.Exp(x.z), double.Exp(x.w));
        /// <summary>
        /// Returns the base-2 exponential of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 exponentials of <paramref name="x"/>.</returns>
        public static double4 exp2(double4 x) => new double4(double.Exp2(x.x), double.Exp2(x.y), double.Exp2(x.z), double.Exp2(x.w));
        /// <summary>
        /// Returns the natural logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise natural logarithms of <paramref name="x"/>.</returns>
        public static double4 log(double4 x) => new double4(double.Log(x.x), double.Log(x.y), double.Log(x.z), double.Log(x.w));
        /// <summary>
        /// Returns the base-2 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-2 logarithms of <paramref name="x"/>.</returns>
        public static double4 log2(double4 x) => new double4(double.Log2(x.x), double.Log2(x.y), double.Log2(x.z), double.Log2(x.w));
        /// <summary>
        /// Returns the base-10 logarithm of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise base-10 logarithms of <paramref name="x"/>.</returns>
        public static double4 log10(double4 x) => new double4(double.Log10(x.x), double.Log10(x.y), double.Log10(x.z), double.Log10(x.w));
        /// <summary>
        /// Raises each component of a vector to the power of the corresponding component of another vector.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The exponent vector.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static double4 pow(double4 x, double4 y) => new double4(double.Pow(x.x, y.x), double.Pow(x.y, y.y), double.Pow(x.z, y.z), double.Pow(x.w, y.w));
        /// <summary>
        /// Raises each component of a vector to the power of a scalar value.
        /// </summary>
        /// <param name="x">The base vector.</param>
        /// <param name="y">The scalar exponent.</param>
        /// <returns>A vector containing the component-wise power of <paramref name="x"/> raised to <paramref name="y"/>.</returns>
        public static double4 pow(double4 x, double y) => new double4(double.Pow(x.x, y), double.Pow(x.y, y), double.Pow(x.z, y), double.Pow(x.w, y));
        /// <summary>
        /// Returns the reciprocal of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocals of <paramref name="x"/>.</returns>
        public static double4 rcp(double4 x) => new double4(1.0 / x.x, 1.0 / x.y, 1.0 / x.z, 1.0 / x.w);
        /// <summary>
        /// Returns the reciprocal of the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise reciprocal square roots of <paramref name="x"/>.</returns>
        public static double4 rsqrt(double4 x) => new double4(1.0 / double.Sqrt(x.x), 1.0 / double.Sqrt(x.y), 1.0 / double.Sqrt(x.z), 1.0 / double.Sqrt(x.w));
        /// <summary>
        /// Returns the square root of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise square roots of <paramref name="x"/>.</returns>
        public static double4 sqrt(double4 x) => new double4(double.Sqrt(x.x), double.Sqrt(x.y), double.Sqrt(x.z), double.Sqrt(x.w));
        /// <summary>
        /// Returns the arccosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arccosines of <paramref name="x"/>, in radians.</returns>
        public static double4 acos(double4 x) => new double4(double.Acos(x.x), double.Acos(x.y), double.Acos(x.z), double.Acos(x.w));
        /// <summary>
        /// Returns the arcsine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector, whose components should be in the range [-1, 1].</param>
        /// <returns>A vector containing the component-wise arcsines of <paramref name="x"/>, in radians.</returns>
        public static double4 asin(double4 x) => new double4(double.Asin(x.x), double.Asin(x.y), double.Asin(x.z), double.Asin(x.w));
        /// <summary>
        /// Returns the arctangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="x"/>, in radians.</returns>
        public static double4 atan(double4 x) => new double4(double.Atan(x.x), double.Atan(x.y), double.Atan(x.z), double.Atan(x.w));
        /// <summary>
        /// Returns the component-wise arctangent of two vectors, using the signs of both to determine the quadrant of each result.
        /// </summary>
        /// <param name="y">The y-coordinate vector.</param>
        /// <param name="x">The x-coordinate vector.</param>
        /// <returns>A vector containing the component-wise arctangents of <paramref name="y"/> / <paramref name="x"/>, in radians.</returns>
        public static double4 atan2(double4 y, double4 x) => new double4(double.Atan2(y.x, x.x), double.Atan2(y.y, x.y), double.Atan2(y.z, x.z), double.Atan2(y.w, x.w));
        /// <summary>
        /// Returns the cosine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise cosines of <paramref name="x"/>.</returns>
        public static double4 cos(double4 x) => new double4(double.Cos(x.x), double.Cos(x.y), double.Cos(x.z), double.Cos(x.w));
        /// <summary>
        /// Returns the sine of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise sines of <paramref name="x"/>.</returns>
        public static double4 sin(double4 x) => new double4(double.Sin(x.x), double.Sin(x.y), double.Sin(x.z), double.Sin(x.w));
        /// <summary>
        /// Returns the tangent of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector of angles, in radians.</param>
        /// <returns>A vector containing the component-wise tangents of <paramref name="x"/>.</returns>
        public static double4 tan(double4 x) => new double4(double.Tan(x.x), double.Tan(x.y), double.Tan(x.z), double.Tan(x.w));
        /// <summary>
        /// Converts each component of the specified vector from degrees to radians.
        /// </summary>
        /// <param name="x">The vector of angles in degrees.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to radians.</returns>
        public static double4 radians(double4 x) => new double4(double.DegreesToRadians(x.x), double.DegreesToRadians(x.y), double.DegreesToRadians(x.z), double.DegreesToRadians(x.w));
        /// <summary>
        /// Converts each component of the specified vector from radians to degrees.
        /// </summary>
        /// <param name="x">The vector of angles in radians.</param>
        /// <returns>A vector containing the component-wise angles of <paramref name="x"/> converted to degrees.</returns>
        public static double4 degrees(double4 x) => new double4(double.RadiansToDegrees(x.x), double.RadiansToDegrees(x.y), double.RadiansToDegrees(x.z), double.RadiansToDegrees(x.w));
        /// <summary>
        /// Determines whether each component of the specified vector is finite.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is finite.</returns>
        public static bool4 isfinite(double4 x) => new bool4(double.IsFinite(x.x), double.IsFinite(x.y), double.IsFinite(x.z), double.IsFinite(x.w));
        /// <summary>
        /// Determines whether each component of the specified vector is an infinity.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is positive or negative infinity.</returns>
        public static bool4 isinf(double4 x) => new bool4(double.IsInfinity(x.x), double.IsInfinity(x.y), double.IsInfinity(x.z), double.IsInfinity(x.w));
        /// <summary>
        /// Determines whether each component of the specified vector is Not-a-Number (NaN).
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A boolean vector where each component is <see langword="true"/> if the corresponding component of <paramref name="x"/> is NaN.</returns>
        public static bool4 isnan(double4 x) => new bool4(double.IsNaN(x.x), double.IsNaN(x.y), double.IsNaN(x.z), double.IsNaN(x.w));

        // Vector geometry
        /// <summary>
        /// Computes the dot product of two 4D vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The scalar dot product of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double dot(double4 x, double4 y) => x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w;
        /// <summary>
        /// Computes the length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The length of <paramref name="x"/>.</returns>
        public static double length(double4 x) => double.Sqrt(dot(x, x));
        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static double lengthsq(double4 x) => dot(x, x);
        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="x">The first vector.</param>
        /// <param name="y">The second vector.</param>
        /// <returns>The distance between <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static double distance(double4 x, double4 y) => length(x - y);
        /// <summary>
        /// Returns a normalized (unit length) version of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A unit-length vector in the same direction as <paramref name="x"/>, or <see cref="double4.zero"/> if <paramref name="x"/> has zero length.</returns>
        public static double4 normalize(double4 x)
        {
            double len = length(x);
            return len > 0 ? x / len : double4.zero;
        }

        // Component reduction
        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static double cmin(double4 x) => double.Min(x.x, double.Min(x.y, double.Min(x.z, x.w)));
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static double cmax(double4 x) => double.Max(x.x, double.Max(x.y, double.Max(x.z, x.w)));
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static double csum(double4 x) => x.x + x.y + x.z + x.w;

        // Reflection and refraction
        /// <summary>
        /// Computes the reflection of an incident vector around a normal vector.
        /// </summary>
        /// <param name="i">The incident vector.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <returns>The reflected vector.</returns>
        public static double4 reflect(double4 i, double4 n) => i - 2.0 * dot(n, i) * n;
        /// <summary>
        /// Computes the refraction of an incident vector through a surface with the specified normal and ratio of indices of refraction.
        /// </summary>
        /// <param name="i">The incident vector, which is assumed to be normalized.</param>
        /// <param name="n">The normal vector, which is assumed to be normalized.</param>
        /// <param name="eta">The ratio of indices of refraction between the two media.</param>
        /// <returns>The refracted vector, or <see cref="double4.zero"/> if total internal reflection occurs.</returns>
        public static double4 refract(double4 i, double4 n, double eta)
        {
            double ndoti = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ndoti * ndoti);
            return k < 0 ? double4.zero : eta * i - (eta * ndoti + double.Sqrt(k)) * n;
        }
        /// <summary>
        /// Returns a vector facing the same direction as the normal, based on the sign of the dot product with the incident vector.
        /// </summary>
        /// <param name="n">The normal vector.</param>
        /// <param name="i">The incident vector.</param>
        /// <param name="ng">The geometric normal vector.</param>
        /// <returns><paramref name="n"/> if the dot product of <paramref name="ng"/> and <paramref name="i"/> is negative; otherwise, the negation of <paramref name="n"/>.</returns>
        public static double4 faceforward(double4 n, double4 i, double4 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two edge vectors.
        /// </summary>
        /// <param name="edge0">The vector of lower edges of the transition.</param>
        /// <param name="edge1">The vector of upper edges of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static double4 smoothstep(double4 edge0, double4 edge1, double4 x)
        {
            double4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double4(3.0, 3.0, 3.0, 3.0) - 2.0 * t);
        }
        /// <summary>
        /// Performs a component-wise smooth Hermite interpolation between two scalar edges.
        /// </summary>
        /// <param name="edge0">The lower edge of the transition.</param>
        /// <param name="edge1">The upper edge of the transition.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the component-wise smoothstep interpolation results.</returns>
        public static double4 smoothstep(double edge0, double edge1, double4 x)
        {
            double4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double4(3.0, 3.0, 3.0, 3.0) - 2.0 * t);
        }

        // Step
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against the corresponding component of an edge vector.
        /// </summary>
        /// <param name="edge">The vector of edge values.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to that of <paramref name="edge"/>, and 0 otherwise.</returns>
        public static double4 step(double4 edge, double4 x) => new double4(x.x >= edge.x ? 1.0 : 0.0, x.y >= edge.y ? 1.0 : 0.0, x.z >= edge.z ? 1.0 : 0.0, x.w >= edge.w ? 1.0 : 0.0);
        /// <summary>
        /// Returns 0 or 1 for each component by comparing against a scalar edge value.
        /// </summary>
        /// <param name="edge">The scalar edge value.</param>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is 1 if the corresponding component of <paramref name="x"/> is greater than or equal to <paramref name="edge"/>, and 0 otherwise.</returns>
        public static double4 step(double edge, double4 x) => new double4(x.x >= edge ? 1.0 : 0.0, x.y >= edge ? 1.0 : 0.0, x.z >= edge ? 1.0 : 0.0, x.w >= edge ? 1.0 : 0.0);

        // Modf
        /// <summary>
        /// Splits each component of the specified vector into its integral and fractional parts.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <param name="intPart">When this method returns, contains the component-wise integral parts of <paramref name="x"/>.</param>
        /// <returns>A vector containing the component-wise fractional parts of <paramref name="x"/>.</returns>
        public static double4 modf(double4 x, out double4 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (4D cross product is not standard in HLSL, but here's a 4D implementation using 3D components)
        /// <summary>
        /// Computes a cross-product-like vector using the x, y, and z components of the input vectors; the w component of the result is set to zero.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>A vector whose x, y, and z components are the cross product of the corresponding components of <paramref name="a"/> and <paramref name="b"/>, and whose w component is zero.</returns>
        /// <remarks>The cross product is not defined for 4D vectors in HLSL; this overload exists for convenience when working with 4-component vectors whose first three components represent a 3D direction.</remarks>
        public static double4 cross(double4 a, double4 b) => new double4(
            a.y * b.z - a.z * b.y,
            a.z * b.x - a.x * b.z,
            a.x * b.y - a.y * b.x,
            0.0
        );

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
        public static int4 abs(int4 x) => new int4(int.Abs(x.x), int.Abs(x.y), int.Abs(x.z), int.Abs(x.w));
        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static int4 clamp(int4 x, int4 min, int4 max) => new int4(int.Clamp(x.x, min.x, max.x), int.Clamp(x.y, min.y, max.y), int.Clamp(x.z, min.z, max.z), int.Clamp(x.w, min.w, max.w));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static int4 max(int4 x, int4 y) => new int4(int.Max(x.x, y.x), int.Max(x.y, y.y), int.Max(x.z, y.z), int.Max(x.w, y.w));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static int4 min(int4 x, int4 y) => new int4(int.Min(x.x, y.x), int.Min(x.y, y.y), int.Min(x.z, y.z), int.Min(x.w, y.w));
        /// <summary>
        /// Returns the sign of each component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector where each component is -1, 0, or 1 depending on the sign of the corresponding component of <paramref name="x"/>.</returns>
        public static int4 sign(int4 x) => new int4(int.Sign(x.x), int.Sign(x.y), int.Sign(x.z), int.Sign(x.w));

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static int cmin(int4 x) => int.Min(x.x, int.Min(x.y, int.Min(x.z, x.w)));
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static int cmax(int4 x) => int.Max(x.x, int.Max(x.y, int.Max(x.z, x.w)));
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static int csum(int4 x) => x.x + x.y + x.z + x.w;

        #endregion int
        #region uint

        /// <summary>
        /// Clamps each component of the specified vector to the corresponding component of the minimum and maximum vectors.
        /// </summary>
        /// <param name="x">The vector to clamp.</param>
        /// <param name="min">The vector containing the minimum values for each component.</param>
        /// <param name="max">The vector containing the maximum values for each component.</param>
        /// <returns>A vector with each component clamped to the range [<paramref name="min"/>, <paramref name="max"/>].</returns>
        public static uint4 clamp(uint4 x, uint4 min, uint4 max) => new uint4(uint.Clamp(x.x, min.x, max.x), uint.Clamp(x.y, min.y, max.y), uint.Clamp(x.z, min.z, max.z), uint.Clamp(x.w, min.w, max.w));
        /// <summary>
        /// Selects the greater of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise maximum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static uint4 max(uint4 x, uint4 y) => new uint4(uint.Max(x.x, y.x), uint.Max(x.y, y.y), uint.Max(x.z, y.z), uint.Max(x.w, y.w));
        /// <summary>
        /// Selects the lesser of each corresponding pair of components from two vectors.
        /// </summary>
        /// <param name="x">The first vector to compare.</param>
        /// <param name="y">The second vector to compare.</param>
        /// <returns>A vector containing the component-wise minimum of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public static uint4 min(uint4 x, uint4 y) => new uint4(uint.Min(x.x, y.x), uint.Min(x.y, y.y), uint.Min(x.z, y.z), uint.Min(x.w, y.w));

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static uint cmin(uint4 x) => uint.Min(x.x, uint.Min(x.y, uint.Min(x.z, x.w)));
        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static uint cmax(uint4 x) => uint.Max(x.x, uint.Max(x.y, uint.Max(x.z, x.w)));
        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static uint csum(uint4 x) => x.x + x.y + x.z + x.w;

        #endregion uint
        #region bool

        /// <summary>
        /// Determines whether any component of the specified boolean vector is <see langword="true"/>.
        /// </summary>
        /// <param name="x">The input boolean vector.</param>
        /// <returns>A boolean vector representing the component-wise result of the any operation.</returns>
        public static bool4 any(bool4 x) => x.any;
        /// <summary>
        /// Determines whether all components of the specified boolean vector are <see langword="true"/>.
        /// </summary>
        /// <param name="x">The input boolean vector.</param>
        /// <returns>A boolean vector representing the component-wise result of the all operation.</returns>
        public static bool4 all(bool4 x) => x.all;

        #endregion bool
        #region interpretation

        /// <summary>
        /// Reinterprets the bit pattern of each component of a <see cref="float4"/> as a signed 32-bit integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="int"/> values.</returns>
        public static int4 asint(float4 x) => new int4(BitConverter.SingleToInt32Bits(x.x), BitConverter.SingleToInt32Bits(x.y),
            BitConverter.SingleToInt32Bits(x.z), BitConverter.SingleToInt32Bits(x.w));
        /// <summary>
        /// Reinterprets the bit pattern of each component of a <see cref="float4"/> as an unsigned 32-bit integer.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="uint"/> values.</returns>
        public static uint4 asuint(float4 x) => new uint4(BitConverter.SingleToUInt32Bits(x.x), BitConverter.SingleToUInt32Bits(x.y),
            BitConverter.SingleToUInt32Bits(x.z), BitConverter.SingleToUInt32Bits(x.w));
        /// <summary>
        /// Reinterprets the bit pattern of each component of an <see cref="int4"/> as a <see cref="float"/>.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="float"/> values.</returns>
        public static float4 asfloat(int4 x) => new float4(BitConverter.Int32BitsToSingle(x.x), BitConverter.Int32BitsToSingle(x.y),
            BitConverter.Int32BitsToSingle(x.z), BitConverter.Int32BitsToSingle(x.w));
        /// <summary>
        /// Reinterprets the bit pattern of each component of a <see cref="uint4"/> as a <see cref="float"/>.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>A vector containing the bit patterns of <paramref name="x"/> reinterpreted as <see cref="float"/> values.</returns>
        public static float4 asfloat(uint4 x) => new float4(BitConverter.UInt32BitsToSingle(x.x), BitConverter.UInt32BitsToSingle(x.y),
            BitConverter.UInt32BitsToSingle(x.z), BitConverter.UInt32BitsToSingle(x.w));

        #endregion interpretation
        #region noise

        /// <summary>
        /// Returns itself, noise is not deterministic and varies per GPU device.
        /// </summary>
        /// <returns>Input (x)</returns>
        /// <remarks>This is only for compatibility and is not useful on the C# CPU side</remarks>
        public static float4 noise(float4 x) => x;
        // Implement true noise here later

        #endregion noise
    }
}
