using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct int4
    {
        // Data Storage

        public int x;
        public int y;
        public int z;
        public int w;

        // Component Access

        public int this[int index]
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

        public override readonly string ToString() => $"int4({x}, {y}, {z}, {w})";
        public override readonly bool Equals(object? obj) => obj is int4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        public int4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public int4(int value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public int4(int3 xyz, int w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        public int4(int x, int3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        public int4(int2 xy, int2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        public int4(int x, int y, int2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        public int4(int2 xy, int z, int w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        public int4(int x, int2 yz, int w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        public static int4 operator -(int4 v) => new int4(-v.x, -v.y, -v.z, -v.w);
        public static int4 operator +(int4 v) => v;

        // Implicit Operations

        public static implicit operator int4(int3 v) => new int4(v, 0);
        public static implicit operator int4(int2 v) => new int4(v, 0, 0);
        public static implicit operator int4(int v) => new int4(v);

        // Unit Vectors

        public static int4 zero => new int4(0);
        public static int4 one => new int4(1);
        public static int4 unitX => new int4(1, 0, 0, 0);
        public static int4 unitY => new int4(0, 1, 0, 0);
        public static int4 unitZ => new int4(0, 0, 1, 0);
        public static int4 unitW => new int4(0, 0, 0, 1);

        // Arithmetic Operations

        public static int4 operator +(int4 a, int4 b) => new int4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        public static int4 operator -(int4 a, int4 b) => new int4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        public static int4 operator *(int4 a, int4 b) => new int4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        public static int4 operator /(int4 a, int4 b) => new int4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);

        // Arithmetic - int

        public static int4 operator +(int4 a, int b) => new int4(a.x + b, a.y + b, a.z + b, a.w + b);
        public static int4 operator -(int4 a, int b) => new int4(a.x - b, a.y - b, a.z - b, a.w - b);
        public static int4 operator *(int4 a, int b) => new int4(a.x * b, a.y * b, a.z * b, a.w * b);
        public static int4 operator /(int4 a, int b) => new int4(a.x / b, a.y / b, a.z / b, a.w / b);

        public static int4 operator +(int a, int4 b) => new int4(a + b.x, a + b.y, a + b.z, a + b.w);
        public static int4 operator -(int a, int4 b) => new int4(a - b.x, a - b.y, a - b.z, a - b.w);
        public static int4 operator *(int a, int4 b) => new int4(a * b.x, a * b.y, a * b.z, a * b.w);
        public static int4 operator /(int a, int4 b) => new int4(a / b.x, a / b.y, a / b.z, a / b.w);

        // Arithmetic - int2

        public static int4 operator +(int4 a, int2 b) => new int4(a.x + b.x, a.y + b.y, a.z, a.w);
        public static int4 operator -(int4 a, int2 b) => new int4(a.x - b.x, a.y - b.y, a.z, a.w);
        public static int4 operator *(int4 a, int2 b) => new int4(a.x * b.x, a.y * b.y, a.z, a.w);
        public static int4 operator /(int4 a, int2 b) => new int4(a.x / b.x, a.y / b.y, a.z, a.w);

        public static int4 operator +(int2 a, int4 b) => new int4(a.x + b.x, a.y + b.y, b.z, b.w);
        public static int4 operator -(int2 a, int4 b) => new int4(a.x - b.x, a.y - b.y, b.z, b.w);
        public static int4 operator *(int2 a, int4 b) => new int4(a.x * b.x, a.y * b.y, b.z, b.w);
        public static int4 operator /(int2 a, int4 b) => new int4(a.x / b.x, a.y / b.y, b.z, b.w);

        // Arithmetic - int3

        public static int4 operator +(int4 a, int3 b) => new int4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        public static int4 operator -(int4 a, int3 b) => new int4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        public static int4 operator *(int4 a, int3 b) => new int4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        public static int4 operator /(int4 a, int3 b) => new int4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);

        public static int4 operator +(int3 a, int4 b) => new int4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        public static int4 operator -(int3 a, int4 b) => new int4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        public static int4 operator *(int3 a, int4 b) => new int4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        public static int4 operator /(int3 a, int4 b) => new int4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);

        // Comparison Operations

        public static bool4 operator ==(int4 a, int4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        public static bool4 operator !=(int4 a, int4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        public static bool4 operator <(int4 a, int4 b) => new bool4(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        public static bool4 operator >(int4 a, int4 b) => new bool4(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        public static bool4 operator <=(int4 a, int4 b) => new bool4(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        public static bool4 operator >=(int4 a, int4 b) => new bool4(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);

        // Vector-scalar comparisons
        public static bool4 operator ==(int4 a, int b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        public static bool4 operator !=(int4 a, int b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        public static bool4 operator <(int4 a, int b) => new bool4(a.x < b, a.y < b, a.z < b, a.w < b);
        public static bool4 operator >(int4 a, int b) => new bool4(a.x > b, a.y > b, a.z > b, a.w > b);
        public static bool4 operator <=(int4 a, int b) => new bool4(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        public static bool4 operator >=(int4 a, int b) => new bool4(a.x >= b, a.y >= b, a.z >= b, a.w >= b);

        // Scalar-vector comparisons
        public static bool4 operator ==(int a, int4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        public static bool4 operator !=(int a, int4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);
        public static bool4 operator <(int a, int4 b) => new bool4(a < b.x, a < b.y, a < b.z, a < b.w);
        public static bool4 operator >(int a, int4 b) => new bool4(a > b.x, a > b.y, a > b.z, a > b.w);
        public static bool4 operator <=(int a, int4 b) => new bool4(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
        public static bool4 operator >=(int a, int4 b) => new bool4(a >= b.x, a >= b.y, a >= b.z, a >= b.w);

        // RGBA Equvalence

        public readonly int r => x;
        public readonly int g => y;
        public readonly int b => z;
        public readonly int a => w;
    }
}
