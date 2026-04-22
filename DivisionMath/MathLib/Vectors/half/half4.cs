using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct half4
    {
        // Data Storage

        public float x;
        public float y;
        public float z;
        public float w;

        // Component Access

        public float this[int index]
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

        public override readonly string ToString() => $"half4({x}, {y}, {z}, {w})";
        public override readonly bool Equals(object? obj) => obj is half4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        public half4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public half4(float value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        public half4(half3 xyz, float w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        public half4(float x, half3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        public half4(half2 xy, half2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        public half4(float x, float y, half2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        public half4(half2 xy, float z, float w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        public half4(float x, half2 yz, float w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        public static half4 operator -(half4 v) => new half4(-v.x, -v.y, -v.z, -v.w);
        public static half4 operator +(half4 v) => v;

        // Implicit Operations

        public static implicit operator half4(half3 v) => new half4(v, 0);
        public static implicit operator half4(half2 v) => new half4(v, 0, 0);
        public static implicit operator half4(float v) => new half4(v);

        // Unit Vectors

        public static half4 zero => new half4(0);
        public static half4 one => new half4(1);
        public static half4 unitX => new half4(1, 0, 0, 0);
        public static half4 unitY => new half4(0, 1, 0, 0);
        public static half4 unitZ => new half4(0, 0, 1, 0);
        public static half4 unitW => new half4(0, 0, 0, 1);

        // Arithmetic Operations

        public static half4 operator +(half4 a, half4 b) => new half4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        public static half4 operator -(half4 a, half4 b) => new half4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        public static half4 operator *(half4 a, half4 b) => new half4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        public static half4 operator /(half4 a, half4 b) => new half4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);

        // Arithmetic - half

        public static half4 operator +(half4 a, float b) => new half4(a.x + b, a.y + b, a.z + b, a.w + b);
        public static half4 operator -(half4 a, float b) => new half4(a.x - b, a.y - b, a.z - b, a.w - b);
        public static half4 operator *(half4 a, float b) => new half4(a.x * b, a.y * b, a.z * b, a.w * b);
        public static half4 operator /(half4 a, float b) => new half4(a.x / b, a.y / b, a.z / b, a.w / b);

        public static half4 operator +(float a, half4 b) => new half4(a + b.x, a + b.y, a + b.z, a + b.w);
        public static half4 operator -(float a, half4 b) => new half4(a - b.x, a - b.y, a - b.z, a - b.w);
        public static half4 operator *(float a, half4 b) => new half4(a * b.x, a * b.y, a * b.z, a * b.w);
        public static half4 operator /(float a, half4 b) => new half4(a / b.x, a / b.y, a / b.z, a / b.w);

        // Arithmetic - half2

        public static half4 operator +(half4 a, half2 b) => new half4(a.x + b.x, a.y + b.y, a.z, a.w);
        public static half4 operator -(half4 a, half2 b) => new half4(a.x - b.x, a.y - b.y, a.z, a.w);
        public static half4 operator *(half4 a, half2 b) => new half4(a.x * b.x, a.y * b.y, a.z, a.w);
        public static half4 operator /(half4 a, half2 b) => new half4(a.x / b.x, a.y / b.y, a.z, a.w);

        public static half4 operator +(half2 a, half4 b) => new half4(a.x + b.x, a.y + b.y, b.z, b.w);
        public static half4 operator -(half2 a, half4 b) => new half4(a.x - b.x, a.y - b.y, b.z, b.w);
        public static half4 operator *(half2 a, half4 b) => new half4(a.x * b.x, a.y * b.y, b.z, b.w);
        public static half4 operator /(half2 a, half4 b) => new half4(a.x / b.x, a.y / b.y, b.z, b.w);

        // Arithmetic - half3

        public static half4 operator +(half4 a, half3 b) => new half4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        public static half4 operator -(half4 a, half3 b) => new half4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        public static half4 operator *(half4 a, half3 b) => new half4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        public static half4 operator /(half4 a, half3 b) => new half4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);

        public static half4 operator +(half3 a, half4 b) => new half4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        public static half4 operator -(half3 a, half4 b) => new half4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        public static half4 operator *(half3 a, half4 b) => new half4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        public static half4 operator /(half3 a, half4 b) => new half4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);

        // Comparison Operations

        public static bool4 operator ==(half4 a, half4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        public static bool4 operator !=(half4 a, half4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        public static bool4 operator <(half4 a, half4 b) => new bool4(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        public static bool4 operator >(half4 a, half4 b) => new bool4(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        public static bool4 operator <=(half4 a, half4 b) => new bool4(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        public static bool4 operator >=(half4 a, half4 b) => new bool4(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);

        // Vector-scalar comparisons
        public static bool4 operator ==(half4 a, float b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        public static bool4 operator !=(half4 a, float b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        public static bool4 operator <(half4 a, float b) => new bool4(a.x < b, a.y < b, a.z < b, a.w < b);
        public static bool4 operator >(half4 a, float b) => new bool4(a.x > b, a.y > b, a.z > b, a.w > b);
        public static bool4 operator <=(half4 a, float b) => new bool4(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        public static bool4 operator >=(half4 a, float b) => new bool4(a.x >= b, a.y >= b, a.z >= b, a.w >= b);

        // Scalar-vector comparisons
        public static bool4 operator ==(float a, half4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        public static bool4 operator !=(float a, half4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);
        public static bool4 operator <(float a, half4 b) => new bool4(a < b.x, a < b.y, a < b.z, a < b.w);
        public static bool4 operator >(float a, half4 b) => new bool4(a > b.x, a > b.y, a > b.z, a > b.w);
        public static bool4 operator <=(float a, half4 b) => new bool4(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
        public static bool4 operator >=(float a, half4 b) => new bool4(a >= b.x, a >= b.y, a >= b.z, a >= b.w);

        // RGBA Equvalence

        public readonly float r => x;
        public readonly float g => y;
        public readonly float b => z;
        public readonly float a => w;
    }
}
