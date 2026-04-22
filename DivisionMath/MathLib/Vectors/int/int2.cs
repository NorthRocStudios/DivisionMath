using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct int2
    {
        // Data Storage

        public int x;
        public int y;

        // Component Access

        public int this[int index]
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

        public override readonly string ToString() => $"int2({x}, {y})";
        public override readonly bool Equals(object? obj) => obj is int2 other && x == other.x && y == other.y;
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        public int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int2(int value)
        {
            x = value;
            y = value;
        }

        // Unary Operations

        public static int2 operator -(int2 v) => new int2(-v.x, -v.y);
        public static int2 operator +(int2 v) => v;

        // Implicit Operations

        public static implicit operator int2(int4 v) => new int2(v.x, v.y);
        public static implicit operator int2(int3 v) => new int2(v.x, v.y);
        public static implicit operator int2(int v) => new int2(v);

        // Unit Vectors

        public static int2 zero => new int2(0);
        public static int2 one => new int2(1);
        public static int2 unitX => new int2(1, 0);
        public static int2 unitY => new int2(0, 1);

        // Arithmetic Operations

        public static int2 operator +(int2 a, int2 b) => new int2(a.x + b.x, a.y + b.y);
        public static int2 operator -(int2 a, int2 b) => new int2(a.x - b.x, a.y - b.y);
        public static int2 operator *(int2 a, int2 b) => new int2(a.x * b.x, a.y * b.y);
        public static int2 operator /(int2 a, int2 b) => new int2(a.x / b.x, a.y / b.y);

        public static int2 operator +(int2 a, int b) => new int2(a.x + b, a.y + b);
        public static int2 operator -(int2 a, int b) => new int2(a.x - b, a.y - b);
        public static int2 operator *(int2 a, int b) => new int2(a.x * b, a.y * b);
        public static int2 operator /(int2 a, int b) => new int2(a.x / b, a.y / b);

        public static int2 operator +(int a, int2 b) => new int2(a + b.x, a + b.y);
        public static int2 operator -(int a, int2 b) => new int2(a - b.x, a - b.y);
        public static int2 operator *(int a, int2 b) => new int2(a * b.x, a * b.y);
        public static int2 operator /(int a, int2 b) => new int2(a / b.x, a / b.y);

        // Comparison Operations

        public static bool2 operator ==(int2 a, int2 b) => new bool2(a.x == b.x, a.y == b.y);
        public static bool2 operator !=(int2 a, int2 b) => new bool2(a.x != b.x, a.y != b.y);
        public static bool2 operator <(int2 a, int2 b) => new bool2(a.x < b.x, a.y < b.y);
        public static bool2 operator >(int2 a, int2 b) => new bool2(a.x > b.x, a.y > b.y);
        public static bool2 operator <=(int2 a, int2 b) => new bool2(a.x <= b.x, a.y <= b.y);
        public static bool2 operator >=(int2 a, int2 b) => new bool2(a.x >= b.x, a.y >= b.y);

        // Scalar-vector comparisons
        public static bool2 operator ==(int2 a, int b) => new bool2(a.x == b, a.y == b);
        public static bool2 operator !=(int2 a, int b) => new bool2(a.x != b, a.y != b);
        public static bool2 operator <(int2 a, int b) => new bool2(a.x < b, a.y < b);
        public static bool2 operator >(int2 a, int b) => new bool2(a.x > b, a.y > b);
        public static bool2 operator <=(int2 a, int b) => new bool2(a.x <= b, a.y <= b);
        public static bool2 operator >=(int2 a, int b) => new bool2(a.x >= b, a.y >= b);

        public static bool2 operator ==(int a, int2 b) => new bool2(a == b.x, a == b.y);
        public static bool2 operator !=(int a, int2 b) => new bool2(a != b.x, a != b.y);
        public static bool2 operator <(int a, int2 b) => new bool2(a < b.x, a < b.y);
        public static bool2 operator >(int a, int2 b) => new bool2(a > b.x, a > b.y);
        public static bool2 operator <=(int a, int2 b) => new bool2(a <= b.x, a <= b.y);
        public static bool2 operator >=(int a, int2 b) => new bool2(a >= b.x, a >= b.y);

        // Swizzling

        public readonly int2 xx => new int2(x, x);
        public readonly int2 xy => new int2(x, y);
        public readonly int2 yx => new int2(y, x);
        public readonly int2 yy => new int2(y, y);

        // RGBA Equvalence

        public readonly int r => x;
        public readonly int g => y;

        public readonly int2 rr => new int2(r, r);
        public readonly int2 rg => new int2(r, g);
        public readonly int2 gr => new int2(g, r);
        public readonly int2 gg => new int2(g, g);
    }
}
