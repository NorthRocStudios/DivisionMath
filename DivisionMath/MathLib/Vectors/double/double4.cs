using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct double4
    {
        // Data Storage

        public double x;
        public double y;
        public double z;
        public double w;

        // Component Access

        public double this[int index]
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

        public override readonly string ToString() => $"double4({x}, {y}, {z}, {w})";
        public override readonly bool Equals(object? obj) => obj is double4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        public double4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public double4(double value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public double4(double3 xyz, double w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        public double4(double x, double3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        public double4(double2 xy, double2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        public double4(double x, double y, double2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        public double4(double2 xy, double z, double w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        public double4(double x, double2 yz, double w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        public static double4 operator -(double4 v) => new double4(-v.x, -v.y, -v.z, -v.w);
        public static double4 operator +(double4 v) => v;

        // Implicit Operations

        public static implicit operator double4(double3 v) => new double4(v, 0);
        public static implicit operator double4(double2 v) => new double4(v, 0, 0);
        public static implicit operator double4(double v) => new double4(v);

        // Unit Vectors

        public static double4 zero => new double4(0);
        public static double4 one => new double4(1);
        public static double4 unitX => new double4(1, 0, 0, 0);
        public static double4 unitY => new double4(0, 1, 0, 0);
        public static double4 unitZ => new double4(0, 0, 1, 0);
        public static double4 unitW => new double4(0, 0, 0, 1);

        // Arithmetic Operations

        public static double4 operator +(double4 a, double4 b) => new double4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        public static double4 operator -(double4 a, double4 b) => new double4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        public static double4 operator *(double4 a, double4 b) => new double4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        public static double4 operator /(double4 a, double4 b) => new double4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);

        // Arithmetic - double

        public static double4 operator +(double4 a, double b) => new double4(a.x + b, a.y + b, a.z + b, a.w + b);
        public static double4 operator -(double4 a, double b) => new double4(a.x - b, a.y - b, a.z - b, a.w - b);
        public static double4 operator *(double4 a, double b) => new double4(a.x * b, a.y * b, a.z * b, a.w * b);
        public static double4 operator /(double4 a, double b) => new double4(a.x / b, a.y / b, a.z / b, a.w / b);

        public static double4 operator +(double a, double4 b) => new double4(a + b.x, a + b.y, a + b.z, a + b.w);
        public static double4 operator -(double a, double4 b) => new double4(a - b.x, a - b.y, a - b.z, a - b.w);
        public static double4 operator *(double a, double4 b) => new double4(a * b.x, a * b.y, a * b.z, a * b.w);
        public static double4 operator /(double a, double4 b) => new double4(a / b.x, a / b.y, a / b.z, a / b.w);

        // Arithmetic - double2

        public static double4 operator +(double4 a, double2 b) => new double4(a.x + b.x, a.y + b.y, a.z, a.w);
        public static double4 operator -(double4 a, double2 b) => new double4(a.x - b.x, a.y - b.y, a.z, a.w);
        public static double4 operator *(double4 a, double2 b) => new double4(a.x * b.x, a.y * b.y, a.z, a.w);
        public static double4 operator /(double4 a, double2 b) => new double4(a.x / b.x, a.y / b.y, a.z, a.w);

        public static double4 operator +(double2 a, double4 b) => new double4(a.x + b.x, a.y + b.y, b.z, b.w);
        public static double4 operator -(double2 a, double4 b) => new double4(a.x - b.x, a.y - b.y, b.z, b.w);
        public static double4 operator *(double2 a, double4 b) => new double4(a.x * b.x, a.y * b.y, b.z, b.w);
        public static double4 operator /(double2 a, double4 b) => new double4(a.x / b.x, a.y / b.y, b.z, b.w);

        // Arithmetic - double3

        public static double4 operator +(double4 a, double3 b) => new double4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        public static double4 operator -(double4 a, double3 b) => new double4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        public static double4 operator *(double4 a, double3 b) => new double4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        public static double4 operator /(double4 a, double3 b) => new double4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);

        public static double4 operator +(double3 a, double4 b) => new double4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        public static double4 operator -(double3 a, double4 b) => new double4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        public static double4 operator *(double3 a, double4 b) => new double4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        public static double4 operator /(double3 a, double4 b) => new double4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);

        // Comparison Operations

        public static bool4 operator ==(double4 a, double4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        public static bool4 operator !=(double4 a, double4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        public static bool4 operator <(double4 a, double4 b) => new bool4(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        public static bool4 operator >(double4 a, double4 b) => new bool4(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        public static bool4 operator <=(double4 a, double4 b) => new bool4(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        public static bool4 operator >=(double4 a, double4 b) => new bool4(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);

        // Vector-scalar comparisons
        public static bool4 operator ==(double4 a, double b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        public static bool4 operator !=(double4 a, double b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        public static bool4 operator <(double4 a, double b) => new bool4(a.x < b, a.y < b, a.z < b, a.w < b);
        public static bool4 operator >(double4 a, double b) => new bool4(a.x > b, a.y > b, a.z > b, a.w > b);
        public static bool4 operator <=(double4 a, double b) => new bool4(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        public static bool4 operator >=(double4 a, double b) => new bool4(a.x >= b, a.y >= b, a.z >= b, a.w >= b);

        // Scalar-vector comparisons
        public static bool4 operator ==(double a, double4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        public static bool4 operator !=(double a, double4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);
        public static bool4 operator <(double a, double4 b) => new bool4(a < b.x, a < b.y, a < b.z, a < b.w);
        public static bool4 operator >(double a, double4 b) => new bool4(a > b.x, a > b.y, a > b.z, a > b.w);
        public static bool4 operator <=(double a, double4 b) => new bool4(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
        public static bool4 operator >=(double a, double4 b) => new bool4(a >= b.x, a >= b.y, a >= b.z, a >= b.w);

        // RGBA Equvalence

        public readonly double r => x;
        public readonly double g => y;
        public readonly double b => z;
        public readonly double a => w;
    }
}
