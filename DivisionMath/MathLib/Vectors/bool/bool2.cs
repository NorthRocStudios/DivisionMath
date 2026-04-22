using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct bool2
    {
        // Data Storage

        public bool x;
        public bool y;

        // Component Access

        public bool this[int index]
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

        public override readonly string ToString() => $"bool2({x}, {y})";
        public override readonly bool Equals(object? obj) => obj is bool2 other && x == other.x && y == other.y;
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        public bool2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        public bool2(bool value)
        {
            x = value;
            y = value;
        }

        // Unary Operations

        public static bool2 operator !(bool2 v) => new bool2(!v.x, !v.y);
        public static bool operator true(bool2 v) => v.x && v.y;
        public static bool operator false(bool2 v) => !(v.x && v.y);

        // Implicit Operations

        public static implicit operator bool2(bool4 v) => new bool2(v.x, v.y);
        public static implicit operator bool2(bool3 v) => new bool2(v.x, v.y);
        public static implicit operator bool2(bool v) => new bool2(v);

        // Logical Operations

        // AND
        public static bool2 operator &(bool2 a, bool2 b) => new bool2(a.x & b.x, a.y & b.y);
        public static bool2 operator &(bool2 a, bool b) => new bool2(a.x & b, a.y & b);
        public static bool2 operator &(bool a, bool2 b) => new bool2(a & b.x, a & b.y);

        // OR
        public static bool2 operator |(bool2 a, bool2 b) => new bool2(a.x | b.x, a.y | b.y);
        public static bool2 operator |(bool2 a, bool b) => new bool2(a.x | b, a.y | b);
        public static bool2 operator |(bool a, bool2 b) => new bool2(a | b.x, a | b.y);

        // XOR
        public static bool2 operator ^(bool2 a, bool2 b) => new bool2(a.x ^ b.x, a.y ^ b.y);
        public static bool2 operator ^(bool2 a, bool b) => new bool2(a.x ^ b, a.y ^ b);
        public static bool2 operator ^(bool a, bool2 b) => new bool2(a ^ b.x, a ^ b.y);

        // Comparison Operations

        public static bool2 operator ==(bool2 a, bool2 b) => new bool2(a.x == b.x, a.y == b.y);
        public static bool2 operator !=(bool2 a, bool2 b) => new bool2(a.x != b.x, a.y != b.y);
        public static bool2 operator ==(bool2 a, bool b) => new bool2(a.x == b, a.y == b);
        public static bool2 operator !=(bool2 a, bool b) => new bool2(a.x != b, a.y != b);
        public static bool2 operator ==(bool a, bool2 b) => new bool2(a == b.x, a == b.y);
        public static bool2 operator !=(bool a, bool2 b) => new bool2(a != b.x, a != b.y);

        // Static Properties

        public static bool2 off => new bool2(false);
        public static bool2 on => new bool2(true);
        public static bool2 unitX => new bool2(true, false);
        public static bool2 unitY => new bool2(false, true);

        // Helper Methods

        public readonly bool all => x && y;
        public readonly bool any => x || y;

        // Swizzling

        public readonly bool2 xx => new bool2(x, x);
        public readonly bool2 xy => new bool2(x, y);
        public readonly bool2 yx => new bool2(y, x);
        public readonly bool2 yy => new bool2(y, y);

        // RGBA Equvalence

        public readonly bool r => x;
        public readonly bool g => y;

        public readonly bool2 rr => new bool2(r, r);
        public readonly bool2 rg => new bool2(r, g);
        public readonly bool2 gr => new bool2(g, r);
        public readonly bool2 gg => new bool2(g, g);
    }
}
