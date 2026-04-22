using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct uint4
    {
        // Data Storage

        public uint x;
        public uint y;
        public uint z;
        public uint w;

        // Component Access

        public uint this[int index]
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

        public override readonly string ToString() => $"uint4({x}, {y}, {z}, {w})";
        public override readonly bool Equals(object? obj) => obj is uint4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        public uint4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public uint4(uint value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public uint4(uint3 xyz, uint w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        public uint4(uint x, uint3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        public uint4(uint2 xy, uint2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        public uint4(uint x, uint y, uint2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        public uint4(uint2 xy, uint z, uint w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        public uint4(uint x, uint2 yz, uint w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Implicit Operations

        public static implicit operator uint4(uint3 v) => new uint4(v, 0);
        public static implicit operator uint4(uint2 v) => new uint4(v, 0, 0);
        public static implicit operator uint4(uint v) => new uint4(v);

        // Unit Vectors

        public static uint4 zero => new uint4(0);
        public static uint4 one => new uint4(1);
        public static uint4 unitX => new uint4(1, 0, 0, 0);
        public static uint4 unitY => new uint4(0, 1, 0, 0);
        public static uint4 unitZ => new uint4(0, 0, 1, 0);
        public static uint4 unitW => new uint4(0, 0, 0, 1);

        // Arithmetic Operations

        public static uint4 operator +(uint4 a, uint4 b) => new uint4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        public static uint4 operator -(uint4 a, uint4 b) => new uint4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        public static uint4 operator *(uint4 a, uint4 b) => new uint4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        public static uint4 operator /(uint4 a, uint4 b) => new uint4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);

        // Arithmetic - uint

        public static uint4 operator +(uint4 a, uint b) => new uint4(a.x + b, a.y + b, a.z + b, a.w + b);
        public static uint4 operator -(uint4 a, uint b) => new uint4(a.x - b, a.y - b, a.z - b, a.w - b);
        public static uint4 operator *(uint4 a, uint b) => new uint4(a.x * b, a.y * b, a.z * b, a.w * b);
        public static uint4 operator /(uint4 a, uint b) => new uint4(a.x / b, a.y / b, a.z / b, a.w / b);

        public static uint4 operator +(uint a, uint4 b) => new uint4(a + b.x, a + b.y, a + b.z, a + b.w);
        public static uint4 operator -(uint a, uint4 b) => new uint4(a - b.x, a - b.y, a - b.z, a - b.w);
        public static uint4 operator *(uint a, uint4 b) => new uint4(a * b.x, a * b.y, a * b.z, a * b.w);
        public static uint4 operator /(uint a, uint4 b) => new uint4(a / b.x, a / b.y, a / b.z, a / b.w);

        // Arithmetic - uint2

        public static uint4 operator +(uint4 a, uint2 b) => new uint4(a.x + b.x, a.y + b.y, a.z, a.w);
        public static uint4 operator -(uint4 a, uint2 b) => new uint4(a.x - b.x, a.y - b.y, a.z, a.w);
        public static uint4 operator *(uint4 a, uint2 b) => new uint4(a.x * b.x, a.y * b.y, a.z, a.w);
        public static uint4 operator /(uint4 a, uint2 b) => new uint4(a.x / b.x, a.y / b.y, a.z, a.w);

        public static uint4 operator +(uint2 a, uint4 b) => new uint4(a.x + b.x, a.y + b.y, b.z, b.w);
        public static uint4 operator -(uint2 a, uint4 b) => new uint4(a.x - b.x, a.y - b.y, b.z, b.w);
        public static uint4 operator *(uint2 a, uint4 b) => new uint4(a.x * b.x, a.y * b.y, b.z, b.w);
        public static uint4 operator /(uint2 a, uint4 b) => new uint4(a.x / b.x, a.y / b.y, b.z, b.w);

        // Arithmetic - uint3

        public static uint4 operator +(uint4 a, uint3 b) => new uint4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        public static uint4 operator -(uint4 a, uint3 b) => new uint4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        public static uint4 operator *(uint4 a, uint3 b) => new uint4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        public static uint4 operator /(uint4 a, uint3 b) => new uint4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);

        public static uint4 operator +(uint3 a, uint4 b) => new uint4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        public static uint4 operator -(uint3 a, uint4 b) => new uint4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        public static uint4 operator *(uint3 a, uint4 b) => new uint4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        public static uint4 operator /(uint3 a, uint4 b) => new uint4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);

        // Comparison Operations

        public static bool4 operator ==(uint4 a, uint4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        public static bool4 operator !=(uint4 a, uint4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        public static bool4 operator <(uint4 a, uint4 b) => new bool4(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        public static bool4 operator >(uint4 a, uint4 b) => new bool4(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        public static bool4 operator <=(uint4 a, uint4 b) => new bool4(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        public static bool4 operator >=(uint4 a, uint4 b) => new bool4(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);

        // Vector-scalar comparisons
        public static bool4 operator ==(uint4 a, uint b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        public static bool4 operator !=(uint4 a, uint b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        public static bool4 operator <(uint4 a, uint b) => new bool4(a.x < b, a.y < b, a.z < b, a.w < b);
        public static bool4 operator >(uint4 a, uint b) => new bool4(a.x > b, a.y > b, a.z > b, a.w > b);
        public static bool4 operator <=(uint4 a, uint b) => new bool4(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        public static bool4 operator >=(uint4 a, uint b) => new bool4(a.x >= b, a.y >= b, a.z >= b, a.w >= b);

        // Scalar-vector comparisons
        public static bool4 operator ==(uint a, uint4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        public static bool4 operator !=(uint a, uint4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);
        public static bool4 operator <(uint a, uint4 b) => new bool4(a < b.x, a < b.y, a < b.z, a < b.w);
        public static bool4 operator >(uint a, uint4 b) => new bool4(a > b.x, a > b.y, a > b.z, a > b.w);
        public static bool4 operator <=(uint a, uint4 b) => new bool4(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
        public static bool4 operator >=(uint a, uint4 b) => new bool4(a >= b.x, a >= b.y, a >= b.z, a >= b.w);

        // RGBA Equvalence

        public readonly uint r => x;
        public readonly uint g => y;
        public readonly uint b => z;
        public readonly uint a => w;
    }
}
