using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct bool3
    {
        // Data Storage

        public bool x;
        public bool y;
        public bool z;

        // Component Access

        public bool this[int index]
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

        public override readonly string ToString() => $"bool3({x}, {y}, {z})";
        public override readonly bool Equals(object? obj) => obj is bool3 other && x == other.x && y == other.y && z == other.z;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        public bool3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool3(bool value)
        {
            x = value;
            y = value;
            z = value;
        }

        public bool3(bool2 xy, bool z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        public bool3(bool x, bool2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        public static bool3 operator !(bool3 v) => new bool3(!v.x, !v.y, !v.z);
        public static bool operator true(bool3 v) => v.x && v.y && v.z;
        public static bool operator false(bool3 v) => !(v.x && v.y && v.z);

        // Logical Operators

        // AND
        public static bool3 operator &(bool3 a, bool3 b) => new bool3(a.x & b.x, a.y & b.y, a.z & b.z);
        public static bool3 operator &(bool3 a, bool b) => new bool3(a.x & b, a.y & b, a.z & b);
        public static bool3 operator &(bool a, bool3 b) => new bool3(a & b.x, a & b.y, a & b.z);

        // OR
        public static bool3 operator |(bool3 a, bool3 b) => new bool3(a.x | b.x, a.y | b.y, a.z | b.z);
        public static bool3 operator |(bool3 a, bool b) => new bool3(a.x | b, a.y | b, a.z | b);
        public static bool3 operator |(bool a, bool3 b) => new bool3(a | b.x, a | b.y, a | b.z);

        // XOR
        public static bool3 operator ^(bool3 a, bool3 b) => new bool3(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
        public static bool3 operator ^(bool3 a, bool b) => new bool3(a.x ^ b, a.y ^ b, a.z ^ b);
        public static bool3 operator ^(bool a, bool3 b) => new bool3(a ^ b.x, a ^ b.y, a ^ b.z);

        // Comparison Operations

        public static bool3 operator ==(bool3 a, bool3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        public static bool3 operator !=(bool3 a, bool3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        public static bool3 operator ==(bool3 a, bool b) => new bool3(a.x == b, a.y == b, a.z == b);
        public static bool3 operator !=(bool3 a, bool b) => new bool3(a.x != b, a.y != b, a.z != b);
        public static bool3 operator ==(bool a, bool3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        public static bool3 operator !=(bool a, bool3 b) => new bool3(a != b.x, a != b.y, a != b.z);

        // Implicit Conversions

        public static implicit operator bool3(bool4 v) => new bool3(v.x, v.y, v.z);
        public static implicit operator bool3(bool2 v) => new bool3(v.x, v.y, false);
        public static implicit operator bool3(bool v) => new bool3(v);

        // Static Properties

        public static bool3 off => new bool3(false);
        public static bool3 on => new bool3(true);
        public static bool3 unitX => new bool3(true, false, false);
        public static bool3 unitY => new bool3(false, true, false);
        public static bool3 unitZ => new bool3(false, false, true);

        // Helper Methods

        public readonly bool all => x && y && z;
        public readonly bool any => x || y || z;

        // Swizzling - bool3

        // x
        public readonly bool3 xxx => new bool3(x, x, x);
        public readonly bool3 xxy => new bool3(x, x, y);
        public readonly bool3 xxz => new bool3(x, x, z);

        public readonly bool3 xyx => new bool3(x, y, x);
        public readonly bool3 xyy => new bool3(x, y, y);
        public readonly bool3 xyz => new bool3(x, y, z);

        public readonly bool3 xzx => new bool3(x, z, x);
        public readonly bool3 xzy => new bool3(x, z, y);
        public readonly bool3 xzz => new bool3(x, z, z);

        // y
        public readonly bool3 yxx => new bool3(y, x, x);
        public readonly bool3 yxy => new bool3(y, x, y);
        public readonly bool3 yxz => new bool3(y, x, z);

        public readonly bool3 yyx => new bool3(y, y, x);
        public readonly bool3 yyy => new bool3(y, y, y);
        public readonly bool3 yyz => new bool3(y, y, z);

        public readonly bool3 yzx => new bool3(y, z, x);
        public readonly bool3 yzy => new bool3(y, z, y);
        public readonly bool3 yzz => new bool3(y, z, z);

        // z
        public readonly bool3 zxx => new bool3(z, x, x);
        public readonly bool3 zxy => new bool3(z, x, y);
        public readonly bool3 zxz => new bool3(z, x, z);

        public readonly bool3 zyx => new bool3(z, y, x);
        public readonly bool3 zyy => new bool3(z, y, y);
        public readonly bool3 zyz => new bool3(z, y, z);

        public readonly bool3 zzx => new bool3(z, z, x);
        public readonly bool3 zzy => new bool3(z, z, y);
        public readonly bool3 zzz => new bool3(z, z, z);

        // Swizzling - bool2

        public readonly bool2 xx => new bool2(x, x);
        public readonly bool2 xy => new bool2(x, y);
        public readonly bool2 xz => new bool2(x, z);

        public readonly bool2 yx => new bool2(y, x);
        public readonly bool2 yy => new bool2(y, y);
        public readonly bool2 yz => new bool2(y, z);

        public readonly bool2 zx => new bool2(z, x);
        public readonly bool2 zy => new bool2(z, y);
        public readonly bool2 zz => new bool2(z, z);

        // RGBA Equvalence

        public readonly bool r => x;
        public readonly bool g => y;
        public readonly bool b => z;

        // RGBA Swizzling - bool3

        // r
        public readonly bool3 rrr => new bool3(r, r, r);
        public readonly bool3 rrg => new bool3(r, r, g);
        public readonly bool3 rrb => new bool3(r, r, b);

        public readonly bool3 rgr => new bool3(r, g, r);
        public readonly bool3 rgg => new bool3(r, g, g);
        public readonly bool3 rgb => new bool3(r, g, b);

        public readonly bool3 rbr => new bool3(r, b, r);
        public readonly bool3 rbg => new bool3(r, b, g);
        public readonly bool3 rbb => new bool3(r, b, b);

        // g
        public readonly bool3 grr => new bool3(g, r, r);
        public readonly bool3 grg => new bool3(g, r, g);
        public readonly bool3 grb => new bool3(g, r, b);

        public readonly bool3 ggr => new bool3(g, g, r);
        public readonly bool3 ggg => new bool3(g, g, g);
        public readonly bool3 ggb => new bool3(g, g, b);

        public readonly bool3 gbr => new bool3(g, b, r);
        public readonly bool3 gbg => new bool3(g, b, g);
        public readonly bool3 gbb => new bool3(g, b, b);

        // b
        public readonly bool3 brr => new bool3(b, r, r);
        public readonly bool3 brg => new bool3(b, r, g);
        public readonly bool3 brb => new bool3(b, r, b);

        public readonly bool3 bgr => new bool3(b, g, r);
        public readonly bool3 bgg => new bool3(b, g, g);
        public readonly bool3 bgb => new bool3(b, g, b);

        public readonly bool3 bbr => new bool3(b, b, r);
        public readonly bool3 bbg => new bool3(b, b, g);
        public readonly bool3 bbb => new bool3(b, b, b);

        // RGBA Swizzling - bool2

        public readonly bool2 rr => new bool2(r, r);
        public readonly bool2 rg => new bool2(r, g);
        public readonly bool2 rb => new bool2(r, b);

        public readonly bool2 gr => new bool2(g, r);
        public readonly bool2 gg => new bool2(g, g);
        public readonly bool2 gb => new bool2(g, b);

        public readonly bool2 br => new bool2(b, r);
        public readonly bool2 bg => new bool2(b, g);
        public readonly bool2 bb => new bool2(b, b);
    }
}
