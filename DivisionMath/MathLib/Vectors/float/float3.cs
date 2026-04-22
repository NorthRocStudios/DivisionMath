using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct float3
    {
        // Data Storage

        public float x;
        public float y;
        public float z;

        // Component Access

        public float this[int index]
        {
            readonly get => index switch
            {
                0 => x,
                1 => y,
                2 => z,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                }
            }
        }

        // Overrides

        public override readonly string ToString() => $"float3({x}, {y}, {z})";
        public override readonly bool Equals(object? obj) => obj is float3 other && x == other.x && y == other.y && z == other.z;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        public float3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float3(float value)
        {
            x = value;
            y = value;
            z = value;
        }

        public float3(float2 xy, float z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        public float3(float x, float2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        public static float3 operator -(float3 v) => new float3(-v.x, -v.y, -v.z);
        public static float3 operator +(float3 v) => v;

        // Implicit Operations

        public static implicit operator float3(float4 v) => new float3(v.x, v.y, v.z);
        public static implicit operator float3(float2 v) => new float3(v, 0);
        public static implicit operator float3(float v) => new float3(v);

        // Unit Vectors

        public static float3 zero => new float3(0);
        public static float3 one => new float3(1);
        public static float3 unitX => new float3(1, 0, 0);
        public static float3 unitY => new float3(0, 1, 0);
        public static float3 unitZ => new float3(0, 0, 1);

        public static float3 up => unitY;
        public static float3 down => new float3(0, -1, 0);
        public static float3 left => new float3(-1, 0, 0);
        public static float3 right => new float3(1, 0, 0);
        public static float3 forward => new float3(0, 0, 1);
        public static float3 back => new float3(0, 0, -1);

        // Arithmetic Operations

        public static float3 operator +(float3 a, float3 b) => new float3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static float3 operator -(float3 a, float3 b) => new float3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static float3 operator *(float3 a, float3 b) => new float3(a.x * b.x, a.y * b.y, a.z * b.z);
        public static float3 operator /(float3 a, float3 b) => new float3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - float

        public static float3 operator +(float3 a, float b) => new float3(a.x + b, a.y + b, a.z + b);
        public static float3 operator -(float3 a, float b) => new float3(a.x - b, a.y - b, a.z - b);
        public static float3 operator *(float3 a, float b) => new float3(a.x * b, a.y * b, a.z * b);
        public static float3 operator /(float3 a, float b) => new float3(a.x / b, a.y / b, a.z / b);

        public static float3 operator +(float a, float3 b) => new float3(a + b.x, a + b.y, a + b.z);
        public static float3 operator -(float a, float3 b) => new float3(a - b.x, a - b.y, a - b.z);
        public static float3 operator *(float a, float3 b) => new float3(a * b.x, a * b.y, a * b.z);
        public static float3 operator /(float a, float3 b) => new float3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - float2

        public static float3 operator +(float3 a, float2 b) => new float3(a.x + b.x, a.y + b.y, a.z);
        public static float3 operator -(float3 a, float2 b) => new float3(a.x - b.x, a.y - b.y, a.z);
        public static float3 operator *(float3 a, float2 b) => new float3(a.x * b.x, a.y * b.y, a.z);
        public static float3 operator /(float3 a, float2 b) => new float3(a.x / b.x, a.y / b.y, a.z);

        public static float3 operator +(float2 a, float3 b) => new float3(a.x + b.x, a.y + b.y, b.z);
        public static float3 operator -(float2 a, float3 b) => new float3(a.x - b.x, a.y - b.y, b.z);
        public static float3 operator *(float2 a, float3 b) => new float3(a.x * b.x, a.y * b.y, b.z);
        public static float3 operator /(float2 a, float3 b) => new float3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        public static bool3 operator ==(float3 a, float3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        public static bool3 operator !=(float3 a, float3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        public static bool3 operator <(float3 a, float3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        public static bool3 operator >(float3 a, float3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        public static bool3 operator <=(float3 a, float3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        public static bool3 operator >=(float3 a, float3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        public static bool3 operator ==(float3 a, float b) => new bool3(a.x == b, a.y == b, a.z == b);
        public static bool3 operator !=(float3 a, float b) => new bool3(a.x != b, a.y != b, a.z != b);
        public static bool3 operator <(float3 a, float b) => new bool3(a.x < b, a.y < b, a.z < b);
        public static bool3 operator >(float3 a, float b) => new bool3(a.x > b, a.y > b, a.z > b);
        public static bool3 operator <=(float3 a, float b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        public static bool3 operator >=(float3 a, float b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        public static bool3 operator ==(float a, float3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        public static bool3 operator !=(float a, float3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        public static bool3 operator <(float a, float3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        public static bool3 operator >(float a, float3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        public static bool3 operator <=(float a, float3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        public static bool3 operator >=(float a, float3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - float3

        // x
        public readonly float3 xxx => new float3(x, x, x);
        public readonly float3 xxy => new float3(x, x, y);
        public readonly float3 xxz => new float3(x, x, z);

        public readonly float3 xyx => new float3(x, y, x);
        public readonly float3 xyy => new float3(x, y, y);
        public readonly float3 xyz => new float3(x, y, z);

        public readonly float3 xzx => new float3(x, z, x);
        public readonly float3 xzy => new float3(x, z, y);
        public readonly float3 xzz => new float3(x, z, z);

        // y
        public readonly float3 yxx => new float3(y, x, x);
        public readonly float3 yxy => new float3(y, x, y);
        public readonly float3 yxz => new float3(y, x, z);

        public readonly float3 yyx => new float3(y, y, x);
        public readonly float3 yyy => new float3(y, y, y);
        public readonly float3 yyz => new float3(y, y, z);

        public readonly float3 yzx => new float3(y, z, x);
        public readonly float3 yzy => new float3(y, z, y);
        public readonly float3 yzz => new float3(y, z, z);

        // z
        public readonly float3 zxx => new float3(z, x, x);
        public readonly float3 zxy => new float3(z, x, y);
        public readonly float3 zxz => new float3(z, x, z);

        public readonly float3 zyx => new float3(z, y, x);
        public readonly float3 zyy => new float3(z, y, y);
        public readonly float3 zyz => new float3(z, y, z);

        public readonly float3 zzx => new float3(z, z, x);
        public readonly float3 zzy => new float3(z, z, y);
        public readonly float3 zzz => new float3(z, z, z);

        // Swizzling - float2

        public readonly float2 xx => new float2(x, x);
        public readonly float2 xy => new float2(x, y);
        public readonly float2 xz => new float2(x, z);

        public readonly float2 yx => new float2(y, x);
        public readonly float2 yy => new float2(y, y);
        public readonly float2 yz => new float2(y, z);

        public readonly float2 zx => new float2(z, x);
        public readonly float2 zy => new float2(z, y);
        public readonly float2 zz => new float2(z, z);

        // RGBA Equvalence

        public readonly float r => x;
        public readonly float g => y;
        public readonly float b => z;

        // RGBA Swizzling - float3

        // r
        public readonly float3 rrr => new float3(r, r, r);
        public readonly float3 rrg => new float3(r, r, g);
        public readonly float3 rrb => new float3(r, r, b);

        public readonly float3 rgr => new float3(r, g, r);
        public readonly float3 rgg => new float3(r, g, g);
        public readonly float3 rgb => new float3(r, g, b);

        public readonly float3 rbr => new float3(r, b, r);
        public readonly float3 rbg => new float3(r, b, g);
        public readonly float3 rbb => new float3(r, b, b);

        // g
        public readonly float3 grr => new float3(g, r, r);
        public readonly float3 grg => new float3(g, r, g);
        public readonly float3 grb => new float3(g, r, b);

        public readonly float3 ggr => new float3(g, g, r);
        public readonly float3 ggg => new float3(g, g, g);
        public readonly float3 ggb => new float3(g, g, b);

        public readonly float3 gbr => new float3(g, b, r);
        public readonly float3 gbg => new float3(g, b, g);
        public readonly float3 gbb => new float3(g, b, b);

        // b
        public readonly float3 brr => new float3(b, r, r);
        public readonly float3 brg => new float3(b, r, g);
        public readonly float3 brb => new float3(b, r, b);

        public readonly float3 bgr => new float3(b, g, r);
        public readonly float3 bgg => new float3(b, g, g);
        public readonly float3 bgb => new float3(b, g, b);

        public readonly float3 bbr => new float3(b, b, r);
        public readonly float3 bbg => new float3(b, b, g);
        public readonly float3 bbb => new float3(b, b, b);

        // RGBA Swizzling - float2

        public readonly float2 rr => new float2(r, r);
        public readonly float2 rg => new float2(r, g);
        public readonly float2 rb => new float2(r, b);

        public readonly float2 gr => new float2(g, r);
        public readonly float2 gg => new float2(g, g);
        public readonly float2 gb => new float2(g, b);

        public readonly float2 br => new float2(b, r);
        public readonly float2 bg => new float2(b, g);
        public readonly float2 bb => new float2(b, b);
    }
}
