using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct double3
    {
        // Data Storage

        public double x;
        public double y;
        public double z;

        // Component Access

        public double this[int index]
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

        public override readonly string ToString() => $"double3({x}, {y}, {z})";
        public override readonly bool Equals(object? obj) => obj is double3 other && x == other.x && y == other.y && z == other.z;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        public double3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double3(double value)
        {
            x = value;
            y = value;
            z = value;
        }

        public double3(double2 xy, double z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        public double3(double x, double2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        public static double3 operator -(double3 v) => new double3(-v.x, -v.y, -v.z);
        public static double3 operator +(double3 v) => v;

        // Implicit Operations

        public static implicit operator double3(double4 v) => new double3(v.x, v.y, v.z);
        public static implicit operator double3(double2 v) => new double3(v, 0);
        public static implicit operator double3(double v) => new double3(v);

        // Unit Vectors

        public static double3 zero => new double3(0);
        public static double3 one => new double3(1);
        public static double3 unitX => new double3(1, 0, 0);
        public static double3 unitY => new double3(0, 1, 0);
        public static double3 unitZ => new double3(0, 0, 1);

        public static double3 up => unitY;
        public static double3 down => new double3(0, -1, 0);
        public static double3 left => new double3(-1, 0, 0);
        public static double3 right => new double3(1, 0, 0);
        public static double3 forward => new double3(0, 0, 1);
        public static double3 back => new double3(0, 0, -1);

        // Arithmetic Operations

        public static double3 operator +(double3 a, double3 b) => new double3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static double3 operator -(double3 a, double3 b) => new double3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static double3 operator *(double3 a, double3 b) => new double3(a.x * b.x, a.y * b.y, a.z * b.z);
        public static double3 operator /(double3 a, double3 b) => new double3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - double

        public static double3 operator +(double3 a, double b) => new double3(a.x + b, a.y + b, a.z + b);
        public static double3 operator -(double3 a, double b) => new double3(a.x - b, a.y - b, a.z - b);
        public static double3 operator *(double3 a, double b) => new double3(a.x * b, a.y * b, a.z * b);
        public static double3 operator /(double3 a, double b) => new double3(a.x / b, a.y / b, a.z / b);

        public static double3 operator +(double a, double3 b) => new double3(a + b.x, a + b.y, a + b.z);
        public static double3 operator -(double a, double3 b) => new double3(a - b.x, a - b.y, a - b.z);
        public static double3 operator *(double a, double3 b) => new double3(a * b.x, a * b.y, a * b.z);
        public static double3 operator /(double a, double3 b) => new double3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - double2

        public static double3 operator +(double3 a, double2 b) => new double3(a.x + b.x, a.y + b.y, a.z);
        public static double3 operator -(double3 a, double2 b) => new double3(a.x - b.x, a.y - b.y, a.z);
        public static double3 operator *(double3 a, double2 b) => new double3(a.x * b.x, a.y * b.y, a.z);
        public static double3 operator /(double3 a, double2 b) => new double3(a.x / b.x, a.y / b.y, a.z);

        public static double3 operator +(double2 a, double3 b) => new double3(a.x + b.x, a.y + b.y, b.z);
        public static double3 operator -(double2 a, double3 b) => new double3(a.x - b.x, a.y - b.y, b.z);
        public static double3 operator *(double2 a, double3 b) => new double3(a.x * b.x, a.y * b.y, b.z);
        public static double3 operator /(double2 a, double3 b) => new double3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        public static bool3 operator ==(double3 a, double3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        public static bool3 operator !=(double3 a, double3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        public static bool3 operator <(double3 a, double3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        public static bool3 operator >(double3 a, double3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        public static bool3 operator <=(double3 a, double3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        public static bool3 operator >=(double3 a, double3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        public static bool3 operator ==(double3 a, double b) => new bool3(a.x == b, a.y == b, a.z == b);
        public static bool3 operator !=(double3 a, double b) => new bool3(a.x != b, a.y != b, a.z != b);
        public static bool3 operator <(double3 a, double b) => new bool3(a.x < b, a.y < b, a.z < b);
        public static bool3 operator >(double3 a, double b) => new bool3(a.x > b, a.y > b, a.z > b);
        public static bool3 operator <=(double3 a, double b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        public static bool3 operator >=(double3 a, double b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        public static bool3 operator ==(double a, double3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        public static bool3 operator !=(double a, double3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        public static bool3 operator <(double a, double3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        public static bool3 operator >(double a, double3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        public static bool3 operator <=(double a, double3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        public static bool3 operator >=(double a, double3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - double3

        // x
        public readonly double3 xxx => new double3(x, x, x);
        public readonly double3 xxy => new double3(x, x, y);
        public readonly double3 xxz => new double3(x, x, z);

        public readonly double3 xyx => new double3(x, y, x);
        public readonly double3 xyy => new double3(x, y, y);
        public readonly double3 xyz => new double3(x, y, z);

        public readonly double3 xzx => new double3(x, z, x);
        public readonly double3 xzy => new double3(x, z, y);
        public readonly double3 xzz => new double3(x, z, z);

        // y
        public readonly double3 yxx => new double3(y, x, x);
        public readonly double3 yxy => new double3(y, x, y);
        public readonly double3 yxz => new double3(y, x, z);

        public readonly double3 yyx => new double3(y, y, x);
        public readonly double3 yyy => new double3(y, y, y);
        public readonly double3 yyz => new double3(y, y, z);

        public readonly double3 yzx => new double3(y, z, x);
        public readonly double3 yzy => new double3(y, z, y);
        public readonly double3 yzz => new double3(y, z, z);

        // z
        public readonly double3 zxx => new double3(z, x, x);
        public readonly double3 zxy => new double3(z, x, y);
        public readonly double3 zxz => new double3(z, x, z);

        public readonly double3 zyx => new double3(z, y, x);
        public readonly double3 zyy => new double3(z, y, y);
        public readonly double3 zyz => new double3(z, y, z);

        public readonly double3 zzx => new double3(z, z, x);
        public readonly double3 zzy => new double3(z, z, y);
        public readonly double3 zzz => new double3(z, z, z);

        // Swizzling - double2

        public readonly double2 xx => new double2(x, x);
        public readonly double2 xy => new double2(x, y);
        public readonly double2 xz => new double2(x, z);

        public readonly double2 yx => new double2(y, x);
        public readonly double2 yy => new double2(y, y);
        public readonly double2 yz => new double2(y, z);

        public readonly double2 zx => new double2(z, x);
        public readonly double2 zy => new double2(z, y);
        public readonly double2 zz => new double2(z, z);

        // RGBA Equvalence

        public readonly double r => x;
        public readonly double g => y;
        public readonly double b => z;

        // RGBA Swizzling - double3

        // r
        public readonly double3 rrr => new double3(r, r, r);
        public readonly double3 rrg => new double3(r, r, g);
        public readonly double3 rrb => new double3(r, r, b);

        public readonly double3 rgr => new double3(r, g, r);
        public readonly double3 rgg => new double3(r, g, g);
        public readonly double3 rgb => new double3(r, g, b);

        public readonly double3 rbr => new double3(r, b, r);
        public readonly double3 rbg => new double3(r, b, g);
        public readonly double3 rbb => new double3(r, b, b);

        // g
        public readonly double3 grr => new double3(g, r, r);
        public readonly double3 grg => new double3(g, r, g);
        public readonly double3 grb => new double3(g, r, b);

        public readonly double3 ggr => new double3(g, g, r);
        public readonly double3 ggg => new double3(g, g, g);
        public readonly double3 ggb => new double3(g, g, b);

        public readonly double3 gbr => new double3(g, b, r);
        public readonly double3 gbg => new double3(g, b, g);
        public readonly double3 gbb => new double3(g, b, b);

        // b
        public readonly double3 brr => new double3(b, r, r);
        public readonly double3 brg => new double3(b, r, g);
        public readonly double3 brb => new double3(b, r, b);

        public readonly double3 bgr => new double3(b, g, r);
        public readonly double3 bgg => new double3(b, g, g);
        public readonly double3 bgb => new double3(b, g, b);

        public readonly double3 bbr => new double3(b, b, r);
        public readonly double3 bbg => new double3(b, b, g);
        public readonly double3 bbb => new double3(b, b, b);

        // RGBA Swizzling - double2

        public readonly double2 rr => new double2(r, r);
        public readonly double2 rg => new double2(r, g);
        public readonly double2 rb => new double2(r, b);

        public readonly double2 gr => new double2(g, r);
        public readonly double2 gg => new double2(g, g);
        public readonly double2 gb => new double2(g, b);

        public readonly double2 br => new double2(b, r);
        public readonly double2 bg => new double2(b, g);
        public readonly double2 bb => new double2(b, b);
    }
}
