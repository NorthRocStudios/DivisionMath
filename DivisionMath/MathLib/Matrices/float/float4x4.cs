namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 4x4 matrix with single-precision floating-point values, typically used for 3D transformations such
    /// as translation, rotation, and scaling.
    /// </summary>
    /// <remarks>The matrix is stored in column-major order, matching the convention used in HLSL and many
    /// graphics APIs. This structure provides static methods for creating common transformation matrices and supports
    /// matrix and vector multiplication.</remarks>
    /// <param name="c0">The first column of the matrix.</param>
    /// <param name="c1">The second column of the matrix.</param>
    /// <param name="c2">The third column of the matrix.</param>
    /// <param name="c3">The fourth column of the matrix.</param>
    public struct float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
    {
        public float4 c0 = c0, c1 = c1, c2 = c2, c3 = c3; // Column-major storage (HLSL standard)

        public static float4x4 identity => new float4x4(
            new float4(1, 0, 0, 0),
            new float4(0, 1, 0, 0),
            new float4(0, 0, 1, 0),
            new float4(0, 0, 0, 1)
        );

        public float4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, 3 => c3, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; case 3: c3 = value; break; } }
        }

        // Matrix multiplication
        public static float4x4 operator *(float4x4 a, float4x4 b)
        {
            return new float4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w
            );
        }

        // Matrix * vector
        public static float4 operator *(float4x4 m, float4 v)
        {
            return v.x * m.c0 + v.y * m.c1 + v.z * m.c2 + v.w * m.c3;
        }

        // Translation, rotation, scale helpers
        public static float4x4 Translate(float3 translation)
        {
            return new float4x4(
                new float4(1, 0, 0, 0),
                new float4(0, 1, 0, 0),
                new float4(0, 0, 1, 0),
                new float4(translation.x, translation.y, translation.z, 1)
            );
        }

        public static float4x4 Scale(float3 scale)
        {
            return new float4x4(
                new float4(scale.x, 0, 0, 0),
                new float4(0, scale.y, 0, 0),
                new float4(0, 0, scale.z, 0),
                new float4(0, 0, 0, 1)
            );
        }
    }
}
