using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct float4
    {
        // Data Storage

        public float x;
        public float y;
        public float z;
        public float w;

        // Component Access

        public float this[int index]
        {
            readonly get => index switch
            {
                0 => x,
                1 => y,
                2 => z,
                3 => w,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                }
            }
        }

        // Overrides

        public override readonly string ToString() => $"float4({x}, {y}, {z}, {w})";
        public override readonly bool Equals(object? obj) => obj is float4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        public float4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public float4(float value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public float4(float3 xyz, float w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        public float4(float x, float3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        public float4(float2 xy, float2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        public float4(float x, float y, float2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        public float4(float2 xy, float z, float w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        public float4(float x, float2 yz, float w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        public static float4 operator -(float4 v) => new float4(-v.x, -v.y, -v.z, -v.w);
        public static float4 operator +(float4 v) => v;

        // Implicit Operations

        public static implicit operator float4(float3 v) => new float4(v, 0);
        public static implicit operator float4(float2 v) => new float4(v, 0, 0);
        public static implicit operator float4(float v) => new float4(v);

        // Unit Vectors

        public static float4 zero => new float4(0);
        public static float4 one => new float4(1);
        public static float4 unitX => new float4(1, 0, 0, 0);
        public static float4 unitY => new float4(0, 1, 0, 0);
        public static float4 unitZ => new float4(0, 0, 1, 0);
        public static float4 unitW => new float4(0, 0, 0, 1);

        // Arithmetic Operations

        public static float4 operator +(float4 a, float4 b) => new float4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        public static float4 operator -(float4 a, float4 b) => new float4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        public static float4 operator *(float4 a, float4 b) => new float4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        public static float4 operator /(float4 a, float4 b) => new float4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);

        // Arithmetic - float

        public static float4 operator +(float4 a, float b) => new float4(a.x + b, a.y + b, a.z + b, a.w + b);
        public static float4 operator -(float4 a, float b) => new float4(a.x - b, a.y - b, a.z - b, a.w - b);
        public static float4 operator *(float4 a, float b) => new float4(a.x * b, a.y * b, a.z * b, a.w * b);
        public static float4 operator /(float4 a, float b) => new float4(a.x / b, a.y / b, a.z / b, a.w / b);

        public static float4 operator +(float a, float4 b) => new float4(a + b.x, a + b.y, a + b.z, a + b.w);
        public static float4 operator -(float a, float4 b) => new float4(a - b.x, a - b.y, a - b.z, a - b.w);
        public static float4 operator *(float a, float4 b) => new float4(a * b.x, a * b.y, a * b.z, a * b.w);
        public static float4 operator /(float a, float4 b) => new float4(a / b.x, a / b.y, a / b.z, a / b.w);

        // Arithmetic - float2

        public static float4 operator +(float4 a, float2 b) => new float4(a.x + b.x, a.y + b.y, a.z, a.w);
        public static float4 operator -(float4 a, float2 b) => new float4(a.x - b.x, a.y - b.y, a.z, a.w);
        public static float4 operator *(float4 a, float2 b) => new float4(a.x * b.x, a.y * b.y, a.z, a.w);
        public static float4 operator /(float4 a, float2 b) => new float4(a.x / b.x, a.y / b.y, a.z, a.w);

        public static float4 operator +(float2 a, float4 b) => new float4(a.x + b.x, a.y + b.y, b.z, b.w);
        public static float4 operator -(float2 a, float4 b) => new float4(a.x - b.x, a.y - b.y, b.z, b.w);
        public static float4 operator *(float2 a, float4 b) => new float4(a.x * b.x, a.y * b.y, b.z, b.w);
        public static float4 operator /(float2 a, float4 b) => new float4(a.x / b.x, a.y / b.y, b.z, b.w);

        // Arithmetic - float3

        public static float4 operator +(float4 a, float3 b) => new float4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        public static float4 operator -(float4 a, float3 b) => new float4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        public static float4 operator *(float4 a, float3 b) => new float4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        public static float4 operator /(float4 a, float3 b) => new float4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);

        public static float4 operator +(float3 a, float4 b) => new float4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        public static float4 operator -(float3 a, float4 b) => new float4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        public static float4 operator *(float3 a, float4 b) => new float4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        public static float4 operator /(float3 a, float4 b) => new float4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);

        // Comparison Operations

        public static bool4 operator ==(float4 a, float4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        public static bool4 operator !=(float4 a, float4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        public static bool4 operator <(float4 a, float4 b) => new bool4(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        public static bool4 operator >(float4 a, float4 b) => new bool4(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        public static bool4 operator <=(float4 a, float4 b) => new bool4(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        public static bool4 operator >=(float4 a, float4 b) => new bool4(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);

        // Vector-scalar comparisons
        public static bool4 operator ==(float4 a, float b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        public static bool4 operator !=(float4 a, float b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        public static bool4 operator <(float4 a, float b) => new bool4(a.x < b, a.y < b, a.z < b, a.w < b);
        public static bool4 operator >(float4 a, float b) => new bool4(a.x > b, a.y > b, a.z > b, a.w > b);
        public static bool4 operator <=(float4 a, float b) => new bool4(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        public static bool4 operator >=(float4 a, float b) => new bool4(a.x >= b, a.y >= b, a.z >= b, a.w >= b);

        // Scalar-vector comparisons
        public static bool4 operator ==(float a, float4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        public static bool4 operator !=(float a, float4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);
        public static bool4 operator <(float a, float4 b) => new bool4(a < b.x, a < b.y, a < b.z, a < b.w);
        public static bool4 operator >(float a, float4 b) => new bool4(a > b.x, a > b.y, a > b.z, a > b.w);
        public static bool4 operator <=(float a, float4 b) => new bool4(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
        public static bool4 operator >=(float a, float4 b) => new bool4(a >= b.x, a >= b.y, a >= b.z, a >= b.w);

        // RGBA Equvalence

        public readonly float r => x;
        public readonly float g => y;
        public readonly float b => z;
        public readonly float a => w;
    }
}
