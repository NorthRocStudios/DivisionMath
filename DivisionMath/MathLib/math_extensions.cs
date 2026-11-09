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
    /// <summary>
    /// CPU-only convenience helpers that have no HLSL intrinsic equivalent: component reductions
    /// (<c>cmin</c>, <c>cmax</c>, <c>csum</c>, <c>lengthsq</c>) and vector-pair determinants.
    /// DivisionTranslate must expand these instead of emitting them verbatim into a shader.
    /// </summary>
    public static partial class math
#pragma warning restore CS8981
    {
        #region Non-HLSL extensions
        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static float lengthsq(float2 x) => dot(x, x);

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

        /// <summary>
        /// Computes the determinant of two 2D vectors, which is equivalent to their 2D cross product.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>The determinant of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static float determinant(float2 a, float2 b) => cross(a, b);

        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static double lengthsq(double2 x) => dot(x, x);

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

        /// <summary>
        /// Computes the determinant of two 2D vectors, which is equivalent to their 2D cross product.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns>The determinant of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static double determinant(double2 a, double2 b) => cross(a, b);

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

        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static float lengthsq(float3 x) => dot(x, x);

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static float cmin(float3 x) => float.Min(x.x, float.Min(x.y, x.z));

        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static float cmax(float3 x) => float.Max(x.x, float.Max(x.y, x.z));

        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static float csum(float3 x) => x.x + x.y + x.z;

        /// <summary>
        /// Computes the determinant of a 3x3 matrix whose rows (or columns) are the specified vectors.
        /// </summary>
        /// <param name="a">The first row (or column) vector.</param>
        /// <param name="b">The second row (or column) vector.</param>
        /// <param name="c">The third row (or column) vector.</param>
        /// <returns>The determinant of the 3x3 matrix formed from <paramref name="a"/>, <paramref name="b"/>, and <paramref name="c"/>.</returns>
        public static float determinant(float3 a, float3 b, float3 c) => dot(a, cross(b, c));

        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static double lengthsq(double3 x) => dot(x, x);

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static double cmin(double3 x) => double.Min(x.x, double.Min(x.y, x.z));

        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static double cmax(double3 x) => double.Max(x.x, double.Max(x.y, x.z));

        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static double csum(double3 x) => x.x + x.y + x.z;

        /// <summary>
        /// Computes the determinant of a 3x3 matrix whose rows (or columns) are the specified vectors.
        /// </summary>
        /// <param name="a">The first row (or column) vector.</param>
        /// <param name="b">The second row (or column) vector.</param>
        /// <param name="c">The third row (or column) vector.</param>
        /// <returns>The determinant of the 3x3 matrix formed from <paramref name="a"/>, <paramref name="b"/>, and <paramref name="c"/>.</returns>
        public static double determinant(double3 a, double3 b, double3 c) => dot(a, cross(b, c));

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static int cmin(int3 x) => int.Min(x.x, int.Min(x.y, x.z));

        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static int cmax(int3 x) => int.Max(x.x, int.Max(x.y, x.z));

        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static int csum(int3 x) => x.x + x.y + x.z;

        /// <summary>
        /// Returns the smallest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The minimum of the components of <paramref name="x"/>.</returns>
        public static uint cmin(uint3 x) => uint.Min(x.x, uint.Min(x.y, x.z));

        /// <summary>
        /// Returns the largest component of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The maximum of the components of <paramref name="x"/>.</returns>
        public static uint cmax(uint3 x) => uint.Max(x.x, uint.Max(x.y, x.z));

        /// <summary>
        /// Returns the sum of all components of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The sum of the components of <paramref name="x"/>.</returns>
        public static uint csum(uint3 x) => x.x + x.y + x.z;

        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static float lengthsq(float4 x) => dot(x, x);

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

        /// <summary>
        /// Computes the squared length (magnitude) of the specified vector.
        /// </summary>
        /// <param name="x">The input vector.</param>
        /// <returns>The squared length of <paramref name="x"/>, which avoids a square root operation.</returns>
        public static double lengthsq(double4 x) => dot(x, x);

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
        #endregion
    }
}