namespace DivisionEngine.MathLib
{
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public static partial class math
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        #region float

        public static float3 abs(float3 x) => new float3(float.Abs(x.x), float.Abs(x.y), float.Abs(x.z));
        public static float3 clamp(float3 x, float3 min, float3 max) => new float3(float.Clamp(x.x, min.x, max.x), float.Clamp(x.y, min.y, max.y), float.Clamp(x.z, min.z, max.z));
        public static float3 clamp(float3 x, float min, float max) => new float3(float.Clamp(x.x, min, max), float.Clamp(x.y, min, max), float.Clamp(x.z, min, max));
        public static float3 lerp(float3 x, float3 y, float t) => new float3(float.Lerp(x.x, y.x, t), float.Lerp(x.y, y.y, t), float.Lerp(x.z, y.z, t));
        public static float3 lerp(float3 x, float3 y, float3 t) => new float3(float.Lerp(x.x, y.x, t.x), float.Lerp(x.y, y.y, t.y), float.Lerp(x.z, y.z, t.z));
        public static float3 max(float3 x, float3 y) => new float3(float.Max(x.x, y.x), float.Max(x.y, y.y), float.Max(x.z, y.z));
        public static float3 max(float3 x, float y) => new float3(float.Max(x.x, y), float.Max(x.y, y), float.Max(x.z, y));
        public static float3 min(float3 x, float3 y) => new float3(float.Min(x.x, y.x), float.Min(x.y, y.y), float.Min(x.z, y.z));
        public static float3 min(float3 x, float y) => new float3(float.Min(x.x, y), float.Min(x.y, y), float.Min(x.z, y));
        public static float3 saturate(float3 x) => new float3(float.Clamp(x.x, 0f, 1f), float.Clamp(x.y, 0f, 1f), float.Clamp(x.z, 0f, 1f));
        public static float3 sign(float3 x) => new float3(float.Sign(x.x), float.Sign(x.y), float.Sign(x.z));
        public static float3 ceil(float3 x) => new float3(float.Ceiling(x.x), float.Ceiling(x.y), float.Ceiling(x.z));
        public static float3 floor(float3 x) => new float3(float.Floor(x.x), float.Floor(x.y), float.Floor(x.z));
        public static float3 round(float3 x) => new float3(float.Round(x.x), float.Round(x.y), float.Round(x.z));
        public static float3 trunc(float3 x) => new float3(float.Truncate(x.x), float.Truncate(x.y), float.Truncate(x.z));
        public static float3 frac(float3 x) => new float3(x.x - float.Floor(x.x), x.y - float.Floor(x.y), x.z - float.Floor(x.z));
        public static float3 exp(float3 x) => new float3(float.Exp(x.x), float.Exp(x.y), float.Exp(x.z));
        public static float3 exp2(float3 x) => new float3(float.Exp2(x.x), float.Exp2(x.y), float.Exp2(x.z));
        public static float3 log(float3 x) => new float3(float.Log(x.x), float.Log(x.y), float.Log(x.z));
        public static float3 log2(float3 x) => new float3(float.Log2(x.x), float.Log2(x.y), float.Log2(x.z));
        public static float3 log10(float3 x) => new float3(float.Log10(x.x), float.Log10(x.y), float.Log10(x.z));
        public static float3 pow(float3 x, float3 y) => new float3(float.Pow(x.x, y.x), float.Pow(x.y, y.y), float.Pow(x.z, y.z));
        public static float3 pow(float3 x, float y) => new float3(float.Pow(x.x, y), float.Pow(x.y, y), float.Pow(x.z, y));
        public static float3 rcp(float3 x) => new float3(1f / x.x, 1f / x.y, 1f / x.z);
        public static float3 rsqrt(float3 x) => new float3(1f / float.Sqrt(x.x), 1f / float.Sqrt(x.y), 1f / float.Sqrt(x.z));
        public static float3 sqrt(float3 x) => new float3(float.Sqrt(x.x), float.Sqrt(x.y), float.Sqrt(x.z));
        public static float3 acos(float3 x) => new float3(float.Acos(x.x), float.Acos(x.y), float.Acos(x.z));
        public static float3 asin(float3 x) => new float3(float.Asin(x.x), float.Asin(x.y), float.Asin(x.z));
        public static float3 atan(float3 x) => new float3(float.Atan(x.x), float.Atan(x.y), float.Atan(x.z));
        public static float3 atan2(float3 y, float3 x) => new float3(float.Atan2(y.x, x.x), float.Atan2(y.y, x.y), float.Atan2(y.z, x.z));
        public static float3 cos(float3 x) => new float3(float.Cos(x.x), float.Cos(x.y), float.Cos(x.z));
        public static float3 sin(float3 x) => new float3(float.Sin(x.x), float.Sin(x.y), float.Sin(x.z));
        public static float3 tan(float3 x) => new float3(float.Tan(x.x), float.Tan(x.y), float.Tan(x.z));
        public static float3 radians(float3 x) => new float3(float.DegreesToRadians(x.x), float.DegreesToRadians(x.y), float.DegreesToRadians(x.z));
        public static float3 degrees(float3 x) => new float3(float.RadiansToDegrees(x.x), float.RadiansToDegrees(x.y), float.RadiansToDegrees(x.z));
        public static bool3 isfinite(float3 x) => new bool3(float.IsFinite(x.x), float.IsFinite(x.y), float.IsFinite(x.z));
        public static bool3 isinf(float3 x) => new bool3(float.IsInfinity(x.x), float.IsInfinity(x.y), float.IsInfinity(x.z));
        public static bool3 isnan(float3 x) => new bool3(float.IsNaN(x.x), float.IsNaN(x.y), float.IsNaN(x.z));

        // Vector geometry
        public static float dot(float3 x, float3 y) => x.x * y.x + x.y * y.y + x.z * y.z;
        public static float length(float3 x) => float.Sqrt(dot(x, x));
        public static float lengthsq(float3 x) => dot(x, x);
        public static float distance(float3 x, float3 y) => length(x - y);
        public static float3 normalize(float3 x)
        {
            float len = length(x);
            return len > 0 ? x / len : float3.zero;
        }

        // Component reduction
        public static float cmin(float3 x) => float.Min(x.x, float.Min(x.y, x.z));
        public static float cmax(float3 x) => float.Max(x.x, float.Max(x.y, x.z));
        public static float csum(float3 x) => x.x + x.y + x.z;

        // Cross product (3D only)
        public static float3 cross(float3 a, float3 b) => new float3(
            a.y * b.z - a.z * b.y,
            a.z * b.x - a.x * b.z,
            a.x * b.y - a.y * b.x
        );

        // Reflection and refraction
        public static float3 reflect(float3 i, float3 n) => i - 2f * dot(n, i) * n;
        public static float3 refract(float3 i, float3 n, float eta)
        {
            float ndoti = dot(n, i);
            float k = 1f - eta * eta * (1f - ndoti * ndoti);
            return k < 0 ? float3.zero : eta * i - (eta * ndoti + float.Sqrt(k)) * n;
        }
        public static float3 faceforward(float3 n, float3 i, float3 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        public static float3 smoothstep(float3 edge0, float3 edge1, float3 x)
        {
            float3 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float3(3f, 3f, 3f) - 2f * t);
        }
        public static float3 smoothstep(float edge0, float edge1, float3 x)
        {
            float3 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float3(3f, 3f, 3f) - 2f * t);
        }

        // Step
        public static float3 step(float3 edge, float3 x) => new float3(x.x >= edge.x ? 1f : 0f, x.y >= edge.y ? 1f : 0f, x.z >= edge.z ? 1f : 0f);
        public static float3 step(float edge, float3 x) => new float3(x.x >= edge ? 1f : 0f, x.y >= edge ? 1f : 0f, x.z >= edge ? 1f : 0f);

        // Modf
        public static float3 modf(float3 x, out float3 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Determinant (for float3x3 matrices - will be useful later)
        public static float determinant(float3 a, float3 b, float3 c) => dot(a, cross(b, c));

        #endregion float
        #region double

        public static double3 abs(double3 x) => new double3(double.Abs(x.x), double.Abs(x.y), double.Abs(x.z));
        public static double3 clamp(double3 x, double3 min, double3 max) => new double3(double.Clamp(x.x, min.x, max.x), double.Clamp(x.y, min.y, max.y), double.Clamp(x.z, min.z, max.z));
        public static double3 clamp(double3 x, double min, double max) => new double3(double.Clamp(x.x, min, max), double.Clamp(x.y, min, max), double.Clamp(x.z, min, max));
        public static double3 lerp(double3 x, double3 y, double t) => new double3(double.Lerp(x.x, y.x, t), double.Lerp(x.y, y.y, t), double.Lerp(x.z, y.z, t));
        public static double3 lerp(double3 x, double3 y, double3 t) => new double3(double.Lerp(x.x, y.x, t.x), double.Lerp(x.y, y.y, t.y), double.Lerp(x.z, y.z, t.z));
        public static double3 max(double3 x, double3 y) => new double3(double.Max(x.x, y.x), double.Max(x.y, y.y), double.Max(x.z, y.z));
        public static double3 max(double3 x, double y) => new double3(double.Max(x.x, y), double.Max(x.y, y), double.Max(x.z, y));
        public static double3 min(double3 x, double3 y) => new double3(double.Min(x.x, y.x), double.Min(x.y, y.y), double.Min(x.z, y.z));
        public static double3 min(double3 x, double y) => new double3(double.Min(x.x, y), double.Min(x.y, y), double.Min(x.z, y));
        public static double3 saturate(double3 x) => new double3(double.Clamp(x.x, 0.0, 1.0), double.Clamp(x.y, 0.0, 1.0), double.Clamp(x.z, 0.0, 1.0));
        public static double3 sign(double3 x) => new double3(double.Sign(x.x), double.Sign(x.y), double.Sign(x.z));
        public static double3 ceil(double3 x) => new double3(double.Ceiling(x.x), double.Ceiling(x.y), double.Ceiling(x.z));
        public static double3 floor(double3 x) => new double3(double.Floor(x.x), double.Floor(x.y), double.Floor(x.z));
        public static double3 round(double3 x) => new double3(double.Round(x.x), double.Round(x.y), double.Round(x.z));
        public static double3 trunc(double3 x) => new double3(double.Truncate(x.x), double.Truncate(x.y), double.Truncate(x.z));
        public static double3 frac(double3 x) => new double3(x.x - double.Floor(x.x), x.y - double.Floor(x.y), x.z - double.Floor(x.z));
        public static double3 exp(double3 x) => new double3(double.Exp(x.x), double.Exp(x.y), double.Exp(x.z));
        public static double3 exp2(double3 x) => new double3(double.Exp2(x.x), double.Exp2(x.y), double.Exp2(x.z));
        public static double3 log(double3 x) => new double3(double.Log(x.x), double.Log(x.y), double.Log(x.z));
        public static double3 log2(double3 x) => new double3(double.Log2(x.x), double.Log2(x.y), double.Log2(x.z));
        public static double3 log10(double3 x) => new double3(double.Log10(x.x), double.Log10(x.y), double.Log10(x.z));
        public static double3 pow(double3 x, double3 y) => new double3(double.Pow(x.x, y.x), double.Pow(x.y, y.y), double.Pow(x.z, y.z));
        public static double3 pow(double3 x, double y) => new double3(double.Pow(x.x, y), double.Pow(x.y, y), double.Pow(x.z, y));
        public static double3 rcp(double3 x) => new double3(1.0 / x.x, 1.0 / x.y, 1.0 / x.z);
        public static double3 rsqrt(double3 x) => new double3(1.0 / double.Sqrt(x.x), 1.0 / double.Sqrt(x.y), 1.0 / double.Sqrt(x.z));
        public static double3 sqrt(double3 x) => new double3(double.Sqrt(x.x), double.Sqrt(x.y), double.Sqrt(x.z));
        public static double3 acos(double3 x) => new double3(double.Acos(x.x), double.Acos(x.y), double.Acos(x.z));
        public static double3 asin(double3 x) => new double3(double.Asin(x.x), double.Asin(x.y), double.Asin(x.z));
        public static double3 atan(double3 x) => new double3(double.Atan(x.x), double.Atan(x.y), double.Atan(x.z));
        public static double3 atan2(double3 y, double3 x) => new double3(double.Atan2(y.x, x.x), double.Atan2(y.y, x.y), double.Atan2(y.z, x.z));
        public static double3 cos(double3 x) => new double3(double.Cos(x.x), double.Cos(x.y), double.Cos(x.z));
        public static double3 sin(double3 x) => new double3(double.Sin(x.x), double.Sin(x.y), double.Sin(x.z));
        public static double3 tan(double3 x) => new double3(double.Tan(x.x), double.Tan(x.y), double.Tan(x.z));
        public static double3 radians(double3 x) => new double3(double.DegreesToRadians(x.x), double.DegreesToRadians(x.y), double.DegreesToRadians(x.z));
        public static double3 degrees(double3 x) => new double3(double.RadiansToDegrees(x.x), double.RadiansToDegrees(x.y), double.RadiansToDegrees(x.z));
        public static bool3 isfinite(double3 x) => new bool3(double.IsFinite(x.x), double.IsFinite(x.y), double.IsFinite(x.z));
        public static bool3 isinf(double3 x) => new bool3(double.IsInfinity(x.x), double.IsInfinity(x.y), double.IsInfinity(x.z));
        public static bool3 isnan(double3 x) => new bool3(double.IsNaN(x.x), double.IsNaN(x.y), double.IsNaN(x.z));

        // Vector geometry
        public static double dot(double3 x, double3 y) => x.x * y.x + x.y * y.y + x.z * y.z;
        public static double length(double3 x) => double.Sqrt(dot(x, x));
        public static double lengthsq(double3 x) => dot(x, x);
        public static double distance(double3 x, double3 y) => length(x - y);
        public static double3 normalize(double3 x)
        {
            double len = length(x);
            return len > 0 ? x / len : double3.zero;
        }

        // Component reduction
        public static double cmin(double3 x) => double.Min(x.x, double.Min(x.y, x.z));
        public static double cmax(double3 x) => double.Max(x.x, double.Max(x.y, x.z));
        public static double csum(double3 x) => x.x + x.y + x.z;

        // Cross product
        public static double3 cross(double3 a, double3 b) => new double3(
            a.y * b.z - a.z * b.y,
            a.z * b.x - a.x * b.z,
            a.x * b.y - a.y * b.x
        );

        // Reflection and refraction
        public static double3 reflect(double3 i, double3 n) => i - 2.0 * dot(n, i) * n;
        public static double3 refract(double3 i, double3 n, double eta)
        {
            double ndoti = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ndoti * ndoti);
            return k < 0 ? double3.zero : eta * i - (eta * ndoti + double.Sqrt(k)) * n;
        }
        public static double3 faceforward(double3 n, double3 i, double3 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        public static double3 smoothstep(double3 edge0, double3 edge1, double3 x)
        {
            double3 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double3(3.0, 3.0, 3.0) - 2.0 * t);
        }
        public static double3 smoothstep(double edge0, double edge1, double3 x)
        {
            double3 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double3(3.0, 3.0, 3.0) - 2.0 * t);
        }

        // Step
        public static double3 step(double3 edge, double3 x) => new double3(x.x >= edge.x ? 1.0 : 0.0, x.y >= edge.y ? 1.0 : 0.0, x.z >= edge.z ? 1.0 : 0.0);
        public static double3 step(double edge, double3 x) => new double3(x.x >= edge ? 1.0 : 0.0, x.y >= edge ? 1.0 : 0.0, x.z >= edge ? 1.0 : 0.0);

        // Modf
        public static double3 modf(double3 x, out double3 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Determinant
        public static double determinant(double3 a, double3 b, double3 c) => dot(a, cross(b, c));

        #endregion double
        #region half

        // No equivalent in C#, will automatically translate correctly regardless

        #endregion half
        #region int

        public static int3 abs(int3 x) => new int3(int.Abs(x.x), int.Abs(x.y), int.Abs(x.z));
        public static int3 clamp(int3 x, int3 min, int3 max) => new int3(int.Clamp(x.x, min.x, max.x), int.Clamp(x.y, min.y, max.y), int.Clamp(x.z, min.z, max.z));
        public static int3 max(int3 x, int3 y) => new int3(int.Max(x.x, y.x), int.Max(x.y, y.y), int.Max(x.z, y.z));
        public static int3 min(int3 x, int3 y) => new int3(int.Min(x.x, y.x), int.Min(x.y, y.y), int.Min(x.z, y.z));
        public static int3 sign(int3 x) => new int3(int.Sign(x.x), int.Sign(x.y), int.Sign(x.z));

        public static int cmin(int3 x) => int.Min(x.x, int.Min(x.y, x.z));
        public static int cmax(int3 x) => int.Max(x.x, int.Max(x.y, x.z));
        public static int csum(int3 x) => x.x + x.y + x.z;

        #endregion int
        #region uint

        public static uint3 clamp(uint3 x, uint3 min, uint3 max) => new uint3(uint.Clamp(x.x, min.x, max.x), uint.Clamp(x.y, min.y, max.y), uint.Clamp(x.z, min.z, max.z));
        public static uint3 max(uint3 x, uint3 y) => new uint3(uint.Max(x.x, y.x), uint.Max(x.y, y.y), uint.Max(x.z, y.z));
        public static uint3 min(uint3 x, uint3 y) => new uint3(uint.Min(x.x, y.x), uint.Min(x.y, y.y), uint.Min(x.z, y.z));

        public static uint cmin(uint3 x) => uint.Min(x.x, uint.Min(x.y, x.z));
        public static uint cmax(uint3 x) => uint.Max(x.x, uint.Max(x.y, x.z));
        public static uint csum(uint3 x) => x.x + x.y + x.z;

        #endregion uint
        #region bool

        public static bool3 any(bool3 x) => x.any;
        public static bool3 all(bool3 x) => x.all;

        #endregion bool
        #region interpretation

        public static int3 asint(float3 x) => new int3(BitConverter.SingleToInt32Bits(x.x), BitConverter.SingleToInt32Bits(x.y), BitConverter.SingleToInt32Bits(x.z));
        public static uint3 asuint(float3 x) => new uint3(BitConverter.SingleToUInt32Bits(x.x), BitConverter.SingleToUInt32Bits(x.y), BitConverter.SingleToUInt32Bits(x.z));
        public static float3 asfloat(int3 x) => new float3(BitConverter.Int32BitsToSingle(x.x), BitConverter.Int32BitsToSingle(x.y), BitConverter.Int32BitsToSingle(x.z));
        public static float3 asfloat(uint3 x) => new float3(BitConverter.UInt32BitsToSingle(x.x), BitConverter.UInt32BitsToSingle(x.y), BitConverter.UInt32BitsToSingle(x.z));

        #endregion interpretation
        #region noise

        /// <summary>
        /// Returns itself, noise is not deterministic and varies per GPU device.
        /// </summary>
        /// <returns>Input (x)</returns>
        /// <remarks>This is only for compatibility and is not useful on the C# CPU side</remarks>
        public static float3 noise(float3 x) => x;
        // Implement true noise here later

        #endregion noise
    }
}
