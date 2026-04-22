using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct double2
    {
        // Data Storage

        public double x;
        public double y;

        // Component Access

        public double this[int index]
        {
            readonly get => index switch
            {
                0 => x,
                1 => y,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                }
            }
        }

        // Overrides

        public override readonly string ToString() => $"double2({x}, {y})";
        public override readonly bool Equals(object? obj) => obj is double2 other && x == other.x && y == other.y;
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        public double2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double2(double value)
        {
            x = value;
            y = value;
        }

        // Unary Operations

        public static double2 operator -(double2 v) => new double2(-v.x, -v.y);
        public static double2 operator +(double2 v) => v;

        // Implicit Operations

        public static implicit operator double2(double4 v) => new double2(v.x, v.y);
        public static implicit operator double2(double3 v) => new double2(v.x, v.y);
        public static implicit operator double2(double v) => new double2(v);

        // Unit Vectors

        public static double2 zero => new double2(0);
        public static double2 one => new double2(1);
        public static double2 unitX => new double2(1, 0);
        public static double2 unitY => new double2(0, 1);

        // Arithmetic Operations

        public static double2 operator +(double2 a, double2 b) => new double2(a.x + b.x, a.y + b.y);
        public static double2 operator -(double2 a, double2 b) => new double2(a.x - b.x, a.y - b.y);
        public static double2 operator *(double2 a, double2 b) => new double2(a.x * b.x, a.y * b.y);
        public static double2 operator /(double2 a, double2 b) => new double2(a.x / b.x, a.y / b.y);

        public static double2 operator +(double2 a, double b) => new double2(a.x + b, a.y + b);
        public static double2 operator -(double2 a, double b) => new double2(a.x - b, a.y - b);
        public static double2 operator *(double2 a, double b) => new double2(a.x * b, a.y * b);
        public static double2 operator /(double2 a, double b) => new double2(a.x / b, a.y / b);

        public static double2 operator +(double a, double2 b) => new double2(a + b.x, a + b.y);
        public static double2 operator -(double a, double2 b) => new double2(a - b.x, a - b.y);
        public static double2 operator *(double a, double2 b) => new double2(a * b.x, a * b.y);
        public static double2 operator /(double a, double2 b) => new double2(a / b.x, a / b.y);

        // Comparison Operations

        public static bool2 operator ==(double2 a, double2 b) => new bool2(a.x == b.x, a.y == b.y);
        public static bool2 operator !=(double2 a, double2 b) => new bool2(a.x != b.x, a.y != b.y);
        public static bool2 operator <(double2 a, double2 b) => new bool2(a.x < b.x, a.y < b.y);
        public static bool2 operator >(double2 a, double2 b) => new bool2(a.x > b.x, a.y > b.y);
        public static bool2 operator <=(double2 a, double2 b) => new bool2(a.x <= b.x, a.y <= b.y);
        public static bool2 operator >=(double2 a, double2 b) => new bool2(a.x >= b.x, a.y >= b.y);

        // Scalar-vector comparisons
        public static bool2 operator ==(double2 a, double b) => new bool2(a.x == b, a.y == b);
        public static bool2 operator !=(double2 a, double b) => new bool2(a.x != b, a.y != b);
        public static bool2 operator <(double2 a, double b) => new bool2(a.x < b, a.y < b);
        public static bool2 operator >(double2 a, double b) => new bool2(a.x > b, a.y > b);
        public static bool2 operator <=(double2 a, double b) => new bool2(a.x <= b, a.y <= b);
        public static bool2 operator >=(double2 a, double b) => new bool2(a.x >= b, a.y >= b);

        public static bool2 operator ==(double a, double2 b) => new bool2(a == b.x, a == b.y);
        public static bool2 operator !=(double a, double2 b) => new bool2(a != b.x, a != b.y);
        public static bool2 operator <(double a, double2 b) => new bool2(a < b.x, a < b.y);
        public static bool2 operator >(double a, double2 b) => new bool2(a > b.x, a > b.y);
        public static bool2 operator <=(double a, double2 b) => new bool2(a <= b.x, a <= b.y);
        public static bool2 operator >=(double a, double2 b) => new bool2(a >= b.x, a >= b.y);

        // Swizzling

        public readonly double2 xx => new double2(x, x);
        public readonly double2 xy => new double2(x, y);
        public readonly double2 yx => new double2(y, x);
        public readonly double2 yy => new double2(y, y);

        // RGBA Equvalence

        public readonly double r => x;
        public readonly double g => y;

        public readonly double2 rr => new double2(r, r);
        public readonly double2 rg => new double2(r, g);
        public readonly double2 gr => new double2(g, r);
        public readonly double2 gg => new double2(g, g);
    }
}
