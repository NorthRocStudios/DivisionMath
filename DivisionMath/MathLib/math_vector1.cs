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

        public static float abs(float x) => float.Abs(x);
        public static float clamp(float x, float min, float max) => float.Clamp(x, min, max);
        public static float lerp(float x, float y, float t) => float.Lerp(x, y, t);
        public static float max(float x, float y) => float.Max(x, y);
        public static float min(float x, float y) => float.Min(x, y);
        public static float saturate(float x) => float.Clamp(x, 0f, 1f);
        public static float sign(float x) => float.Sign(x);
        public static float ceil(float x) => float.Ceiling(x);
        public static float floor(float x) => float.Floor(x);
        public static float round(float x) => float.Round(x);
        public static float trunc(float x) => float.Truncate(x);
        public static float frac(float x) => x - float.Floor(x);
        public static float exp(float x) => float.Exp(x);
        public static float exp2(float x) => float.Exp2(x);
        public static float log(float x) => float.Log(x);
        public static float log2(float x) => float.Log2(x);
        public static float log10(float x) => float.Log10(x);
        public static float pow(float x, float y) => float.Pow(x, y);
        public static float rcp(float x) => float.ReciprocalEstimate(x);
        public static float rsqrt(float x) => float.ReciprocalSqrtEstimate(x);
        public static float sqrt(float x) => float.Sqrt(x);
        public static float acos(float x) => float.Acos(x);
        public static float asin(float x) => float.Asin(x);
        public static float atan(float x) => float.Atan(x);
        public static float atan2(float y, float x) => float.Atan2(y, x);
        public static float cos(float x) => float.Cos(x);
        public static float sin(float x) => float.Sin(x);
        public static float tan(float x) => float.Tan(x);
        public static float radians(float x) => float.DegreesToRadians(x);
        public static float degrees(float x) => float.RadiansToDegrees(x);
        public static bool isfinite(float x) => float.IsFinite(x);
        public static bool isinf(float x) => float.IsInfinity(x);
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

        public static double abs(double x) => double.Abs(x);
        public static double clamp(double x, double min, double max) => double.Clamp(x, min, max);
        public static double lerp(double x, double y, double t) => double.Lerp(x, y, t);
        public static double max(double x, double y) => double.Max(x, y);
        public static double min(double x, double y) => double.Min(x, y);
        public static double saturate(double x) => double.Clamp(x, 0.0, 1.0);
        public static double sign(double x) => double.Sign(x);
        public static double ceil(double x) => double.Ceiling(x);
        public static double floor(double x) => double.Floor(x);
        public static double round(double x) => double.Round(x);
        public static double trunc(double x) => double.Truncate(x);
        public static double frac(double x) => x - double.Floor(x);
        public static double exp(double x) => double.Exp(x);
        public static double exp2(double x) => double.Exp2(x);
        public static double log(double x) => double.Log(x);
        public static double log2(double x) => double.Log2(x);
        public static double log10(double x) => double.Log10(x);
        public static double pow(double x, double y) => double.Pow(x, y);
        public static double rcp(double x) => double.ReciprocalEstimate(x);
        public static double rsqrt(double x) => double.ReciprocalSqrtEstimate(x);
        public static double sqrt(double x) => double.Sqrt(x);
        public static double acos(double x) => double.Acos(x);
        public static double asin(double x) => double.Asin(x);
        public static double atan(double x) => double.Atan(x);
        public static double atan2(double y, double x) => double.Atan2(y, x);
        public static double cos(double x) => double.Cos(x);
        public static double sin(double x) => double.Sin(x);
        public static double tan(double x) => double.Tan(x);
        public static double radians(double x) => double.DegreesToRadians(x);
        public static double degrees(double x) => double.RadiansToDegrees(x);
        public static bool isfinite(double x) => double.IsFinite(x);
        public static bool isinf(double x) => double.IsInfinity(x);
        public static bool isnan(double x) => double.IsNaN(x);

        #endregion double
        #region half

        // No equivalent in C#, will automatically translate correctly regardless

        #endregion half
        #region int

        public static int abs(int x) => int.Abs(x);
        public static int clamp(int x, int min, int max) => int.Clamp(x, min, max);
        public static int max(int x, int y) => int.Max(x, y);
        public static int min(int x, int y) => int.Min(x, y);
        public static int sign(int x) => int.Sign(x);
        public static int log2(int x) => int.Log2(x);

        public static int countbits(int x) => BitOperations.PopCount((uint)x);
        public static int firstbithigh(int x) => 31 - BitOperations.LeadingZeroCount((uint)x);
        public static int firstbitlow(int x) => BitOperations.TrailingZeroCount((uint)x);
        //public static int reversebits(int x) => (int)BitOperations.ReverseBits((uint)x); - Finish implementing this

        #endregion int
        #region uint

        public static uint clamp(uint x, uint min, uint max) => uint.Clamp(x, min, max);
        public static uint max(uint x, uint y) => uint.Max(x, y);
        public static uint min(uint x, uint y) => uint.Min(x, y);
        public static uint log2(uint x) => uint.Log2(x);

        public static int countbits(uint x) => BitOperations.PopCount(x);
        public static int firstbithigh(uint x) => 31 - BitOperations.LeadingZeroCount(x);
        public static int firstbitlow(uint x) => BitOperations.TrailingZeroCount(x);
        //public static uint reversebits(uint x) => BitOperations.ReverseBits(x); - Finish implementing this

        #endregion uint
        #region bool

        public static bool any(bool x) => x;
        public static bool all(bool x) => x;

        #endregion bool
        #region interpretation

        public static int asint(float x) => BitConverter.SingleToInt32Bits(x);
        public static uint asuint(float x) => BitConverter.SingleToUInt32Bits(x);
        public static float asfloat(int x) => BitConverter.Int32BitsToSingle(x);
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
