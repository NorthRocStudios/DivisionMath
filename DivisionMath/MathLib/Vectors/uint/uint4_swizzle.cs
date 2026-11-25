//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
namespace DivisionEngine.MathLib
{
    public partial struct uint4
    {
        #region Swizzles_uint4

        // Swizzles - uint4

        // x
        // xx
        /// <summary>Gets the <c>xxxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxxx => new uint4(x, x, x, x);
        /// <summary>Gets the <c>xxxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxxy => new uint4(x, x, x, y);
        /// <summary>Gets the <c>xxxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxxz => new uint4(x, x, x, z);
        /// <summary>Gets the <c>xxxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxxw => new uint4(x, x, x, w);

        /// <summary>Gets the <c>xxyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxyx => new uint4(x, x, y, x);
        /// <summary>Gets the <c>xxyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxyy => new uint4(x, x, y, y);
        /// <summary>Gets the <c>xxyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxyz => new uint4(x, x, y, z);
        /// <summary>Gets the <c>xxyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxyw => new uint4(x, x, y, w);

        /// <summary>Gets the <c>xxzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxzx => new uint4(x, x, z, x);
        /// <summary>Gets the <c>xxzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxzy => new uint4(x, x, z, y);
        /// <summary>Gets the <c>xxzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxzz => new uint4(x, x, z, z);
        /// <summary>Gets the <c>xxzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxzw => new uint4(x, x, z, w);

        /// <summary>Gets the <c>xxwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxwx => new uint4(x, x, w, x);
        /// <summary>Gets the <c>xxwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxwy => new uint4(x, x, w, y);
        /// <summary>Gets the <c>xxwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxwz => new uint4(x, x, w, z);
        /// <summary>Gets the <c>xxww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xxww => new uint4(x, x, w, w);

        // xy
        /// <summary>Gets the <c>xyxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyxx => new uint4(x, y, x, x);
        /// <summary>Gets the <c>xyxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyxy => new uint4(x, y, x, y);
        /// <summary>Gets the <c>xyxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyxz => new uint4(x, y, x, z);
        /// <summary>Gets the <c>xyxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyxw => new uint4(x, y, x, w);

        /// <summary>Gets the <c>xyyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyyx => new uint4(x, y, y, x);
        /// <summary>Gets the <c>xyyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyyy => new uint4(x, y, y, y);
        /// <summary>Gets the <c>xyyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyyz => new uint4(x, y, y, z);
        /// <summary>Gets the <c>xyyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyyw => new uint4(x, y, y, w);

        /// <summary>Gets the <c>xyzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyzx => new uint4(x, y, z, x);
        /// <summary>Gets the <c>xyzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyzy => new uint4(x, y, z, y);
        /// <summary>Gets the <c>xyzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyzz => new uint4(x, y, z, z);
        /// <summary>Gets the <c>xyzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyzw => new uint4(x, y, z, w);

        /// <summary>Gets the <c>xywx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xywx => new uint4(x, y, w, x);
        /// <summary>Gets the <c>xywy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xywy => new uint4(x, y, w, y);
        /// <summary>Gets the <c>xywz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xywz => new uint4(x, y, w, z);
        /// <summary>Gets the <c>xyww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xyww => new uint4(x, y, w, w);

        // xz
        /// <summary>Gets the <c>xzxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzxx => new uint4(x, z, x, x);
        /// <summary>Gets the <c>xzxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzxy => new uint4(x, z, x, y);
        /// <summary>Gets the <c>xzxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzxz => new uint4(x, z, x, z);
        /// <summary>Gets the <c>xzxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzxw => new uint4(x, z, x, w);

        /// <summary>Gets the <c>xzyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzyx => new uint4(x, z, y, x);
        /// <summary>Gets the <c>xzyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzyy => new uint4(x, z, y, y);
        /// <summary>Gets the <c>xzyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzyz => new uint4(x, z, y, z);
        /// <summary>Gets the <c>xzyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzyw => new uint4(x, z, y, w);

        /// <summary>Gets the <c>xzzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzzx => new uint4(x, z, z, x);
        /// <summary>Gets the <c>xzzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzzy => new uint4(x, z, z, y);
        /// <summary>Gets the <c>xzzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzzz => new uint4(x, z, z, z);
        /// <summary>Gets the <c>xzzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzzw => new uint4(x, z, z, w);

        /// <summary>Gets the <c>xzwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzwx => new uint4(x, z, w, x);
        /// <summary>Gets the <c>xzwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzwy => new uint4(x, z, w, y);
        /// <summary>Gets the <c>xzwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzwz => new uint4(x, z, w, z);
        /// <summary>Gets the <c>xzww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xzww => new uint4(x, z, w, w);

        // xw
        /// <summary>Gets the <c>xwxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwxx => new uint4(x, w, x, x);
        /// <summary>Gets the <c>xwxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwxy => new uint4(x, w, x, y);
        /// <summary>Gets the <c>xwxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwxz => new uint4(x, w, x, z);
        /// <summary>Gets the <c>xwxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwxw => new uint4(x, w, x, w);

        /// <summary>Gets the <c>xwyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwyx => new uint4(x, w, y, x);
        /// <summary>Gets the <c>xwyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwyy => new uint4(x, w, y, y);
        /// <summary>Gets the <c>xwyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwyz => new uint4(x, w, y, z);
        /// <summary>Gets the <c>xwyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwyw => new uint4(x, w, y, w);

        /// <summary>Gets the <c>xwzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwzx => new uint4(x, w, z, x);
        /// <summary>Gets the <c>xwzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwzy => new uint4(x, w, z, y);
        /// <summary>Gets the <c>xwzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwzz => new uint4(x, w, z, z);
        /// <summary>Gets the <c>xwzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwzw => new uint4(x, w, z, w);

        /// <summary>Gets the <c>xwwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwwx => new uint4(x, w, w, x);
        /// <summary>Gets the <c>xwwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwwy => new uint4(x, w, w, y);
        /// <summary>Gets the <c>xwwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwwz => new uint4(x, w, w, z);
        /// <summary>Gets the <c>xwww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 xwww => new uint4(x, w, w, w);


        // y
        // yx
        /// <summary>Gets the <c>yxxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxxx => new uint4(y, x, x, x);
        /// <summary>Gets the <c>yxxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxxy => new uint4(y, x, x, y);
        /// <summary>Gets the <c>yxxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxxz => new uint4(y, x, x, z);
        /// <summary>Gets the <c>yxxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxxw => new uint4(y, x, x, w);

        /// <summary>Gets the <c>yxyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxyx => new uint4(y, x, y, x);
        /// <summary>Gets the <c>yxyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxyy => new uint4(y, x, y, y);
        /// <summary>Gets the <c>yxyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxyz => new uint4(y, x, y, z);
        /// <summary>Gets the <c>yxyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxyw => new uint4(y, x, y, w);

        /// <summary>Gets the <c>yxzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxzx => new uint4(y, x, z, x);
        /// <summary>Gets the <c>yxzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxzy => new uint4(y, x, z, y);
        /// <summary>Gets the <c>yxzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxzz => new uint4(y, x, z, z);
        /// <summary>Gets the <c>yxzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxzw => new uint4(y, x, z, w);

        /// <summary>Gets the <c>yxwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxwx => new uint4(y, x, w, x);
        /// <summary>Gets the <c>yxwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxwy => new uint4(y, x, w, y);
        /// <summary>Gets the <c>yxwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxwz => new uint4(y, x, w, z);
        /// <summary>Gets the <c>yxww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yxww => new uint4(y, x, w, w);

        // yy
        /// <summary>Gets the <c>yyxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyxx => new uint4(y, y, x, x);
        /// <summary>Gets the <c>yyxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyxy => new uint4(y, y, x, y);
        /// <summary>Gets the <c>yyxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyxz => new uint4(y, y, x, z);
        /// <summary>Gets the <c>yyxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyxw => new uint4(y, y, x, w);

        /// <summary>Gets the <c>yyyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyyx => new uint4(y, y, y, x);
        /// <summary>Gets the <c>yyyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyyy => new uint4(y, y, y, y);
        /// <summary>Gets the <c>yyyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyyz => new uint4(y, y, y, z);
        /// <summary>Gets the <c>yyyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyyw => new uint4(y, y, y, w);

        /// <summary>Gets the <c>yyzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyzx => new uint4(y, y, z, x);
        /// <summary>Gets the <c>yyzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyzy => new uint4(y, y, z, y);
        /// <summary>Gets the <c>yyzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyzz => new uint4(y, y, z, z);
        /// <summary>Gets the <c>yyzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyzw => new uint4(y, y, z, w);

        /// <summary>Gets the <c>yywx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yywx => new uint4(y, y, w, x);
        /// <summary>Gets the <c>yywy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yywy => new uint4(y, y, w, y);
        /// <summary>Gets the <c>yywz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yywz => new uint4(y, y, w, z);
        /// <summary>Gets the <c>yyww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yyww => new uint4(y, y, w, w);

        // yz
        /// <summary>Gets the <c>yzxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzxx => new uint4(y, z, x, x);
        /// <summary>Gets the <c>yzxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzxy => new uint4(y, z, x, y);
        /// <summary>Gets the <c>yzxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzxz => new uint4(y, z, x, z);
        /// <summary>Gets the <c>yzxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzxw => new uint4(y, z, x, w);

        /// <summary>Gets the <c>yzyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzyx => new uint4(y, z, y, x);
        /// <summary>Gets the <c>yzyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzyy => new uint4(y, z, y, y);
        /// <summary>Gets the <c>yzyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzyz => new uint4(y, z, y, z);
        /// <summary>Gets the <c>yzyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzyw => new uint4(y, z, y, w);

        /// <summary>Gets the <c>yzzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzzx => new uint4(y, z, z, x);
        /// <summary>Gets the <c>yzzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzzy => new uint4(y, z, z, y);
        /// <summary>Gets the <c>yzzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzzz => new uint4(y, z, z, z);
        /// <summary>Gets the <c>yzzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzzw => new uint4(y, z, z, w);

        /// <summary>Gets the <c>yzwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzwx => new uint4(y, z, w, x);
        /// <summary>Gets the <c>yzwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzwy => new uint4(y, z, w, y);
        /// <summary>Gets the <c>yzwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzwz => new uint4(y, z, w, z);
        /// <summary>Gets the <c>yzww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 yzww => new uint4(y, z, w, w);

        // yw
        /// <summary>Gets the <c>ywxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywxx => new uint4(y, w, x, x);
        /// <summary>Gets the <c>ywxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywxy => new uint4(y, w, x, y);
        /// <summary>Gets the <c>ywxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywxz => new uint4(y, w, x, z);
        /// <summary>Gets the <c>ywxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywxw => new uint4(y, w, x, w);

        /// <summary>Gets the <c>ywyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywyx => new uint4(y, w, y, x);
        /// <summary>Gets the <c>ywyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywyy => new uint4(y, w, y, y);
        /// <summary>Gets the <c>ywyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywyz => new uint4(y, w, y, z);
        /// <summary>Gets the <c>ywyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywyw => new uint4(y, w, y, w);

        /// <summary>Gets the <c>ywzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywzx => new uint4(y, w, z, x);
        /// <summary>Gets the <c>ywzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywzy => new uint4(y, w, z, y);
        /// <summary>Gets the <c>ywzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywzz => new uint4(y, w, z, z);
        /// <summary>Gets the <c>ywzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywzw => new uint4(y, w, z, w);

        /// <summary>Gets the <c>ywwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywwx => new uint4(y, w, w, x);
        /// <summary>Gets the <c>ywwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywwy => new uint4(y, w, w, y);
        /// <summary>Gets the <c>ywwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywwz => new uint4(y, w, w, z);
        /// <summary>Gets the <c>ywww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ywww => new uint4(y, w, w, w);


        // z
        // zx
        /// <summary>Gets the <c>zxxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxxx => new uint4(z, x, x, x);
        /// <summary>Gets the <c>zxxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxxy => new uint4(z, x, x, y);
        /// <summary>Gets the <c>zxxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxxz => new uint4(z, x, x, z);
        /// <summary>Gets the <c>zxxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxxw => new uint4(z, x, x, w);

        /// <summary>Gets the <c>zxyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxyx => new uint4(z, x, y, x);
        /// <summary>Gets the <c>zxyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxyy => new uint4(z, x, y, y);
        /// <summary>Gets the <c>zxyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxyz => new uint4(z, x, y, z);
        /// <summary>Gets the <c>zxyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxyw => new uint4(z, x, y, w);

        /// <summary>Gets the <c>zxzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxzx => new uint4(z, x, z, x);
        /// <summary>Gets the <c>zxzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxzy => new uint4(z, x, z, y);
        /// <summary>Gets the <c>zxzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxzz => new uint4(z, x, z, z);
        /// <summary>Gets the <c>zxzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxzw => new uint4(z, x, z, w);

        /// <summary>Gets the <c>zxwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxwx => new uint4(z, x, w, x);
        /// <summary>Gets the <c>zxwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxwy => new uint4(z, x, w, y);
        /// <summary>Gets the <c>zxwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxwz => new uint4(z, x, w, z);
        /// <summary>Gets the <c>zxww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zxww => new uint4(z, x, w, w);

        // zy
        /// <summary>Gets the <c>zyxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyxx => new uint4(z, y, x, x);
        /// <summary>Gets the <c>zyxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyxy => new uint4(z, y, x, y);
        /// <summary>Gets the <c>zyxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyxz => new uint4(z, y, x, z);
        /// <summary>Gets the <c>zyxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyxw => new uint4(z, y, x, w);

        /// <summary>Gets the <c>zyyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyyx => new uint4(z, y, y, x);
        /// <summary>Gets the <c>zyyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyyy => new uint4(z, y, y, y);
        /// <summary>Gets the <c>zyyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyyz => new uint4(z, y, y, z);
        /// <summary>Gets the <c>zyyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyyw => new uint4(z, y, y, w);

        /// <summary>Gets the <c>zyzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyzx => new uint4(z, y, z, x);
        /// <summary>Gets the <c>zyzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyzy => new uint4(z, y, z, y);
        /// <summary>Gets the <c>zyzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyzz => new uint4(z, y, z, z);
        /// <summary>Gets the <c>zyzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyzw => new uint4(z, y, z, w);

        /// <summary>Gets the <c>zywx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zywx => new uint4(z, y, w, x);
        /// <summary>Gets the <c>zywy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zywy => new uint4(z, y, w, y);
        /// <summary>Gets the <c>zywz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zywz => new uint4(z, y, w, z);
        /// <summary>Gets the <c>zyww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zyww => new uint4(z, y, w, w);

        // zz
        /// <summary>Gets the <c>zzxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzxx => new uint4(z, z, x, x);
        /// <summary>Gets the <c>zzxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzxy => new uint4(z, z, x, y);
        /// <summary>Gets the <c>zzxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzxz => new uint4(z, z, x, z);
        /// <summary>Gets the <c>zzxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzxw => new uint4(z, z, x, w);

        /// <summary>Gets the <c>zzyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzyx => new uint4(z, z, y, x);
        /// <summary>Gets the <c>zzyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzyy => new uint4(z, z, y, y);
        /// <summary>Gets the <c>zzyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzyz => new uint4(z, z, y, z);
        /// <summary>Gets the <c>zzyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzyw => new uint4(z, z, y, w);

        /// <summary>Gets the <c>zzzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzzx => new uint4(z, z, z, x);
        /// <summary>Gets the <c>zzzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzzy => new uint4(z, z, z, y);
        /// <summary>Gets the <c>zzzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzzz => new uint4(z, z, z, z);
        /// <summary>Gets the <c>zzzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzzw => new uint4(z, z, z, w);

        /// <summary>Gets the <c>zzwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzwx => new uint4(z, z, w, x);
        /// <summary>Gets the <c>zzwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzwy => new uint4(z, z, w, y);
        /// <summary>Gets the <c>zzwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzwz => new uint4(z, z, w, z);
        /// <summary>Gets the <c>zzww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zzww => new uint4(z, z, w, w);

        // zw
        /// <summary>Gets the <c>zwxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwxx => new uint4(z, w, x, x);
        /// <summary>Gets the <c>zwxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwxy => new uint4(z, w, x, y);
        /// <summary>Gets the <c>zwxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwxz => new uint4(z, w, x, z);
        /// <summary>Gets the <c>zwxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwxw => new uint4(z, w, x, w);

        /// <summary>Gets the <c>zwyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwyx => new uint4(z, w, y, x);
        /// <summary>Gets the <c>zwyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwyy => new uint4(z, w, y, y);
        /// <summary>Gets the <c>zwyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwyz => new uint4(z, w, y, z);
        /// <summary>Gets the <c>zwyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwyw => new uint4(z, w, y, w);

        /// <summary>Gets the <c>zwzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwzx => new uint4(z, w, z, x);
        /// <summary>Gets the <c>zwzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwzy => new uint4(z, w, z, y);
        /// <summary>Gets the <c>zwzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwzz => new uint4(z, w, z, z);
        /// <summary>Gets the <c>zwzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwzw => new uint4(z, w, z, w);

        /// <summary>Gets the <c>zwwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwwx => new uint4(z, w, w, x);
        /// <summary>Gets the <c>zwwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwwy => new uint4(z, w, w, y);
        /// <summary>Gets the <c>zwwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwwz => new uint4(z, w, w, z);
        /// <summary>Gets the <c>zwww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 zwww => new uint4(z, w, w, w);


        // w
        // wx
        /// <summary>Gets the <c>wxxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxxx => new uint4(w, x, x, x);
        /// <summary>Gets the <c>wxxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxxy => new uint4(w, x, x, y);
        /// <summary>Gets the <c>wxxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxxz => new uint4(w, x, x, z);
        /// <summary>Gets the <c>wxxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxxw => new uint4(w, x, x, w);

        /// <summary>Gets the <c>wxyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxyx => new uint4(w, x, y, x);
        /// <summary>Gets the <c>wxyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxyy => new uint4(w, x, y, y);
        /// <summary>Gets the <c>wxyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxyz => new uint4(w, x, y, z);
        /// <summary>Gets the <c>wxyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxyw => new uint4(w, x, y, w);

        /// <summary>Gets the <c>wxzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxzx => new uint4(w, x, z, x);
        /// <summary>Gets the <c>wxzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxzy => new uint4(w, x, z, y);
        /// <summary>Gets the <c>wxzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxzz => new uint4(w, x, z, z);
        /// <summary>Gets the <c>wxzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxzw => new uint4(w, x, z, w);

        /// <summary>Gets the <c>wxwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxwx => new uint4(w, x, w, x);
        /// <summary>Gets the <c>wxwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxwy => new uint4(w, x, w, y);
        /// <summary>Gets the <c>wxwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxwz => new uint4(w, x, w, z);
        /// <summary>Gets the <c>wxww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wxww => new uint4(w, x, w, w);

        // wy
        /// <summary>Gets the <c>wyxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyxx => new uint4(w, y, x, x);
        /// <summary>Gets the <c>wyxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyxy => new uint4(w, y, x, y);
        /// <summary>Gets the <c>wyxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyxz => new uint4(w, y, x, z);
        /// <summary>Gets the <c>wyxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyxw => new uint4(w, y, x, w);

        /// <summary>Gets the <c>wyyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyyx => new uint4(w, y, y, x);
        /// <summary>Gets the <c>wyyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyyy => new uint4(w, y, y, y);
        /// <summary>Gets the <c>wyyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyyz => new uint4(w, y, y, z);
        /// <summary>Gets the <c>wyyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyyw => new uint4(w, y, y, w);

        /// <summary>Gets the <c>wyzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyzx => new uint4(w, y, z, x);
        /// <summary>Gets the <c>wyzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyzy => new uint4(w, y, z, y);
        /// <summary>Gets the <c>wyzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyzz => new uint4(w, y, z, z);
        /// <summary>Gets the <c>wyzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyzw => new uint4(w, y, z, w);

        /// <summary>Gets the <c>wywx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wywx => new uint4(w, y, w, x);
        /// <summary>Gets the <c>wywy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wywy => new uint4(w, y, w, y);
        /// <summary>Gets the <c>wywz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wywz => new uint4(w, y, w, z);
        /// <summary>Gets the <c>wyww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wyww => new uint4(w, y, w, w);

        // wz
        /// <summary>Gets the <c>wzxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzxx => new uint4(w, z, x, x);
        /// <summary>Gets the <c>wzxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzxy => new uint4(w, z, x, y);
        /// <summary>Gets the <c>wzxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzxz => new uint4(w, z, x, z);
        /// <summary>Gets the <c>wzxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzxw => new uint4(w, z, x, w);

        /// <summary>Gets the <c>wzyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzyx => new uint4(w, z, y, x);
        /// <summary>Gets the <c>wzyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzyy => new uint4(w, z, y, y);
        /// <summary>Gets the <c>wzyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzyz => new uint4(w, z, y, z);
        /// <summary>Gets the <c>wzyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzyw => new uint4(w, z, y, w);

        /// <summary>Gets the <c>wzzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzzx => new uint4(w, z, z, x);
        /// <summary>Gets the <c>wzzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzzy => new uint4(w, z, z, y);
        /// <summary>Gets the <c>wzzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzzz => new uint4(w, z, z, z);
        /// <summary>Gets the <c>wzzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzzw => new uint4(w, z, z, w);

        /// <summary>Gets the <c>wzwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzwx => new uint4(w, z, w, x);
        /// <summary>Gets the <c>wzwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzwy => new uint4(w, z, w, y);
        /// <summary>Gets the <c>wzwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzwz => new uint4(w, z, w, z);
        /// <summary>Gets the <c>wzww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wzww => new uint4(w, z, w, w);

        // ww
        /// <summary>Gets the <c>wwxx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwxx => new uint4(w, w, x, x);
        /// <summary>Gets the <c>wwxy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwxy => new uint4(w, w, x, y);
        /// <summary>Gets the <c>wwxz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwxz => new uint4(w, w, x, z);
        /// <summary>Gets the <c>wwxw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwxw => new uint4(w, w, x, w);

        /// <summary>Gets the <c>wwyx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwyx => new uint4(w, w, y, x);
        /// <summary>Gets the <c>wwyy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwyy => new uint4(w, w, y, y);
        /// <summary>Gets the <c>wwyz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwyz => new uint4(w, w, y, z);
        /// <summary>Gets the <c>wwyw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwyw => new uint4(w, w, y, w);

        /// <summary>Gets the <c>wwzx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwzx => new uint4(w, w, z, x);
        /// <summary>Gets the <c>wwzy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwzy => new uint4(w, w, z, y);
        /// <summary>Gets the <c>wwzz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwzz => new uint4(w, w, z, z);
        /// <summary>Gets the <c>wwzw</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwzw => new uint4(w, w, z, w);

        /// <summary>Gets the <c>wwwx</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwwx => new uint4(w, w, w, x);
        /// <summary>Gets the <c>wwwy</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwwy => new uint4(w, w, w, y);
        /// <summary>Gets the <c>wwwz</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwwz => new uint4(w, w, w, z);
        /// <summary>Gets the <c>wwww</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 wwww => new uint4(w, w, w, w);

        #endregion Swizzles_uint4
        #region Swizzles_uint4_RGBA

        // RGBA - Swizzles - uint4

        // r
        // rr
        /// <summary>Gets the <c>rrrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrrr => new uint4(r, r, r, r);
        /// <summary>Gets the <c>rrrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrrg => new uint4(r, r, r, g);
        /// <summary>Gets the <c>rrrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrrb => new uint4(r, r, r, b);
        /// <summary>Gets the <c>rrra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrra => new uint4(r, r, r, a);

        /// <summary>Gets the <c>rrgr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrgr => new uint4(r, r, g, r);
        /// <summary>Gets the <c>rrgg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrgg => new uint4(r, r, g, g);
        /// <summary>Gets the <c>rrgb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrgb => new uint4(r, r, g, b);
        /// <summary>Gets the <c>rrga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrga => new uint4(r, r, g, a);

        /// <summary>Gets the <c>rrbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrbr => new uint4(r, r, b, r);
        /// <summary>Gets the <c>rrbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrbg => new uint4(r, r, b, g);
        /// <summary>Gets the <c>rrbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrbb => new uint4(r, r, b, b);
        /// <summary>Gets the <c>rrba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrba => new uint4(r, r, b, a);

        /// <summary>Gets the <c>rrar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrar => new uint4(r, r, a, r);
        /// <summary>Gets the <c>rrag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrag => new uint4(r, r, a, g);
        /// <summary>Gets the <c>rrab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rrab => new uint4(r, r, a, b);
        /// <summary>Gets the <c>rraa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rraa => new uint4(r, r, a, a);

        // rg
        /// <summary>Gets the <c>rgrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgrr => new uint4(r, g, r, r);
        /// <summary>Gets the <c>rgrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgrg => new uint4(r, g, r, g);
        /// <summary>Gets the <c>rgrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgrb => new uint4(r, g, r, b);
        /// <summary>Gets the <c>rgra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgra => new uint4(r, g, r, a);

        /// <summary>Gets the <c>rggr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rggr => new uint4(r, g, g, r);
        /// <summary>Gets the <c>rggg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rggg => new uint4(r, g, g, g);
        /// <summary>Gets the <c>rggb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rggb => new uint4(r, g, g, b);
        /// <summary>Gets the <c>rgga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgga => new uint4(r, g, g, a);

        /// <summary>Gets the <c>rgbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgbr => new uint4(r, g, b, r);
        /// <summary>Gets the <c>rgbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgbg => new uint4(r, g, b, g);
        /// <summary>Gets the <c>rgbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgbb => new uint4(r, g, b, b);
        /// <summary>Gets the <c>rgba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgba => new uint4(r, g, b, a);

        /// <summary>Gets the <c>rgar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgar => new uint4(r, g, a, r);
        /// <summary>Gets the <c>rgag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgag => new uint4(r, g, a, g);
        /// <summary>Gets the <c>rgab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgab => new uint4(r, g, a, b);
        /// <summary>Gets the <c>rgaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rgaa => new uint4(r, g, a, a);

        // rb
        /// <summary>Gets the <c>rbrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbrr => new uint4(r, b, r, r);
        /// <summary>Gets the <c>rbrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbrg => new uint4(r, b, r, g);
        /// <summary>Gets the <c>rbrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbrb => new uint4(r, b, r, b);
        /// <summary>Gets the <c>rbra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbra => new uint4(r, b, r, a);

        /// <summary>Gets the <c>rbgr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbgr => new uint4(r, b, g, r);
        /// <summary>Gets the <c>rbgg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbgg => new uint4(r, b, g, g);
        /// <summary>Gets the <c>rbgb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbgb => new uint4(r, b, g, b);
        /// <summary>Gets the <c>rbga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbga => new uint4(r, b, g, a);

        /// <summary>Gets the <c>rbbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbbr => new uint4(r, b, b, r);
        /// <summary>Gets the <c>rbbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbbg => new uint4(r, b, b, g);
        /// <summary>Gets the <c>rbbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbbb => new uint4(r, b, b, b);
        /// <summary>Gets the <c>rbba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbba => new uint4(r, b, b, a);

        /// <summary>Gets the <c>rbar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbar => new uint4(r, b, a, r);
        /// <summary>Gets the <c>rbag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbag => new uint4(r, b, a, g);
        /// <summary>Gets the <c>rbab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbab => new uint4(r, b, a, b);
        /// <summary>Gets the <c>rbaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rbaa => new uint4(r, b, a, a);

        // ra
        /// <summary>Gets the <c>rarr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rarr => new uint4(r, a, r, r);
        /// <summary>Gets the <c>rarg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rarg => new uint4(r, a, r, g);
        /// <summary>Gets the <c>rarb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rarb => new uint4(r, a, r, b);
        /// <summary>Gets the <c>rara</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rara => new uint4(r, a, r, a);

        /// <summary>Gets the <c>ragr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ragr => new uint4(r, a, g, r);
        /// <summary>Gets the <c>ragg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ragg => new uint4(r, a, g, g);
        /// <summary>Gets the <c>ragb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ragb => new uint4(r, a, g, b);
        /// <summary>Gets the <c>raga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 raga => new uint4(r, a, g, a);

        /// <summary>Gets the <c>rabr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rabr => new uint4(r, a, b, r);
        /// <summary>Gets the <c>rabg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rabg => new uint4(r, a, b, g);
        /// <summary>Gets the <c>rabb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 rabb => new uint4(r, a, b, b);
        /// <summary>Gets the <c>raba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 raba => new uint4(r, a, b, a);

        /// <summary>Gets the <c>raar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 raar => new uint4(r, a, a, r);
        /// <summary>Gets the <c>raag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 raag => new uint4(r, a, a, g);
        /// <summary>Gets the <c>raab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 raab => new uint4(r, a, a, b);
        /// <summary>Gets the <c>raaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 raaa => new uint4(r, a, a, a);


        // g
        // gr
        /// <summary>Gets the <c>grrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grrr => new uint4(g, r, r, r);
        /// <summary>Gets the <c>grrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grrg => new uint4(g, r, r, g);
        /// <summary>Gets the <c>grrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grrb => new uint4(g, r, r, b);
        /// <summary>Gets the <c>grra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grra => new uint4(g, r, r, a);

        /// <summary>Gets the <c>grgr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grgr => new uint4(g, r, g, r);
        /// <summary>Gets the <c>grgg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grgg => new uint4(g, r, g, g);
        /// <summary>Gets the <c>grgb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grgb => new uint4(g, r, g, b);
        /// <summary>Gets the <c>grga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grga => new uint4(g, r, g, a);

        /// <summary>Gets the <c>grbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grbr => new uint4(g, r, b, r);
        /// <summary>Gets the <c>grbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grbg => new uint4(g, r, b, g);
        /// <summary>Gets the <c>grbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grbb => new uint4(g, r, b, b);
        /// <summary>Gets the <c>grba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grba => new uint4(g, r, b, a);

        /// <summary>Gets the <c>grar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grar => new uint4(g, r, a, r);
        /// <summary>Gets the <c>grag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grag => new uint4(g, r, a, g);
        /// <summary>Gets the <c>grab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 grab => new uint4(g, r, a, b);
        /// <summary>Gets the <c>graa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 graa => new uint4(g, r, a, a);

        // gg
        /// <summary>Gets the <c>ggrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggrr => new uint4(g, g, r, r);
        /// <summary>Gets the <c>ggrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggrg => new uint4(g, g, r, g);
        /// <summary>Gets the <c>ggrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggrb => new uint4(g, g, r, b);
        /// <summary>Gets the <c>ggra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggra => new uint4(g, g, r, a);

        /// <summary>Gets the <c>gggr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gggr => new uint4(g, g, g, r);
        /// <summary>Gets the <c>gggg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gggg => new uint4(g, g, g, g);
        /// <summary>Gets the <c>gggb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gggb => new uint4(g, g, g, b);
        /// <summary>Gets the <c>ggga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggga => new uint4(g, g, g, a);

        /// <summary>Gets the <c>ggbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggbr => new uint4(g, g, b, r);
        /// <summary>Gets the <c>ggbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggbg => new uint4(g, g, b, g);
        /// <summary>Gets the <c>ggbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggbb => new uint4(g, g, b, b);
        /// <summary>Gets the <c>ggba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggba => new uint4(g, g, b, a);

        /// <summary>Gets the <c>ggar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggar => new uint4(g, g, a, r);
        /// <summary>Gets the <c>ggag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggag => new uint4(g, g, a, g);
        /// <summary>Gets the <c>ggab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggab => new uint4(g, g, a, b);
        /// <summary>Gets the <c>ggaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 ggaa => new uint4(g, g, a, a);

        // gb
        /// <summary>Gets the <c>gbrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbrr => new uint4(g, b, r, r);
        /// <summary>Gets the <c>gbrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbrg => new uint4(g, b, r, g);
        /// <summary>Gets the <c>gbrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbrb => new uint4(g, b, r, b);
        /// <summary>Gets the <c>gbra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbra => new uint4(g, b, r, a);

        /// <summary>Gets the <c>gbgr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbgr => new uint4(g, b, g, r);
        /// <summary>Gets the <c>gbgg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbgg => new uint4(g, b, g, g);
        /// <summary>Gets the <c>gbgb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbgb => new uint4(g, b, g, b);
        /// <summary>Gets the <c>gbga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbga => new uint4(g, b, g, a);

        /// <summary>Gets the <c>gbbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbbr => new uint4(g, b, b, r);
        /// <summary>Gets the <c>gbbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbbg => new uint4(g, b, b, g);
        /// <summary>Gets the <c>gbbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbbb => new uint4(g, b, b, b);
        /// <summary>Gets the <c>gbba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbba => new uint4(g, b, b, a);

        /// <summary>Gets the <c>gbar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbar => new uint4(g, b, a, r);
        /// <summary>Gets the <c>gbag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbag => new uint4(g, b, a, g);
        /// <summary>Gets the <c>gbab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbab => new uint4(g, b, a, b);
        /// <summary>Gets the <c>gbaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gbaa => new uint4(g, b, a, a);

        // ga
        /// <summary>Gets the <c>garr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 garr => new uint4(g, a, r, r);
        /// <summary>Gets the <c>garg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 garg => new uint4(g, a, r, g);
        /// <summary>Gets the <c>garb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 garb => new uint4(g, a, r, b);
        /// <summary>Gets the <c>gara</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gara => new uint4(g, a, r, a);

        /// <summary>Gets the <c>gagr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gagr => new uint4(g, a, g, r);
        /// <summary>Gets the <c>gagg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gagg => new uint4(g, a, g, g);
        /// <summary>Gets the <c>gagb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gagb => new uint4(g, a, g, b);
        /// <summary>Gets the <c>gaga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gaga => new uint4(g, a, g, a);

        /// <summary>Gets the <c>gabr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gabr => new uint4(g, a, b, r);
        /// <summary>Gets the <c>gabg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gabg => new uint4(g, a, b, g);
        /// <summary>Gets the <c>gabb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gabb => new uint4(g, a, b, b);
        /// <summary>Gets the <c>gaba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gaba => new uint4(g, a, b, a);

        /// <summary>Gets the <c>gaar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gaar => new uint4(g, a, a, r);
        /// <summary>Gets the <c>gaag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gaag => new uint4(g, a, a, g);
        /// <summary>Gets the <c>gaab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gaab => new uint4(g, a, a, b);
        /// <summary>Gets the <c>gaaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 gaaa => new uint4(g, a, a, a);


        // b
        // br
        /// <summary>Gets the <c>brrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brrr => new uint4(b, r, r, r);
        /// <summary>Gets the <c>brrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brrg => new uint4(b, r, r, g);
        /// <summary>Gets the <c>brrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brrb => new uint4(b, r, r, b);
        /// <summary>Gets the <c>brra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brra => new uint4(b, r, r, a);

        /// <summary>Gets the <c>brgr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brgr => new uint4(b, r, g, r);
        /// <summary>Gets the <c>brgg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brgg => new uint4(b, r, g, g);
        /// <summary>Gets the <c>brgb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brgb => new uint4(b, r, g, b);
        /// <summary>Gets the <c>brga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brga => new uint4(b, r, g, a);

        /// <summary>Gets the <c>brbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brbr => new uint4(b, r, b, r);
        /// <summary>Gets the <c>brbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brbg => new uint4(b, r, b, g);
        /// <summary>Gets the <c>brbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brbb => new uint4(b, r, b, b);
        /// <summary>Gets the <c>brba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brba => new uint4(b, r, b, a);

        /// <summary>Gets the <c>brar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brar => new uint4(b, r, a, r);
        /// <summary>Gets the <c>brag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brag => new uint4(b, r, a, g);
        /// <summary>Gets the <c>brab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 brab => new uint4(b, r, a, b);
        /// <summary>Gets the <c>braa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 braa => new uint4(b, r, a, a);

        // bg
        /// <summary>Gets the <c>bgrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgrr => new uint4(b, g, r, r);
        /// <summary>Gets the <c>bgrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgrg => new uint4(b, g, r, g);
        /// <summary>Gets the <c>bgrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgrb => new uint4(b, g, r, b);
        /// <summary>Gets the <c>bgra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgra => new uint4(b, g, r, a);

        /// <summary>Gets the <c>bggr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bggr => new uint4(b, g, g, r);
        /// <summary>Gets the <c>bggg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bggg => new uint4(b, g, g, g);
        /// <summary>Gets the <c>bggb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bggb => new uint4(b, g, g, b);
        /// <summary>Gets the <c>bgga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgga => new uint4(b, g, g, a);

        /// <summary>Gets the <c>bgbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgbr => new uint4(b, g, b, r);
        /// <summary>Gets the <c>bgbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgbg => new uint4(b, g, b, g);
        /// <summary>Gets the <c>bgbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgbb => new uint4(b, g, b, b);
        /// <summary>Gets the <c>bgba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgba => new uint4(b, g, b, a);

        /// <summary>Gets the <c>bgar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgar => new uint4(b, g, a, r);
        /// <summary>Gets the <c>bgag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgag => new uint4(b, g, a, g);
        /// <summary>Gets the <c>bgab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgab => new uint4(b, g, a, b);
        /// <summary>Gets the <c>bgaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bgaa => new uint4(b, g, a, a);

        // bb
        /// <summary>Gets the <c>bbrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbrr => new uint4(b, b, r, r);
        /// <summary>Gets the <c>bbrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbrg => new uint4(b, b, r, g);
        /// <summary>Gets the <c>bbrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbrb => new uint4(b, b, r, b);
        /// <summary>Gets the <c>bbra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbra => new uint4(b, b, r, a);

        /// <summary>Gets the <c>bbgr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbgr => new uint4(b, b, g, r);
        /// <summary>Gets the <c>bbgg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbgg => new uint4(b, b, g, g);
        /// <summary>Gets the <c>bbgb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbgb => new uint4(b, b, g, b);
        /// <summary>Gets the <c>bbga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbga => new uint4(b, b, g, a);

        /// <summary>Gets the <c>bbbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbbr => new uint4(b, b, b, r);
        /// <summary>Gets the <c>bbbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbbg => new uint4(b, b, b, g);
        /// <summary>Gets the <c>bbbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbbb => new uint4(b, b, b, b);
        /// <summary>Gets the <c>bbba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbba => new uint4(b, b, b, a);

        /// <summary>Gets the <c>bbar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbar => new uint4(b, b, a, r);
        /// <summary>Gets the <c>bbag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbag => new uint4(b, b, a, g);
        /// <summary>Gets the <c>bbab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbab => new uint4(b, b, a, b);
        /// <summary>Gets the <c>bbaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bbaa => new uint4(b, b, a, a);

        // ba
        /// <summary>Gets the <c>barr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 barr => new uint4(b, a, r, r);
        /// <summary>Gets the <c>barg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 barg => new uint4(b, a, r, g);
        /// <summary>Gets the <c>barb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 barb => new uint4(b, a, r, b);
        /// <summary>Gets the <c>bara</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bara => new uint4(b, a, r, a);

        /// <summary>Gets the <c>bagr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bagr => new uint4(b, a, g, r);
        /// <summary>Gets the <c>bagg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bagg => new uint4(b, a, g, g);
        /// <summary>Gets the <c>bagb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 bagb => new uint4(b, a, g, b);
        /// <summary>Gets the <c>baga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 baga => new uint4(b, a, g, a);

        /// <summary>Gets the <c>babr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 babr => new uint4(b, a, b, r);
        /// <summary>Gets the <c>babg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 babg => new uint4(b, a, b, g);
        /// <summary>Gets the <c>babb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 babb => new uint4(b, a, b, b);
        /// <summary>Gets the <c>baba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 baba => new uint4(b, a, b, a);

        /// <summary>Gets the <c>baar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 baar => new uint4(b, a, a, r);
        /// <summary>Gets the <c>baag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 baag => new uint4(b, a, a, g);
        /// <summary>Gets the <c>baab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 baab => new uint4(b, a, a, b);
        /// <summary>Gets the <c>baaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 baaa => new uint4(b, a, a, a);


        // a
        // ar
        /// <summary>Gets the <c>arrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arrr => new uint4(a, r, r, r);
        /// <summary>Gets the <c>arrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arrg => new uint4(a, r, r, g);
        /// <summary>Gets the <c>arrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arrb => new uint4(a, r, r, b);
        /// <summary>Gets the <c>arra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arra => new uint4(a, r, r, a);

        /// <summary>Gets the <c>argr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 argr => new uint4(a, r, g, r);
        /// <summary>Gets the <c>argg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 argg => new uint4(a, r, g, g);
        /// <summary>Gets the <c>argb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 argb => new uint4(a, r, g, b);
        /// <summary>Gets the <c>arga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arga => new uint4(a, r, g, a);

        /// <summary>Gets the <c>arbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arbr => new uint4(a, r, b, r);
        /// <summary>Gets the <c>arbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arbg => new uint4(a, r, b, g);
        /// <summary>Gets the <c>arbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arbb => new uint4(a, r, b, b);
        /// <summary>Gets the <c>arba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arba => new uint4(a, r, b, a);

        /// <summary>Gets the <c>arar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arar => new uint4(a, r, a, r);
        /// <summary>Gets the <c>arag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arag => new uint4(a, r, a, g);
        /// <summary>Gets the <c>arab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 arab => new uint4(a, r, a, b);
        /// <summary>Gets the <c>araa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 araa => new uint4(a, r, a, a);

        // ag
        /// <summary>Gets the <c>agrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agrr => new uint4(a, g, r, r);
        /// <summary>Gets the <c>agrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agrg => new uint4(a, g, r, g);
        /// <summary>Gets the <c>agrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agrb => new uint4(a, g, r, b);
        /// <summary>Gets the <c>agra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agra => new uint4(a, g, r, a);

        /// <summary>Gets the <c>aggr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aggr => new uint4(a, g, g, r);
        /// <summary>Gets the <c>aggg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aggg => new uint4(a, g, g, g);
        /// <summary>Gets the <c>aggb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aggb => new uint4(a, g, g, b);
        /// <summary>Gets the <c>agga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agga => new uint4(a, g, g, a);

        /// <summary>Gets the <c>agbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agbr => new uint4(a, g, b, r);
        /// <summary>Gets the <c>agbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agbg => new uint4(a, g, b, g);
        /// <summary>Gets the <c>agbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agbb => new uint4(a, g, b, b);
        /// <summary>Gets the <c>agba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agba => new uint4(a, g, b, a);

        /// <summary>Gets the <c>agar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agar => new uint4(a, g, a, r);
        /// <summary>Gets the <c>agag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agag => new uint4(a, g, a, g);
        /// <summary>Gets the <c>agab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agab => new uint4(a, g, a, b);
        /// <summary>Gets the <c>agaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 agaa => new uint4(a, g, a, a);

        // ab
        /// <summary>Gets the <c>abrr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abrr => new uint4(a, b, r, r);
        /// <summary>Gets the <c>abrg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abrg => new uint4(a, b, r, g);
        /// <summary>Gets the <c>abrb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abrb => new uint4(a, b, r, b);
        /// <summary>Gets the <c>abra</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abra => new uint4(a, b, r, a);

        /// <summary>Gets the <c>abgr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abgr => new uint4(a, b, g, r);
        /// <summary>Gets the <c>abgg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abgg => new uint4(a, b, g, g);
        /// <summary>Gets the <c>abgb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abgb => new uint4(a, b, g, b);
        /// <summary>Gets the <c>abga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abga => new uint4(a, b, g, a);

        /// <summary>Gets the <c>abbr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abbr => new uint4(a, b, b, r);
        /// <summary>Gets the <c>abbg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abbg => new uint4(a, b, b, g);
        /// <summary>Gets the <c>abbb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abbb => new uint4(a, b, b, b);
        /// <summary>Gets the <c>abba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abba => new uint4(a, b, b, a);

        /// <summary>Gets the <c>abar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abar => new uint4(a, b, a, r);
        /// <summary>Gets the <c>abag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abag => new uint4(a, b, a, g);
        /// <summary>Gets the <c>abab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abab => new uint4(a, b, a, b);
        /// <summary>Gets the <c>abaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 abaa => new uint4(a, b, a, a);

        // aa
        /// <summary>Gets the <c>aarr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aarr => new uint4(a, a, r, r);
        /// <summary>Gets the <c>aarg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aarg => new uint4(a, a, r, g);
        /// <summary>Gets the <c>aarb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aarb => new uint4(a, a, r, b);
        /// <summary>Gets the <c>aara</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aara => new uint4(a, a, r, a);

        /// <summary>Gets the <c>aagr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aagr => new uint4(a, a, g, r);
        /// <summary>Gets the <c>aagg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aagg => new uint4(a, a, g, g);
        /// <summary>Gets the <c>aagb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aagb => new uint4(a, a, g, b);
        /// <summary>Gets the <c>aaga</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aaga => new uint4(a, a, g, a);

        /// <summary>Gets the <c>aabr</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aabr => new uint4(a, a, b, r);
        /// <summary>Gets the <c>aabg</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aabg => new uint4(a, a, b, g);
        /// <summary>Gets the <c>aabb</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aabb => new uint4(a, a, b, b);
        /// <summary>Gets the <c>aaba</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aaba => new uint4(a, a, b, a);

        /// <summary>Gets the <c>aaar</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aaar => new uint4(a, a, a, r);
        /// <summary>Gets the <c>aaag</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aaag => new uint4(a, a, a, g);
        /// <summary>Gets the <c>aaab</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aaab => new uint4(a, a, a, b);
        /// <summary>Gets the <c>aaaa</c> swizzle of the vector as a <see cref="uint4"/>.</summary>
        public readonly uint4 aaaa => new uint4(a, a, a, a);

        #endregion Swizzles_uint4_RGBA
        #region Swizzles_Extra

        // Swizzles - uint3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xxx => new uint3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xxy => new uint3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xxz => new uint3(x, x, z);
        /// <summary>Gets the <c>xxw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xxw => new uint3(x, x, w);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xyx => new uint3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xyy => new uint3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xyz => new uint3(x, y, z);
        /// <summary>Gets the <c>xyw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xyw => new uint3(x, y, w);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xzx => new uint3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xzy => new uint3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xzz => new uint3(x, z, z);
        /// <summary>Gets the <c>xzw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xzw => new uint3(x, z, w);

        /// <summary>Gets the <c>xwx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xwx => new uint3(x, w, x);
        /// <summary>Gets the <c>xwy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xwy => new uint3(x, w, y);
        /// <summary>Gets the <c>xwz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xwz => new uint3(x, w, z);
        /// <summary>Gets the <c>xww</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xww => new uint3(x, w, w);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yxx => new uint3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yxy => new uint3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yxz => new uint3(y, x, z);
        /// <summary>Gets the <c>yxw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yxw => new uint3(y, x, w);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yyx => new uint3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yyy => new uint3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yyz => new uint3(y, y, z);
        /// <summary>Gets the <c>yyw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yyw => new uint3(y, y, w);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yzx => new uint3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yzy => new uint3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yzz => new uint3(y, z, z);
        /// <summary>Gets the <c>yzw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yzw => new uint3(y, z, w);

        /// <summary>Gets the <c>ywx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ywx => new uint3(y, w, x);
        /// <summary>Gets the <c>ywy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ywy => new uint3(y, w, y);
        /// <summary>Gets the <c>ywz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ywz => new uint3(y, w, z);
        /// <summary>Gets the <c>yww</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yww => new uint3(y, w, w);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zxx => new uint3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zxy => new uint3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zxz => new uint3(z, x, z);
        /// <summary>Gets the <c>zxw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zxw => new uint3(z, x, w);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zyx => new uint3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zyy => new uint3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zyz => new uint3(z, y, z);
        /// <summary>Gets the <c>zyw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zyw => new uint3(z, y, w);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zzx => new uint3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zzy => new uint3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zzz => new uint3(z, z, z);
        /// <summary>Gets the <c>zzw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zzw => new uint3(z, z, w);

        /// <summary>Gets the <c>zwx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zwx => new uint3(z, w, x);
        /// <summary>Gets the <c>zwy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zwy => new uint3(z, w, y);
        /// <summary>Gets the <c>zwz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zwz => new uint3(z, w, z);
        /// <summary>Gets the <c>zww</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zww => new uint3(z, w, w);

        // w
        /// <summary>Gets the <c>wxx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wxx => new uint3(w, x, x);
        /// <summary>Gets the <c>wxy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wxy => new uint3(w, x, y);
        /// <summary>Gets the <c>wxz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wxz => new uint3(w, x, z);
        /// <summary>Gets the <c>wxw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wxw => new uint3(w, x, w);

        /// <summary>Gets the <c>wyx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wyx => new uint3(w, y, x);
        /// <summary>Gets the <c>wyy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wyy => new uint3(w, y, y);
        /// <summary>Gets the <c>wyz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wyz => new uint3(w, y, z);
        /// <summary>Gets the <c>wyw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wyw => new uint3(w, y, w);

        /// <summary>Gets the <c>wzx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wzx => new uint3(w, z, x);
        /// <summary>Gets the <c>wzy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wzy => new uint3(w, z, y);
        /// <summary>Gets the <c>wzz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wzz => new uint3(w, z, z);
        /// <summary>Gets the <c>wzw</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wzw => new uint3(w, z, w);

        /// <summary>Gets the <c>wwx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wwx => new uint3(w, w, x);
        /// <summary>Gets the <c>wwy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wwy => new uint3(w, w, y);
        /// <summary>Gets the <c>wwz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 wwz => new uint3(w, w, z);
        /// <summary>Gets the <c>www</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 www => new uint3(w, w, w);

        // Swizzles - uint2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 xx => new uint2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 xy => new uint2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 xz => new uint2(x, z);
        /// <summary>Gets the <c>xw</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 xw => new uint2(x, w);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 yx => new uint2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 yy => new uint2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 yz => new uint2(y, z);
        /// <summary>Gets the <c>yw</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 yw => new uint2(y, w);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 zx => new uint2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 zy => new uint2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 zz => new uint2(z, z);
        /// <summary>Gets the <c>zw</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 zw => new uint2(z, w);

        /// <summary>Gets the <c>wx</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 wx => new uint2(w, x);
        /// <summary>Gets the <c>wy</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 wy => new uint2(w, y);
        /// <summary>Gets the <c>wz</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 wz => new uint2(w, z);
        /// <summary>Gets the <c>ww</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 ww => new uint2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - uint3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rrr => new uint3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rrg => new uint3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rrb => new uint3(r, r, b);
        /// <summary>Gets the <c>rra</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rra => new uint3(r, r, a);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rgr => new uint3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rgg => new uint3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rgb => new uint3(r, g, b);
        /// <summary>Gets the <c>rga</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rga => new uint3(r, g, a);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rbr => new uint3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rbg => new uint3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rbb => new uint3(r, b, b);
        /// <summary>Gets the <c>rba</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rba => new uint3(r, b, a);

        /// <summary>Gets the <c>rar</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rar => new uint3(r, a, r);
        /// <summary>Gets the <c>rag</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rag => new uint3(r, a, g);
        /// <summary>Gets the <c>rab</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rab => new uint3(r, a, b);
        /// <summary>Gets the <c>raa</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 raa => new uint3(r, a, a);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 grr => new uint3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 grg => new uint3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 grb => new uint3(g, r, b);
        /// <summary>Gets the <c>gra</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gra => new uint3(g, r, a);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ggr => new uint3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ggg => new uint3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ggb => new uint3(g, g, b);
        /// <summary>Gets the <c>gga</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gga => new uint3(g, g, a);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gbr => new uint3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gbg => new uint3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gbb => new uint3(g, b, b);
        /// <summary>Gets the <c>gba</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gba => new uint3(g, b, a);

        /// <summary>Gets the <c>gar</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gar => new uint3(g, a, r);
        /// <summary>Gets the <c>gag</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gag => new uint3(g, a, g);
        /// <summary>Gets the <c>gab</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gab => new uint3(g, a, b);
        /// <summary>Gets the <c>gaa</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gaa => new uint3(g, a, a);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 brr => new uint3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 brg => new uint3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 brb => new uint3(b, r, b);
        /// <summary>Gets the <c>bra</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bra => new uint3(b, r, a);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bgr => new uint3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bgg => new uint3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bgb => new uint3(b, g, b);
        /// <summary>Gets the <c>bga</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bga => new uint3(b, g, a);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bbr => new uint3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bbg => new uint3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bbb => new uint3(b, b, b);
        /// <summary>Gets the <c>bba</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bba => new uint3(b, b, a);

        /// <summary>Gets the <c>bar</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bar => new uint3(b, a, r);
        /// <summary>Gets the <c>bag</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bag => new uint3(b, a, g);
        /// <summary>Gets the <c>bab</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bab => new uint3(b, a, b);
        /// <summary>Gets the <c>baa</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 baa => new uint3(b, a, a);

        // a
        /// <summary>Gets the <c>arr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 arr => new uint3(a, r, r);
        /// <summary>Gets the <c>arg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 arg => new uint3(a, r, g);
        /// <summary>Gets the <c>arb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 arb => new uint3(a, r, b);
        /// <summary>Gets the <c>ara</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ara => new uint3(a, r, a);

        /// <summary>Gets the <c>agr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 agr => new uint3(a, g, r);
        /// <summary>Gets the <c>agg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 agg => new uint3(a, g, g);
        /// <summary>Gets the <c>agb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 agb => new uint3(a, g, b);
        /// <summary>Gets the <c>aga</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 aga => new uint3(a, g, a);

        /// <summary>Gets the <c>abr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 abr => new uint3(a, b, r);
        /// <summary>Gets the <c>abg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 abg => new uint3(a, b, g);
        /// <summary>Gets the <c>abb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 abb => new uint3(a, b, b);
        /// <summary>Gets the <c>aba</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 aba => new uint3(a, b, a);

        /// <summary>Gets the <c>aar</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 aar => new uint3(a, a, r);
        /// <summary>Gets the <c>aag</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 aag => new uint3(a, a, g);
        /// <summary>Gets the <c>aab</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 aab => new uint3(a, a, b);
        /// <summary>Gets the <c>aaa</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 aaa => new uint3(a, a, a);

        // RGBA - Swizzles - uint2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 rr => new uint2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 rg => new uint2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 rb => new uint2(r, b);
        /// <summary>Gets the <c>ra</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 ra => new uint2(r, a);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 gr => new uint2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 gg => new uint2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 gb => new uint2(g, b);
        /// <summary>Gets the <c>ga</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 ga => new uint2(g, a);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 br => new uint2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 bg => new uint2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 bb => new uint2(b, b);
        /// <summary>Gets the <c>ba</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 ba => new uint2(b, a);

        /// <summary>Gets the <c>ar</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 ar => new uint2(a, r);
        /// <summary>Gets the <c>ag</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 ag => new uint2(a, g);
        /// <summary>Gets the <c>ab</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 ab => new uint2(a, b);
        /// <summary>Gets the <c>aa</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 aa => new uint2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
