using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct uint2
    {
        // Data Storage

        public uint x;
        public uint y;

        // Component Access

        public uint this[int index]
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

        public override readonly string ToString() => $"uint2({x}, {y})";
        public override readonly bool Equals(object? obj) => obj is uint2 other && x == other.x && y == other.y;
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        public uint2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }

        public uint2(uint value)
        {
            x = value;
            y = value;
        }

        // Implicit Operations

        public static implicit operator uint2(uint4 v) => new uint2(v.x, v.y);
        public static implicit operator uint2(uint3 v) => new uint2(v.x, v.y);
        public static implicit operator uint2(uint v) => new uint2(v);

        // Unit Vectors

        public static uint2 zero => new uint2(0);
        public static uint2 one => new uint2(1);
        public static uint2 unitX => new uint2(1, 0);
        public static uint2 unitY => new uint2(0, 1);

        // Arithmetic Operations

        public static uint2 operator +(uint2 a, uint2 b) => new uint2(a.x + b.x, a.y + b.y);
        public static uint2 operator -(uint2 a, uint2 b) => new uint2(a.x - b.x, a.y - b.y);
        public static uint2 operator *(uint2 a, uint2 b) => new uint2(a.x * b.x, a.y * b.y);
        public static uint2 operator /(uint2 a, uint2 b) => new uint2(a.x / b.x, a.y / b.y);

        public static uint2 operator +(uint2 a, uint b) => new uint2(a.x + b, a.y + b);
        public static uint2 operator -(uint2 a, uint b) => new uint2(a.x - b, a.y - b);
        public static uint2 operator *(uint2 a, uint b) => new uint2(a.x * b, a.y * b);
        public static uint2 operator /(uint2 a, uint b) => new uint2(a.x / b, a.y / b);

        public static uint2 operator +(uint a, uint2 b) => new uint2(a + b.x, a + b.y);
        public static uint2 operator -(uint a, uint2 b) => new uint2(a - b.x, a - b.y);
        public static uint2 operator *(uint a, uint2 b) => new uint2(a * b.x, a * b.y);
        public static uint2 operator /(uint a, uint2 b) => new uint2(a / b.x, a / b.y);

        // Comparison Operations

        public static bool2 operator ==(uint2 a, uint2 b) => new bool2(a.x == b.x, a.y == b.y);
        public static bool2 operator !=(uint2 a, uint2 b) => new bool2(a.x != b.x, a.y != b.y);
        public static bool2 operator <(uint2 a, uint2 b) => new bool2(a.x < b.x, a.y < b.y);
        public static bool2 operator >(uint2 a, uint2 b) => new bool2(a.x > b.x, a.y > b.y);
        public static bool2 operator <=(uint2 a, uint2 b) => new bool2(a.x <= b.x, a.y <= b.y);
        public static bool2 operator >=(uint2 a, uint2 b) => new bool2(a.x >= b.x, a.y >= b.y);

        // Scalar-vector comparisons
        public static bool2 operator ==(uint2 a, uint b) => new bool2(a.x == b, a.y == b);
        public static bool2 operator !=(uint2 a, uint b) => new bool2(a.x != b, a.y != b);
        public static bool2 operator <(uint2 a, uint b) => new bool2(a.x < b, a.y < b);
        public static bool2 operator >(uint2 a, uint b) => new bool2(a.x > b, a.y > b);
        public static bool2 operator <=(uint2 a, uint b) => new bool2(a.x <= b, a.y <= b);
        public static bool2 operator >=(uint2 a, uint b) => new bool2(a.x >= b, a.y >= b);

        public static bool2 operator ==(uint a, uint2 b) => new bool2(a == b.x, a == b.y);
        public static bool2 operator !=(uint a, uint2 b) => new bool2(a != b.x, a != b.y);
        public static bool2 operator <(uint a, uint2 b) => new bool2(a < b.x, a < b.y);
        public static bool2 operator >(uint a, uint2 b) => new bool2(a > b.x, a > b.y);
        public static bool2 operator <=(uint a, uint2 b) => new bool2(a <= b.x, a <= b.y);
        public static bool2 operator >=(uint a, uint2 b) => new bool2(a >= b.x, a >= b.y);

        // Swizzling

        public readonly uint2 xx => new uint2(x, x);
        public readonly uint2 xy => new uint2(x, y);
        public readonly uint2 yx => new uint2(y, x);
        public readonly uint2 yy => new uint2(y, y);

        // RGBA Equvalence

        public readonly uint r => x;
        public readonly uint g => y;

        public readonly uint2 rr => new uint2(r, r);
        public readonly uint2 rg => new uint2(r, g);
        public readonly uint2 gr => new uint2(g, r);
        public readonly uint2 gg => new uint2(g, g);
    }
}
