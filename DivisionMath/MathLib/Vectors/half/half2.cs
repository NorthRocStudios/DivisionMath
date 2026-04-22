using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct half2
    {
        // Data Storage

        public float x;
        public float y;

        // Component Access

        public float this[int index]
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

        public override readonly string ToString() => $"half2({x}, {y})";
        public override readonly bool Equals(object? obj) => obj is half2 other && x == other.x && y == other.y;
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        public half2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public half2(float value)
        {
            x = value;
            y = value;
        }

        // Unary Operations

        public static half2 operator -(half2 v) => new half2(-v.x, -v.y);
        public static half2 operator +(half2 v) => v;

        // Implicit Operations

        public static implicit operator half2(half4 v) => new half2(v.x, v.y);
        public static implicit operator half2(half3 v) => new half2(v.x, v.y);
        public static implicit operator half2(float v) => new half2(v);

        // Unit Vectors

        public static half2 zero => new half2(0);
        public static half2 one => new half2(1);
        public static half2 unitX => new half2(1, 0);
        public static half2 unitY => new half2(0, 1);

        // Arithmetic Operations

        public static half2 operator +(half2 a, half2 b) => new half2(a.x + b.x, a.y + b.y);
        public static half2 operator -(half2 a, half2 b) => new half2(a.x - b.x, a.y - b.y);
        public static half2 operator *(half2 a, half2 b) => new half2(a.x * b.x, a.y * b.y);
        public static half2 operator /(half2 a, half2 b) => new half2(a.x / b.x, a.y / b.y);

        public static half2 operator +(half2 a, float b) => new half2(a.x + b, a.y + b);
        public static half2 operator -(half2 a, float b) => new half2(a.x - b, a.y - b);
        public static half2 operator *(half2 a, float b) => new half2(a.x * b, a.y * b);
        public static half2 operator /(half2 a, float b) => new half2(a.x / b, a.y / b);

        public static half2 operator +(float a, half2 b) => new half2(a + b.x, a + b.y);
        public static half2 operator -(float a, half2 b) => new half2(a - b.x, a - b.y);
        public static half2 operator *(float a, half2 b) => new half2(a * b.x, a * b.y);
        public static half2 operator /(float a, half2 b) => new half2(a / b.x, a / b.y);

        // Comparison Operations

        public static bool2 operator ==(half2 a, half2 b) => new bool2(a.x == b.x, a.y == b.y);
        public static bool2 operator !=(half2 a, half2 b) => new bool2(a.x != b.x, a.y != b.y);
        public static bool2 operator <(half2 a, half2 b) => new bool2(a.x < b.x, a.y < b.y);
        public static bool2 operator >(half2 a, half2 b) => new bool2(a.x > b.x, a.y > b.y);
        public static bool2 operator <=(half2 a, half2 b) => new bool2(a.x <= b.x, a.y <= b.y);
        public static bool2 operator >=(half2 a, half2 b) => new bool2(a.x >= b.x, a.y >= b.y);

        // Scalar-vector comparisons
        public static bool2 operator ==(half2 a, float b) => new bool2(a.x == b, a.y == b);
        public static bool2 operator !=(half2 a, float b) => new bool2(a.x != b, a.y != b);
        public static bool2 operator <(half2 a, float b) => new bool2(a.x < b, a.y < b);
        public static bool2 operator >(half2 a, float b) => new bool2(a.x > b, a.y > b);
        public static bool2 operator <=(half2 a, float b) => new bool2(a.x <= b, a.y <= b);
        public static bool2 operator >=(half2 a, float b) => new bool2(a.x >= b, a.y >= b);

        public static bool2 operator ==(float a, half2 b) => new bool2(a == b.x, a == b.y);
        public static bool2 operator !=(float a, half2 b) => new bool2(a != b.x, a != b.y);
        public static bool2 operator <(float a, half2 b) => new bool2(a < b.x, a < b.y);
        public static bool2 operator >(float a, half2 b) => new bool2(a > b.x, a > b.y);
        public static bool2 operator <=(float a, half2 b) => new bool2(a <= b.x, a <= b.y);
        public static bool2 operator >=(float a, half2 b) => new bool2(a >= b.x, a >= b.y);

        // Swizzling

        public readonly half2 xx => new half2(x, x);
        public readonly half2 xy => new half2(x, y);
        public readonly half2 yx => new half2(y, x);
        public readonly half2 yy => new half2(y, y);

        // RGBA Equvalence

        public readonly float r => x;
        public readonly float g => y;

        public readonly half2 rr => new half2(r, r);
        public readonly half2 rg => new half2(r, g);
        public readonly half2 gr => new half2(g, r);
        public readonly half2 gg => new half2(g, g);
    }
}
