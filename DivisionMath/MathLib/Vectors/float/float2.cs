using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct float2
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

        public override readonly string ToString() => $"float2({x}, {y})";
        public override readonly bool Equals(object? obj) => obj is float2 other && x == other.x && y == other.y;
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float2(float value)
        {
            x = value;
            y = value;
        }

        // Unary Operations

        public static float2 operator -(float2 v) => new float2(-v.x, -v.y);
        public static float2 operator +(float2 v) => v;

        // Implicit Operations

        public static implicit operator float2(float4 v) => new float2(v.x, v.y);
        public static implicit operator float2(float3 v) => new float2(v.x, v.y);
        public static implicit operator float2(float v) => new float2(v);

        // Unit Vectors

        public static float2 zero => new float2(0);
        public static float2 one => new float2(1);
        public static float2 unitX => new float2(1, 0);
        public static float2 unitY => new float2(0, 1);

        // Arithmetic Operations

        public static float2 operator +(float2 a, float2 b) => new float2(a.x + b.x, a.y + b.y);
        public static float2 operator -(float2 a, float2 b) => new float2(a.x - b.x, a.y - b.y);
        public static float2 operator *(float2 a, float2 b) => new float2(a.x * b.x, a.y * b.y);
        public static float2 operator /(float2 a, float2 b) => new float2(a.x / b.x, a.y / b.y);

        public static float2 operator +(float2 a, float b) => new float2(a.x + b, a.y + b);
        public static float2 operator -(float2 a, float b) => new float2(a.x - b, a.y - b);
        public static float2 operator *(float2 a, float b) => new float2(a.x * b, a.y * b);
        public static float2 operator /(float2 a, float b) => new float2(a.x / b, a.y / b);

        public static float2 operator +(float a, float2 b) => new float2(a + b.x, a + b.y);
        public static float2 operator -(float a, float2 b) => new float2(a - b.x, a - b.y);
        public static float2 operator *(float a, float2 b) => new float2(a * b.x, a * b.y);
        public static float2 operator /(float a, float2 b) => new float2(a / b.x, a / b.y);

        // Comparison Operations

        public static bool2 operator ==(float2 a, float2 b) => new bool2(a.x == b.x, a.y == b.y);
        public static bool2 operator !=(float2 a, float2 b) => new bool2(a.x != b.x, a.y != b.y);
        public static bool2 operator <(float2 a, float2 b) => new bool2(a.x < b.x, a.y < b.y);
        public static bool2 operator >(float2 a, float2 b) => new bool2(a.x > b.x, a.y > b.y);
        public static bool2 operator <=(float2 a, float2 b) => new bool2(a.x <= b.x, a.y <= b.y);
        public static bool2 operator >=(float2 a, float2 b) => new bool2(a.x >= b.x, a.y >= b.y);

        // Scalar-vector comparisons
        public static bool2 operator ==(float2 a, float b) => new bool2(a.x == b, a.y == b);
        public static bool2 operator !=(float2 a, float b) => new bool2(a.x != b, a.y != b);
        public static bool2 operator <(float2 a, float b) => new bool2(a.x < b, a.y < b);
        public static bool2 operator >(float2 a, float b) => new bool2(a.x > b, a.y > b);
        public static bool2 operator <=(float2 a, float b) => new bool2(a.x <= b, a.y <= b);
        public static bool2 operator >=(float2 a, float b) => new bool2(a.x >= b, a.y >= b);

        public static bool2 operator ==(float a, float2 b) => new bool2(a == b.x, a == b.y);
        public static bool2 operator !=(float a, float2 b) => new bool2(a != b.x, a != b.y);
        public static bool2 operator <(float a, float2 b) => new bool2(a < b.x, a < b.y);
        public static bool2 operator >(float a, float2 b) => new bool2(a > b.x, a > b.y);
        public static bool2 operator <=(float a, float2 b) => new bool2(a <= b.x, a <= b.y);
        public static bool2 operator >=(float a, float2 b) => new bool2(a >= b.x, a >= b.y);

        // Swizzling

        public readonly float2 xx => new float2(x, x);
        public readonly float2 xy => new float2(x, y);
        public readonly float2 yx => new float2(y, x);
        public readonly float2 yy => new float2(y, y);

        // RGBA Equvalence

        public readonly float r => x;
        public readonly float g => y;

        public readonly float2 rr => new float2(r, r);
        public readonly float2 rg => new float2(r, g);
        public readonly float2 gr => new float2(g, r);
        public readonly float2 gg => new float2(g, g);
    }
}
