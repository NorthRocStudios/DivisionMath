namespace DivisionEngine.MathLib
{
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public static partial class math
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        #region float

        public static float4 abs(float4 x) => new float4(float.Abs(x.x), float.Abs(x.y), float.Abs(x.z), float.Abs(x.w));
        public static float4 clamp(float4 x, float4 min, float4 max) => new float4(float.Clamp(x.x, min.x, max.x), float.Clamp(x.y, min.y, max.y), float.Clamp(x.z, min.z, max.z), float.Clamp(x.w, min.w, max.w));
        public static float4 clamp(float4 x, float min, float max) => new float4(float.Clamp(x.x, min, max), float.Clamp(x.y, min, max), float.Clamp(x.z, min, max), float.Clamp(x.w, min, max));
        public static float4 lerp(float4 x, float4 y, float t) => new float4(float.Lerp(x.x, y.x, t), float.Lerp(x.y, y.y, t), float.Lerp(x.z, y.z, t), float.Lerp(x.w, y.w, t));
        public static float4 lerp(float4 x, float4 y, float4 t) => new float4(float.Lerp(x.x, y.x, t.x), float.Lerp(x.y, y.y, t.y), float.Lerp(x.z, y.z, t.z), float.Lerp(x.w, y.w, t.w));
        public static float4 max(float4 x, float4 y) => new float4(float.Max(x.x, y.x), float.Max(x.y, y.y), float.Max(x.z, y.z), float.Max(x.w, y.w));
        public static float4 max(float4 x, float y) => new float4(float.Max(x.x, y), float.Max(x.y, y), float.Max(x.z, y), float.Max(x.w, y));
        public static float4 min(float4 x, float4 y) => new float4(float.Min(x.x, y.x), float.Min(x.y, y.y), float.Min(x.z, y.z), float.Min(x.w, y.w));
        public static float4 min(float4 x, float y) => new float4(float.Min(x.x, y), float.Min(x.y, y), float.Min(x.z, y), float.Min(x.w, y));
        public static float4 saturate(float4 x) => new float4(float.Clamp(x.x, 0f, 1f), float.Clamp(x.y, 0f, 1f), float.Clamp(x.z, 0f, 1f), float.Clamp(x.w, 0f, 1f));
        public static float4 sign(float4 x) => new float4(float.Sign(x.x), float.Sign(x.y), float.Sign(x.z), float.Sign(x.w));
        public static float4 ceil(float4 x) => new float4(float.Ceiling(x.x), float.Ceiling(x.y), float.Ceiling(x.z), float.Ceiling(x.w));
        public static float4 floor(float4 x) => new float4(float.Floor(x.x), float.Floor(x.y), float.Floor(x.z), float.Floor(x.w));
        public static float4 round(float4 x) => new float4(float.Round(x.x), float.Round(x.y), float.Round(x.z), float.Round(x.w));
        public static float4 trunc(float4 x) => new float4(float.Truncate(x.x), float.Truncate(x.y), float.Truncate(x.z), float.Truncate(x.w));
        public static float4 frac(float4 x) => new float4(x.x - float.Floor(x.x), x.y - float.Floor(x.y), x.z - float.Floor(x.z), x.w - float.Floor(x.w));
        public static float4 exp(float4 x) => new float4(float.Exp(x.x), float.Exp(x.y), float.Exp(x.z), float.Exp(x.w));
        public static float4 exp2(float4 x) => new float4(float.Exp2(x.x), float.Exp2(x.y), float.Exp2(x.z), float.Exp2(x.w));
        public static float4 log(float4 x) => new float4(float.Log(x.x), float.Log(x.y), float.Log(x.z), float.Log(x.w));
        public static float4 log2(float4 x) => new float4(float.Log2(x.x), float.Log2(x.y), float.Log2(x.z), float.Log2(x.w));
        public static float4 log10(float4 x) => new float4(float.Log10(x.x), float.Log10(x.y), float.Log10(x.z), float.Log10(x.w));
        public static float4 pow(float4 x, float4 y) => new float4(float.Pow(x.x, y.x), float.Pow(x.y, y.y), float.Pow(x.z, y.z), float.Pow(x.w, y.w));
        public static float4 pow(float4 x, float y) => new float4(float.Pow(x.x, y), float.Pow(x.y, y), float.Pow(x.z, y), float.Pow(x.w, y));
        public static float4 rcp(float4 x) => new float4(1f / x.x, 1f / x.y, 1f / x.z, 1f / x.w);
        public static float4 rsqrt(float4 x) => new float4(1f / float.Sqrt(x.x), 1f / float.Sqrt(x.y), 1f / float.Sqrt(x.z), 1f / float.Sqrt(x.w));
        public static float4 sqrt(float4 x) => new float4(float.Sqrt(x.x), float.Sqrt(x.y), float.Sqrt(x.z), float.Sqrt(x.w));
        public static float4 acos(float4 x) => new float4(float.Acos(x.x), float.Acos(x.y), float.Acos(x.z), float.Acos(x.w));
        public static float4 asin(float4 x) => new float4(float.Asin(x.x), float.Asin(x.y), float.Asin(x.z), float.Asin(x.w));
        public static float4 atan(float4 x) => new float4(float.Atan(x.x), float.Atan(x.y), float.Atan(x.z), float.Atan(x.w));
        public static float4 atan2(float4 y, float4 x) => new float4(float.Atan2(y.x, x.x), float.Atan2(y.y, x.y), float.Atan2(y.z, x.z), float.Atan2(y.w, x.w));
        public static float4 cos(float4 x) => new float4(float.Cos(x.x), float.Cos(x.y), float.Cos(x.z), float.Cos(x.w));
        public static float4 sin(float4 x) => new float4(float.Sin(x.x), float.Sin(x.y), float.Sin(x.z), float.Sin(x.w));
        public static float4 tan(float4 x) => new float4(float.Tan(x.x), float.Tan(x.y), float.Tan(x.z), float.Tan(x.w));
        public static float4 radians(float4 x) => new float4(float.DegreesToRadians(x.x), float.DegreesToRadians(x.y), float.DegreesToRadians(x.z), float.DegreesToRadians(x.w));
        public static float4 degrees(float4 x) => new float4(float.RadiansToDegrees(x.x), float.RadiansToDegrees(x.y), float.RadiansToDegrees(x.z), float.RadiansToDegrees(x.w));
        public static bool4 isfinite(float4 x) => new bool4(float.IsFinite(x.x), float.IsFinite(x.y), float.IsFinite(x.z), float.IsFinite(x.w));
        public static bool4 isinf(float4 x) => new bool4(float.IsInfinity(x.x), float.IsInfinity(x.y), float.IsInfinity(x.z), float.IsInfinity(x.w));
        public static bool4 isnan(float4 x) => new bool4(float.IsNaN(x.x), float.IsNaN(x.y), float.IsNaN(x.z), float.IsNaN(x.w));

        // Vector geometry
        public static float dot(float4 x, float4 y) => x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w;
        public static float length(float4 x) => float.Sqrt(dot(x, x));
        public static float lengthsq(float4 x) => dot(x, x);
        public static float distance(float4 x, float4 y) => length(x - y);
        public static float4 normalize(float4 x)
        {
            float len = length(x);
            return len > 0 ? x / len : float4.zero;
        }

        // Component reduction
        public static float cmin(float4 x) => float.Min(x.x, float.Min(x.y, float.Min(x.z, x.w)));
        public static float cmax(float4 x) => float.Max(x.x, float.Max(x.y, float.Max(x.z, x.w)));
        public static float csum(float4 x) => x.x + x.y + x.z + x.w;

        // Reflection and refraction
        public static float4 reflect(float4 i, float4 n) => i - 2f * dot(n, i) * n;
        public static float4 refract(float4 i, float4 n, float eta)
        {
            float ndoti = dot(n, i);
            float k = 1f - eta * eta * (1f - ndoti * ndoti);
            return k < 0 ? float4.zero : eta * i - (eta * ndoti + float.Sqrt(k)) * n;
        }
        public static float4 faceforward(float4 n, float4 i, float4 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        public static float4 smoothstep(float4 edge0, float4 edge1, float4 x)
        {
            float4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float4(3f, 3f, 3f, 3f) - 2f * t);
        }
        public static float4 smoothstep(float edge0, float edge1, float4 x)
        {
            float4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new float4(3f, 3f, 3f, 3f) - 2f * t);
        }

        // Step
        public static float4 step(float4 edge, float4 x) => new float4(x.x >= edge.x ? 1f : 0f, x.y >= edge.y ? 1f : 0f, x.z >= edge.z ? 1f : 0f, x.w >= edge.w ? 1f : 0f);
        public static float4 step(float edge, float4 x) => new float4(x.x >= edge ? 1f : 0f, x.y >= edge ? 1f : 0f, x.z >= edge ? 1f : 0f, x.w >= edge ? 1f : 0f);

        // Modf
        public static float4 modf(float4 x, out float4 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (not defined for float4 in HLSL, but included for completeness with 3D components)
        public static float4 cross(float4 a, float4 b) => new float4(
            a.y * b.z - a.z * b.y,
            a.z * b.x - a.x * b.z,
            a.x * b.y - a.y * b.x,
            0f
        );

        #endregion float
        #region double

        public static double4 abs(double4 x) => new double4(double.Abs(x.x), double.Abs(x.y), double.Abs(x.z), double.Abs(x.w));
        public static double4 clamp(double4 x, double4 min, double4 max) => new double4(double.Clamp(x.x, min.x, max.x), double.Clamp(x.y, min.y, max.y), double.Clamp(x.z, min.z, max.z), double.Clamp(x.w, min.w, max.w));
        public static double4 clamp(double4 x, double min, double max) => new double4(double.Clamp(x.x, min, max), double.Clamp(x.y, min, max), double.Clamp(x.z, min, max), double.Clamp(x.w, min, max));
        public static double4 lerp(double4 x, double4 y, double t) => new double4(double.Lerp(x.x, y.x, t), double.Lerp(x.y, y.y, t), double.Lerp(x.z, y.z, t), double.Lerp(x.w, y.w, t));
        public static double4 lerp(double4 x, double4 y, double4 t) => new double4(double.Lerp(x.x, y.x, t.x), double.Lerp(x.y, y.y, t.y), double.Lerp(x.z, y.z, t.z), double.Lerp(x.w, y.w, t.w));
        public static double4 max(double4 x, double4 y) => new double4(double.Max(x.x, y.x), double.Max(x.y, y.y), double.Max(x.z, y.z), double.Max(x.w, y.w));
        public static double4 max(double4 x, double y) => new double4(double.Max(x.x, y), double.Max(x.y, y), double.Max(x.z, y), double.Max(x.w, y));
        public static double4 min(double4 x, double4 y) => new double4(double.Min(x.x, y.x), double.Min(x.y, y.y), double.Min(x.z, y.z), double.Min(x.w, y.w));
        public static double4 min(double4 x, double y) => new double4(double.Min(x.x, y), double.Min(x.y, y), double.Min(x.z, y), double.Min(x.w, y));
        public static double4 saturate(double4 x) => new double4(double.Clamp(x.x, 0.0, 1.0), double.Clamp(x.y, 0.0, 1.0), double.Clamp(x.z, 0.0, 1.0), double.Clamp(x.w, 0.0, 1.0));
        public static double4 sign(double4 x) => new double4(double.Sign(x.x), double.Sign(x.y), double.Sign(x.z), double.Sign(x.w));
        public static double4 ceil(double4 x) => new double4(double.Ceiling(x.x), double.Ceiling(x.y), double.Ceiling(x.z), double.Ceiling(x.w));
        public static double4 floor(double4 x) => new double4(double.Floor(x.x), double.Floor(x.y), double.Floor(x.z), double.Floor(x.w));
        public static double4 round(double4 x) => new double4(double.Round(x.x), double.Round(x.y), double.Round(x.z), double.Round(x.w));
        public static double4 trunc(double4 x) => new double4(double.Truncate(x.x), double.Truncate(x.y), double.Truncate(x.z), double.Truncate(x.w));
        public static double4 frac(double4 x) => new double4(x.x - double.Floor(x.x), x.y - double.Floor(x.y), x.z - double.Floor(x.z), x.w - double.Floor(x.w));
        public static double4 exp(double4 x) => new double4(double.Exp(x.x), double.Exp(x.y), double.Exp(x.z), double.Exp(x.w));
        public static double4 exp2(double4 x) => new double4(double.Exp2(x.x), double.Exp2(x.y), double.Exp2(x.z), double.Exp2(x.w));
        public static double4 log(double4 x) => new double4(double.Log(x.x), double.Log(x.y), double.Log(x.z), double.Log(x.w));
        public static double4 log2(double4 x) => new double4(double.Log2(x.x), double.Log2(x.y), double.Log2(x.z), double.Log2(x.w));
        public static double4 log10(double4 x) => new double4(double.Log10(x.x), double.Log10(x.y), double.Log10(x.z), double.Log10(x.w));
        public static double4 pow(double4 x, double4 y) => new double4(double.Pow(x.x, y.x), double.Pow(x.y, y.y), double.Pow(x.z, y.z), double.Pow(x.w, y.w));
        public static double4 pow(double4 x, double y) => new double4(double.Pow(x.x, y), double.Pow(x.y, y), double.Pow(x.z, y), double.Pow(x.w, y));
        public static double4 rcp(double4 x) => new double4(1.0 / x.x, 1.0 / x.y, 1.0 / x.z, 1.0 / x.w);
        public static double4 rsqrt(double4 x) => new double4(1.0 / double.Sqrt(x.x), 1.0 / double.Sqrt(x.y), 1.0 / double.Sqrt(x.z), 1.0 / double.Sqrt(x.w));
        public static double4 sqrt(double4 x) => new double4(double.Sqrt(x.x), double.Sqrt(x.y), double.Sqrt(x.z), double.Sqrt(x.w));
        public static double4 acos(double4 x) => new double4(double.Acos(x.x), double.Acos(x.y), double.Acos(x.z), double.Acos(x.w));
        public static double4 asin(double4 x) => new double4(double.Asin(x.x), double.Asin(x.y), double.Asin(x.z), double.Asin(x.w));
        public static double4 atan(double4 x) => new double4(double.Atan(x.x), double.Atan(x.y), double.Atan(x.z), double.Atan(x.w));
        public static double4 atan2(double4 y, double4 x) => new double4(double.Atan2(y.x, x.x), double.Atan2(y.y, x.y), double.Atan2(y.z, x.z), double.Atan2(y.w, x.w));
        public static double4 cos(double4 x) => new double4(double.Cos(x.x), double.Cos(x.y), double.Cos(x.z), double.Cos(x.w));
        public static double4 sin(double4 x) => new double4(double.Sin(x.x), double.Sin(x.y), double.Sin(x.z), double.Sin(x.w));
        public static double4 tan(double4 x) => new double4(double.Tan(x.x), double.Tan(x.y), double.Tan(x.z), double.Tan(x.w));
        public static double4 radians(double4 x) => new double4(double.DegreesToRadians(x.x), double.DegreesToRadians(x.y), double.DegreesToRadians(x.z), double.DegreesToRadians(x.w));
        public static double4 degrees(double4 x) => new double4(double.RadiansToDegrees(x.x), double.RadiansToDegrees(x.y), double.RadiansToDegrees(x.z), double.RadiansToDegrees(x.w));
        public static bool4 isfinite(double4 x) => new bool4(double.IsFinite(x.x), double.IsFinite(x.y), double.IsFinite(x.z), double.IsFinite(x.w));
        public static bool4 isinf(double4 x) => new bool4(double.IsInfinity(x.x), double.IsInfinity(x.y), double.IsInfinity(x.z), double.IsInfinity(x.w));
        public static bool4 isnan(double4 x) => new bool4(double.IsNaN(x.x), double.IsNaN(x.y), double.IsNaN(x.z), double.IsNaN(x.w));

        // Vector geometry
        public static double dot(double4 x, double4 y) => x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w;
        public static double length(double4 x) => double.Sqrt(dot(x, x));
        public static double lengthsq(double4 x) => dot(x, x);
        public static double distance(double4 x, double4 y) => length(x - y);
        public static double4 normalize(double4 x)
        {
            double len = length(x);
            return len > 0 ? x / len : double4.zero;
        }

        // Component reduction
        public static double cmin(double4 x) => double.Min(x.x, double.Min(x.y, double.Min(x.z, x.w)));
        public static double cmax(double4 x) => double.Max(x.x, double.Max(x.y, double.Max(x.z, x.w)));
        public static double csum(double4 x) => x.x + x.y + x.z + x.w;

        // Reflection and refraction
        public static double4 reflect(double4 i, double4 n) => i - 2.0 * dot(n, i) * n;
        public static double4 refract(double4 i, double4 n, double eta)
        {
            double ndoti = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ndoti * ndoti);
            return k < 0 ? double4.zero : eta * i - (eta * ndoti + double.Sqrt(k)) * n;
        }
        public static double4 faceforward(double4 n, double4 i, double4 ng) => dot(ng, i) < 0 ? n : -n;

        // Smoothstep
        public static double4 smoothstep(double4 edge0, double4 edge1, double4 x)
        {
            double4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double4(3.0, 3.0, 3.0, 3.0) - 2.0 * t);
        }
        public static double4 smoothstep(double edge0, double edge1, double4 x)
        {
            double4 t = saturate((x - edge0) / (edge1 - edge0));
            return t * t * (new double4(3.0, 3.0, 3.0, 3.0) - 2.0 * t);
        }

        // Step
        public static double4 step(double4 edge, double4 x) => new double4(x.x >= edge.x ? 1.0 : 0.0, x.y >= edge.y ? 1.0 : 0.0, x.z >= edge.z ? 1.0 : 0.0, x.w >= edge.w ? 1.0 : 0.0);
        public static double4 step(double edge, double4 x) => new double4(x.x >= edge ? 1.0 : 0.0, x.y >= edge ? 1.0 : 0.0, x.z >= edge ? 1.0 : 0.0, x.w >= edge ? 1.0 : 0.0);

        // Modf
        public static double4 modf(double4 x, out double4 intPart)
        {
            intPart = trunc(x);
            return x - intPart;
        }

        // Cross product (4D cross product is not standard in HLSL, but here's a 4D implementation using 3D components)
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

        public static int4 abs(int4 x) => new int4(int.Abs(x.x), int.Abs(x.y), int.Abs(x.z), int.Abs(x.w));
        public static int4 clamp(int4 x, int4 min, int4 max) => new int4(int.Clamp(x.x, min.x, max.x), int.Clamp(x.y, min.y, max.y), int.Clamp(x.z, min.z, max.z), int.Clamp(x.w, min.w, max.w));
        public static int4 max(int4 x, int4 y) => new int4(int.Max(x.x, y.x), int.Max(x.y, y.y), int.Max(x.z, y.z), int.Max(x.w, y.w));
        public static int4 min(int4 x, int4 y) => new int4(int.Min(x.x, y.x), int.Min(x.y, y.y), int.Min(x.z, y.z), int.Min(x.w, y.w));
        public static int4 sign(int4 x) => new int4(int.Sign(x.x), int.Sign(x.y), int.Sign(x.z), int.Sign(x.w));

        public static int cmin(int4 x) => int.Min(x.x, int.Min(x.y, int.Min(x.z, x.w)));
        public static int cmax(int4 x) => int.Max(x.x, int.Max(x.y, int.Max(x.z, x.w)));
        public static int csum(int4 x) => x.x + x.y + x.z + x.w;

        #endregion int
        #region uint

        public static uint4 clamp(uint4 x, uint4 min, uint4 max) => new uint4(uint.Clamp(x.x, min.x, max.x), uint.Clamp(x.y, min.y, max.y), uint.Clamp(x.z, min.z, max.z), uint.Clamp(x.w, min.w, max.w));
        public static uint4 max(uint4 x, uint4 y) => new uint4(uint.Max(x.x, y.x), uint.Max(x.y, y.y), uint.Max(x.z, y.z), uint.Max(x.w, y.w));
        public static uint4 min(uint4 x, uint4 y) => new uint4(uint.Min(x.x, y.x), uint.Min(x.y, y.y), uint.Min(x.z, y.z), uint.Min(x.w, y.w));

        public static uint cmin(uint4 x) => uint.Min(x.x, uint.Min(x.y, uint.Min(x.z, x.w)));
        public static uint cmax(uint4 x) => uint.Max(x.x, uint.Max(x.y, uint.Max(x.z, x.w)));
        public static uint csum(uint4 x) => x.x + x.y + x.z + x.w;

        #endregion uint
        #region bool

        public static bool4 any(bool4 x) => x.any;
        public static bool4 all(bool4 x) => x.all;

        #endregion bool
        #region interpretation

        public static int4 asint(float4 x) => new int4(BitConverter.SingleToInt32Bits(x.x), BitConverter.SingleToInt32Bits(x.y), 
            BitConverter.SingleToInt32Bits(x.z), BitConverter.SingleToInt32Bits(x.w));
        public static uint4 asuint(float4 x) => new uint4(BitConverter.SingleToUInt32Bits(x.x), BitConverter.SingleToUInt32Bits(x.y), 
            BitConverter.SingleToUInt32Bits(x.z), BitConverter.SingleToUInt32Bits(x.w));
        public static float4 asfloat(int4 x) => new float4(BitConverter.Int32BitsToSingle(x.x), BitConverter.Int32BitsToSingle(x.y), 
            BitConverter.Int32BitsToSingle(x.z), BitConverter.Int32BitsToSingle(x.w));
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
