namespace DivisionEngine.MathLib
{
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public static partial class math
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        #region float

        public static float2 abs(float2 x) => new float2(float.Abs(x.x), float.Abs(x.y));
        public static float2 clamp(float2 x, float2 min, float2 max) => new float2(float.Clamp(x.x, min.x, max.x), float.Clamp(x.y, min.y, max.y));
        public static float2 clamp(float2 x, float min, float max) => new float2(float.Clamp(x.x, min, max), float.Clamp(x.y, min, max));
        public static float2 lerp(float2 x, float2 y, float t) => new float2(float.Lerp(x.x, y.x, t), float.Lerp(x.y, y.y, t));
        public static float2 lerp(float2 x, float2 y, float2 t) => new float2(float.Lerp(x.x, y.x, t.x), float.Lerp(x.y, y.y, t.y));
        public static float2 max(float2 x, float2 y) => new float2(float.Max(x.x, y.x), float.Max(x.y, y.y));
        public static float2 max(float2 x, float y) => new float2(float.Max(x.x, y), float.Max(x.y, y));
        public static float2 min(float2 x, float2 y) => new float2(float.Min(x.x, y.x), float.Min(x.y, y.y));
        public static float2 min(float2 x, float y) => new float2(float.Min(x.x, y), float.Min(x.y, y));
        public static float2 saturate(float2 x) => new float2(float.Clamp(x.x, 0f, 1f), float.Clamp(x.y, 0f, 1f));
        public static float2 sign(float2 x) => new float2(float.Sign(x.x), float.Sign(x.y));
        public static float2 ceil(float2 x) => new float2(float.Ceiling(x.x), float.Ceiling(x.y));
        public static float2 floor(float2 x) => new float2(float.Floor(x.x), float.Floor(x.y));
        public static float2 round(float2 x) => new float2(float.Round(x.x), float.Round(x.y));
        public static float2 trunc(float2 x) => new float2(float.Truncate(x.x), float.Truncate(x.y));
        public static float2 frac(float2 x) => new float2(x.x - float.Floor(x.x), x.y - float.Floor(x.y));
        public static float2 exp(float2 x) => new float2(float.Exp(x.x), float.Exp(x.y));
        public static float2 exp2(float2 x) => new float2(float.Exp2(x.x), float.Exp2(x.y));
        public static float2 log(float2 x) => new float2(float.Log(x.x), float.Log(x.y));
        public static float2 log2(float2 x) => new float2(float.Log2(x.x), float.Log2(x.y));
        public static float2 log10(float2 x) => new float2(float.Log10(x.x), float.Log10(x.y));
        public static float2 pow(float2 x, float2 y) => new float2(float.Pow(x.x, y.x), float.Pow(x.y, y.y));
        public static float2 pow(float2 x, float y) => new float2(float.Pow(x.x, y), float.Pow(x.y, y));
        public static float2 rcp(float2 x) => new float2(1f / x.x, 1f / x.y);
        public static float2 rsqrt(float2 x) => new float2(1f / float.Sqrt(x.x), 1f / float.Sqrt(x.y));
        public static float2 sqrt(float2 x) => new float2(float.Sqrt(x.x), float.Sqrt(x.y));
        public static float2 acos(float2 x) => new float2(float.Acos(x.x), float.Acos(x.y));
        public static float2 asin(float2 x) => new float2(float.Asin(x.x), float.Asin(x.y));
        public static float2 atan(float2 x) => new float2(float.Atan(x.x), float.Atan(x.y));
        public static float2 atan2(float2 y, float2 x) => new float2(float.Atan2(y.x, x.x), float.Atan2(y.y, x.y));
        public static float2 cos(float2 x) => new float2(float.Cos(x.x), float.Cos(x.y));
        public static float2 sin(float2 x) => new float2(float.Sin(x.x), float.Sin(x.y));
        public static float2 tan(float2 x) => new float2(float.Tan(x.x), float.Tan(x.y));
        public static float2 radians(float2 x) => new float2(float.DegreesToRadians(x.x), float.DegreesToRadians(x.y));
        public static float2 degrees(float2 x) => new float2(float.RadiansToDegrees(x.x), float.RadiansToDegrees(x.y));
        public static bool2 isfinite(float2 x) => new bool2(float.IsFinite(x.x), float.IsFinite(x.y));
        public static bool2 isinf(float2 x) => new bool2(float.IsInfinity(x.x), float.IsInfinity(x.y));
        public static bool2 isnan(float2 x) => new bool2(float.IsNaN(x.x), float.IsNaN(x.y));

        // Vector geometry
        public static float dot(float2 x, float2 y) => x.x * y.x + x.y * y.y;
        public static float length(float2 x) => float.Sqrt(dot(x, x));
        public static float lengthsq(float2 x) => dot(x, x);
        public static float distance(float2 x, float2 y) => length(x - y);
        public static float2 normalize(float2 x)
        {
            float len = length(x);
            return len > 0 ? x / len : float2.zero;
        }

        // Component reduction
        public static float cmin(float2 x) => float.Min(x.x, x.y);
        public static float cmax(float2 x) => float.Max(x.x, x.y);
        public static float csum(float2 x) => x.x + x.y;

        // Reflection and refraction
        public static float2 reflect(float2 i, float2 n) => i - 2f * dot(n, i) * n;
        public static float2 refract(float2 i, float2 n, float eta)
        {
            float ndoti = dot(n, i);
            float k = 1f - eta * eta * (1f - ndoti * ndoti);
            return k < 0 ? float2.zero : eta * i - (eta * ndoti + float.Sqrt(k)) * n;
        }
        public static float2 faceforward(float2 n, float2 i, float2 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        public static float2 smoothstep(float2 edge0, float2 edge1, float2 x)
        {
            float2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float2(3f, 3f) - 2f * t);
        }
        public static float2 smoothstep(float edge0, float edge1, float2 x)
        {
            float2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float2(3f, 3f) - 2f * t);
        }

        // Step
        public static float2 step(float2 edge, float2 x) => new float2(x.x >= edge.x ? 1f : 0f, x.y >= edge.y ? 1f : 0f);
        public static float2 step(float edge, float2 x) => new float2(x.x >= edge ? 1f : 0f, x.y >= edge ? 1f : 0f);

        // Modf (split into integer and fractional parts)
        public static float2 modf(float2 x, out float2 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (returns scalar for float2 in HLSL)
        public static float cross(float2 a, float2 b) => a.x * b.y - a.y * b.x;

        // Determinant (alias for cross)
        public static float determinant(float2 a, float2 b) => cross(a, b);

        #endregion float
        #region double

        public static double2 abs(double2 x) => new double2(double.Abs(x.x), double.Abs(x.y));
        public static double2 clamp(double2 x, double2 min, double2 max) => new double2(double.Clamp(x.x, min.x, max.x), double.Clamp(x.y, min.y, max.y));
        public static double2 clamp(double2 x, double min, double max) => new double2(double.Clamp(x.x, min, max), double.Clamp(x.y, min, max));
        public static double2 lerp(double2 x, double2 y, double t) => new double2(double.Lerp(x.x, y.x, t), double.Lerp(x.y, y.y, t));
        public static double2 lerp(double2 x, double2 y, double2 t) => new double2(double.Lerp(x.x, y.x, t.x), double.Lerp(x.y, y.y, t.y));
        public static double2 max(double2 x, double2 y) => new double2(double.Max(x.x, y.x), double.Max(x.y, y.y));
        public static double2 max(double2 x, double y) => new double2(double.Max(x.x, y), double.Max(x.y, y));
        public static double2 min(double2 x, double2 y) => new double2(double.Min(x.x, y.x), double.Min(x.y, y.y));
        public static double2 min(double2 x, double y) => new double2(double.Min(x.x, y), double.Min(x.y, y));
        public static double2 saturate(double2 x) => new double2(double.Clamp(x.x, 0.0, 1.0), double.Clamp(x.y, 0.0, 1.0));
        public static double2 sign(double2 x) => new double2(double.Sign(x.x), double.Sign(x.y));
        public static double2 ceil(double2 x) => new double2(double.Ceiling(x.x), double.Ceiling(x.y));
        public static double2 floor(double2 x) => new double2(double.Floor(x.x), double.Floor(x.y));
        public static double2 round(double2 x) => new double2(double.Round(x.x), double.Round(x.y));
        public static double2 trunc(double2 x) => new double2(double.Truncate(x.x), double.Truncate(x.y));
        public static double2 frac(double2 x) => new double2(x.x - double.Floor(x.x), x.y - double.Floor(x.y));
        public static double2 exp(double2 x) => new double2(double.Exp(x.x), double.Exp(x.y));
        public static double2 exp2(double2 x) => new double2(double.Exp2(x.x), double.Exp2(x.y));
        public static double2 log(double2 x) => new double2(double.Log(x.x), double.Log(x.y));
        public static double2 log2(double2 x) => new double2(double.Log2(x.x), double.Log2(x.y));
        public static double2 log10(double2 x) => new double2(double.Log10(x.x), double.Log10(x.y));
        public static double2 pow(double2 x, double2 y) => new double2(double.Pow(x.x, y.x), double.Pow(x.y, y.y));
        public static double2 pow(double2 x, double y) => new double2(double.Pow(x.x, y), double.Pow(x.y, y));
        public static double2 rcp(double2 x) => new double2(1.0 / x.x, 1.0 / x.y);
        public static double2 rsqrt(double2 x) => new double2(1.0 / double.Sqrt(x.x), 1.0 / double.Sqrt(x.y));
        public static double2 sqrt(double2 x) => new double2(double.Sqrt(x.x), double.Sqrt(x.y));
        public static double2 acos(double2 x) => new double2(double.Acos(x.x), double.Acos(x.y));
        public static double2 asin(double2 x) => new double2(double.Asin(x.x), double.Asin(x.y));
        public static double2 atan(double2 x) => new double2(double.Atan(x.x), double.Atan(x.y));
        public static double2 atan2(double2 y, double2 x) => new double2(double.Atan2(y.x, x.x), double.Atan2(y.y, x.y));
        public static double2 cos(double2 x) => new double2(double.Cos(x.x), double.Cos(x.y));
        public static double2 sin(double2 x) => new double2(double.Sin(x.x), double.Sin(x.y));
        public static double2 tan(double2 x) => new double2(double.Tan(x.x), double.Tan(x.y));
        public static double2 radians(double2 x) => new double2(double.DegreesToRadians(x.x), double.DegreesToRadians(x.y));
        public static double2 degrees(double2 x) => new double2(double.RadiansToDegrees(x.x), double.RadiansToDegrees(x.y));
        public static bool2 isfinite(double2 x) => new bool2(double.IsFinite(x.x), double.IsFinite(x.y));
        public static bool2 isinf(double2 x) => new bool2(double.IsInfinity(x.x), double.IsInfinity(x.y));
        public static bool2 isnan(double2 x) => new bool2(double.IsNaN(x.x), double.IsNaN(x.y));

        // Vector geometry
        public static double dot(double2 x, double2 y) => x.x * y.x + x.y * y.y;
        public static double length(double2 x) => double.Sqrt(dot(x, x));
        public static double lengthsq(double2 x) => dot(x, x);
        public static double distance(double2 x, double2 y) => length(x - y);
        public static double2 normalize(double2 x)
        {
            double len = length(x);
            return len > 0 ? x / len : double2.zero;
        }

        // Component reduction
        public static double cmin(double2 x) => double.Min(x.x, x.y);
        public static double cmax(double2 x) => double.Max(x.x, x.y);
        public static double csum(double2 x) => x.x + x.y;

        // Reflection and refraction
        public static double2 reflect(double2 i, double2 n) => i - 2.0 * dot(n, i) * n;
        public static double2 refract(double2 i, double2 n, double eta)
        {
            double ndoti = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ndoti * ndoti);
            return k < 0 ? double2.zero : eta * i - (eta * ndoti + double.Sqrt(k)) * n;
        }
        public static double2 faceforward(double2 n, double2 i, double2 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        public static double2 smoothstep(double2 edge0, double2 edge1, double2 x)
        {
            double2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double2(3.0, 3.0) - 2.0 * t);
        }
        public static double2 smoothstep(double edge0, double edge1, double2 x)
        {
            double2 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double2(3.0, 3.0) - 2.0 * t);
        }

        // Step
        public static double2 step(double2 edge, double2 x) => new double2(x.x >= edge.x ? 1.0 : 0.0, x.y >= edge.y ? 1.0 : 0.0);
        public static double2 step(double edge, double2 x) => new double2(x.x >= edge ? 1.0 : 0.0, x.y >= edge ? 1.0 : 0.0);

        // Modf (split into integer and fractional parts)
        public static double2 modf(double2 x, out double2 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (returns scalar for double2 in HLSL)
        public static double cross(double2 a, double2 b) => a.x * b.y - a.y * b.x;

        // Determinant (alias for cross)
        public static double determinant(double2 a, double2 b) => cross(a, b);

        #endregion double
        #region half

        // No equivalent in C#, will automatically translate correctly regardless

        #endregion half
        #region int

        public static int2 abs(int2 x) => new int2(int.Abs(x.x), int.Abs(x.y));
        public static int2 clamp(int2 x, int2 min, int2 max) => new int2(int.Clamp(x.x, min.x, max.x), int.Clamp(x.y, min.y, max.y));
        public static int2 max(int2 x, int2 y) => new int2(int.Max(x.x, y.x), int.Max(x.y, y.y));
        public static int2 min(int2 x, int2 y) => new int2(int.Min(x.x, y.x), int.Min(x.y, y.y));
        public static int2 sign(int2 x) => new int2(int.Sign(x.x), int.Sign(x.y));

        public static int cmin(int2 x) => int.Min(x.x, x.y);
        public static int cmax(int2 x) => int.Max(x.x, x.y);
        public static int csum(int2 x) => x.x + x.y;

        #endregion int
        #region uint

        public static uint2 clamp(uint2 x, uint2 min, uint2 max) => new uint2(uint.Clamp(x.x, min.x, max.x), uint.Clamp(x.y, min.y, max.y));
        public static uint2 max(uint2 x, uint2 y) => new uint2(uint.Max(x.x, y.x), uint.Max(x.y, y.y));
        public static uint2 min(uint2 x, uint2 y) => new uint2(uint.Min(x.x, y.x), uint.Min(x.y, y.y));

        public static uint cmin(uint2 x) => uint.Min(x.x, x.y);
        public static uint cmax(uint2 x) => uint.Max(x.x, x.y);
        public static uint csum(uint2 x) => x.x + x.y;

        #endregion uint
        #region bool

        public static bool2 any(bool2 x) => x.any;
        public static bool2 all(bool2 x) => x.all;

        #endregion bool
        #region interpretation

        public static int2 asint(float2 x) => new int2(BitConverter.SingleToInt32Bits(x.x), BitConverter.SingleToInt32Bits(x.y));
        public static uint2 asuint(float2 x) => new uint2(BitConverter.SingleToUInt32Bits(x.x), BitConverter.SingleToUInt32Bits(x.y));
        public static float2 asfloat(int2 x) => new float2(BitConverter.Int32BitsToSingle(x.x), BitConverter.Int32BitsToSingle(x.y));
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
