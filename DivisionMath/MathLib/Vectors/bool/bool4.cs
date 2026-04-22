using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct bool4
    {
        // Data Storage

        public bool x;
        public bool y;
        public bool z;
        public bool w;

        // Component Access

        public bool this[int index]
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

        public override readonly string ToString() => $"bool4({x}, {y}, {z}, {w})";
        public override readonly bool Equals(object? obj) => obj is bool4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        public bool4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public bool4(bool value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public bool4(bool3 xyz, bool w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        public bool4(bool x, bool3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        public bool4(bool2 xy, bool2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        public bool4(bool x, bool y, bool2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        public bool4(bool2 xy, bool z, bool w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        public bool4(bool x, bool2 yz, bool w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        public static bool4 operator !(bool4 v) => new bool4(!v.x, !v.y, !v.z, !v.w);
        public static bool operator true(bool4 v) => v.x && v.y && v.z && v.w;
        public static bool operator false(bool4 v) => !(v.x && v.y && v.z && v.w);

        // Logical Operations

        // AND
        public static bool4 operator &(bool4 a, bool4 b) => new bool4(a.x & b.x, a.y & b.y, a.z & b.z, a.w & b.w);
        public static bool4 operator &(bool4 a, bool b) => new bool4(a.x & b, a.y & b, a.z & b, a.w & b);
        public static bool4 operator &(bool a, bool4 b) => new bool4(a & b.x, a & b.y, a & b.z, a & b.w);

        // OR
        public static bool4 operator |(bool4 a, bool4 b) => new bool4(a.x | b.x, a.y | b.y, a.z | b.z, a.w | b.w);
        public static bool4 operator |(bool4 a, bool b) => new bool4(a.x | b, a.y | b, a.z | b, a.w | b);
        public static bool4 operator |(bool a, bool4 b) => new bool4(a | b.x, a | b.y, a | b.z, a | b.w);

        // XOR
        public static bool4 operator ^(bool4 a, bool4 b) => new bool4(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z, a.w ^ b.w);
        public static bool4 operator ^(bool4 a, bool b) => new bool4(a.x ^ b, a.y ^ b, a.z ^ b, a.w ^ b);
        public static bool4 operator ^(bool a, bool4 b) => new bool4(a ^ b.x, a ^ b.y, a ^ b.z, a ^ b.w);

        // Comparison Operations

        public static bool4 operator ==(bool4 a, bool4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        public static bool4 operator !=(bool4 a, bool4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        //public static bool4 operator ==(bool4 a, bool b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        //public static bool4 operator !=(bool4 a, bool b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        //public static bool4 operator ==(bool a, bool4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        //public static bool4 operator !=(bool a, bool4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);

        // Implicit Conversions

        public static implicit operator bool4(bool3 v) => new bool4(v.x, v.y, v.z, false);
        public static implicit operator bool4(bool2 v) => new bool4(v.x, v.y, false, false);
        public static implicit operator bool4(bool v) => new bool4(v);

        // Static Properties

        public static bool4 off => new bool4(false);
        public static bool4 on => new bool4(true);
        public static bool4 unitX => new bool4(true, false, false, false);
        public static bool4 unitY => new bool4(false, true, false, false);
        public static bool4 unitZ => new bool4(false, false, true, false);
        public static bool4 unitW => new bool4(false, false, false, true);

        // Helper Methods

        public readonly bool all => x && y && z && w;
        public readonly bool any => x || y || z || w;

        // RGBA Equvalence

        public readonly bool r => x;
        public readonly bool g => y;
        public readonly bool b => z;
        public readonly bool a => w;
    }
}
