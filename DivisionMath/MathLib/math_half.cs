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
    /// Half-precision overloads of the HLSL intrinsics. Each one widens to float, calls the
    /// float implementation and narrows the result, so half and float agree by construction.
    /// </summary>
    public static partial class math
#pragma warning restore CS8981
    {
        #region unary
        /// <summary>Half-precision overload.</summary>
        public static half2 abs(half2 x) => (half2)abs((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 acos(half2 x) => (half2)acos((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 asin(half2 x) => (half2)asin((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 atan(half2 x) => (half2)atan((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 ceil(half2 x) => (half2)ceil((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 cos(half2 x) => (half2)cos((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 cosh(half2 x) => (half2)cosh((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 degrees(half2 x) => (half2)degrees((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 exp(half2 x) => (half2)exp((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 exp2(half2 x) => (half2)exp2((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 floor(half2 x) => (half2)floor((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 frac(half2 x) => (half2)frac((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 log(half2 x) => (half2)log((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 log10(half2 x) => (half2)log10((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 log2(half2 x) => (half2)log2((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 radians(half2 x) => (half2)radians((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 rcp(half2 x) => (half2)rcp((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 round(half2 x) => (half2)round((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 rsqrt(half2 x) => (half2)rsqrt((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 saturate(half2 x) => (half2)saturate((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 sign(half2 x) => (half2)sign((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 sin(half2 x) => (half2)sin((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 sinh(half2 x) => (half2)sinh((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 sqrt(half2 x) => (half2)sqrt((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 tan(half2 x) => (half2)tan((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 tanh(half2 x) => (half2)tanh((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 trunc(half2 x) => (half2)trunc((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 normalize(half2 x) => (half2)normalize((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 abs(half3 x) => (half3)abs((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 acos(half3 x) => (half3)acos((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 asin(half3 x) => (half3)asin((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 atan(half3 x) => (half3)atan((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 ceil(half3 x) => (half3)ceil((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 cos(half3 x) => (half3)cos((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 cosh(half3 x) => (half3)cosh((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 degrees(half3 x) => (half3)degrees((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 exp(half3 x) => (half3)exp((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 exp2(half3 x) => (half3)exp2((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 floor(half3 x) => (half3)floor((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 frac(half3 x) => (half3)frac((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 log(half3 x) => (half3)log((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 log10(half3 x) => (half3)log10((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 log2(half3 x) => (half3)log2((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 radians(half3 x) => (half3)radians((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 rcp(half3 x) => (half3)rcp((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 round(half3 x) => (half3)round((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 rsqrt(half3 x) => (half3)rsqrt((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 saturate(half3 x) => (half3)saturate((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 sign(half3 x) => (half3)sign((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 sin(half3 x) => (half3)sin((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 sinh(half3 x) => (half3)sinh((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 sqrt(half3 x) => (half3)sqrt((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 tan(half3 x) => (half3)tan((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 tanh(half3 x) => (half3)tanh((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 trunc(half3 x) => (half3)trunc((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 normalize(half3 x) => (half3)normalize((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 abs(half4 x) => (half4)abs((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 acos(half4 x) => (half4)acos((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 asin(half4 x) => (half4)asin((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 atan(half4 x) => (half4)atan((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 ceil(half4 x) => (half4)ceil((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 cos(half4 x) => (half4)cos((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 cosh(half4 x) => (half4)cosh((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 degrees(half4 x) => (half4)degrees((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 exp(half4 x) => (half4)exp((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 exp2(half4 x) => (half4)exp2((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 floor(half4 x) => (half4)floor((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 frac(half4 x) => (half4)frac((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 log(half4 x) => (half4)log((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 log10(half4 x) => (half4)log10((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 log2(half4 x) => (half4)log2((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 radians(half4 x) => (half4)radians((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 rcp(half4 x) => (half4)rcp((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 round(half4 x) => (half4)round((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 rsqrt(half4 x) => (half4)rsqrt((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 saturate(half4 x) => (half4)saturate((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 sign(half4 x) => (half4)sign((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 sin(half4 x) => (half4)sin((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 sinh(half4 x) => (half4)sinh((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 sqrt(half4 x) => (half4)sqrt((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 tan(half4 x) => (half4)tan((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 tanh(half4 x) => (half4)tanh((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 trunc(half4 x) => (half4)trunc((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 normalize(half4 x) => (half4)normalize((float4)x);
        #endregion

        #region binary
        /// <summary>Half-precision overload.</summary>
        public static half2 atan2(half2 a, half2 b) => (half2)atan2((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static half2 fmod(half2 a, half2 b) => (half2)fmod((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static half2 max(half2 a, half2 b) => (half2)max((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static half2 min(half2 a, half2 b) => (half2)min((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static half2 pow(half2 a, half2 b) => (half2)pow((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static half2 step(half2 a, half2 b) => (half2)step((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static half2 reflect(half2 a, half2 b) => (half2)reflect((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static half2 faceforward(half2 n, half2 i, half2 ng) => (half2)faceforward((float2)n, (float2)i, (float2)ng);
        /// <summary>Half-precision overload.</summary>
        public static half2 step(float edge, half2 x) => (half2)step(edge, (float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 atan2(half3 a, half3 b) => (half3)atan2((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static half3 fmod(half3 a, half3 b) => (half3)fmod((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static half3 max(half3 a, half3 b) => (half3)max((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static half3 min(half3 a, half3 b) => (half3)min((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static half3 pow(half3 a, half3 b) => (half3)pow((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static half3 step(half3 a, half3 b) => (half3)step((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static half3 reflect(half3 a, half3 b) => (half3)reflect((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static half3 faceforward(half3 n, half3 i, half3 ng) => (half3)faceforward((float3)n, (float3)i, (float3)ng);
        /// <summary>Half-precision overload.</summary>
        public static half3 step(float edge, half3 x) => (half3)step(edge, (float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 atan2(half4 a, half4 b) => (half4)atan2((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static half4 fmod(half4 a, half4 b) => (half4)fmod((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static half4 max(half4 a, half4 b) => (half4)max((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static half4 min(half4 a, half4 b) => (half4)min((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static half4 pow(half4 a, half4 b) => (half4)pow((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static half4 step(half4 a, half4 b) => (half4)step((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static half4 reflect(half4 a, half4 b) => (half4)reflect((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static half4 faceforward(half4 n, half4 i, half4 ng) => (half4)faceforward((float4)n, (float4)i, (float4)ng);
        /// <summary>Half-precision overload.</summary>
        public static half4 step(float edge, half4 x) => (half4)step(edge, (float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 cross(half3 a, half3 b) => (half3)cross((float3)a, (float3)b);
        #endregion

        #region lerp, clamp, fma, mad, smoothstep, refract
        /// <summary>Half-precision overload.</summary>
        public static half2 lerp(half2 x, half2 y, float t) => (half2)lerp((float2)x, (float2)y, t);
        /// <summary>Half-precision overload.</summary>
        public static half2 lerp(half2 x, half2 y, half2 t) => (half2)lerp((float2)x, (float2)y, (float2)t);
        /// <summary>Half-precision overload.</summary>
        public static half2 clamp(half2 x, half2 min, half2 max) => (half2)clamp((float2)x, (float2)min, (float2)max);
        /// <summary>Half-precision overload.</summary>
        public static half2 clamp(half2 x, float min, float max) => (half2)clamp((float2)x, min, max);
        /// <summary>Half-precision overload.</summary>
        public static half2 fma(half2 a, half2 b, half2 c) => (half2)fma((float2)a, (float2)b, (float2)c);
        /// <summary>Half-precision overload.</summary>
        public static half2 mad(half2 a, half2 b, half2 c) => (half2)mad((float2)a, (float2)b, (float2)c);
        /// <summary>Half-precision overload.</summary>
        public static half2 smoothstep(half2 edge0, half2 edge1, half2 x) => (half2)smoothstep((float2)edge0, (float2)edge1, (float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 smoothstep(float edge0, float edge1, half2 x) => (half2)smoothstep(edge0, edge1, (float2)x);
        /// <summary>Half-precision overload.</summary>
        public static half2 refract(half2 i, half2 n, float eta) => (half2)refract((float2)i, (float2)n, eta);
        /// <summary>Half-precision overload.</summary>
        public static half3 lerp(half3 x, half3 y, float t) => (half3)lerp((float3)x, (float3)y, t);
        /// <summary>Half-precision overload.</summary>
        public static half3 lerp(half3 x, half3 y, half3 t) => (half3)lerp((float3)x, (float3)y, (float3)t);
        /// <summary>Half-precision overload.</summary>
        public static half3 clamp(half3 x, half3 min, half3 max) => (half3)clamp((float3)x, (float3)min, (float3)max);
        /// <summary>Half-precision overload.</summary>
        public static half3 clamp(half3 x, float min, float max) => (half3)clamp((float3)x, min, max);
        /// <summary>Half-precision overload.</summary>
        public static half3 fma(half3 a, half3 b, half3 c) => (half3)fma((float3)a, (float3)b, (float3)c);
        /// <summary>Half-precision overload.</summary>
        public static half3 mad(half3 a, half3 b, half3 c) => (half3)mad((float3)a, (float3)b, (float3)c);
        /// <summary>Half-precision overload.</summary>
        public static half3 smoothstep(half3 edge0, half3 edge1, half3 x) => (half3)smoothstep((float3)edge0, (float3)edge1, (float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 smoothstep(float edge0, float edge1, half3 x) => (half3)smoothstep(edge0, edge1, (float3)x);
        /// <summary>Half-precision overload.</summary>
        public static half3 refract(half3 i, half3 n, float eta) => (half3)refract((float3)i, (float3)n, eta);
        /// <summary>Half-precision overload.</summary>
        public static half4 lerp(half4 x, half4 y, float t) => (half4)lerp((float4)x, (float4)y, t);
        /// <summary>Half-precision overload.</summary>
        public static half4 lerp(half4 x, half4 y, half4 t) => (half4)lerp((float4)x, (float4)y, (float4)t);
        /// <summary>Half-precision overload.</summary>
        public static half4 clamp(half4 x, half4 min, half4 max) => (half4)clamp((float4)x, (float4)min, (float4)max);
        /// <summary>Half-precision overload.</summary>
        public static half4 clamp(half4 x, float min, float max) => (half4)clamp((float4)x, min, max);
        /// <summary>Half-precision overload.</summary>
        public static half4 fma(half4 a, half4 b, half4 c) => (half4)fma((float4)a, (float4)b, (float4)c);
        /// <summary>Half-precision overload.</summary>
        public static half4 mad(half4 a, half4 b, half4 c) => (half4)mad((float4)a, (float4)b, (float4)c);
        /// <summary>Half-precision overload.</summary>
        public static half4 smoothstep(half4 edge0, half4 edge1, half4 x) => (half4)smoothstep((float4)edge0, (float4)edge1, (float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 smoothstep(float edge0, float edge1, half4 x) => (half4)smoothstep(edge0, edge1, (float4)x);
        /// <summary>Half-precision overload.</summary>
        public static half4 refract(half4 i, half4 n, float eta) => (half4)refract((float4)i, (float4)n, eta);
        #endregion

        #region reductions and predicates
        /// <summary>Half-precision overload.</summary>
        public static float length(half2 x) => length((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static float dot(half2 a, half2 b) => dot((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static float distance(half2 a, half2 b) => distance((float2)a, (float2)b);
        /// <summary>Half-precision overload.</summary>
        public static bool2 isfinite(half2 x) => isfinite((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static bool2 isinf(half2 x) => isinf((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static bool2 isnan(half2 x) => isnan((float2)x);
        /// <summary>Half-precision overload.</summary>
        public static float length(half3 x) => length((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static float dot(half3 a, half3 b) => dot((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static float distance(half3 a, half3 b) => distance((float3)a, (float3)b);
        /// <summary>Half-precision overload.</summary>
        public static bool3 isfinite(half3 x) => isfinite((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static bool3 isinf(half3 x) => isinf((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static bool3 isnan(half3 x) => isnan((float3)x);
        /// <summary>Half-precision overload.</summary>
        public static float length(half4 x) => length((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static float dot(half4 a, half4 b) => dot((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static float distance(half4 a, half4 b) => distance((float4)a, (float4)b);
        /// <summary>Half-precision overload.</summary>
        public static bool4 isfinite(half4 x) => isfinite((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static bool4 isinf(half4 x) => isinf((float4)x);
        /// <summary>Half-precision overload.</summary>
        public static bool4 isnan(half4 x) => isnan((float4)x);
        #endregion

        #region out-parameter forms
        /// <summary>Splits into fractional and integer parts.</summary>
        public static half2 modf(half2 x, out half2 intPart)
        {
            var fraction = modf((float2)x, out var integerPart);
            intPart = (half2)integerPart;
            return (half2)fraction;
        }
        /// <summary>Computes sine and cosine.</summary>
        public static void sincos(half2 x, out half2 s, out half2 c)
        {
            sincos((float2)x, out var sv, out var cv);
            s = (half2)sv;
            c = (half2)cv;
        }
        /// <summary>Half-precision overload.</summary>
        public static half2 ldexp(half2 x, int2 exp) => (half2)ldexp((float2)x, exp);
        /// <summary>Splits into fractional and integer parts.</summary>
        public static half3 modf(half3 x, out half3 intPart)
        {
            var fraction = modf((float3)x, out var integerPart);
            intPart = (half3)integerPart;
            return (half3)fraction;
        }
        /// <summary>Computes sine and cosine.</summary>
        public static void sincos(half3 x, out half3 s, out half3 c)
        {
            sincos((float3)x, out var sv, out var cv);
            s = (half3)sv;
            c = (half3)cv;
        }
        /// <summary>Half-precision overload.</summary>
        public static half3 ldexp(half3 x, int3 exp) => (half3)ldexp((float3)x, exp);
        /// <summary>Splits into fractional and integer parts.</summary>
        public static half4 modf(half4 x, out half4 intPart)
        {
            var fraction = modf((float4)x, out var integerPart);
            intPart = (half4)integerPart;
            return (half4)fraction;
        }
        /// <summary>Computes sine and cosine.</summary>
        public static void sincos(half4 x, out half4 s, out half4 c)
        {
            sincos((float4)x, out var sv, out var cv);
            s = (half4)sv;
            c = (half4)cv;
        }
        /// <summary>Half-precision overload.</summary>
        public static half4 ldexp(half4 x, int4 exp) => (half4)ldexp((float4)x, exp);
        #endregion
    }
}
