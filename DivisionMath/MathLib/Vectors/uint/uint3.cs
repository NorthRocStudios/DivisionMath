using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct uint3
    {
        // Data Storage

        public uint x;
        public uint y;
        public uint z;

        // Component Access

        public uint this[int index]
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

        public override readonly string ToString() => $"uint3({x}, {y}, {z})";
        public override readonly bool Equals(object? obj) => obj is uint3 other && x == other.x && y == other.y && z == other.z;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        public uint3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public uint3(uint value)
        {
            x = value;
            y = value;
            z = value;
        }

        public uint3(uint2 xy, uint z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        public uint3(uint x, uint2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Implicit Operations

        public static implicit operator uint3(uint4 v) => new uint3(v.x, v.y, v.z);
        public static implicit operator uint3(uint2 v) => new uint3(v, 0);
        public static implicit operator uint3(uint v) => new uint3(v);

        // Unit Vectors

        public static uint3 zero => new uint3(0);
        public static uint3 one => new uint3(1);
        public static uint3 unitX => new uint3(1, 0, 0);
        public static uint3 unitY => new uint3(0, 1, 0);
        public static uint3 unitZ => new uint3(0, 0, 1);

        public static uint3 up => unitY;
        public static uint3 right => new uint3(1, 0, 0);
        public static uint3 forward => new uint3(0, 0, 1);

        // Arithmetic Operations

        public static uint3 operator +(uint3 a, uint3 b) => new uint3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static uint3 operator -(uint3 a, uint3 b) => new uint3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static uint3 operator *(uint3 a, uint3 b) => new uint3(a.x * b.x, a.y * b.y, a.z * b.z);
        public static uint3 operator /(uint3 a, uint3 b) => new uint3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - uint

        public static uint3 operator +(uint3 a, uint b) => new uint3(a.x + b, a.y + b, a.z + b);
        public static uint3 operator -(uint3 a, uint b) => new uint3(a.x - b, a.y - b, a.z - b);
        public static uint3 operator *(uint3 a, uint b) => new uint3(a.x * b, a.y * b, a.z * b);
        public static uint3 operator /(uint3 a, uint b) => new uint3(a.x / b, a.y / b, a.z / b);

        public static uint3 operator +(uint a, uint3 b) => new uint3(a + b.x, a + b.y, a + b.z);
        public static uint3 operator -(uint a, uint3 b) => new uint3(a - b.x, a - b.y, a - b.z);
        public static uint3 operator *(uint a, uint3 b) => new uint3(a * b.x, a * b.y, a * b.z);
        public static uint3 operator /(uint a, uint3 b) => new uint3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - uint2

        public static uint3 operator +(uint3 a, uint2 b) => new uint3(a.x + b.x, a.y + b.y, a.z);
        public static uint3 operator -(uint3 a, uint2 b) => new uint3(a.x - b.x, a.y - b.y, a.z);
        public static uint3 operator *(uint3 a, uint2 b) => new uint3(a.x * b.x, a.y * b.y, a.z);
        public static uint3 operator /(uint3 a, uint2 b) => new uint3(a.x / b.x, a.y / b.y, a.z);

        public static uint3 operator +(uint2 a, uint3 b) => new uint3(a.x + b.x, a.y + b.y, b.z);
        public static uint3 operator -(uint2 a, uint3 b) => new uint3(a.x - b.x, a.y - b.y, b.z);
        public static uint3 operator *(uint2 a, uint3 b) => new uint3(a.x * b.x, a.y * b.y, b.z);
        public static uint3 operator /(uint2 a, uint3 b) => new uint3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        public static bool3 operator ==(uint3 a, uint3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        public static bool3 operator !=(uint3 a, uint3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        public static bool3 operator <(uint3 a, uint3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        public static bool3 operator >(uint3 a, uint3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        public static bool3 operator <=(uint3 a, uint3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        public static bool3 operator >=(uint3 a, uint3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        public static bool3 operator ==(uint3 a, uint b) => new bool3(a.x == b, a.y == b, a.z == b);
        public static bool3 operator !=(uint3 a, uint b) => new bool3(a.x != b, a.y != b, a.z != b);
        public static bool3 operator <(uint3 a, uint b) => new bool3(a.x < b, a.y < b, a.z < b);
        public static bool3 operator >(uint3 a, uint b) => new bool3(a.x > b, a.y > b, a.z > b);
        public static bool3 operator <=(uint3 a, uint b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        public static bool3 operator >=(uint3 a, uint b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        public static bool3 operator ==(uint a, uint3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        public static bool3 operator !=(uint a, uint3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        public static bool3 operator <(uint a, uint3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        public static bool3 operator >(uint a, uint3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        public static bool3 operator <=(uint a, uint3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        public static bool3 operator >=(uint a, uint3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - uint3

        // x
        public readonly uint3 xxx => new uint3(x, x, x);
        public readonly uint3 xxy => new uint3(x, x, y);
        public readonly uint3 xxz => new uint3(x, x, z);

        public readonly uint3 xyx => new uint3(x, y, x);
        public readonly uint3 xyy => new uint3(x, y, y);
        public readonly uint3 xyz => new uint3(x, y, z);

        public readonly uint3 xzx => new uint3(x, z, x);
        public readonly uint3 xzy => new uint3(x, z, y);
        public readonly uint3 xzz => new uint3(x, z, z);

        // y
        public readonly uint3 yxx => new uint3(y, x, x);
        public readonly uint3 yxy => new uint3(y, x, y);
        public readonly uint3 yxz => new uint3(y, x, z);

        public readonly uint3 yyx => new uint3(y, y, x);
        public readonly uint3 yyy => new uint3(y, y, y);
        public readonly uint3 yyz => new uint3(y, y, z);

        public readonly uint3 yzx => new uint3(y, z, x);
        public readonly uint3 yzy => new uint3(y, z, y);
        public readonly uint3 yzz => new uint3(y, z, z);

        // z
        public readonly uint3 zxx => new uint3(z, x, x);
        public readonly uint3 zxy => new uint3(z, x, y);
        public readonly uint3 zxz => new uint3(z, x, z);

        public readonly uint3 zyx => new uint3(z, y, x);
        public readonly uint3 zyy => new uint3(z, y, y);
        public readonly uint3 zyz => new uint3(z, y, z);

        public readonly uint3 zzx => new uint3(z, z, x);
        public readonly uint3 zzy => new uint3(z, z, y);
        public readonly uint3 zzz => new uint3(z, z, z);

        // Swizzling - uint2

        public readonly uint2 xx => new uint2(x, x);
        public readonly uint2 xy => new uint2(x, y);
        public readonly uint2 xz => new uint2(x, z);

        public readonly uint2 yx => new uint2(y, x);
        public readonly uint2 yy => new uint2(y, y);
        public readonly uint2 yz => new uint2(y, z);

        public readonly uint2 zx => new uint2(z, x);
        public readonly uint2 zy => new uint2(z, y);
        public readonly uint2 zz => new uint2(z, z);

        // RGBA Equvalence

        public readonly uint r => x;
        public readonly uint g => y;
        public readonly uint b => z;

        // RGBA Swizzling - uint3

        // r
        public readonly uint3 rrr => new uint3(r, r, r);
        public readonly uint3 rrg => new uint3(r, r, g);
        public readonly uint3 rrb => new uint3(r, r, b);

        public readonly uint3 rgr => new uint3(r, g, r);
        public readonly uint3 rgg => new uint3(r, g, g);
        public readonly uint3 rgb => new uint3(r, g, b);

        public readonly uint3 rbr => new uint3(r, b, r);
        public readonly uint3 rbg => new uint3(r, b, g);
        public readonly uint3 rbb => new uint3(r, b, b);

        // g
        public readonly uint3 grr => new uint3(g, r, r);
        public readonly uint3 grg => new uint3(g, r, g);
        public readonly uint3 grb => new uint3(g, r, b);

        public readonly uint3 ggr => new uint3(g, g, r);
        public readonly uint3 ggg => new uint3(g, g, g);
        public readonly uint3 ggb => new uint3(g, g, b);

        public readonly uint3 gbr => new uint3(g, b, r);
        public readonly uint3 gbg => new uint3(g, b, g);
        public readonly uint3 gbb => new uint3(g, b, b);

        // b
        public readonly uint3 brr => new uint3(b, r, r);
        public readonly uint3 brg => new uint3(b, r, g);
        public readonly uint3 brb => new uint3(b, r, b);

        public readonly uint3 bgr => new uint3(b, g, r);
        public readonly uint3 bgg => new uint3(b, g, g);
        public readonly uint3 bgb => new uint3(b, g, b);

        public readonly uint3 bbr => new uint3(b, b, r);
        public readonly uint3 bbg => new uint3(b, b, g);
        public readonly uint3 bbb => new uint3(b, b, b);

        // RGBA Swizzling - uint2

        public readonly uint2 rr => new uint2(r, r);
        public readonly uint2 rg => new uint2(r, g);
        public readonly uint2 rb => new uint2(r, b);

        public readonly uint2 gr => new uint2(g, r);
        public readonly uint2 gg => new uint2(g, g);
        public readonly uint2 gb => new uint2(g, b);

        public readonly uint2 br => new uint2(b, r);
        public readonly uint2 bg => new uint2(b, g);
        public readonly uint2 bb => new uint2(b, b);
    }
}
