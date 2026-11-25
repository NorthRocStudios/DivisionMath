//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
namespace DivisionEngine.MathLib
{
    public partial struct bool4
    {
        #region Swizzles_bool4

        // Swizzles - bool4

        // x
        // xx
        /// <summary>Gets the <c>xxxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxxx => new bool4(x, x, x, x);
        /// <summary>Gets the <c>xxxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxxy => new bool4(x, x, x, y);
        /// <summary>Gets the <c>xxxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxxz => new bool4(x, x, x, z);
        /// <summary>Gets the <c>xxxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxxw => new bool4(x, x, x, w);

        /// <summary>Gets the <c>xxyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxyx => new bool4(x, x, y, x);
        /// <summary>Gets the <c>xxyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxyy => new bool4(x, x, y, y);
        /// <summary>Gets the <c>xxyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxyz => new bool4(x, x, y, z);
        /// <summary>Gets the <c>xxyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxyw => new bool4(x, x, y, w);

        /// <summary>Gets the <c>xxzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxzx => new bool4(x, x, z, x);
        /// <summary>Gets the <c>xxzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxzy => new bool4(x, x, z, y);
        /// <summary>Gets the <c>xxzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxzz => new bool4(x, x, z, z);
        /// <summary>Gets the <c>xxzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxzw => new bool4(x, x, z, w);

        /// <summary>Gets the <c>xxwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxwx => new bool4(x, x, w, x);
        /// <summary>Gets the <c>xxwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxwy => new bool4(x, x, w, y);
        /// <summary>Gets the <c>xxwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxwz => new bool4(x, x, w, z);
        /// <summary>Gets the <c>xxww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xxww => new bool4(x, x, w, w);

        // xy
        /// <summary>Gets the <c>xyxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyxx => new bool4(x, y, x, x);
        /// <summary>Gets the <c>xyxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyxy => new bool4(x, y, x, y);
        /// <summary>Gets the <c>xyxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyxz => new bool4(x, y, x, z);
        /// <summary>Gets the <c>xyxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyxw => new bool4(x, y, x, w);

        /// <summary>Gets the <c>xyyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyyx => new bool4(x, y, y, x);
        /// <summary>Gets the <c>xyyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyyy => new bool4(x, y, y, y);
        /// <summary>Gets the <c>xyyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyyz => new bool4(x, y, y, z);
        /// <summary>Gets the <c>xyyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyyw => new bool4(x, y, y, w);

        /// <summary>Gets the <c>xyzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyzx => new bool4(x, y, z, x);
        /// <summary>Gets the <c>xyzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyzy => new bool4(x, y, z, y);
        /// <summary>Gets the <c>xyzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyzz => new bool4(x, y, z, z);
        /// <summary>Gets the <c>xyzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyzw => new bool4(x, y, z, w);

        /// <summary>Gets the <c>xywx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xywx => new bool4(x, y, w, x);
        /// <summary>Gets the <c>xywy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xywy => new bool4(x, y, w, y);
        /// <summary>Gets the <c>xywz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xywz => new bool4(x, y, w, z);
        /// <summary>Gets the <c>xyww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xyww => new bool4(x, y, w, w);

        // xz
        /// <summary>Gets the <c>xzxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzxx => new bool4(x, z, x, x);
        /// <summary>Gets the <c>xzxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzxy => new bool4(x, z, x, y);
        /// <summary>Gets the <c>xzxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzxz => new bool4(x, z, x, z);
        /// <summary>Gets the <c>xzxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzxw => new bool4(x, z, x, w);

        /// <summary>Gets the <c>xzyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzyx => new bool4(x, z, y, x);
        /// <summary>Gets the <c>xzyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzyy => new bool4(x, z, y, y);
        /// <summary>Gets the <c>xzyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzyz => new bool4(x, z, y, z);
        /// <summary>Gets the <c>xzyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzyw => new bool4(x, z, y, w);

        /// <summary>Gets the <c>xzzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzzx => new bool4(x, z, z, x);
        /// <summary>Gets the <c>xzzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzzy => new bool4(x, z, z, y);
        /// <summary>Gets the <c>xzzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzzz => new bool4(x, z, z, z);
        /// <summary>Gets the <c>xzzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzzw => new bool4(x, z, z, w);

        /// <summary>Gets the <c>xzwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzwx => new bool4(x, z, w, x);
        /// <summary>Gets the <c>xzwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzwy => new bool4(x, z, w, y);
        /// <summary>Gets the <c>xzwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzwz => new bool4(x, z, w, z);
        /// <summary>Gets the <c>xzww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xzww => new bool4(x, z, w, w);

        // xw
        /// <summary>Gets the <c>xwxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwxx => new bool4(x, w, x, x);
        /// <summary>Gets the <c>xwxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwxy => new bool4(x, w, x, y);
        /// <summary>Gets the <c>xwxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwxz => new bool4(x, w, x, z);
        /// <summary>Gets the <c>xwxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwxw => new bool4(x, w, x, w);

        /// <summary>Gets the <c>xwyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwyx => new bool4(x, w, y, x);
        /// <summary>Gets the <c>xwyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwyy => new bool4(x, w, y, y);
        /// <summary>Gets the <c>xwyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwyz => new bool4(x, w, y, z);
        /// <summary>Gets the <c>xwyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwyw => new bool4(x, w, y, w);

        /// <summary>Gets the <c>xwzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwzx => new bool4(x, w, z, x);
        /// <summary>Gets the <c>xwzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwzy => new bool4(x, w, z, y);
        /// <summary>Gets the <c>xwzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwzz => new bool4(x, w, z, z);
        /// <summary>Gets the <c>xwzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwzw => new bool4(x, w, z, w);

        /// <summary>Gets the <c>xwwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwwx => new bool4(x, w, w, x);
        /// <summary>Gets the <c>xwwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwwy => new bool4(x, w, w, y);
        /// <summary>Gets the <c>xwwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwwz => new bool4(x, w, w, z);
        /// <summary>Gets the <c>xwww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 xwww => new bool4(x, w, w, w);


        // y
        // yx
        /// <summary>Gets the <c>yxxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxxx => new bool4(y, x, x, x);
        /// <summary>Gets the <c>yxxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxxy => new bool4(y, x, x, y);
        /// <summary>Gets the <c>yxxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxxz => new bool4(y, x, x, z);
        /// <summary>Gets the <c>yxxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxxw => new bool4(y, x, x, w);

        /// <summary>Gets the <c>yxyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxyx => new bool4(y, x, y, x);
        /// <summary>Gets the <c>yxyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxyy => new bool4(y, x, y, y);
        /// <summary>Gets the <c>yxyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxyz => new bool4(y, x, y, z);
        /// <summary>Gets the <c>yxyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxyw => new bool4(y, x, y, w);

        /// <summary>Gets the <c>yxzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxzx => new bool4(y, x, z, x);
        /// <summary>Gets the <c>yxzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxzy => new bool4(y, x, z, y);
        /// <summary>Gets the <c>yxzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxzz => new bool4(y, x, z, z);
        /// <summary>Gets the <c>yxzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxzw => new bool4(y, x, z, w);

        /// <summary>Gets the <c>yxwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxwx => new bool4(y, x, w, x);
        /// <summary>Gets the <c>yxwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxwy => new bool4(y, x, w, y);
        /// <summary>Gets the <c>yxwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxwz => new bool4(y, x, w, z);
        /// <summary>Gets the <c>yxww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yxww => new bool4(y, x, w, w);

        // yy
        /// <summary>Gets the <c>yyxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyxx => new bool4(y, y, x, x);
        /// <summary>Gets the <c>yyxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyxy => new bool4(y, y, x, y);
        /// <summary>Gets the <c>yyxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyxz => new bool4(y, y, x, z);
        /// <summary>Gets the <c>yyxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyxw => new bool4(y, y, x, w);

        /// <summary>Gets the <c>yyyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyyx => new bool4(y, y, y, x);
        /// <summary>Gets the <c>yyyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyyy => new bool4(y, y, y, y);
        /// <summary>Gets the <c>yyyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyyz => new bool4(y, y, y, z);
        /// <summary>Gets the <c>yyyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyyw => new bool4(y, y, y, w);

        /// <summary>Gets the <c>yyzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyzx => new bool4(y, y, z, x);
        /// <summary>Gets the <c>yyzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyzy => new bool4(y, y, z, y);
        /// <summary>Gets the <c>yyzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyzz => new bool4(y, y, z, z);
        /// <summary>Gets the <c>yyzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyzw => new bool4(y, y, z, w);

        /// <summary>Gets the <c>yywx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yywx => new bool4(y, y, w, x);
        /// <summary>Gets the <c>yywy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yywy => new bool4(y, y, w, y);
        /// <summary>Gets the <c>yywz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yywz => new bool4(y, y, w, z);
        /// <summary>Gets the <c>yyww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yyww => new bool4(y, y, w, w);

        // yz
        /// <summary>Gets the <c>yzxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzxx => new bool4(y, z, x, x);
        /// <summary>Gets the <c>yzxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzxy => new bool4(y, z, x, y);
        /// <summary>Gets the <c>yzxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzxz => new bool4(y, z, x, z);
        /// <summary>Gets the <c>yzxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzxw => new bool4(y, z, x, w);

        /// <summary>Gets the <c>yzyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzyx => new bool4(y, z, y, x);
        /// <summary>Gets the <c>yzyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzyy => new bool4(y, z, y, y);
        /// <summary>Gets the <c>yzyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzyz => new bool4(y, z, y, z);
        /// <summary>Gets the <c>yzyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzyw => new bool4(y, z, y, w);

        /// <summary>Gets the <c>yzzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzzx => new bool4(y, z, z, x);
        /// <summary>Gets the <c>yzzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzzy => new bool4(y, z, z, y);
        /// <summary>Gets the <c>yzzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzzz => new bool4(y, z, z, z);
        /// <summary>Gets the <c>yzzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzzw => new bool4(y, z, z, w);

        /// <summary>Gets the <c>yzwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzwx => new bool4(y, z, w, x);
        /// <summary>Gets the <c>yzwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzwy => new bool4(y, z, w, y);
        /// <summary>Gets the <c>yzwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzwz => new bool4(y, z, w, z);
        /// <summary>Gets the <c>yzww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 yzww => new bool4(y, z, w, w);

        // yw
        /// <summary>Gets the <c>ywxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywxx => new bool4(y, w, x, x);
        /// <summary>Gets the <c>ywxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywxy => new bool4(y, w, x, y);
        /// <summary>Gets the <c>ywxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywxz => new bool4(y, w, x, z);
        /// <summary>Gets the <c>ywxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywxw => new bool4(y, w, x, w);

        /// <summary>Gets the <c>ywyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywyx => new bool4(y, w, y, x);
        /// <summary>Gets the <c>ywyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywyy => new bool4(y, w, y, y);
        /// <summary>Gets the <c>ywyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywyz => new bool4(y, w, y, z);
        /// <summary>Gets the <c>ywyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywyw => new bool4(y, w, y, w);

        /// <summary>Gets the <c>ywzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywzx => new bool4(y, w, z, x);
        /// <summary>Gets the <c>ywzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywzy => new bool4(y, w, z, y);
        /// <summary>Gets the <c>ywzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywzz => new bool4(y, w, z, z);
        /// <summary>Gets the <c>ywzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywzw => new bool4(y, w, z, w);

        /// <summary>Gets the <c>ywwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywwx => new bool4(y, w, w, x);
        /// <summary>Gets the <c>ywwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywwy => new bool4(y, w, w, y);
        /// <summary>Gets the <c>ywwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywwz => new bool4(y, w, w, z);
        /// <summary>Gets the <c>ywww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ywww => new bool4(y, w, w, w);


        // z
        // zx
        /// <summary>Gets the <c>zxxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxxx => new bool4(z, x, x, x);
        /// <summary>Gets the <c>zxxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxxy => new bool4(z, x, x, y);
        /// <summary>Gets the <c>zxxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxxz => new bool4(z, x, x, z);
        /// <summary>Gets the <c>zxxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxxw => new bool4(z, x, x, w);

        /// <summary>Gets the <c>zxyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxyx => new bool4(z, x, y, x);
        /// <summary>Gets the <c>zxyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxyy => new bool4(z, x, y, y);
        /// <summary>Gets the <c>zxyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxyz => new bool4(z, x, y, z);
        /// <summary>Gets the <c>zxyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxyw => new bool4(z, x, y, w);

        /// <summary>Gets the <c>zxzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxzx => new bool4(z, x, z, x);
        /// <summary>Gets the <c>zxzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxzy => new bool4(z, x, z, y);
        /// <summary>Gets the <c>zxzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxzz => new bool4(z, x, z, z);
        /// <summary>Gets the <c>zxzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxzw => new bool4(z, x, z, w);

        /// <summary>Gets the <c>zxwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxwx => new bool4(z, x, w, x);
        /// <summary>Gets the <c>zxwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxwy => new bool4(z, x, w, y);
        /// <summary>Gets the <c>zxwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxwz => new bool4(z, x, w, z);
        /// <summary>Gets the <c>zxww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zxww => new bool4(z, x, w, w);

        // zy
        /// <summary>Gets the <c>zyxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyxx => new bool4(z, y, x, x);
        /// <summary>Gets the <c>zyxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyxy => new bool4(z, y, x, y);
        /// <summary>Gets the <c>zyxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyxz => new bool4(z, y, x, z);
        /// <summary>Gets the <c>zyxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyxw => new bool4(z, y, x, w);

        /// <summary>Gets the <c>zyyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyyx => new bool4(z, y, y, x);
        /// <summary>Gets the <c>zyyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyyy => new bool4(z, y, y, y);
        /// <summary>Gets the <c>zyyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyyz => new bool4(z, y, y, z);
        /// <summary>Gets the <c>zyyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyyw => new bool4(z, y, y, w);

        /// <summary>Gets the <c>zyzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyzx => new bool4(z, y, z, x);
        /// <summary>Gets the <c>zyzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyzy => new bool4(z, y, z, y);
        /// <summary>Gets the <c>zyzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyzz => new bool4(z, y, z, z);
        /// <summary>Gets the <c>zyzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyzw => new bool4(z, y, z, w);

        /// <summary>Gets the <c>zywx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zywx => new bool4(z, y, w, x);
        /// <summary>Gets the <c>zywy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zywy => new bool4(z, y, w, y);
        /// <summary>Gets the <c>zywz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zywz => new bool4(z, y, w, z);
        /// <summary>Gets the <c>zyww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zyww => new bool4(z, y, w, w);

        // zz
        /// <summary>Gets the <c>zzxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzxx => new bool4(z, z, x, x);
        /// <summary>Gets the <c>zzxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzxy => new bool4(z, z, x, y);
        /// <summary>Gets the <c>zzxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzxz => new bool4(z, z, x, z);
        /// <summary>Gets the <c>zzxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzxw => new bool4(z, z, x, w);

        /// <summary>Gets the <c>zzyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzyx => new bool4(z, z, y, x);
        /// <summary>Gets the <c>zzyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzyy => new bool4(z, z, y, y);
        /// <summary>Gets the <c>zzyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzyz => new bool4(z, z, y, z);
        /// <summary>Gets the <c>zzyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzyw => new bool4(z, z, y, w);

        /// <summary>Gets the <c>zzzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzzx => new bool4(z, z, z, x);
        /// <summary>Gets the <c>zzzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzzy => new bool4(z, z, z, y);
        /// <summary>Gets the <c>zzzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzzz => new bool4(z, z, z, z);
        /// <summary>Gets the <c>zzzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzzw => new bool4(z, z, z, w);

        /// <summary>Gets the <c>zzwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzwx => new bool4(z, z, w, x);
        /// <summary>Gets the <c>zzwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzwy => new bool4(z, z, w, y);
        /// <summary>Gets the <c>zzwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzwz => new bool4(z, z, w, z);
        /// <summary>Gets the <c>zzww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zzww => new bool4(z, z, w, w);

        // zw
        /// <summary>Gets the <c>zwxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwxx => new bool4(z, w, x, x);
        /// <summary>Gets the <c>zwxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwxy => new bool4(z, w, x, y);
        /// <summary>Gets the <c>zwxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwxz => new bool4(z, w, x, z);
        /// <summary>Gets the <c>zwxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwxw => new bool4(z, w, x, w);

        /// <summary>Gets the <c>zwyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwyx => new bool4(z, w, y, x);
        /// <summary>Gets the <c>zwyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwyy => new bool4(z, w, y, y);
        /// <summary>Gets the <c>zwyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwyz => new bool4(z, w, y, z);
        /// <summary>Gets the <c>zwyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwyw => new bool4(z, w, y, w);

        /// <summary>Gets the <c>zwzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwzx => new bool4(z, w, z, x);
        /// <summary>Gets the <c>zwzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwzy => new bool4(z, w, z, y);
        /// <summary>Gets the <c>zwzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwzz => new bool4(z, w, z, z);
        /// <summary>Gets the <c>zwzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwzw => new bool4(z, w, z, w);

        /// <summary>Gets the <c>zwwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwwx => new bool4(z, w, w, x);
        /// <summary>Gets the <c>zwwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwwy => new bool4(z, w, w, y);
        /// <summary>Gets the <c>zwwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwwz => new bool4(z, w, w, z);
        /// <summary>Gets the <c>zwww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 zwww => new bool4(z, w, w, w);


        // w
        // wx
        /// <summary>Gets the <c>wxxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxxx => new bool4(w, x, x, x);
        /// <summary>Gets the <c>wxxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxxy => new bool4(w, x, x, y);
        /// <summary>Gets the <c>wxxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxxz => new bool4(w, x, x, z);
        /// <summary>Gets the <c>wxxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxxw => new bool4(w, x, x, w);

        /// <summary>Gets the <c>wxyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxyx => new bool4(w, x, y, x);
        /// <summary>Gets the <c>wxyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxyy => new bool4(w, x, y, y);
        /// <summary>Gets the <c>wxyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxyz => new bool4(w, x, y, z);
        /// <summary>Gets the <c>wxyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxyw => new bool4(w, x, y, w);

        /// <summary>Gets the <c>wxzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxzx => new bool4(w, x, z, x);
        /// <summary>Gets the <c>wxzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxzy => new bool4(w, x, z, y);
        /// <summary>Gets the <c>wxzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxzz => new bool4(w, x, z, z);
        /// <summary>Gets the <c>wxzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxzw => new bool4(w, x, z, w);

        /// <summary>Gets the <c>wxwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxwx => new bool4(w, x, w, x);
        /// <summary>Gets the <c>wxwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxwy => new bool4(w, x, w, y);
        /// <summary>Gets the <c>wxwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxwz => new bool4(w, x, w, z);
        /// <summary>Gets the <c>wxww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wxww => new bool4(w, x, w, w);

        // wy
        /// <summary>Gets the <c>wyxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyxx => new bool4(w, y, x, x);
        /// <summary>Gets the <c>wyxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyxy => new bool4(w, y, x, y);
        /// <summary>Gets the <c>wyxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyxz => new bool4(w, y, x, z);
        /// <summary>Gets the <c>wyxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyxw => new bool4(w, y, x, w);

        /// <summary>Gets the <c>wyyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyyx => new bool4(w, y, y, x);
        /// <summary>Gets the <c>wyyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyyy => new bool4(w, y, y, y);
        /// <summary>Gets the <c>wyyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyyz => new bool4(w, y, y, z);
        /// <summary>Gets the <c>wyyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyyw => new bool4(w, y, y, w);

        /// <summary>Gets the <c>wyzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyzx => new bool4(w, y, z, x);
        /// <summary>Gets the <c>wyzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyzy => new bool4(w, y, z, y);
        /// <summary>Gets the <c>wyzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyzz => new bool4(w, y, z, z);
        /// <summary>Gets the <c>wyzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyzw => new bool4(w, y, z, w);

        /// <summary>Gets the <c>wywx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wywx => new bool4(w, y, w, x);
        /// <summary>Gets the <c>wywy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wywy => new bool4(w, y, w, y);
        /// <summary>Gets the <c>wywz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wywz => new bool4(w, y, w, z);
        /// <summary>Gets the <c>wyww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wyww => new bool4(w, y, w, w);

        // wz
        /// <summary>Gets the <c>wzxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzxx => new bool4(w, z, x, x);
        /// <summary>Gets the <c>wzxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzxy => new bool4(w, z, x, y);
        /// <summary>Gets the <c>wzxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzxz => new bool4(w, z, x, z);
        /// <summary>Gets the <c>wzxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzxw => new bool4(w, z, x, w);

        /// <summary>Gets the <c>wzyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzyx => new bool4(w, z, y, x);
        /// <summary>Gets the <c>wzyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzyy => new bool4(w, z, y, y);
        /// <summary>Gets the <c>wzyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzyz => new bool4(w, z, y, z);
        /// <summary>Gets the <c>wzyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzyw => new bool4(w, z, y, w);

        /// <summary>Gets the <c>wzzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzzx => new bool4(w, z, z, x);
        /// <summary>Gets the <c>wzzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzzy => new bool4(w, z, z, y);
        /// <summary>Gets the <c>wzzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzzz => new bool4(w, z, z, z);
        /// <summary>Gets the <c>wzzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzzw => new bool4(w, z, z, w);

        /// <summary>Gets the <c>wzwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzwx => new bool4(w, z, w, x);
        /// <summary>Gets the <c>wzwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzwy => new bool4(w, z, w, y);
        /// <summary>Gets the <c>wzwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzwz => new bool4(w, z, w, z);
        /// <summary>Gets the <c>wzww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wzww => new bool4(w, z, w, w);

        // ww
        /// <summary>Gets the <c>wwxx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwxx => new bool4(w, w, x, x);
        /// <summary>Gets the <c>wwxy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwxy => new bool4(w, w, x, y);
        /// <summary>Gets the <c>wwxz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwxz => new bool4(w, w, x, z);
        /// <summary>Gets the <c>wwxw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwxw => new bool4(w, w, x, w);

        /// <summary>Gets the <c>wwyx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwyx => new bool4(w, w, y, x);
        /// <summary>Gets the <c>wwyy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwyy => new bool4(w, w, y, y);
        /// <summary>Gets the <c>wwyz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwyz => new bool4(w, w, y, z);
        /// <summary>Gets the <c>wwyw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwyw => new bool4(w, w, y, w);

        /// <summary>Gets the <c>wwzx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwzx => new bool4(w, w, z, x);
        /// <summary>Gets the <c>wwzy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwzy => new bool4(w, w, z, y);
        /// <summary>Gets the <c>wwzz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwzz => new bool4(w, w, z, z);
        /// <summary>Gets the <c>wwzw</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwzw => new bool4(w, w, z, w);

        /// <summary>Gets the <c>wwwx</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwwx => new bool4(w, w, w, x);
        /// <summary>Gets the <c>wwwy</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwwy => new bool4(w, w, w, y);
        /// <summary>Gets the <c>wwwz</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwwz => new bool4(w, w, w, z);
        /// <summary>Gets the <c>wwww</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 wwww => new bool4(w, w, w, w);

        #endregion Swizzles_bool4
        #region Swizzles_bool4_RGBA

        // RGBA - Swizzles - bool4

        // r
        // rr
        /// <summary>Gets the <c>rrrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrrr => new bool4(r, r, r, r);
        /// <summary>Gets the <c>rrrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrrg => new bool4(r, r, r, g);
        /// <summary>Gets the <c>rrrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrrb => new bool4(r, r, r, b);
        /// <summary>Gets the <c>rrra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrra => new bool4(r, r, r, a);

        /// <summary>Gets the <c>rrgr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrgr => new bool4(r, r, g, r);
        /// <summary>Gets the <c>rrgg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrgg => new bool4(r, r, g, g);
        /// <summary>Gets the <c>rrgb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrgb => new bool4(r, r, g, b);
        /// <summary>Gets the <c>rrga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrga => new bool4(r, r, g, a);

        /// <summary>Gets the <c>rrbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrbr => new bool4(r, r, b, r);
        /// <summary>Gets the <c>rrbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrbg => new bool4(r, r, b, g);
        /// <summary>Gets the <c>rrbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrbb => new bool4(r, r, b, b);
        /// <summary>Gets the <c>rrba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrba => new bool4(r, r, b, a);

        /// <summary>Gets the <c>rrar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrar => new bool4(r, r, a, r);
        /// <summary>Gets the <c>rrag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrag => new bool4(r, r, a, g);
        /// <summary>Gets the <c>rrab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rrab => new bool4(r, r, a, b);
        /// <summary>Gets the <c>rraa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rraa => new bool4(r, r, a, a);

        // rg
        /// <summary>Gets the <c>rgrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgrr => new bool4(r, g, r, r);
        /// <summary>Gets the <c>rgrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgrg => new bool4(r, g, r, g);
        /// <summary>Gets the <c>rgrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgrb => new bool4(r, g, r, b);
        /// <summary>Gets the <c>rgra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgra => new bool4(r, g, r, a);

        /// <summary>Gets the <c>rggr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rggr => new bool4(r, g, g, r);
        /// <summary>Gets the <c>rggg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rggg => new bool4(r, g, g, g);
        /// <summary>Gets the <c>rggb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rggb => new bool4(r, g, g, b);
        /// <summary>Gets the <c>rgga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgga => new bool4(r, g, g, a);

        /// <summary>Gets the <c>rgbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgbr => new bool4(r, g, b, r);
        /// <summary>Gets the <c>rgbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgbg => new bool4(r, g, b, g);
        /// <summary>Gets the <c>rgbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgbb => new bool4(r, g, b, b);
        /// <summary>Gets the <c>rgba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgba => new bool4(r, g, b, a);

        /// <summary>Gets the <c>rgar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgar => new bool4(r, g, a, r);
        /// <summary>Gets the <c>rgag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgag => new bool4(r, g, a, g);
        /// <summary>Gets the <c>rgab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgab => new bool4(r, g, a, b);
        /// <summary>Gets the <c>rgaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rgaa => new bool4(r, g, a, a);

        // rb
        /// <summary>Gets the <c>rbrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbrr => new bool4(r, b, r, r);
        /// <summary>Gets the <c>rbrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbrg => new bool4(r, b, r, g);
        /// <summary>Gets the <c>rbrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbrb => new bool4(r, b, r, b);
        /// <summary>Gets the <c>rbra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbra => new bool4(r, b, r, a);

        /// <summary>Gets the <c>rbgr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbgr => new bool4(r, b, g, r);
        /// <summary>Gets the <c>rbgg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbgg => new bool4(r, b, g, g);
        /// <summary>Gets the <c>rbgb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbgb => new bool4(r, b, g, b);
        /// <summary>Gets the <c>rbga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbga => new bool4(r, b, g, a);

        /// <summary>Gets the <c>rbbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbbr => new bool4(r, b, b, r);
        /// <summary>Gets the <c>rbbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbbg => new bool4(r, b, b, g);
        /// <summary>Gets the <c>rbbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbbb => new bool4(r, b, b, b);
        /// <summary>Gets the <c>rbba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbba => new bool4(r, b, b, a);

        /// <summary>Gets the <c>rbar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbar => new bool4(r, b, a, r);
        /// <summary>Gets the <c>rbag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbag => new bool4(r, b, a, g);
        /// <summary>Gets the <c>rbab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbab => new bool4(r, b, a, b);
        /// <summary>Gets the <c>rbaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rbaa => new bool4(r, b, a, a);

        // ra
        /// <summary>Gets the <c>rarr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rarr => new bool4(r, a, r, r);
        /// <summary>Gets the <c>rarg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rarg => new bool4(r, a, r, g);
        /// <summary>Gets the <c>rarb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rarb => new bool4(r, a, r, b);
        /// <summary>Gets the <c>rara</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rara => new bool4(r, a, r, a);

        /// <summary>Gets the <c>ragr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ragr => new bool4(r, a, g, r);
        /// <summary>Gets the <c>ragg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ragg => new bool4(r, a, g, g);
        /// <summary>Gets the <c>ragb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ragb => new bool4(r, a, g, b);
        /// <summary>Gets the <c>raga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 raga => new bool4(r, a, g, a);

        /// <summary>Gets the <c>rabr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rabr => new bool4(r, a, b, r);
        /// <summary>Gets the <c>rabg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rabg => new bool4(r, a, b, g);
        /// <summary>Gets the <c>rabb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 rabb => new bool4(r, a, b, b);
        /// <summary>Gets the <c>raba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 raba => new bool4(r, a, b, a);

        /// <summary>Gets the <c>raar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 raar => new bool4(r, a, a, r);
        /// <summary>Gets the <c>raag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 raag => new bool4(r, a, a, g);
        /// <summary>Gets the <c>raab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 raab => new bool4(r, a, a, b);
        /// <summary>Gets the <c>raaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 raaa => new bool4(r, a, a, a);


        // g
        // gr
        /// <summary>Gets the <c>grrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grrr => new bool4(g, r, r, r);
        /// <summary>Gets the <c>grrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grrg => new bool4(g, r, r, g);
        /// <summary>Gets the <c>grrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grrb => new bool4(g, r, r, b);
        /// <summary>Gets the <c>grra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grra => new bool4(g, r, r, a);

        /// <summary>Gets the <c>grgr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grgr => new bool4(g, r, g, r);
        /// <summary>Gets the <c>grgg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grgg => new bool4(g, r, g, g);
        /// <summary>Gets the <c>grgb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grgb => new bool4(g, r, g, b);
        /// <summary>Gets the <c>grga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grga => new bool4(g, r, g, a);

        /// <summary>Gets the <c>grbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grbr => new bool4(g, r, b, r);
        /// <summary>Gets the <c>grbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grbg => new bool4(g, r, b, g);
        /// <summary>Gets the <c>grbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grbb => new bool4(g, r, b, b);
        /// <summary>Gets the <c>grba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grba => new bool4(g, r, b, a);

        /// <summary>Gets the <c>grar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grar => new bool4(g, r, a, r);
        /// <summary>Gets the <c>grag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grag => new bool4(g, r, a, g);
        /// <summary>Gets the <c>grab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 grab => new bool4(g, r, a, b);
        /// <summary>Gets the <c>graa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 graa => new bool4(g, r, a, a);

        // gg
        /// <summary>Gets the <c>ggrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggrr => new bool4(g, g, r, r);
        /// <summary>Gets the <c>ggrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggrg => new bool4(g, g, r, g);
        /// <summary>Gets the <c>ggrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggrb => new bool4(g, g, r, b);
        /// <summary>Gets the <c>ggra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggra => new bool4(g, g, r, a);

        /// <summary>Gets the <c>gggr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gggr => new bool4(g, g, g, r);
        /// <summary>Gets the <c>gggg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gggg => new bool4(g, g, g, g);
        /// <summary>Gets the <c>gggb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gggb => new bool4(g, g, g, b);
        /// <summary>Gets the <c>ggga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggga => new bool4(g, g, g, a);

        /// <summary>Gets the <c>ggbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggbr => new bool4(g, g, b, r);
        /// <summary>Gets the <c>ggbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggbg => new bool4(g, g, b, g);
        /// <summary>Gets the <c>ggbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggbb => new bool4(g, g, b, b);
        /// <summary>Gets the <c>ggba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggba => new bool4(g, g, b, a);

        /// <summary>Gets the <c>ggar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggar => new bool4(g, g, a, r);
        /// <summary>Gets the <c>ggag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggag => new bool4(g, g, a, g);
        /// <summary>Gets the <c>ggab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggab => new bool4(g, g, a, b);
        /// <summary>Gets the <c>ggaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 ggaa => new bool4(g, g, a, a);

        // gb
        /// <summary>Gets the <c>gbrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbrr => new bool4(g, b, r, r);
        /// <summary>Gets the <c>gbrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbrg => new bool4(g, b, r, g);
        /// <summary>Gets the <c>gbrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbrb => new bool4(g, b, r, b);
        /// <summary>Gets the <c>gbra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbra => new bool4(g, b, r, a);

        /// <summary>Gets the <c>gbgr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbgr => new bool4(g, b, g, r);
        /// <summary>Gets the <c>gbgg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbgg => new bool4(g, b, g, g);
        /// <summary>Gets the <c>gbgb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbgb => new bool4(g, b, g, b);
        /// <summary>Gets the <c>gbga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbga => new bool4(g, b, g, a);

        /// <summary>Gets the <c>gbbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbbr => new bool4(g, b, b, r);
        /// <summary>Gets the <c>gbbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbbg => new bool4(g, b, b, g);
        /// <summary>Gets the <c>gbbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbbb => new bool4(g, b, b, b);
        /// <summary>Gets the <c>gbba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbba => new bool4(g, b, b, a);

        /// <summary>Gets the <c>gbar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbar => new bool4(g, b, a, r);
        /// <summary>Gets the <c>gbag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbag => new bool4(g, b, a, g);
        /// <summary>Gets the <c>gbab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbab => new bool4(g, b, a, b);
        /// <summary>Gets the <c>gbaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gbaa => new bool4(g, b, a, a);

        // ga
        /// <summary>Gets the <c>garr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 garr => new bool4(g, a, r, r);
        /// <summary>Gets the <c>garg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 garg => new bool4(g, a, r, g);
        /// <summary>Gets the <c>garb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 garb => new bool4(g, a, r, b);
        /// <summary>Gets the <c>gara</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gara => new bool4(g, a, r, a);

        /// <summary>Gets the <c>gagr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gagr => new bool4(g, a, g, r);
        /// <summary>Gets the <c>gagg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gagg => new bool4(g, a, g, g);
        /// <summary>Gets the <c>gagb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gagb => new bool4(g, a, g, b);
        /// <summary>Gets the <c>gaga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gaga => new bool4(g, a, g, a);

        /// <summary>Gets the <c>gabr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gabr => new bool4(g, a, b, r);
        /// <summary>Gets the <c>gabg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gabg => new bool4(g, a, b, g);
        /// <summary>Gets the <c>gabb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gabb => new bool4(g, a, b, b);
        /// <summary>Gets the <c>gaba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gaba => new bool4(g, a, b, a);

        /// <summary>Gets the <c>gaar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gaar => new bool4(g, a, a, r);
        /// <summary>Gets the <c>gaag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gaag => new bool4(g, a, a, g);
        /// <summary>Gets the <c>gaab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gaab => new bool4(g, a, a, b);
        /// <summary>Gets the <c>gaaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 gaaa => new bool4(g, a, a, a);


        // b
        // br
        /// <summary>Gets the <c>brrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brrr => new bool4(b, r, r, r);
        /// <summary>Gets the <c>brrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brrg => new bool4(b, r, r, g);
        /// <summary>Gets the <c>brrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brrb => new bool4(b, r, r, b);
        /// <summary>Gets the <c>brra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brra => new bool4(b, r, r, a);

        /// <summary>Gets the <c>brgr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brgr => new bool4(b, r, g, r);
        /// <summary>Gets the <c>brgg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brgg => new bool4(b, r, g, g);
        /// <summary>Gets the <c>brgb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brgb => new bool4(b, r, g, b);
        /// <summary>Gets the <c>brga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brga => new bool4(b, r, g, a);

        /// <summary>Gets the <c>brbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brbr => new bool4(b, r, b, r);
        /// <summary>Gets the <c>brbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brbg => new bool4(b, r, b, g);
        /// <summary>Gets the <c>brbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brbb => new bool4(b, r, b, b);
        /// <summary>Gets the <c>brba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brba => new bool4(b, r, b, a);

        /// <summary>Gets the <c>brar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brar => new bool4(b, r, a, r);
        /// <summary>Gets the <c>brag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brag => new bool4(b, r, a, g);
        /// <summary>Gets the <c>brab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 brab => new bool4(b, r, a, b);
        /// <summary>Gets the <c>braa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 braa => new bool4(b, r, a, a);

        // bg
        /// <summary>Gets the <c>bgrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgrr => new bool4(b, g, r, r);
        /// <summary>Gets the <c>bgrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgrg => new bool4(b, g, r, g);
        /// <summary>Gets the <c>bgrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgrb => new bool4(b, g, r, b);
        /// <summary>Gets the <c>bgra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgra => new bool4(b, g, r, a);

        /// <summary>Gets the <c>bggr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bggr => new bool4(b, g, g, r);
        /// <summary>Gets the <c>bggg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bggg => new bool4(b, g, g, g);
        /// <summary>Gets the <c>bggb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bggb => new bool4(b, g, g, b);
        /// <summary>Gets the <c>bgga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgga => new bool4(b, g, g, a);

        /// <summary>Gets the <c>bgbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgbr => new bool4(b, g, b, r);
        /// <summary>Gets the <c>bgbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgbg => new bool4(b, g, b, g);
        /// <summary>Gets the <c>bgbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgbb => new bool4(b, g, b, b);
        /// <summary>Gets the <c>bgba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgba => new bool4(b, g, b, a);

        /// <summary>Gets the <c>bgar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgar => new bool4(b, g, a, r);
        /// <summary>Gets the <c>bgag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgag => new bool4(b, g, a, g);
        /// <summary>Gets the <c>bgab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgab => new bool4(b, g, a, b);
        /// <summary>Gets the <c>bgaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bgaa => new bool4(b, g, a, a);

        // bb
        /// <summary>Gets the <c>bbrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbrr => new bool4(b, b, r, r);
        /// <summary>Gets the <c>bbrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbrg => new bool4(b, b, r, g);
        /// <summary>Gets the <c>bbrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbrb => new bool4(b, b, r, b);
        /// <summary>Gets the <c>bbra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbra => new bool4(b, b, r, a);

        /// <summary>Gets the <c>bbgr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbgr => new bool4(b, b, g, r);
        /// <summary>Gets the <c>bbgg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbgg => new bool4(b, b, g, g);
        /// <summary>Gets the <c>bbgb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbgb => new bool4(b, b, g, b);
        /// <summary>Gets the <c>bbga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbga => new bool4(b, b, g, a);

        /// <summary>Gets the <c>bbbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbbr => new bool4(b, b, b, r);
        /// <summary>Gets the <c>bbbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbbg => new bool4(b, b, b, g);
        /// <summary>Gets the <c>bbbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbbb => new bool4(b, b, b, b);
        /// <summary>Gets the <c>bbba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbba => new bool4(b, b, b, a);

        /// <summary>Gets the <c>bbar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbar => new bool4(b, b, a, r);
        /// <summary>Gets the <c>bbag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbag => new bool4(b, b, a, g);
        /// <summary>Gets the <c>bbab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbab => new bool4(b, b, a, b);
        /// <summary>Gets the <c>bbaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bbaa => new bool4(b, b, a, a);

        // ba
        /// <summary>Gets the <c>barr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 barr => new bool4(b, a, r, r);
        /// <summary>Gets the <c>barg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 barg => new bool4(b, a, r, g);
        /// <summary>Gets the <c>barb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 barb => new bool4(b, a, r, b);
        /// <summary>Gets the <c>bara</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bara => new bool4(b, a, r, a);

        /// <summary>Gets the <c>bagr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bagr => new bool4(b, a, g, r);
        /// <summary>Gets the <c>bagg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bagg => new bool4(b, a, g, g);
        /// <summary>Gets the <c>bagb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 bagb => new bool4(b, a, g, b);
        /// <summary>Gets the <c>baga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 baga => new bool4(b, a, g, a);

        /// <summary>Gets the <c>babr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 babr => new bool4(b, a, b, r);
        /// <summary>Gets the <c>babg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 babg => new bool4(b, a, b, g);
        /// <summary>Gets the <c>babb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 babb => new bool4(b, a, b, b);
        /// <summary>Gets the <c>baba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 baba => new bool4(b, a, b, a);

        /// <summary>Gets the <c>baar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 baar => new bool4(b, a, a, r);
        /// <summary>Gets the <c>baag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 baag => new bool4(b, a, a, g);
        /// <summary>Gets the <c>baab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 baab => new bool4(b, a, a, b);
        /// <summary>Gets the <c>baaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 baaa => new bool4(b, a, a, a);


        // a
        // ar
        /// <summary>Gets the <c>arrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arrr => new bool4(a, r, r, r);
        /// <summary>Gets the <c>arrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arrg => new bool4(a, r, r, g);
        /// <summary>Gets the <c>arrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arrb => new bool4(a, r, r, b);
        /// <summary>Gets the <c>arra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arra => new bool4(a, r, r, a);

        /// <summary>Gets the <c>argr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 argr => new bool4(a, r, g, r);
        /// <summary>Gets the <c>argg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 argg => new bool4(a, r, g, g);
        /// <summary>Gets the <c>argb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 argb => new bool4(a, r, g, b);
        /// <summary>Gets the <c>arga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arga => new bool4(a, r, g, a);

        /// <summary>Gets the <c>arbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arbr => new bool4(a, r, b, r);
        /// <summary>Gets the <c>arbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arbg => new bool4(a, r, b, g);
        /// <summary>Gets the <c>arbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arbb => new bool4(a, r, b, b);
        /// <summary>Gets the <c>arba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arba => new bool4(a, r, b, a);

        /// <summary>Gets the <c>arar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arar => new bool4(a, r, a, r);
        /// <summary>Gets the <c>arag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arag => new bool4(a, r, a, g);
        /// <summary>Gets the <c>arab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 arab => new bool4(a, r, a, b);
        /// <summary>Gets the <c>araa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 araa => new bool4(a, r, a, a);

        // ag
        /// <summary>Gets the <c>agrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agrr => new bool4(a, g, r, r);
        /// <summary>Gets the <c>agrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agrg => new bool4(a, g, r, g);
        /// <summary>Gets the <c>agrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agrb => new bool4(a, g, r, b);
        /// <summary>Gets the <c>agra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agra => new bool4(a, g, r, a);

        /// <summary>Gets the <c>aggr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aggr => new bool4(a, g, g, r);
        /// <summary>Gets the <c>aggg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aggg => new bool4(a, g, g, g);
        /// <summary>Gets the <c>aggb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aggb => new bool4(a, g, g, b);
        /// <summary>Gets the <c>agga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agga => new bool4(a, g, g, a);

        /// <summary>Gets the <c>agbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agbr => new bool4(a, g, b, r);
        /// <summary>Gets the <c>agbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agbg => new bool4(a, g, b, g);
        /// <summary>Gets the <c>agbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agbb => new bool4(a, g, b, b);
        /// <summary>Gets the <c>agba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agba => new bool4(a, g, b, a);

        /// <summary>Gets the <c>agar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agar => new bool4(a, g, a, r);
        /// <summary>Gets the <c>agag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agag => new bool4(a, g, a, g);
        /// <summary>Gets the <c>agab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agab => new bool4(a, g, a, b);
        /// <summary>Gets the <c>agaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 agaa => new bool4(a, g, a, a);

        // ab
        /// <summary>Gets the <c>abrr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abrr => new bool4(a, b, r, r);
        /// <summary>Gets the <c>abrg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abrg => new bool4(a, b, r, g);
        /// <summary>Gets the <c>abrb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abrb => new bool4(a, b, r, b);
        /// <summary>Gets the <c>abra</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abra => new bool4(a, b, r, a);

        /// <summary>Gets the <c>abgr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abgr => new bool4(a, b, g, r);
        /// <summary>Gets the <c>abgg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abgg => new bool4(a, b, g, g);
        /// <summary>Gets the <c>abgb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abgb => new bool4(a, b, g, b);
        /// <summary>Gets the <c>abga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abga => new bool4(a, b, g, a);

        /// <summary>Gets the <c>abbr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abbr => new bool4(a, b, b, r);
        /// <summary>Gets the <c>abbg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abbg => new bool4(a, b, b, g);
        /// <summary>Gets the <c>abbb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abbb => new bool4(a, b, b, b);
        /// <summary>Gets the <c>abba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abba => new bool4(a, b, b, a);

        /// <summary>Gets the <c>abar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abar => new bool4(a, b, a, r);
        /// <summary>Gets the <c>abag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abag => new bool4(a, b, a, g);
        /// <summary>Gets the <c>abab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abab => new bool4(a, b, a, b);
        /// <summary>Gets the <c>abaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 abaa => new bool4(a, b, a, a);

        // aa
        /// <summary>Gets the <c>aarr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aarr => new bool4(a, a, r, r);
        /// <summary>Gets the <c>aarg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aarg => new bool4(a, a, r, g);
        /// <summary>Gets the <c>aarb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aarb => new bool4(a, a, r, b);
        /// <summary>Gets the <c>aara</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aara => new bool4(a, a, r, a);

        /// <summary>Gets the <c>aagr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aagr => new bool4(a, a, g, r);
        /// <summary>Gets the <c>aagg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aagg => new bool4(a, a, g, g);
        /// <summary>Gets the <c>aagb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aagb => new bool4(a, a, g, b);
        /// <summary>Gets the <c>aaga</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aaga => new bool4(a, a, g, a);

        /// <summary>Gets the <c>aabr</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aabr => new bool4(a, a, b, r);
        /// <summary>Gets the <c>aabg</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aabg => new bool4(a, a, b, g);
        /// <summary>Gets the <c>aabb</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aabb => new bool4(a, a, b, b);
        /// <summary>Gets the <c>aaba</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aaba => new bool4(a, a, b, a);

        /// <summary>Gets the <c>aaar</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aaar => new bool4(a, a, a, r);
        /// <summary>Gets the <c>aaag</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aaag => new bool4(a, a, a, g);
        /// <summary>Gets the <c>aaab</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aaab => new bool4(a, a, a, b);
        /// <summary>Gets the <c>aaaa</c> swizzle of the vector as a <see cref="bool4"/>.</summary>
        public readonly bool4 aaaa => new bool4(a, a, a, a);

        #endregion Swizzles_bool4_RGBA
        #region Swizzles_Extra

        // Swizzles - bool3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xxx => new bool3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xxy => new bool3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xxz => new bool3(x, x, z);
        /// <summary>Gets the <c>xxw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xxw => new bool3(x, x, w);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xyx => new bool3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xyy => new bool3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xyz => new bool3(x, y, z);
        /// <summary>Gets the <c>xyw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xyw => new bool3(x, y, w);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xzx => new bool3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xzy => new bool3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xzz => new bool3(x, z, z);
        /// <summary>Gets the <c>xzw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xzw => new bool3(x, z, w);

        /// <summary>Gets the <c>xwx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xwx => new bool3(x, w, x);
        /// <summary>Gets the <c>xwy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xwy => new bool3(x, w, y);
        /// <summary>Gets the <c>xwz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xwz => new bool3(x, w, z);
        /// <summary>Gets the <c>xww</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xww => new bool3(x, w, w);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yxx => new bool3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yxy => new bool3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yxz => new bool3(y, x, z);
        /// <summary>Gets the <c>yxw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yxw => new bool3(y, x, w);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yyx => new bool3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yyy => new bool3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yyz => new bool3(y, y, z);
        /// <summary>Gets the <c>yyw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yyw => new bool3(y, y, w);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yzx => new bool3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yzy => new bool3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yzz => new bool3(y, z, z);
        /// <summary>Gets the <c>yzw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yzw => new bool3(y, z, w);

        /// <summary>Gets the <c>ywx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ywx => new bool3(y, w, x);
        /// <summary>Gets the <c>ywy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ywy => new bool3(y, w, y);
        /// <summary>Gets the <c>ywz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ywz => new bool3(y, w, z);
        /// <summary>Gets the <c>yww</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yww => new bool3(y, w, w);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zxx => new bool3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zxy => new bool3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zxz => new bool3(z, x, z);
        /// <summary>Gets the <c>zxw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zxw => new bool3(z, x, w);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zyx => new bool3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zyy => new bool3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zyz => new bool3(z, y, z);
        /// <summary>Gets the <c>zyw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zyw => new bool3(z, y, w);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zzx => new bool3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zzy => new bool3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zzz => new bool3(z, z, z);
        /// <summary>Gets the <c>zzw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zzw => new bool3(z, z, w);

        /// <summary>Gets the <c>zwx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zwx => new bool3(z, w, x);
        /// <summary>Gets the <c>zwy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zwy => new bool3(z, w, y);
        /// <summary>Gets the <c>zwz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zwz => new bool3(z, w, z);
        /// <summary>Gets the <c>zww</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zww => new bool3(z, w, w);

        // w
        /// <summary>Gets the <c>wxx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wxx => new bool3(w, x, x);
        /// <summary>Gets the <c>wxy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wxy => new bool3(w, x, y);
        /// <summary>Gets the <c>wxz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wxz => new bool3(w, x, z);
        /// <summary>Gets the <c>wxw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wxw => new bool3(w, x, w);

        /// <summary>Gets the <c>wyx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wyx => new bool3(w, y, x);
        /// <summary>Gets the <c>wyy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wyy => new bool3(w, y, y);
        /// <summary>Gets the <c>wyz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wyz => new bool3(w, y, z);
        /// <summary>Gets the <c>wyw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wyw => new bool3(w, y, w);

        /// <summary>Gets the <c>wzx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wzx => new bool3(w, z, x);
        /// <summary>Gets the <c>wzy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wzy => new bool3(w, z, y);
        /// <summary>Gets the <c>wzz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wzz => new bool3(w, z, z);
        /// <summary>Gets the <c>wzw</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wzw => new bool3(w, z, w);

        /// <summary>Gets the <c>wwx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wwx => new bool3(w, w, x);
        /// <summary>Gets the <c>wwy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wwy => new bool3(w, w, y);
        /// <summary>Gets the <c>wwz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 wwz => new bool3(w, w, z);
        /// <summary>Gets the <c>www</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 www => new bool3(w, w, w);

        // Swizzles - bool2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xx => new bool2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xy => new bool2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xz => new bool2(x, z);
        /// <summary>Gets the <c>xw</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xw => new bool2(x, w);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yx => new bool2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yy => new bool2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yz => new bool2(y, z);
        /// <summary>Gets the <c>yw</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yw => new bool2(y, w);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 zx => new bool2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 zy => new bool2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 zz => new bool2(z, z);
        /// <summary>Gets the <c>zw</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 zw => new bool2(z, w);

        /// <summary>Gets the <c>wx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 wx => new bool2(w, x);
        /// <summary>Gets the <c>wy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 wy => new bool2(w, y);
        /// <summary>Gets the <c>wz</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 wz => new bool2(w, z);
        /// <summary>Gets the <c>ww</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 ww => new bool2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - bool3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rrr => new bool3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rrg => new bool3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rrb => new bool3(r, r, b);
        /// <summary>Gets the <c>rra</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rra => new bool3(r, r, a);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rgr => new bool3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rgg => new bool3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rgb => new bool3(r, g, b);
        /// <summary>Gets the <c>rga</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rga => new bool3(r, g, a);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rbr => new bool3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rbg => new bool3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rbb => new bool3(r, b, b);
        /// <summary>Gets the <c>rba</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rba => new bool3(r, b, a);

        /// <summary>Gets the <c>rar</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rar => new bool3(r, a, r);
        /// <summary>Gets the <c>rag</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rag => new bool3(r, a, g);
        /// <summary>Gets the <c>rab</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rab => new bool3(r, a, b);
        /// <summary>Gets the <c>raa</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 raa => new bool3(r, a, a);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 grr => new bool3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 grg => new bool3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 grb => new bool3(g, r, b);
        /// <summary>Gets the <c>gra</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gra => new bool3(g, r, a);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ggr => new bool3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ggg => new bool3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ggb => new bool3(g, g, b);
        /// <summary>Gets the <c>gga</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gga => new bool3(g, g, a);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gbr => new bool3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gbg => new bool3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gbb => new bool3(g, b, b);
        /// <summary>Gets the <c>gba</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gba => new bool3(g, b, a);

        /// <summary>Gets the <c>gar</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gar => new bool3(g, a, r);
        /// <summary>Gets the <c>gag</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gag => new bool3(g, a, g);
        /// <summary>Gets the <c>gab</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gab => new bool3(g, a, b);
        /// <summary>Gets the <c>gaa</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gaa => new bool3(g, a, a);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 brr => new bool3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 brg => new bool3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 brb => new bool3(b, r, b);
        /// <summary>Gets the <c>bra</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bra => new bool3(b, r, a);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bgr => new bool3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bgg => new bool3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bgb => new bool3(b, g, b);
        /// <summary>Gets the <c>bga</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bga => new bool3(b, g, a);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bbr => new bool3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bbg => new bool3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bbb => new bool3(b, b, b);
        /// <summary>Gets the <c>bba</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bba => new bool3(b, b, a);

        /// <summary>Gets the <c>bar</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bar => new bool3(b, a, r);
        /// <summary>Gets the <c>bag</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bag => new bool3(b, a, g);
        /// <summary>Gets the <c>bab</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bab => new bool3(b, a, b);
        /// <summary>Gets the <c>baa</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 baa => new bool3(b, a, a);

        // a
        /// <summary>Gets the <c>arr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 arr => new bool3(a, r, r);
        /// <summary>Gets the <c>arg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 arg => new bool3(a, r, g);
        /// <summary>Gets the <c>arb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 arb => new bool3(a, r, b);
        /// <summary>Gets the <c>ara</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ara => new bool3(a, r, a);

        /// <summary>Gets the <c>agr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 agr => new bool3(a, g, r);
        /// <summary>Gets the <c>agg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 agg => new bool3(a, g, g);
        /// <summary>Gets the <c>agb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 agb => new bool3(a, g, b);
        /// <summary>Gets the <c>aga</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 aga => new bool3(a, g, a);

        /// <summary>Gets the <c>abr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 abr => new bool3(a, b, r);
        /// <summary>Gets the <c>abg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 abg => new bool3(a, b, g);
        /// <summary>Gets the <c>abb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 abb => new bool3(a, b, b);
        /// <summary>Gets the <c>aba</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 aba => new bool3(a, b, a);

        /// <summary>Gets the <c>aar</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 aar => new bool3(a, a, r);
        /// <summary>Gets the <c>aag</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 aag => new bool3(a, a, g);
        /// <summary>Gets the <c>aab</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 aab => new bool3(a, a, b);
        /// <summary>Gets the <c>aaa</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 aaa => new bool3(a, a, a);

        // RGBA - Swizzles - bool2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rr => new bool2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rg => new bool2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rb => new bool2(r, b);
        /// <summary>Gets the <c>ra</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 ra => new bool2(r, a);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gr => new bool2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gg => new bool2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gb => new bool2(g, b);
        /// <summary>Gets the <c>ga</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 ga => new bool2(g, a);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 br => new bool2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 bg => new bool2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 bb => new bool2(b, b);
        /// <summary>Gets the <c>ba</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 ba => new bool2(b, a);

        /// <summary>Gets the <c>ar</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 ar => new bool2(a, r);
        /// <summary>Gets the <c>ag</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 ag => new bool2(a, g);
        /// <summary>Gets the <c>ab</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 ab => new bool2(a, b);
        /// <summary>Gets the <c>aa</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 aa => new bool2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
