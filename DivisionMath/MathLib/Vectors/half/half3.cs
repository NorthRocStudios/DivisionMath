using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct half3
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

        public override readonly string ToString() => $"half3({x}, {y}, {z})";
        public override readonly bool Equals(object? obj) => obj is half3 other && x == other.x && y == other.y && z == other.z;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        public half3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public half3(float value)
        {
            x = value;
            y = value;
            z = value;
        }

        public half3(half2 xy, float z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        public half3(float x, half2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        public static half3 operator -(half3 v) => new half3(-v.x, -v.y, -v.z);
        public static half3 operator +(half3 v) => v;

        // Implicit Operations

        public static implicit operator half3(half4 v) => new half3(v.x, v.y, v.z);
        public static implicit operator half3(half2 v) => new half3(v, 0);
        public static implicit operator half3(float v) => new half3(v);

        // Unit Vectors

        public static half3 zero => new half3(0);
        public static half3 one => new half3(1);
        public static half3 unitX => new half3(1, 0, 0);
        public static half3 unitY => new half3(0, 1, 0);
        public static half3 unitZ => new half3(0, 0, 1);

        public static half3 up => unitY;
        public static half3 down => new half3(0, -1, 0);
        public static half3 left => new half3(-1, 0, 0);
        public static half3 right => new half3(1, 0, 0);
        public static half3 forward => new half3(0, 0, 1);
        public static half3 back => new half3(0, 0, -1);

        // Arithmetic Operations

        public static half3 operator +(half3 a, half3 b) => new half3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static half3 operator -(half3 a, half3 b) => new half3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static half3 operator *(half3 a, half3 b) => new half3(a.x * b.x, a.y * b.y, a.z * b.z);
        public static half3 operator /(half3 a, half3 b) => new half3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - half

        public static half3 operator +(half3 a, float b) => new half3(a.x + b, a.y + b, a.z + b);
        public static half3 operator -(half3 a, float b) => new half3(a.x - b, a.y - b, a.z - b);
        public static half3 operator *(half3 a, float b) => new half3(a.x * b, a.y * b, a.z * b);
        public static half3 operator /(half3 a, float b) => new half3(a.x / b, a.y / b, a.z / b);

        public static half3 operator +(float a, half3 b) => new half3(a + b.x, a + b.y, a + b.z);
        public static half3 operator -(float a, half3 b) => new half3(a - b.x, a - b.y, a - b.z);
        public static half3 operator *(float a, half3 b) => new half3(a * b.x, a * b.y, a * b.z);
        public static half3 operator /(float a, half3 b) => new half3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - half2

        public static half3 operator +(half3 a, half2 b) => new half3(a.x + b.x, a.y + b.y, a.z);
        public static half3 operator -(half3 a, half2 b) => new half3(a.x - b.x, a.y - b.y, a.z);
        public static half3 operator *(half3 a, half2 b) => new half3(a.x * b.x, a.y * b.y, a.z);
        public static half3 operator /(half3 a, half2 b) => new half3(a.x / b.x, a.y / b.y, a.z);

        public static half3 operator +(half2 a, half3 b) => new half3(a.x + b.x, a.y + b.y, b.z);
        public static half3 operator -(half2 a, half3 b) => new half3(a.x - b.x, a.y - b.y, b.z);
        public static half3 operator *(half2 a, half3 b) => new half3(a.x * b.x, a.y * b.y, b.z);
        public static half3 operator /(half2 a, half3 b) => new half3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        public static bool3 operator ==(half3 a, half3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        public static bool3 operator !=(half3 a, half3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        public static bool3 operator <(half3 a, half3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        public static bool3 operator >(half3 a, half3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        public static bool3 operator <=(half3 a, half3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        public static bool3 operator >=(half3 a, half3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        public static bool3 operator ==(half3 a, float b) => new bool3(a.x == b, a.y == b, a.z == b);
        public static bool3 operator !=(half3 a, float b) => new bool3(a.x != b, a.y != b, a.z != b);
        public static bool3 operator <(half3 a, float b) => new bool3(a.x < b, a.y < b, a.z < b);
        public static bool3 operator >(half3 a, float b) => new bool3(a.x > b, a.y > b, a.z > b);
        public static bool3 operator <=(half3 a, float b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        public static bool3 operator >=(half3 a, float b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        public static bool3 operator ==(float a, half3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        public static bool3 operator !=(float a, half3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        public static bool3 operator <(float a, half3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        public static bool3 operator >(float a, half3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        public static bool3 operator <=(float a, half3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        public static bool3 operator >=(float a, half3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - half3

        // x
        public readonly half3 xxx => new half3(x, x, x);
        public readonly half3 xxy => new half3(x, x, y);
        public readonly half3 xxz => new half3(x, x, z);

        public readonly half3 xyx => new half3(x, y, x);
        public readonly half3 xyy => new half3(x, y, y);
        public readonly half3 xyz => new half3(x, y, z);

        public readonly half3 xzx => new half3(x, z, x);
        public readonly half3 xzy => new half3(x, z, y);
        public readonly half3 xzz => new half3(x, z, z);

        // y
        public readonly half3 yxx => new half3(y, x, x);
        public readonly half3 yxy => new half3(y, x, y);
        public readonly half3 yxz => new half3(y, x, z);

        public readonly half3 yyx => new half3(y, y, x);
        public readonly half3 yyy => new half3(y, y, y);
        public readonly half3 yyz => new half3(y, y, z);

        public readonly half3 yzx => new half3(y, z, x);
        public readonly half3 yzy => new half3(y, z, y);
        public readonly half3 yzz => new half3(y, z, z);

        // z
        public readonly half3 zxx => new half3(z, x, x);
        public readonly half3 zxy => new half3(z, x, y);
        public readonly half3 zxz => new half3(z, x, z);

        public readonly half3 zyx => new half3(z, y, x);
        public readonly half3 zyy => new half3(z, y, y);
        public readonly half3 zyz => new half3(z, y, z);

        public readonly half3 zzx => new half3(z, z, x);
        public readonly half3 zzy => new half3(z, z, y);
        public readonly half3 zzz => new half3(z, z, z);

        // Swizzling - half2

        public readonly half2 xx => new half2(x, x);
        public readonly half2 xy => new half2(x, y);
        public readonly half2 xz => new half2(x, z);

        public readonly half2 yx => new half2(y, x);
        public readonly half2 yy => new half2(y, y);
        public readonly half2 yz => new half2(y, z);

        public readonly half2 zx => new half2(z, x);
        public readonly half2 zy => new half2(z, y);
        public readonly half2 zz => new half2(z, z);

        // RGBA Equvalence

        public readonly float r => x;
        public readonly float g => y;
        public readonly float b => z;

        // RGBA Swizzling - half3

        // r
        public readonly half3 rrr => new half3(r, r, r);
        public readonly half3 rrg => new half3(r, r, g);
        public readonly half3 rrb => new half3(r, r, b);

        public readonly half3 rgr => new half3(r, g, r);
        public readonly half3 rgg => new half3(r, g, g);
        public readonly half3 rgb => new half3(r, g, b);

        public readonly half3 rbr => new half3(r, b, r);
        public readonly half3 rbg => new half3(r, b, g);
        public readonly half3 rbb => new half3(r, b, b);

        // g
        public readonly half3 grr => new half3(g, r, r);
        public readonly half3 grg => new half3(g, r, g);
        public readonly half3 grb => new half3(g, r, b);

        public readonly half3 ggr => new half3(g, g, r);
        public readonly half3 ggg => new half3(g, g, g);
        public readonly half3 ggb => new half3(g, g, b);

        public readonly half3 gbr => new half3(g, b, r);
        public readonly half3 gbg => new half3(g, b, g);
        public readonly half3 gbb => new half3(g, b, b);

        // b
        public readonly half3 brr => new half3(b, r, r);
        public readonly half3 brg => new half3(b, r, g);
        public readonly half3 brb => new half3(b, r, b);

        public readonly half3 bgr => new half3(b, g, r);
        public readonly half3 bgg => new half3(b, g, g);
        public readonly half3 bgb => new half3(b, g, b);

        public readonly half3 bbr => new half3(b, b, r);
        public readonly half3 bbg => new half3(b, b, g);
        public readonly half3 bbb => new half3(b, b, b);

        // RGBA Swizzling - half2

        public readonly half2 rr => new half2(r, r);
        public readonly half2 rg => new half2(r, g);
        public readonly half2 rb => new half2(r, b);

        public readonly half2 gr => new half2(g, r);
        public readonly half2 gg => new half2(g, g);
        public readonly half2 gb => new half2(g, b);

        public readonly half2 br => new half2(b, r);
        public readonly half2 bg => new half2(b, g);
        public readonly half2 bb => new half2(b, b);
    }
}
