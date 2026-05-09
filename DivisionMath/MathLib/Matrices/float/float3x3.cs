using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 3x3 matrix in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float3x3
    {
        // Column-major storage (matching HLSL)
        public float3 c0;
        public float3 c1;
        public float3 c2;

        #region Constructors

        // From 9 scalars (row-major order for convenience)
        public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
        {
            c0 = new float3(m00, m10, m20);
            c1 = new float3(m01, m11, m21);
            c2 = new float3(m02, m12, m22);
        }

        // From 3 column vectors
        public float3x3(float3 c0, float3 c1, float3 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        // From single scalar (diagonal matrix)
        public float3x3(float diagonal)
        {
            c0 = new float3(diagonal, 0f, 0f);
            c1 = new float3(0f, diagonal, 0f);
            c2 = new float3(0f, 0f, diagonal);
        }

        // From 3x3 array (row-major)
        public float3x3(float[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 3x3");
            c0 = new float3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new float3(m[0, 1], m[1, 1], m[2, 1]);
            c2 = new float3(m[0, 2], m[1, 2], m[2, 2]);
        }

        #endregion Constructors
        #region Indexers

        // Column-major indexer
        public float3 this[int column]
        {
            readonly get => column switch
            {
                0 => c0,
                1 => c1,
                2 => c2,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
                    case 2: c2 = value; break;
                }
            }
        }

        // Element access via [row, column]
        public float this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0:
                        switch (row)
                        {
                            case 0: c0.x = value; break;
                            case 1: c0.y = value; break;
                            case 2: c0.z = value; break;
                        }
                        break;
                    case 1:
                        switch (row)
                        {
                            case 0: c1.x = value; break;
                            case 1: c1.y = value; break;
                            case 2: c1.z = value; break;
                        }
                        break;
                    case 2:
                        switch (row)
                        {
                            case 0: c2.x = value; break;
                            case 1: c2.y = value; break;
                            case 2: c2.z = value; break;
                        }
                        break;
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        public static float3x3 identity => new float3x3(1f);
        public static float3x3 zero => new float3x3(0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        public static float3x3 operator +(float3x3 a, float3x3 b) => new float3x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        public static float3x3 operator -(float3x3 a, float3x3 b) => new float3x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        public static float3x3 operator *(float3x3 a, float3x3 b) => mul(a, b);
        public static float3x3 operator *(float3x3 m, float scalar) => new float3x3(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);
        public static float3x3 operator *(float scalar, float3x3 m) => new float3x3(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);

        // Matrix-Vector
        public static float3 operator *(float3x3 m, float3 v) => v.x * m.c0 + v.y * m.c1 + v.z * m.c2;

        #endregion ArithmeticOperators
        #region StaticMethods

        public static float3x3 mul(float3x3 a, float3x3 b) => new float3x3(
            a.c0.x * b.c0.x + a.c1.x * b.c0.y + a.c2.x * b.c0.z,
            a.c0.y * b.c0.x + a.c1.y * b.c0.y + a.c2.y * b.c0.z,
            a.c0.z * b.c0.x + a.c1.z * b.c0.y + a.c2.z * b.c0.z,

            a.c0.x * b.c1.x + a.c1.x * b.c1.y + a.c2.x * b.c1.z,
            a.c0.y * b.c1.x + a.c1.y * b.c1.y + a.c2.y * b.c1.z,
            a.c0.z * b.c1.x + a.c1.z * b.c1.y + a.c2.z * b.c1.z,

            a.c0.x * b.c2.x + a.c1.x * b.c2.y + a.c2.x * b.c2.z,
            a.c0.y * b.c2.x + a.c1.y * b.c2.y + a.c2.y * b.c2.z,
            a.c0.z * b.c2.x + a.c1.z * b.c2.y + a.c2.z * b.c2.z
        );

        public static float3x3 transpose(float3x3 m) => new float3x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z,
            m.c2.x, m.c2.y, m.c2.z
        );

        public static float determinant(float3x3 m) =>
            m.c0.x * (m.c1.y * m.c2.z - m.c2.y * m.c1.z)
            - m.c1.x * (m.c0.y * m.c2.z - m.c2.y * m.c0.z)
            + m.c2.x * (m.c0.y * m.c1.z - m.c1.y * m.c0.z);

        public static float3x3 inverse(float3x3 m)
        {
            float det = determinant(m);
            if (det == 0f)
                return zero;

            float invDet = 1f / det;

            // Calculate adjugate matrix (transpose of cofactor matrix)
            return new float3x3(
                // First column (cofactors of first row, transposed)
                (m.c1.y * m.c2.z - m.c2.y * m.c1.z) * invDet,
                (m.c2.y * m.c0.z - m.c0.y * m.c2.z) * invDet,
                (m.c0.y * m.c1.z - m.c1.y * m.c0.z) * invDet,

                // Second column (cofactors of second row, transposed)
                (m.c2.x * m.c1.z - m.c1.x * m.c2.z) * invDet,
                (m.c0.x * m.c2.z - m.c2.x * m.c0.z) * invDet,
                (m.c1.x * m.c0.z - m.c0.x * m.c1.z) * invDet,

                // Third column (cofactors of third row, transposed)
                (m.c1.x * m.c2.y - m.c2.x * m.c1.y) * invDet,
                (m.c2.x * m.c0.y - m.c0.x * m.c2.y) * invDet,
                (m.c0.x * m.c1.y - m.c1.x * m.c0.y) * invDet
            );
        }

        #endregion StaticMethods
        #region InstanceMethods

        public readonly float3x3 transpose() => transpose(this);
        public readonly float determinant() => determinant(this);
        public readonly float3x3 inverse() => inverse(this);

        #endregion InstanceMethods
        #region Equality

        public static bool operator ==(float3x3 a, float3x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        public static bool operator !=(float3x3 a, float3x3 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float3x3 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        #endregion Equality
        #region Conversion

        public override readonly string ToString() => $"float3x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y},  {c0.z}, {c1.z}, {c2.z})";

        // Conversion to float4x4
        public static implicit operator float4x4(float3x3 m) => new float4x4(
            m.c0.x, m.c1.x, m.c2.x, 0f,
            m.c0.y, m.c1.y, m.c2.y, 0f,
            m.c0.z, m.c1.z, m.c2.z, 0f,
            0f, 0f, 0f, 1f
        );

        // Conversion from float2x2
        public static implicit operator float3x3(float2x2 m) => new float3x3(
            m.c0.x, m.c1.x, 0f,
            m.c0.y, m.c1.y, 0f,
            0f, 0f, 1f
        );

        #endregion Conversion
    }
}
