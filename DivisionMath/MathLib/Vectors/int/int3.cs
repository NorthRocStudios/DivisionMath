using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct int3
    {
        // Data Storage

        public int x;
        public int y;
        public int z;

        // Component Access

        public int this[int index]
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

        public override readonly string ToString() => $"int3({x}, {y}, {z})";
        public override readonly bool Equals(object? obj) => obj is int3 other && x == other.x && y == other.y && z == other.z;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        public int3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int3(int value)
        {
            x = value;
            y = value;
            z = value;
        }

        public int3(int2 xy, int z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        public int3(int x, int2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        public static int3 operator -(int3 v) => new int3(-v.x, -v.y, -v.z);
        public static int3 operator +(int3 v) => v;

        // Implicit Operations

        public static implicit operator int3(int4 v) => new int3(v.x, v.y, v.z);
        public static implicit operator int3(int2 v) => new int3(v, 0);
        public static implicit operator int3(int v) => new int3(v);

        // Unit Vectors

        public static int3 zero => new int3(0);
        public static int3 one => new int3(1);
        public static int3 unitX => new int3(1, 0, 0);
        public static int3 unitY => new int3(0, 1, 0);
        public static int3 unitZ => new int3(0, 0, 1);

        public static int3 up => unitY;
        public static int3 down => new int3(0, -1, 0);
        public static int3 left => new int3(-1, 0, 0);
        public static int3 right => new int3(1, 0, 0);
        public static int3 forward => new int3(0, 0, 1);
        public static int3 back => new int3(0, 0, -1);

        // Arithmetic Operations

        public static int3 operator +(int3 a, int3 b) => new int3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static int3 operator -(int3 a, int3 b) => new int3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static int3 operator *(int3 a, int3 b) => new int3(a.x * b.x, a.y * b.y, a.z * b.z);
        public static int3 operator /(int3 a, int3 b) => new int3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - int

        public static int3 operator +(int3 a, int b) => new int3(a.x + b, a.y + b, a.z + b);
        public static int3 operator -(int3 a, int b) => new int3(a.x - b, a.y - b, a.z - b);
        public static int3 operator *(int3 a, int b) => new int3(a.x * b, a.y * b, a.z * b);
        public static int3 operator /(int3 a, int b) => new int3(a.x / b, a.y / b, a.z / b);

        public static int3 operator +(int a, int3 b) => new int3(a + b.x, a + b.y, a + b.z);
        public static int3 operator -(int a, int3 b) => new int3(a - b.x, a - b.y, a - b.z);
        public static int3 operator *(int a, int3 b) => new int3(a * b.x, a * b.y, a * b.z);
        public static int3 operator /(int a, int3 b) => new int3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - int2

        public static int3 operator +(int3 a, int2 b) => new int3(a.x + b.x, a.y + b.y, a.z);
        public static int3 operator -(int3 a, int2 b) => new int3(a.x - b.x, a.y - b.y, a.z);
        public static int3 operator *(int3 a, int2 b) => new int3(a.x * b.x, a.y * b.y, a.z);
        public static int3 operator /(int3 a, int2 b) => new int3(a.x / b.x, a.y / b.y, a.z);

        public static int3 operator +(int2 a, int3 b) => new int3(a.x + b.x, a.y + b.y, b.z);
        public static int3 operator -(int2 a, int3 b) => new int3(a.x - b.x, a.y - b.y, b.z);
        public static int3 operator *(int2 a, int3 b) => new int3(a.x * b.x, a.y * b.y, b.z);
        public static int3 operator /(int2 a, int3 b) => new int3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        public static bool3 operator ==(int3 a, int3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        public static bool3 operator !=(int3 a, int3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        public static bool3 operator <(int3 a, int3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        public static bool3 operator >(int3 a, int3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        public static bool3 operator <=(int3 a, int3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        public static bool3 operator >=(int3 a, int3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        public static bool3 operator ==(int3 a, int b) => new bool3(a.x == b, a.y == b, a.z == b);
        public static bool3 operator !=(int3 a, int b) => new bool3(a.x != b, a.y != b, a.z != b);
        public static bool3 operator <(int3 a, int b) => new bool3(a.x < b, a.y < b, a.z < b);
        public static bool3 operator >(int3 a, int b) => new bool3(a.x > b, a.y > b, a.z > b);
        public static bool3 operator <=(int3 a, int b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        public static bool3 operator >=(int3 a, int b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        public static bool3 operator ==(int a, int3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        public static bool3 operator !=(int a, int3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        public static bool3 operator <(int a, int3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        public static bool3 operator >(int a, int3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        public static bool3 operator <=(int a, int3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        public static bool3 operator >=(int a, int3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - int3

        // x
        public readonly int3 xxx => new int3(x, x, x);
        public readonly int3 xxy => new int3(x, x, y);
        public readonly int3 xxz => new int3(x, x, z);

        public readonly int3 xyx => new int3(x, y, x);
        public readonly int3 xyy => new int3(x, y, y);
        public readonly int3 xyz => new int3(x, y, z);

        public readonly int3 xzx => new int3(x, z, x);
        public readonly int3 xzy => new int3(x, z, y);
        public readonly int3 xzz => new int3(x, z, z);

        // y
        public readonly int3 yxx => new int3(y, x, x);
        public readonly int3 yxy => new int3(y, x, y);
        public readonly int3 yxz => new int3(y, x, z);

        public readonly int3 yyx => new int3(y, y, x);
        public readonly int3 yyy => new int3(y, y, y);
        public readonly int3 yyz => new int3(y, y, z);

        public readonly int3 yzx => new int3(y, z, x);
        public readonly int3 yzy => new int3(y, z, y);
        public readonly int3 yzz => new int3(y, z, z);

        // z
        public readonly int3 zxx => new int3(z, x, x);
        public readonly int3 zxy => new int3(z, x, y);
        public readonly int3 zxz => new int3(z, x, z);

        public readonly int3 zyx => new int3(z, y, x);
        public readonly int3 zyy => new int3(z, y, y);
        public readonly int3 zyz => new int3(z, y, z);

        public readonly int3 zzx => new int3(z, z, x);
        public readonly int3 zzy => new int3(z, z, y);
        public readonly int3 zzz => new int3(z, z, z);

        // Swizzling - int2

        public readonly int2 xx => new int2(x, x);
        public readonly int2 xy => new int2(x, y);
        public readonly int2 xz => new int2(x, z);

        public readonly int2 yx => new int2(y, x);
        public readonly int2 yy => new int2(y, y);
        public readonly int2 yz => new int2(y, z);

        public readonly int2 zx => new int2(z, x);
        public readonly int2 zy => new int2(z, y);
        public readonly int2 zz => new int2(z, z);

        // RGBA Equvalence

        public readonly int r => x;
        public readonly int g => y;
        public readonly int b => z;

        // RGBA Swizzling - int3

        // r
        public readonly int3 rrr => new int3(r, r, r);
        public readonly int3 rrg => new int3(r, r, g);
        public readonly int3 rrb => new int3(r, r, b);

        public readonly int3 rgr => new int3(r, g, r);
        public readonly int3 rgg => new int3(r, g, g);
        public readonly int3 rgb => new int3(r, g, b);

        public readonly int3 rbr => new int3(r, b, r);
        public readonly int3 rbg => new int3(r, b, g);
        public readonly int3 rbb => new int3(r, b, b);

        // g
        public readonly int3 grr => new int3(g, r, r);
        public readonly int3 grg => new int3(g, r, g);
        public readonly int3 grb => new int3(g, r, b);

        public readonly int3 ggr => new int3(g, g, r);
        public readonly int3 ggg => new int3(g, g, g);
        public readonly int3 ggb => new int3(g, g, b);

        public readonly int3 gbr => new int3(g, b, r);
        public readonly int3 gbg => new int3(g, b, g);
        public readonly int3 gbb => new int3(g, b, b);

        // b
        public readonly int3 brr => new int3(b, r, r);
        public readonly int3 brg => new int3(b, r, g);
        public readonly int3 brb => new int3(b, r, b);

        public readonly int3 bgr => new int3(b, g, r);
        public readonly int3 bgg => new int3(b, g, g);
        public readonly int3 bgb => new int3(b, g, b);

        public readonly int3 bbr => new int3(b, b, r);
        public readonly int3 bbg => new int3(b, b, g);
        public readonly int3 bbb => new int3(b, b, b);

        // RGBA Swizzling - int2

        public readonly int2 rr => new int2(r, r);
        public readonly int2 rg => new int2(r, g);
        public readonly int2 rb => new int2(r, b);

        public readonly int2 gr => new int2(g, r);
        public readonly int2 gg => new int2(g, g);
        public readonly int2 gb => new int2(g, b);

        public readonly int2 br => new int2(b, r);
        public readonly int2 bg => new int2(b, g);
        public readonly int2 bb => new int2(b, b);
    }
}
