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
    /// HLSL's matrix intrinsics (<c>mul</c>, <c>transpose</c>, <c>determinant</c>) exposed as free
    /// functions, so <c>math.mul(a, b)</c> becomes <c>mul(a, b)</c> when the prefix is stripped.
    /// </summary>
    public static partial class math
#pragma warning restore CS8981
    {
        #region mul
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float2x2 mul(float2x2 m, float s) => float2x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float2x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float2 mul(float2x2 m, float2 v) => float2x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float2x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float2 mul(float2 v, float2x2 m) => float2x2.mul(v, m);
        /// <summary>
        /// Multiplies two <see cref="float2x2"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x2 mul(float2x2 a, float2x2 b) => float2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float2x2"/> by a <see cref="float2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x3 mul(float2x2 a, float2x3 b) => float2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float2x2"/> by a <see cref="float2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x4 mul(float2x2 a, float2x4 b) => float2x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float2x3 mul(float2x3 m, float s) => float2x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float2x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float2 mul(float2x3 m, float3 v) => float2x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float2x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float2 v, float2x3 m) => float2x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float2x3"/> by a <see cref="float3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x2 mul(float2x3 a, float3x2 b) => float2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float2x3"/> by a <see cref="float3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x3 mul(float2x3 a, float3x3 b) => float2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float2x3"/> by a <see cref="float3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x4 mul(float2x3 a, float3x4 b) => float2x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float2x4 mul(float2x4 m, float s) => float2x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float2x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float2 mul(float2x4 m, float4 v) => float2x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float2x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float2 v, float2x4 m) => float2x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float2x4"/> by a <see cref="float4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x2 mul(float2x4 a, float4x2 b) => float2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float2x4"/> by a <see cref="float4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x3 mul(float2x4 a, float4x3 b) => float2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float2x4"/> by a <see cref="float4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float2x4 mul(float2x4 a, float4x4 b) => float2x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float3x2 mul(float3x2 m, float s) => float3x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float3x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float3x2 m, float2 v) => float3x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float3x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float2 mul(float3 v, float3x2 m) => float3x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float3x2"/> by a <see cref="float2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x2 mul(float3x2 a, float2x2 b) => float3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float3x2"/> by a <see cref="float2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x3 mul(float3x2 a, float2x3 b) => float3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float3x2"/> by a <see cref="float2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x4 mul(float3x2 a, float2x4 b) => float3x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float3x3 mul(float3x3 m, float s) => float3x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float3x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float3x3 m, float3 v) => float3x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float3x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float3 v, float3x3 m) => float3x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float3x3"/> by a <see cref="float3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x2 mul(float3x3 a, float3x2 b) => float3x3.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="float3x3"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x3 mul(float3x3 a, float3x3 b) => float3x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float3x3"/> by a <see cref="float3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x4 mul(float3x3 a, float3x4 b) => float3x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float3x4 mul(float3x4 m, float s) => float3x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float3x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float3x4 m, float4 v) => float3x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float3x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float3 v, float3x4 m) => float3x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float3x4"/> by a <see cref="float4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x2 mul(float3x4 a, float4x2 b) => float3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float3x4"/> by a <see cref="float4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x3 mul(float3x4 a, float4x3 b) => float3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float3x4"/> by a <see cref="float4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x4 mul(float3x4 a, float4x4 b) => float3x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float4x2 mul(float4x2 m, float s) => float4x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float4x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float4x2 m, float2 v) => float4x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float4x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float2 mul(float4 v, float4x2 m) => float4x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float4x2"/> by a <see cref="float2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x2 mul(float4x2 a, float2x2 b) => float4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float4x2"/> by a <see cref="float2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x3 mul(float4x2 a, float2x3 b) => float4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float4x2"/> by a <see cref="float2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x4 mul(float4x2 a, float2x4 b) => float4x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float4x3 mul(float4x3 m, float s) => float4x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float4x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float4x3 m, float3 v) => float4x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float4x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float4 v, float4x3 m) => float4x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float4x3"/> by a <see cref="float3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x2 mul(float4x3 a, float3x2 b) => float4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float4x3"/> by a <see cref="float3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x3 mul(float4x3 a, float3x3 b) => float4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float4x3"/> by a <see cref="float3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x4 mul(float4x3 a, float3x4 b) => float4x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float4x4 mul(float4x4 m, float s) => float4x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="float4x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float4x4 m, float4 v) => float4x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="float4x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float4 v, float4x4 m) => float4x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="float4x4"/> by a <see cref="float4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x2 mul(float4x4 a, float4x2 b) => float4x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="float4x4"/> by a <see cref="float4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x3 mul(float4x4 a, float4x3 b) => float4x4.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="float4x4"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x4 mul(float4x4 a, float4x4 b) => float4x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half2x2 mul(half2x2 m, float s) => half2x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half2x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half2x2 m, half2 v) => half2x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half2x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half2 v, half2x2 m) => half2x2.mul(v, m);
        /// <summary>
        /// Multiplies two <see cref="half2x2"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x2 mul(half2x2 a, half2x2 b) => half2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half2x2"/> by a <see cref="half2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x3 mul(half2x2 a, half2x3 b) => half2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half2x2"/> by a <see cref="half2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x4 mul(half2x2 a, half2x4 b) => half2x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half2x3 mul(half2x3 m, float s) => half2x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half2x3 m, half3 v) => half2x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half2x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half2 v, half2x3 m) => half2x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a <see cref="half3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x2 mul(half2x3 a, half3x2 b) => half2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a <see cref="half3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x3 mul(half2x3 a, half3x3 b) => half2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a <see cref="half3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x4 mul(half2x3 a, half3x4 b) => half2x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half2x4 mul(half2x4 m, float s) => half2x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half2x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half2x4 m, half4 v) => half2x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half2x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half4 mul(half2 v, half2x4 m) => half2x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half2x4"/> by a <see cref="half4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x2 mul(half2x4 a, half4x2 b) => half2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half2x4"/> by a <see cref="half4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x3 mul(half2x4 a, half4x3 b) => half2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half2x4"/> by a <see cref="half4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x4 mul(half2x4 a, half4x4 b) => half2x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half3x2 mul(half3x2 m, float s) => half3x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half3x2 m, half2 v) => half3x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half3x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half3 v, half3x2 m) => half3x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a <see cref="half2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x2 mul(half3x2 a, half2x2 b) => half3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a <see cref="half2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x3 mul(half3x2 a, half2x3 b) => half3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a <see cref="half2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x4 mul(half3x2 a, half2x4 b) => half3x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half3x3 mul(half3x3 m, float s) => half3x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half3x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half3x3 m, half3 v) => half3x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half3x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half3 v, half3x3 m) => half3x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half3x3"/> by a <see cref="half3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x2 mul(half3x3 a, half3x2 b) => half3x3.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="half3x3"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x3 mul(half3x3 a, half3x3 b) => half3x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half3x3"/> by a <see cref="half3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x4 mul(half3x3 a, half3x4 b) => half3x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half3x4 mul(half3x4 m, float s) => half3x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half3x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half3x4 m, half4 v) => half3x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half3x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half4 mul(half3 v, half3x4 m) => half3x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half3x4"/> by a <see cref="half4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x2 mul(half3x4 a, half4x2 b) => half3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half3x4"/> by a <see cref="half4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x3 mul(half3x4 a, half4x3 b) => half3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half3x4"/> by a <see cref="half4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x4 mul(half3x4 a, half4x4 b) => half3x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half4x2 mul(half4x2 m, float s) => half4x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half4x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half4 mul(half4x2 m, half2 v) => half4x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half4x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half4 v, half4x2 m) => half4x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half4x2"/> by a <see cref="half2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x2 mul(half4x2 a, half2x2 b) => half4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half4x2"/> by a <see cref="half2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x3 mul(half4x2 a, half2x3 b) => half4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half4x2"/> by a <see cref="half2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x4 mul(half4x2 a, half2x4 b) => half4x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half4x3 mul(half4x3 m, float s) => half4x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half4x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half4 mul(half4x3 m, half3 v) => half4x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half4x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half4 v, half4x3 m) => half4x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half4x3"/> by a <see cref="half3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x2 mul(half4x3 a, half3x2 b) => half4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half4x3"/> by a <see cref="half3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x3 mul(half4x3 a, half3x3 b) => half4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half4x3"/> by a <see cref="half3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x4 mul(half4x3 a, half3x4 b) => half4x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half4x4 mul(half4x4 m, float s) => half4x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="half4x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half4 mul(half4x4 m, half4 v) => half4x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="half4x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half4 mul(half4 v, half4x4 m) => half4x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="half4x4"/> by a <see cref="half4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x2 mul(half4x4 a, half4x2 b) => half4x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="half4x4"/> by a <see cref="half4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x3 mul(half4x4 a, half4x3 b) => half4x4.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="half4x4"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half4x4 mul(half4x4 a, half4x4 b) => half4x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double2x2 mul(double2x2 m, double s) => double2x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double2x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double2x2 m, double2 v) => double2x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double2x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double2 v, double2x2 m) => double2x2.mul(v, m);
        /// <summary>
        /// Multiplies two <see cref="double2x2"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x2 mul(double2x2 a, double2x2 b) => double2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double2x2"/> by a <see cref="double2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x3 mul(double2x2 a, double2x3 b) => double2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double2x2"/> by a <see cref="double2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x4 mul(double2x2 a, double2x4 b) => double2x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double2x3 mul(double2x3 m, double s) => double2x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double2x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double2x3 m, double3 v) => double2x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double2x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double3 mul(double2 v, double2x3 m) => double2x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double2x3"/> by a <see cref="double3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x2 mul(double2x3 a, double3x2 b) => double2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double2x3"/> by a <see cref="double3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x3 mul(double2x3 a, double3x3 b) => double2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double2x3"/> by a <see cref="double3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x4 mul(double2x3 a, double3x4 b) => double2x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double2x4 mul(double2x4 m, double s) => double2x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double2x4 m, double4 v) => double2x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double2x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double4 mul(double2 v, double2x4 m) => double2x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a <see cref="double4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x2 mul(double2x4 a, double4x2 b) => double2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a <see cref="double4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x3 mul(double2x4 a, double4x3 b) => double2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a <see cref="double4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x4 mul(double2x4 a, double4x4 b) => double2x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double3x2 mul(double3x2 m, double s) => double3x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double3 mul(double3x2 m, double2 v) => double3x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double3x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double3 v, double3x2 m) => double3x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a <see cref="double2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x2 mul(double3x2 a, double2x2 b) => double3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a <see cref="double2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x3 mul(double3x2 a, double2x3 b) => double3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a <see cref="double2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x4 mul(double3x2 a, double2x4 b) => double3x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double3x3 mul(double3x3 m, double s) => double3x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double3x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double3 mul(double3x3 m, double3 v) => double3x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double3x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double3 mul(double3 v, double3x3 m) => double3x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double3x3"/> by a <see cref="double3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x2 mul(double3x3 a, double3x2 b) => double3x3.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="double3x3"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x3 mul(double3x3 a, double3x3 b) => double3x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double3x3"/> by a <see cref="double3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x4 mul(double3x3 a, double3x4 b) => double3x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double3x4 mul(double3x4 m, double s) => double3x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double3x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double3 mul(double3x4 m, double4 v) => double3x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double3x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double4 mul(double3 v, double3x4 m) => double3x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double3x4"/> by a <see cref="double4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x2 mul(double3x4 a, double4x2 b) => double3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double3x4"/> by a <see cref="double4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x3 mul(double3x4 a, double4x3 b) => double3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double3x4"/> by a <see cref="double4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x4 mul(double3x4 a, double4x4 b) => double3x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double4x2 mul(double4x2 m, double s) => double4x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double4x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double4 mul(double4x2 m, double2 v) => double4x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double4x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double4 v, double4x2 m) => double4x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double4x2"/> by a <see cref="double2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x2 mul(double4x2 a, double2x2 b) => double4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double4x2"/> by a <see cref="double2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x3 mul(double4x2 a, double2x3 b) => double4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double4x2"/> by a <see cref="double2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x4 mul(double4x2 a, double2x4 b) => double4x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double4x3 mul(double4x3 m, double s) => double4x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double4x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double4 mul(double4x3 m, double3 v) => double4x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double4x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double3 mul(double4 v, double4x3 m) => double4x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double4x3"/> by a <see cref="double3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x2 mul(double4x3 a, double3x2 b) => double4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double4x3"/> by a <see cref="double3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x3 mul(double4x3 a, double3x3 b) => double4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double4x3"/> by a <see cref="double3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x4 mul(double4x3 a, double3x4 b) => double4x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double4x4 mul(double4x4 m, double s) => double4x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="double4x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double4 mul(double4x4 m, double4 v) => double4x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="double4x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double4 mul(double4 v, double4x4 m) => double4x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="double4x4"/> by a <see cref="double4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x2 mul(double4x4 a, double4x2 b) => double4x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="double4x4"/> by a <see cref="double4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x3 mul(double4x4 a, double4x3 b) => double4x4.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="double4x4"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double4x4 mul(double4x4 a, double4x4 b) => double4x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int2x2 mul(int2x2 m, int s) => int2x2.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int2x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int2 mul(int2x2 m, int2 v) => int2x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int2x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int2 mul(int2 v, int2x2 m) => int2x2.mul(v, m);
        /// <summary>
        /// Multiplies two <see cref="int2x2"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x2 mul(int2x2 a, int2x2 b) => int2x2.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int2x2"/> by an <see cref="int2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x3 mul(int2x2 a, int2x3 b) => int2x2.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int2x2"/> by an <see cref="int2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x4 mul(int2x2 a, int2x4 b) => int2x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int2x3 mul(int2x3 m, int s) => int2x3.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int2x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int2 mul(int2x3 m, int3 v) => int2x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int2x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int2 v, int2x3 m) => int2x3.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int2x3"/> by an <see cref="int3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x2 mul(int2x3 a, int3x2 b) => int2x3.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int2x3"/> by an <see cref="int3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x3 mul(int2x3 a, int3x3 b) => int2x3.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int2x3"/> by an <see cref="int3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x4 mul(int2x3 a, int3x4 b) => int2x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int2x4 mul(int2x4 m, int s) => int2x4.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int2x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int2 mul(int2x4 m, int4 v) => int2x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int2x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int4 mul(int2 v, int2x4 m) => int2x4.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int2x4"/> by an <see cref="int4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x2 mul(int2x4 a, int4x2 b) => int2x4.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int2x4"/> by an <see cref="int4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x3 mul(int2x4 a, int4x3 b) => int2x4.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int2x4"/> by an <see cref="int4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int2x4 mul(int2x4 a, int4x4 b) => int2x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int3x2 mul(int3x2 m, int s) => int3x2.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int3x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int3x2 m, int2 v) => int3x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int3x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int2 mul(int3 v, int3x2 m) => int3x2.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int3x2"/> by an <see cref="int2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x2 mul(int3x2 a, int2x2 b) => int3x2.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int3x2"/> by an <see cref="int2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x3 mul(int3x2 a, int2x3 b) => int3x2.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int3x2"/> by an <see cref="int2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x4 mul(int3x2 a, int2x4 b) => int3x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int3x3 mul(int3x3 m, int s) => int3x3.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int3x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int3x3 m, int3 v) => int3x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int3x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int3 v, int3x3 m) => int3x3.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int3x3"/> by an <see cref="int3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x2 mul(int3x3 a, int3x2 b) => int3x3.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="int3x3"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x3 mul(int3x3 a, int3x3 b) => int3x3.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int3x3"/> by an <see cref="int3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x4 mul(int3x3 a, int3x4 b) => int3x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int3x4 mul(int3x4 m, int s) => int3x4.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int3x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int3x4 m, int4 v) => int3x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int3x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int4 mul(int3 v, int3x4 m) => int3x4.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int3x4"/> by an <see cref="int4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x2 mul(int3x4 a, int4x2 b) => int3x4.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int3x4"/> by an <see cref="int4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x3 mul(int3x4 a, int4x3 b) => int3x4.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int3x4"/> by an <see cref="int4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x4 mul(int3x4 a, int4x4 b) => int3x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int4x2 mul(int4x2 m, int s) => int4x2.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int4 mul(int4x2 m, int2 v) => int4x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int4x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int2 mul(int4 v, int4x2 m) => int4x2.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by an <see cref="int2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x2 mul(int4x2 a, int2x2 b) => int4x2.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by an <see cref="int2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x3 mul(int4x2 a, int2x3 b) => int4x2.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by an <see cref="int2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x4 mul(int4x2 a, int2x4 b) => int4x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int4x3 mul(int4x3 m, int s) => int4x3.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int4x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int4 mul(int4x3 m, int3 v) => int4x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int4x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int4 v, int4x3 m) => int4x3.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int4x3"/> by an <see cref="int3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x2 mul(int4x3 a, int3x2 b) => int4x3.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int4x3"/> by an <see cref="int3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x3 mul(int4x3 a, int3x3 b) => int4x3.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int4x3"/> by an <see cref="int3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x4 mul(int4x3 a, int3x4 b) => int4x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int4x4 mul(int4x4 m, int s) => int4x4.mul(m, s);
        /// <summary>
        /// Multiplies an <see cref="int4x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int4 mul(int4x4 m, int4 v) => int4x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by an <see cref="int4x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int4 mul(int4 v, int4x4 m) => int4x4.mul(v, m);
        /// <summary>
        /// Multiplies an <see cref="int4x4"/> by an <see cref="int4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x2 mul(int4x4 a, int4x2 b) => int4x4.mul(a, b);
        /// <summary>
        /// Multiplies an <see cref="int4x4"/> by an <see cref="int4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x3 mul(int4x4 a, int4x3 b) => int4x4.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="int4x4"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x4 mul(int4x4 a, int4x4 b) => int4x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint2x2 mul(uint2x2 m, uint s) => uint2x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint2x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint2x2 m, uint2 v) => uint2x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint2x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint2 v, uint2x2 m) => uint2x2.mul(v, m);
        /// <summary>
        /// Multiplies two <see cref="uint2x2"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x2 mul(uint2x2 a, uint2x2 b) => uint2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint2x2"/> by a <see cref="uint2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x3 mul(uint2x2 a, uint2x3 b) => uint2x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint2x2"/> by a <see cref="uint2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x4 mul(uint2x2 a, uint2x4 b) => uint2x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint2x3 mul(uint2x3 m, uint s) => uint2x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint2x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint2x3 m, uint3 v) => uint2x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint2x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint3 mul(uint2 v, uint2x3 m) => uint2x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint2x3"/> by a <see cref="uint3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x2 mul(uint2x3 a, uint3x2 b) => uint2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint2x3"/> by a <see cref="uint3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x3 mul(uint2x3 a, uint3x3 b) => uint2x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint2x3"/> by a <see cref="uint3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x4 mul(uint2x3 a, uint3x4 b) => uint2x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint2x4 mul(uint2x4 m, uint s) => uint2x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint2x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint2x4 m, uint4 v) => uint2x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint2x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint2 v, uint2x4 m) => uint2x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint2x4"/> by a <see cref="uint4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x2 mul(uint2x4 a, uint4x2 b) => uint2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint2x4"/> by a <see cref="uint4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x3 mul(uint2x4 a, uint4x3 b) => uint2x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint2x4"/> by a <see cref="uint4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x4 mul(uint2x4 a, uint4x4 b) => uint2x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint3x2 mul(uint3x2 m, uint s) => uint3x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint3x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint3 mul(uint3x2 m, uint2 v) => uint3x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint3x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint3 v, uint3x2 m) => uint3x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint3x2"/> by a <see cref="uint2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x2 mul(uint3x2 a, uint2x2 b) => uint3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint3x2"/> by a <see cref="uint2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x3 mul(uint3x2 a, uint2x3 b) => uint3x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint3x2"/> by a <see cref="uint2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x4 mul(uint3x2 a, uint2x4 b) => uint3x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint3x3 mul(uint3x3 m, uint s) => uint3x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint3x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint3 mul(uint3x3 m, uint3 v) => uint3x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint3x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint3 mul(uint3 v, uint3x3 m) => uint3x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint3x3"/> by a <see cref="uint3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x2 mul(uint3x3 a, uint3x2 b) => uint3x3.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="uint3x3"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x3 mul(uint3x3 a, uint3x3 b) => uint3x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint3x3"/> by a <see cref="uint3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x4 mul(uint3x3 a, uint3x4 b) => uint3x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint3x4 mul(uint3x4 m, uint s) => uint3x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint3x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint3 mul(uint3x4 m, uint4 v) => uint3x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint3x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint3 v, uint3x4 m) => uint3x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint3x4"/> by a <see cref="uint4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x2 mul(uint3x4 a, uint4x2 b) => uint3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint3x4"/> by a <see cref="uint4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x3 mul(uint3x4 a, uint4x3 b) => uint3x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint3x4"/> by a <see cref="uint4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint3x4 mul(uint3x4 a, uint4x4 b) => uint3x4.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint4x2 mul(uint4x2 m, uint s) => uint4x2.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint4x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint4x2 m, uint2 v) => uint4x2.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint4x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint4 v, uint4x2 m) => uint4x2.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint4x2"/> by a <see cref="uint2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x2 mul(uint4x2 a, uint2x2 b) => uint4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint4x2"/> by a <see cref="uint2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x3 mul(uint4x2 a, uint2x3 b) => uint4x2.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint4x2"/> by a <see cref="uint2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x4 mul(uint4x2 a, uint2x4 b) => uint4x2.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint4x3 mul(uint4x3 m, uint s) => uint4x3.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint4x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint4x3 m, uint3 v) => uint4x3.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint4x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint3 mul(uint4 v, uint4x3 m) => uint4x3.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint4x3"/> by a <see cref="uint3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x2 mul(uint4x3 a, uint3x2 b) => uint4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint4x3"/> by a <see cref="uint3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x3 mul(uint4x3 a, uint3x3 b) => uint4x3.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint4x3"/> by a <see cref="uint3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x4 mul(uint4x3 a, uint3x4 b) => uint4x3.mul(a, b);
        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint4x4 mul(uint4x4 m, uint s) => uint4x4.mul(m, s);
        /// <summary>
        /// Multiplies a <see cref="uint4x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint4x4 m, uint4 v) => uint4x4.mul(m, v);
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint4x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint4 v, uint4x4 m) => uint4x4.mul(v, m);
        /// <summary>
        /// Multiplies a <see cref="uint4x4"/> by a <see cref="uint4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x2 mul(uint4x4 a, uint4x2 b) => uint4x4.mul(a, b);
        /// <summary>
        /// Multiplies a <see cref="uint4x4"/> by a <see cref="uint4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x3 mul(uint4x4 a, uint4x3 b) => uint4x4.mul(a, b);
        /// <summary>
        /// Multiplies two <see cref="uint4x4"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x4 mul(uint4x4 a, uint4x4 b) => uint4x4.mul(a, b);
        #endregion

        #region transpose
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool2x2 transpose(bool2x2 m) => bool2x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool3x2 transpose(bool2x3 m) => bool2x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool4x2 transpose(bool2x4 m) => bool2x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool2x3 transpose(bool3x2 m) => bool3x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool3x3 transpose(bool3x3 m) => bool3x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool4x3 transpose(bool3x4 m) => bool3x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool2x4 transpose(bool4x2 m) => bool4x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool3x4 transpose(bool4x3 m) => bool4x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool4x4 transpose(bool4x4 m) => bool4x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float2x2 transpose(float2x2 m) => float2x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float3x2 transpose(float2x3 m) => float2x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float4x2 transpose(float2x4 m) => float2x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float2x3 transpose(float3x2 m) => float3x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float3x3 transpose(float3x3 m) => float3x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float4x3 transpose(float3x4 m) => float3x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float2x4 transpose(float4x2 m) => float4x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float3x4 transpose(float4x3 m) => float4x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float4x4 transpose(float4x4 m) => float4x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half2x2 transpose(half2x2 m) => half2x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half3x2 transpose(half2x3 m) => half2x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half4x2 transpose(half2x4 m) => half2x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half2x3 transpose(half3x2 m) => half3x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half3x3 transpose(half3x3 m) => half3x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half4x3 transpose(half3x4 m) => half3x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half2x4 transpose(half4x2 m) => half4x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half3x4 transpose(half4x3 m) => half4x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half4x4 transpose(half4x4 m) => half4x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double2x2 transpose(double2x2 m) => double2x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double3x2 transpose(double2x3 m) => double2x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double4x2 transpose(double2x4 m) => double2x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double2x3 transpose(double3x2 m) => double3x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double3x3 transpose(double3x3 m) => double3x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double4x3 transpose(double3x4 m) => double3x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double2x4 transpose(double4x2 m) => double4x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double3x4 transpose(double4x3 m) => double4x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double4x4 transpose(double4x4 m) => double4x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int2x2 transpose(int2x2 m) => int2x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int3x2 transpose(int2x3 m) => int2x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int4x2 transpose(int2x4 m) => int2x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int2x3 transpose(int3x2 m) => int3x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int3x3 transpose(int3x3 m) => int3x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int4x3 transpose(int3x4 m) => int3x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int2x4 transpose(int4x2 m) => int4x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int3x4 transpose(int4x3 m) => int4x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int4x4 transpose(int4x4 m) => int4x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint2x2 transpose(uint2x2 m) => uint2x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint3x2 transpose(uint2x3 m) => uint2x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint4x2 transpose(uint2x4 m) => uint2x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint2x3 transpose(uint3x2 m) => uint3x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint3x3 transpose(uint3x3 m) => uint3x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint4x3 transpose(uint3x4 m) => uint3x4.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint2x4 transpose(uint4x2 m) => uint4x2.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint3x4 transpose(uint4x3 m) => uint4x3.transpose(m);
        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint4x4 transpose(uint4x4 m) => uint4x4.transpose(m);
        #endregion

        #region determinant
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(float2x2 m) => float2x2.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(float3x3 m) => float3x3.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(float4x4 m) => float4x4.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(half2x2 m) => half2x2.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(half3x3 m) => half3x3.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(half4x4 m) => half4x4.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static double determinant(double2x2 m) => double2x2.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static double determinant(double3x3 m) => double3x3.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static double determinant(double4x4 m) => double4x4.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified integer matrix, promoting to float.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(int2x2 m) => int2x2.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified integer matrix, promoting to float.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(int3x3 m) => int3x3.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified integer matrix, promoting to float.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(int4x4 m) => int4x4.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified integer matrix, promoting to float.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(uint2x2 m) => uint2x2.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified integer matrix, promoting to float.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(uint3x3 m) => uint3x3.determinant(m);
        /// <summary>
        /// Computes the determinant of the specified integer matrix, promoting to float.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(uint4x4 m) => uint4x4.determinant(m);
        #endregion
    }
}
