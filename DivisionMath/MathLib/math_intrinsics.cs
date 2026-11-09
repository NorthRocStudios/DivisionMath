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
    /// HLSL intrinsics that were missing from the original surface. Each entry mirrors the
    /// HLSL name, arity and argument order so the <c>math.</c> prefix can be stripped.
    /// </summary>
    public static partial class math
#pragma warning restore CS8981
    {
        #region mad

        /// <summary>Multiplies and adds: <c>a * b + c</c>.</summary>
        public static float mad(float a, float b, float c) => a * b + c;
        /// <summary>Multiplies and adds, component-wise.</summary>
        public static float2 mad(float2 a, float2 b, float2 c) => a * b + c;
        /// <summary>Multiplies and adds, component-wise.</summary>
        public static float3 mad(float3 a, float3 b, float3 c) => a * b + c;
        /// <summary>Multiplies and adds, component-wise.</summary>
        public static float4 mad(float4 a, float4 b, float4 c) => a * b + c;
        /// <summary>Multiplies and adds: <c>a * b + c</c>.</summary>
        public static double mad(double a, double b, double c) => a * b + c;
        /// <summary>Multiplies and adds, component-wise.</summary>
        public static double2 mad(double2 a, double2 b, double2 c) => a * b + c;
        /// <summary>Multiplies and adds, component-wise.</summary>
        public static double3 mad(double3 a, double3 b, double3 c) => a * b + c;
        /// <summary>Multiplies and adds, component-wise.</summary>
        public static double4 mad(double4 a, double4 b, double4 c) => a * b + c;

        #endregion
        #region fma

        /// <summary>Fused multiply-add: <c>a * b + c</c> with a single rounding.</summary>
        public static float fma(float a, float b, float c) => float.FusedMultiplyAdd(a, b, c);
        /// <summary>Fused multiply-add, component-wise.</summary>
        public static float2 fma(float2 a, float2 b, float2 c) => new float2(
            float.FusedMultiplyAdd(a.x, b.x, c.x), float.FusedMultiplyAdd(a.y, b.y, c.y));
        /// <summary>Fused multiply-add, component-wise.</summary>
        public static float3 fma(float3 a, float3 b, float3 c) => new float3(
            float.FusedMultiplyAdd(a.x, b.x, c.x), float.FusedMultiplyAdd(a.y, b.y, c.y), float.FusedMultiplyAdd(a.z, b.z, c.z));
        /// <summary>Fused multiply-add, component-wise.</summary>
        public static float4 fma(float4 a, float4 b, float4 c) => new float4(
            float.FusedMultiplyAdd(a.x, b.x, c.x), float.FusedMultiplyAdd(a.y, b.y, c.y),
            float.FusedMultiplyAdd(a.z, b.z, c.z), float.FusedMultiplyAdd(a.w, b.w, c.w));
        /// <summary>Fused multiply-add: <c>a * b + c</c> with a single rounding.</summary>
        public static double fma(double a, double b, double c) => double.FusedMultiplyAdd(a, b, c);
        /// <summary>Fused multiply-add, component-wise.</summary>
        public static double2 fma(double2 a, double2 b, double2 c) => new double2(
            double.FusedMultiplyAdd(a.x, b.x, c.x), double.FusedMultiplyAdd(a.y, b.y, c.y));
        /// <summary>Fused multiply-add, component-wise.</summary>
        public static double3 fma(double3 a, double3 b, double3 c) => new double3(
            double.FusedMultiplyAdd(a.x, b.x, c.x), double.FusedMultiplyAdd(a.y, b.y, c.y), double.FusedMultiplyAdd(a.z, b.z, c.z));
        /// <summary>Fused multiply-add, component-wise.</summary>
        public static double4 fma(double4 a, double4 b, double4 c) => new double4(
            double.FusedMultiplyAdd(a.x, b.x, c.x), double.FusedMultiplyAdd(a.y, b.y, c.y),
            double.FusedMultiplyAdd(a.z, b.z, c.z), double.FusedMultiplyAdd(a.w, b.w, c.w));

        #endregion
        #region fmod

        /// <summary>Floating-point remainder of <paramref name="x"/> divided by <paramref name="y"/>; the result takes the sign of <paramref name="x"/>.</summary>
        public static float fmod(float x, float y) => x - y * float.Truncate(x / y);
        /// <summary>Floating-point remainder, component-wise.</summary>
        public static float2 fmod(float2 x, float2 y) => new float2(fmod(x.x, y.x), fmod(x.y, y.y));
        /// <summary>Floating-point remainder, component-wise.</summary>
        public static float3 fmod(float3 x, float3 y) => new float3(fmod(x.x, y.x), fmod(x.y, y.y), fmod(x.z, y.z));
        /// <summary>Floating-point remainder, component-wise.</summary>
        public static float4 fmod(float4 x, float4 y) => new float4(fmod(x.x, y.x), fmod(x.y, y.y), fmod(x.z, y.z), fmod(x.w, y.w));
        /// <summary>Floating-point remainder of <paramref name="x"/> divided by <paramref name="y"/>; the result takes the sign of <paramref name="x"/>.</summary>
        public static double fmod(double x, double y) => x - y * double.Truncate(x / y);
        /// <summary>Floating-point remainder, component-wise.</summary>
        public static double2 fmod(double2 x, double2 y) => new double2(fmod(x.x, y.x), fmod(x.y, y.y));
        /// <summary>Floating-point remainder, component-wise.</summary>
        public static double3 fmod(double3 x, double3 y) => new double3(fmod(x.x, y.x), fmod(x.y, y.y), fmod(x.z, y.z));
        /// <summary>Floating-point remainder, component-wise.</summary>
        public static double4 fmod(double4 x, double4 y) => new double4(fmod(x.x, y.x), fmod(x.y, y.y), fmod(x.z, y.z), fmod(x.w, y.w));

        #endregion
        #region sinh

        /// <summary>Hyperbolic sine.</summary>
        public static float sinh(float x) => float.Sinh(x);
        /// <summary>Hyperbolic sine, component-wise.</summary>
        public static float2 sinh(float2 x) => new float2(float.Sinh(x.x), float.Sinh(x.y));
        /// <summary>Hyperbolic sine, component-wise.</summary>
        public static float3 sinh(float3 x) => new float3(float.Sinh(x.x), float.Sinh(x.y), float.Sinh(x.z));
        /// <summary>Hyperbolic sine, component-wise.</summary>
        public static float4 sinh(float4 x) => new float4(float.Sinh(x.x), float.Sinh(x.y), float.Sinh(x.z), float.Sinh(x.w));
        /// <summary>Hyperbolic sine.</summary>
        public static double sinh(double x) => double.Sinh(x);
        /// <summary>Hyperbolic sine, component-wise.</summary>
        public static double2 sinh(double2 x) => new double2(double.Sinh(x.x), double.Sinh(x.y));
        /// <summary>Hyperbolic sine, component-wise.</summary>
        public static double3 sinh(double3 x) => new double3(double.Sinh(x.x), double.Sinh(x.y), double.Sinh(x.z));
        /// <summary>Hyperbolic sine, component-wise.</summary>
        public static double4 sinh(double4 x) => new double4(double.Sinh(x.x), double.Sinh(x.y), double.Sinh(x.z), double.Sinh(x.w));

        #endregion
        #region cosh

        /// <summary>Hyperbolic cosine.</summary>
        public static float cosh(float x) => float.Cosh(x);
        /// <summary>Hyperbolic cosine, component-wise.</summary>
        public static float2 cosh(float2 x) => new float2(float.Cosh(x.x), float.Cosh(x.y));
        /// <summary>Hyperbolic cosine, component-wise.</summary>
        public static float3 cosh(float3 x) => new float3(float.Cosh(x.x), float.Cosh(x.y), float.Cosh(x.z));
        /// <summary>Hyperbolic cosine, component-wise.</summary>
        public static float4 cosh(float4 x) => new float4(float.Cosh(x.x), float.Cosh(x.y), float.Cosh(x.z), float.Cosh(x.w));
        /// <summary>Hyperbolic cosine.</summary>
        public static double cosh(double x) => double.Cosh(x);
        /// <summary>Hyperbolic cosine, component-wise.</summary>
        public static double2 cosh(double2 x) => new double2(double.Cosh(x.x), double.Cosh(x.y));
        /// <summary>Hyperbolic cosine, component-wise.</summary>
        public static double3 cosh(double3 x) => new double3(double.Cosh(x.x), double.Cosh(x.y), double.Cosh(x.z));
        /// <summary>Hyperbolic cosine, component-wise.</summary>
        public static double4 cosh(double4 x) => new double4(double.Cosh(x.x), double.Cosh(x.y), double.Cosh(x.z), double.Cosh(x.w));

        #endregion
        #region tanh

        /// <summary>Hyperbolic tangent.</summary>
        public static float tanh(float x) => float.Tanh(x);
        /// <summary>Hyperbolic tangent, component-wise.</summary>
        public static float2 tanh(float2 x) => new float2(float.Tanh(x.x), float.Tanh(x.y));
        /// <summary>Hyperbolic tangent, component-wise.</summary>
        public static float3 tanh(float3 x) => new float3(float.Tanh(x.x), float.Tanh(x.y), float.Tanh(x.z));
        /// <summary>Hyperbolic tangent, component-wise.</summary>
        public static float4 tanh(float4 x) => new float4(float.Tanh(x.x), float.Tanh(x.y), float.Tanh(x.z), float.Tanh(x.w));
        /// <summary>Hyperbolic tangent.</summary>
        public static double tanh(double x) => double.Tanh(x);
        /// <summary>Hyperbolic tangent, component-wise.</summary>
        public static double2 tanh(double2 x) => new double2(double.Tanh(x.x), double.Tanh(x.y));
        /// <summary>Hyperbolic tangent, component-wise.</summary>
        public static double3 tanh(double3 x) => new double3(double.Tanh(x.x), double.Tanh(x.y), double.Tanh(x.z));
        /// <summary>Hyperbolic tangent, component-wise.</summary>
        public static double4 tanh(double4 x) => new double4(double.Tanh(x.x), double.Tanh(x.y), double.Tanh(x.z), double.Tanh(x.w));

        #endregion
        #region sincos

        /// <summary>Computes the sine and cosine of <paramref name="x"/> in one call.</summary>
        public static void sincos(float x, out float s, out float c)
        {
            s = float.Sin(x);
            c = float.Cos(x);
        }
        /// <summary>Computes the sine and cosine, component-wise.</summary>
        public static void sincos(float2 x, out float2 s, out float2 c)
        {
            s = new float2(float.Sin(x.x), float.Sin(x.y));
            c = new float2(float.Cos(x.x), float.Cos(x.y));
        }
        /// <summary>Computes the sine and cosine, component-wise.</summary>
        public static void sincos(float3 x, out float3 s, out float3 c)
        {
            s = new float3(float.Sin(x.x), float.Sin(x.y), float.Sin(x.z));
            c = new float3(float.Cos(x.x), float.Cos(x.y), float.Cos(x.z));
        }
        /// <summary>Computes the sine and cosine, component-wise.</summary>
        public static void sincos(float4 x, out float4 s, out float4 c)
        {
            s = new float4(float.Sin(x.x), float.Sin(x.y), float.Sin(x.z), float.Sin(x.w));
            c = new float4(float.Cos(x.x), float.Cos(x.y), float.Cos(x.z), float.Cos(x.w));
        }
        /// <summary>Computes the sine and cosine of <paramref name="x"/> in one call.</summary>
        public static void sincos(double x, out double s, out double c)
        {
            s = double.Sin(x);
            c = double.Cos(x);
        }
        /// <summary>Computes the sine and cosine, component-wise.</summary>
        public static void sincos(double2 x, out double2 s, out double2 c)
        {
            s = new double2(double.Sin(x.x), double.Sin(x.y));
            c = new double2(double.Cos(x.x), double.Cos(x.y));
        }
        /// <summary>Computes the sine and cosine, component-wise.</summary>
        public static void sincos(double3 x, out double3 s, out double3 c)
        {
            s = new double3(double.Sin(x.x), double.Sin(x.y), double.Sin(x.z));
            c = new double3(double.Cos(x.x), double.Cos(x.y), double.Cos(x.z));
        }
        /// <summary>Computes the sine and cosine, component-wise.</summary>
        public static void sincos(double4 x, out double4 s, out double4 c)
        {
            s = new double4(double.Sin(x.x), double.Sin(x.y), double.Sin(x.z), double.Sin(x.w));
            c = new double4(double.Cos(x.x), double.Cos(x.y), double.Cos(x.z), double.Cos(x.w));
        }

        #endregion
        #region ldexp

        /// <summary>Returns <paramref name="x"/> multiplied by 2 raised to <paramref name="exp"/>.</summary>
        public static float ldexp(float x, int exp) => float.ScaleB(x, exp);
        /// <summary>Multiplication by a power of two, component-wise.</summary>
        public static float2 ldexp(float2 x, int2 exp) => new float2(float.ScaleB(x.x, exp.x), float.ScaleB(x.y, exp.y));
        /// <summary>Multiplication by a power of two, component-wise.</summary>
        public static float3 ldexp(float3 x, int3 exp) => new float3(float.ScaleB(x.x, exp.x), float.ScaleB(x.y, exp.y), float.ScaleB(x.z, exp.z));
        /// <summary>Multiplication by a power of two, component-wise.</summary>
        public static float4 ldexp(float4 x, int4 exp) => new float4(float.ScaleB(x.x, exp.x), float.ScaleB(x.y, exp.y), float.ScaleB(x.z, exp.z), float.ScaleB(x.w, exp.w));
        /// <summary>Returns <paramref name="x"/> multiplied by 2 raised to <paramref name="exp"/>.</summary>
        public static double ldexp(double x, int exp) => double.ScaleB(x, exp);
        /// <summary>Multiplication by a power of two, component-wise.</summary>
        public static double2 ldexp(double2 x, int2 exp) => new double2(double.ScaleB(x.x, exp.x), double.ScaleB(x.y, exp.y));
        /// <summary>Multiplication by a power of two, component-wise.</summary>
        public static double3 ldexp(double3 x, int3 exp) => new double3(double.ScaleB(x.x, exp.x), double.ScaleB(x.y, exp.y), double.ScaleB(x.z, exp.z));
        /// <summary>Multiplication by a power of two, component-wise.</summary>
        public static double4 ldexp(double4 x, int4 exp) => new double4(double.ScaleB(x.x, exp.x), double.ScaleB(x.y, exp.y), double.ScaleB(x.z, exp.z), double.ScaleB(x.w, exp.w));

        #endregion
        #region bit reinterpretation

        /// <summary>Reinterprets a pair of 32-bit values as a 64-bit double.</summary>
        public static double asdouble(uint lowbits, uint highbits) =>
            BitConverter.UInt64BitsToDouble(((ulong)highbits << 32) | lowbits);

        /// <summary>Converts the float16 stored in the low half of <paramref name="x"/> to a float.</summary>
        public static float f16tof32(uint x) => (float)BitConverter.UInt16BitsToHalf((ushort)(x & 0xFFFFu));
        /// <summary>Converts packed float16 values to floats, component-wise.</summary>
        public static float2 f16tof32(uint2 x) => new float2(f16tof32(x.x), f16tof32(x.y));
        /// <summary>Converts packed float16 values to floats, component-wise.</summary>
        public static float3 f16tof32(uint3 x) => new float3(f16tof32(x.x), f16tof32(x.y), f16tof32(x.z));
        /// <summary>Converts packed float16 values to floats, component-wise.</summary>
        public static float4 f16tof32(uint4 x) => new float4(f16tof32(x.x), f16tof32(x.y), f16tof32(x.z), f16tof32(x.w));

        /// <summary>Converts a float to float16, returned in the low half of the result.</summary>
        public static uint f32tof16(float x) => BitConverter.HalfToUInt16Bits((Half)x);
        /// <summary>Converts floats to float16, component-wise.</summary>
        public static uint2 f32tof16(float2 x) => new uint2(f32tof16(x.x), f32tof16(x.y));
        /// <summary>Converts floats to float16, component-wise.</summary>
        public static uint3 f32tof16(float3 x) => new uint3(f32tof16(x.x), f32tof16(x.y), f32tof16(x.z));
        /// <summary>Converts floats to float16, component-wise.</summary>
        public static uint4 f32tof16(float4 x) => new uint4(f32tof16(x.x), f32tof16(x.y), f32tof16(x.z), f32tof16(x.w));

        #endregion
        #region dst

        /// <summary>Builds a distance vector: <c>[1, dn.y * dd.y, dn.z * dd.z, dd.w]</c>.</summary>
        public static float4 dst(float4 dn, float4 dd) => new float4(1f, dn.y * dd.y, dn.z * dd.z, dd.w);
        /// <summary>Builds a distance vector: <c>[1, dn.y * dd.y, dn.z * dd.z, dd.w]</c>.</summary>
        public static double4 dst(double4 dn, double4 dd) => new double4(1.0, dn.y * dd.y, dn.z * dd.z, dd.w);

        #endregion
        #region lit

        /// <summary>Returns the lighting vector <c>[ambient, diffuse, specular, 1]</c>.</summary>
        public static float4 lit(float nDotL, float nDotH, float m)
        {
            var diffuse = max(nDotL, 0f);
            var specular = nDotL > 0f ? pow(max(nDotH, 0f), m) : 0f;
            return new float4(1f, diffuse, specular, 1f);
        }

        #endregion
        #region scalar step, smoothstep and modf

        /// <summary>Returns 1 when <paramref name="x"/> is greater than or equal to <paramref name="edge"/>, otherwise 0.</summary>
        public static float step(float edge, float x) => x >= edge ? 1f : 0f;
        /// <summary>Returns 1 when <paramref name="x"/> is greater than or equal to <paramref name="edge"/>, otherwise 0.</summary>
        public static double step(double edge, double x) => x >= edge ? 1.0 : 0.0;

        /// <summary>Smooth Hermite interpolation between 0 and 1 across the given edges.</summary>
        public static float smoothstep(float edge0, float edge1, float x)
        {
            var t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (3f - 2f * t);
        }
        /// <summary>Smooth Hermite interpolation between 0 and 1 across the given edges.</summary>
        public static double smoothstep(double edge0, double edge1, double x)
        {
            var t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (3.0 - 2.0 * t);
        }

        /// <summary>Splits <paramref name="x"/> into its fractional and integer parts.</summary>
        public static float modf(float x, out float intPart)
        {
            intPart = float.Truncate(x);
            return x - intPart;
        }
        /// <summary>Splits <paramref name="x"/> into its fractional and integer parts.</summary>
        public static double modf(double x, out double intPart)
        {
            intPart = double.Truncate(x);
            return x - intPart;
        }

        #endregion
        #region unsigned abs and sign

        /// <summary>Absolute value of an unsigned value: the value itself.</summary>
        public static uint abs(uint x) => x;
        /// <summary>Absolute value of an unsigned vector: the vector itself.</summary>
        public static uint2 abs(uint2 x) => x;
        /// <summary>Absolute value of an unsigned vector: the vector itself.</summary>
        public static uint3 abs(uint3 x) => x;
        /// <summary>Absolute value of an unsigned vector: the vector itself.</summary>
        public static uint4 abs(uint4 x) => x;

        /// <summary>Returns 1 for non-zero input and 0 for zero.</summary>
        public static uint sign(uint x) => x == 0u ? 0u : 1u;
        /// <summary>Returns 1 for non-zero components and 0 for zero components.</summary>
        public static uint2 sign(uint2 x) => new uint2(sign(x.x), sign(x.y));
        /// <summary>Returns 1 for non-zero components and 0 for zero components.</summary>
        public static uint3 sign(uint3 x) => new uint3(sign(x.x), sign(x.y), sign(x.z));
        /// <summary>Returns 1 for non-zero components and 0 for zero components.</summary>
        public static uint4 sign(uint4 x) => new uint4(sign(x.x), sign(x.y), sign(x.z), sign(x.w));

        #endregion
    }
}
