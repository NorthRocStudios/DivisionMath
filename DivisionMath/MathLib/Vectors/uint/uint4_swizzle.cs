namespace DivisionEngine.MathLib
{
    public partial struct uint4
    {
        #region Swizzles_uint4

        // Swizzles - uint4

        // x
        // xx
        public readonly uint4 xxxx => new uint4(x, x, x, x);
        public readonly uint4 xxxy => new uint4(x, x, x, y);
        public readonly uint4 xxxz => new uint4(x, x, x, z);
        public readonly uint4 xxxw => new uint4(x, x, x, w);

        public readonly uint4 xxyx => new uint4(x, x, y, x);
        public readonly uint4 xxyy => new uint4(x, x, y, y);
        public readonly uint4 xxyz => new uint4(x, x, y, z);
        public readonly uint4 xxyw => new uint4(x, x, y, w);

        public readonly uint4 xxzx => new uint4(x, x, z, x);
        public readonly uint4 xxzy => new uint4(x, x, z, y);
        public readonly uint4 xxzz => new uint4(x, x, z, z);
        public readonly uint4 xxzw => new uint4(x, x, z, w);

        public readonly uint4 xxwx => new uint4(x, x, w, x);
        public readonly uint4 xxwy => new uint4(x, x, w, y);
        public readonly uint4 xxwz => new uint4(x, x, w, z);
        public readonly uint4 xxww => new uint4(x, x, w, w);

        // xy
        public readonly uint4 xyxx => new uint4(x, y, x, x);
        public readonly uint4 xyxy => new uint4(x, y, x, y);
        public readonly uint4 xyxz => new uint4(x, y, x, z);
        public readonly uint4 xyxw => new uint4(x, y, x, w);

        public readonly uint4 xyyx => new uint4(x, y, y, x);
        public readonly uint4 xyyy => new uint4(x, y, y, y);
        public readonly uint4 xyyz => new uint4(x, y, y, z);
        public readonly uint4 xyyw => new uint4(x, y, y, w);

        public readonly uint4 xyzx => new uint4(x, y, z, x);
        public readonly uint4 xyzy => new uint4(x, y, z, y);
        public readonly uint4 xyzz => new uint4(x, y, z, z);
        public readonly uint4 xyzw => new uint4(x, y, z, w);

        public readonly uint4 xywx => new uint4(x, y, w, x);
        public readonly uint4 xywy => new uint4(x, y, w, y);
        public readonly uint4 xywz => new uint4(x, y, w, z);
        public readonly uint4 xyww => new uint4(x, y, w, w);

        // xz
        public readonly uint4 xzxx => new uint4(x, z, x, x);
        public readonly uint4 xzxy => new uint4(x, z, x, y);
        public readonly uint4 xzxz => new uint4(x, z, x, z);
        public readonly uint4 xzxw => new uint4(x, z, x, w);

        public readonly uint4 xzyx => new uint4(x, z, y, x);
        public readonly uint4 xzyy => new uint4(x, z, y, y);
        public readonly uint4 xzyz => new uint4(x, z, y, z);
        public readonly uint4 xzyw => new uint4(x, z, y, w);

        public readonly uint4 xzzx => new uint4(x, z, z, x);
        public readonly uint4 xzzy => new uint4(x, z, z, y);
        public readonly uint4 xzzz => new uint4(x, z, z, z);
        public readonly uint4 xzzw => new uint4(x, z, z, w);

        public readonly uint4 xzwx => new uint4(x, z, w, x);
        public readonly uint4 xzwy => new uint4(x, z, w, y);
        public readonly uint4 xzwz => new uint4(x, z, w, z);
        public readonly uint4 xzww => new uint4(x, z, w, w);

        // xw
        public readonly uint4 xwxx => new uint4(x, w, x, x);
        public readonly uint4 xwxy => new uint4(x, w, x, y);
        public readonly uint4 xwxz => new uint4(x, w, x, z);
        public readonly uint4 xwxw => new uint4(x, w, x, w);

        public readonly uint4 xwyx => new uint4(x, w, y, x);
        public readonly uint4 xwyy => new uint4(x, w, y, y);
        public readonly uint4 xwyz => new uint4(x, w, y, z);
        public readonly uint4 xwyw => new uint4(x, w, y, w);

        public readonly uint4 xwzx => new uint4(x, w, z, x);
        public readonly uint4 xwzy => new uint4(x, w, z, y);
        public readonly uint4 xwzz => new uint4(x, w, z, z);
        public readonly uint4 xwzw => new uint4(x, w, z, w);

        public readonly uint4 xwwx => new uint4(x, w, w, x);
        public readonly uint4 xwwy => new uint4(x, w, w, y);
        public readonly uint4 xwwz => new uint4(x, w, w, z);
        public readonly uint4 xwww => new uint4(x, w, w, w);


        // y
        // yx
        public readonly uint4 yxxx => new uint4(y, x, x, x);
        public readonly uint4 yxxy => new uint4(y, x, x, y);
        public readonly uint4 yxxz => new uint4(y, x, x, z);
        public readonly uint4 yxxw => new uint4(y, x, x, w);

        public readonly uint4 yxyx => new uint4(y, x, y, x);
        public readonly uint4 yxyy => new uint4(y, x, y, y);
        public readonly uint4 yxyz => new uint4(y, x, y, z);
        public readonly uint4 yxyw => new uint4(y, x, y, w);

        public readonly uint4 yxzx => new uint4(y, x, z, x);
        public readonly uint4 yxzy => new uint4(y, x, z, y);
        public readonly uint4 yxzz => new uint4(y, x, z, z);
        public readonly uint4 yxzw => new uint4(y, x, z, w);

        public readonly uint4 yxwx => new uint4(y, x, w, x);
        public readonly uint4 yxwy => new uint4(y, x, w, y);
        public readonly uint4 yxwz => new uint4(y, x, w, z);
        public readonly uint4 yxww => new uint4(y, x, w, w);

        // yy
        public readonly uint4 yyxx => new uint4(y, y, x, x);
        public readonly uint4 yyxy => new uint4(y, y, x, y);
        public readonly uint4 yyxz => new uint4(y, y, x, z);
        public readonly uint4 yyxw => new uint4(y, y, x, w);

        public readonly uint4 yyyx => new uint4(y, y, y, x);
        public readonly uint4 yyyy => new uint4(y, y, y, y);
        public readonly uint4 yyyz => new uint4(y, y, y, z);
        public readonly uint4 yyyw => new uint4(y, y, y, w);

        public readonly uint4 yyzx => new uint4(y, y, z, x);
        public readonly uint4 yyzy => new uint4(y, y, z, y);
        public readonly uint4 yyzz => new uint4(y, y, z, z);
        public readonly uint4 yyzw => new uint4(y, y, z, w);

        public readonly uint4 yywx => new uint4(y, y, w, x);
        public readonly uint4 yywy => new uint4(y, y, w, y);
        public readonly uint4 yywz => new uint4(y, y, w, z);
        public readonly uint4 yyww => new uint4(y, y, w, w);

        // yz
        public readonly uint4 yzxx => new uint4(y, z, x, x);
        public readonly uint4 yzxy => new uint4(y, z, x, y);
        public readonly uint4 yzxz => new uint4(y, z, x, z);
        public readonly uint4 yzxw => new uint4(y, z, x, w);

        public readonly uint4 yzyx => new uint4(y, z, y, x);
        public readonly uint4 yzyy => new uint4(y, z, y, y);
        public readonly uint4 yzyz => new uint4(y, z, y, z);
        public readonly uint4 yzyw => new uint4(y, z, y, w);

        public readonly uint4 yzzx => new uint4(y, z, z, x);
        public readonly uint4 yzzy => new uint4(y, z, z, y);
        public readonly uint4 yzzz => new uint4(y, z, z, z);
        public readonly uint4 yzzw => new uint4(y, z, z, w);

        public readonly uint4 yzwx => new uint4(y, z, w, x);
        public readonly uint4 yzwy => new uint4(y, z, w, y);
        public readonly uint4 yzwz => new uint4(y, z, w, z);
        public readonly uint4 yzww => new uint4(y, z, w, w);

        // yw
        public readonly uint4 ywxx => new uint4(y, w, x, x);
        public readonly uint4 ywxy => new uint4(y, w, x, y);
        public readonly uint4 ywxz => new uint4(y, w, x, z);
        public readonly uint4 ywxw => new uint4(y, w, x, w);

        public readonly uint4 ywyx => new uint4(y, w, y, x);
        public readonly uint4 ywyy => new uint4(y, w, y, y);
        public readonly uint4 ywyz => new uint4(y, w, y, z);
        public readonly uint4 ywyw => new uint4(y, w, y, w);

        public readonly uint4 ywzx => new uint4(y, w, z, x);
        public readonly uint4 ywzy => new uint4(y, w, z, y);
        public readonly uint4 ywzz => new uint4(y, w, z, z);
        public readonly uint4 ywzw => new uint4(y, w, z, w);

        public readonly uint4 ywwx => new uint4(y, w, w, x);
        public readonly uint4 ywwy => new uint4(y, w, w, y);
        public readonly uint4 ywwz => new uint4(y, w, w, z);
        public readonly uint4 ywww => new uint4(y, w, w, w);


        // z
        // zx
        public readonly uint4 zxxx => new uint4(z, x, x, x);
        public readonly uint4 zxxy => new uint4(z, x, x, y);
        public readonly uint4 zxxz => new uint4(z, x, x, z);
        public readonly uint4 zxxw => new uint4(z, x, x, w);

        public readonly uint4 zxyx => new uint4(z, x, y, x);
        public readonly uint4 zxyy => new uint4(z, x, y, y);
        public readonly uint4 zxyz => new uint4(z, x, y, z);
        public readonly uint4 zxyw => new uint4(z, x, y, w);

        public readonly uint4 zxzx => new uint4(z, x, z, x);
        public readonly uint4 zxzy => new uint4(z, x, z, y);
        public readonly uint4 zxzz => new uint4(z, x, z, z);
        public readonly uint4 zxzw => new uint4(z, x, z, w);

        public readonly uint4 zxwx => new uint4(z, x, w, x);
        public readonly uint4 zxwy => new uint4(z, x, w, y);
        public readonly uint4 zxwz => new uint4(z, x, w, z);
        public readonly uint4 zxww => new uint4(z, x, w, w);

        // zy
        public readonly uint4 zyxx => new uint4(z, y, x, x);
        public readonly uint4 zyxy => new uint4(z, y, x, y);
        public readonly uint4 zyxz => new uint4(z, y, x, z);
        public readonly uint4 zyxw => new uint4(z, y, x, w);

        public readonly uint4 zyyx => new uint4(z, y, y, x);
        public readonly uint4 zyyy => new uint4(z, y, y, y);
        public readonly uint4 zyyz => new uint4(z, y, y, z);
        public readonly uint4 zyyw => new uint4(z, y, y, w);

        public readonly uint4 zyzx => new uint4(z, y, z, x);
        public readonly uint4 zyzy => new uint4(z, y, z, y);
        public readonly uint4 zyzz => new uint4(z, y, z, z);
        public readonly uint4 zyzw => new uint4(z, y, z, w);

        public readonly uint4 zywx => new uint4(z, y, w, x);
        public readonly uint4 zywy => new uint4(z, y, w, y);
        public readonly uint4 zywz => new uint4(z, y, w, z);
        public readonly uint4 zyww => new uint4(z, y, w, w);

        // zz
        public readonly uint4 zzxx => new uint4(z, z, x, x);
        public readonly uint4 zzxy => new uint4(z, z, x, y);
        public readonly uint4 zzxz => new uint4(z, z, x, z);
        public readonly uint4 zzxw => new uint4(z, z, x, w);

        public readonly uint4 zzyx => new uint4(z, z, y, x);
        public readonly uint4 zzyy => new uint4(z, z, y, y);
        public readonly uint4 zzyz => new uint4(z, z, y, z);
        public readonly uint4 zzyw => new uint4(z, z, y, w);

        public readonly uint4 zzzx => new uint4(z, z, z, x);
        public readonly uint4 zzzy => new uint4(z, z, z, y);
        public readonly uint4 zzzz => new uint4(z, z, z, z);
        public readonly uint4 zzzw => new uint4(z, z, z, w);

        public readonly uint4 zzwx => new uint4(z, z, w, x);
        public readonly uint4 zzwy => new uint4(z, z, w, y);
        public readonly uint4 zzwz => new uint4(z, z, w, z);
        public readonly uint4 zzww => new uint4(z, z, w, w);

        // zw
        public readonly uint4 zwxx => new uint4(z, w, x, x);
        public readonly uint4 zwxy => new uint4(z, w, x, y);
        public readonly uint4 zwxz => new uint4(z, w, x, z);
        public readonly uint4 zwxw => new uint4(z, w, x, w);

        public readonly uint4 zwyx => new uint4(z, w, y, x);
        public readonly uint4 zwyy => new uint4(z, w, y, y);
        public readonly uint4 zwyz => new uint4(z, w, y, z);
        public readonly uint4 zwyw => new uint4(z, w, y, w);

        public readonly uint4 zwzx => new uint4(z, w, z, x);
        public readonly uint4 zwzy => new uint4(z, w, z, y);
        public readonly uint4 zwzz => new uint4(z, w, z, z);
        public readonly uint4 zwzw => new uint4(z, w, z, w);

        public readonly uint4 zwwx => new uint4(z, w, w, x);
        public readonly uint4 zwwy => new uint4(z, w, w, y);
        public readonly uint4 zwwz => new uint4(z, w, w, z);
        public readonly uint4 zwww => new uint4(z, w, w, w);


        // w
        // wx
        public readonly uint4 wxxx => new uint4(w, x, x, x);
        public readonly uint4 wxxy => new uint4(w, x, x, y);
        public readonly uint4 wxxz => new uint4(w, x, x, z);
        public readonly uint4 wxxw => new uint4(w, x, x, w);

        public readonly uint4 wxyx => new uint4(w, x, y, x);
        public readonly uint4 wxyy => new uint4(w, x, y, y);
        public readonly uint4 wxyz => new uint4(w, x, y, z);
        public readonly uint4 wxyw => new uint4(w, x, y, w);

        public readonly uint4 wxzx => new uint4(w, x, z, x);
        public readonly uint4 wxzy => new uint4(w, x, z, y);
        public readonly uint4 wxzz => new uint4(w, x, z, z);
        public readonly uint4 wxzw => new uint4(w, x, z, w);

        public readonly uint4 wxwx => new uint4(w, x, w, x);
        public readonly uint4 wxwy => new uint4(w, x, w, y);
        public readonly uint4 wxwz => new uint4(w, x, w, z);
        public readonly uint4 wxww => new uint4(w, x, w, w);

        // wy
        public readonly uint4 wyxx => new uint4(w, y, x, x);
        public readonly uint4 wyxy => new uint4(w, y, x, y);
        public readonly uint4 wyxz => new uint4(w, y, x, z);
        public readonly uint4 wyxw => new uint4(w, y, x, w);

        public readonly uint4 wyyx => new uint4(w, y, y, x);
        public readonly uint4 wyyy => new uint4(w, y, y, y);
        public readonly uint4 wyyz => new uint4(w, y, y, z);
        public readonly uint4 wyyw => new uint4(w, y, y, w);

        public readonly uint4 wyzx => new uint4(w, y, z, x);
        public readonly uint4 wyzy => new uint4(w, y, z, y);
        public readonly uint4 wyzz => new uint4(w, y, z, z);
        public readonly uint4 wyzw => new uint4(w, y, z, w);

        public readonly uint4 wywx => new uint4(w, y, w, x);
        public readonly uint4 wywy => new uint4(w, y, w, y);
        public readonly uint4 wywz => new uint4(w, y, w, z);
        public readonly uint4 wyww => new uint4(w, y, w, w);

        // wz
        public readonly uint4 wzxx => new uint4(w, z, x, x);
        public readonly uint4 wzxy => new uint4(w, z, x, y);
        public readonly uint4 wzxz => new uint4(w, z, x, z);
        public readonly uint4 wzxw => new uint4(w, z, x, w);

        public readonly uint4 wzyx => new uint4(w, z, y, x);
        public readonly uint4 wzyy => new uint4(w, z, y, y);
        public readonly uint4 wzyz => new uint4(w, z, y, z);
        public readonly uint4 wzyw => new uint4(w, z, y, w);

        public readonly uint4 wzzx => new uint4(w, z, z, x);
        public readonly uint4 wzzy => new uint4(w, z, z, y);
        public readonly uint4 wzzz => new uint4(w, z, z, z);
        public readonly uint4 wzzw => new uint4(w, z, z, w);

        public readonly uint4 wzwx => new uint4(w, z, w, x);
        public readonly uint4 wzwy => new uint4(w, z, w, y);
        public readonly uint4 wzwz => new uint4(w, z, w, z);
        public readonly uint4 wzww => new uint4(w, z, w, w);

        // ww
        public readonly uint4 wwxx => new uint4(w, w, x, x);
        public readonly uint4 wwxy => new uint4(w, w, x, y);
        public readonly uint4 wwxz => new uint4(w, w, x, z);
        public readonly uint4 wwxw => new uint4(w, w, x, w);

        public readonly uint4 wwyx => new uint4(w, w, y, x);
        public readonly uint4 wwyy => new uint4(w, w, y, y);
        public readonly uint4 wwyz => new uint4(w, w, y, z);
        public readonly uint4 wwyw => new uint4(w, w, y, w);

        public readonly uint4 wwzx => new uint4(w, w, z, x);
        public readonly uint4 wwzy => new uint4(w, w, z, y);
        public readonly uint4 wwzz => new uint4(w, w, z, z);
        public readonly uint4 wwzw => new uint4(w, w, z, w);

        public readonly uint4 wwwx => new uint4(w, w, w, x);
        public readonly uint4 wwwy => new uint4(w, w, w, y);
        public readonly uint4 wwwz => new uint4(w, w, w, z);
        public readonly uint4 wwww => new uint4(w, w, w, w);

        #endregion Swizzles_uint4
        #region Swizzles_uint4_RGBA

        // RGBA - Swizzles - uint4

        // r
        // rr
        public readonly uint4 rrrr => new uint4(r, r, r, r);
        public readonly uint4 rrrg => new uint4(r, r, r, g);
        public readonly uint4 rrrb => new uint4(r, r, r, b);
        public readonly uint4 rrra => new uint4(r, r, r, a);

        public readonly uint4 rrgr => new uint4(r, r, g, r);
        public readonly uint4 rrgg => new uint4(r, r, g, g);
        public readonly uint4 rrgb => new uint4(r, r, g, b);
        public readonly uint4 rrga => new uint4(r, r, g, a);

        public readonly uint4 rrbr => new uint4(r, r, b, r);
        public readonly uint4 rrbg => new uint4(r, r, b, g);
        public readonly uint4 rrbb => new uint4(r, r, b, b);
        public readonly uint4 rrba => new uint4(r, r, b, a);

        public readonly uint4 rrar => new uint4(r, r, a, r);
        public readonly uint4 rrag => new uint4(r, r, a, g);
        public readonly uint4 rrab => new uint4(r, r, a, b);
        public readonly uint4 rraa => new uint4(r, r, a, a);

        // rg
        public readonly uint4 rgrr => new uint4(r, g, r, r);
        public readonly uint4 rgrg => new uint4(r, g, r, g);
        public readonly uint4 rgrb => new uint4(r, g, r, b);
        public readonly uint4 rgra => new uint4(r, g, r, a);

        public readonly uint4 rggr => new uint4(r, g, g, r);
        public readonly uint4 rggg => new uint4(r, g, g, g);
        public readonly uint4 rggb => new uint4(r, g, g, b);
        public readonly uint4 rgga => new uint4(r, g, g, a);

        public readonly uint4 rgbr => new uint4(r, g, b, r);
        public readonly uint4 rgbg => new uint4(r, g, b, g);
        public readonly uint4 rgbb => new uint4(r, g, b, b);
        public readonly uint4 rgba => new uint4(r, g, b, a);

        public readonly uint4 rgar => new uint4(r, g, a, r);
        public readonly uint4 rgag => new uint4(r, g, a, g);
        public readonly uint4 rgab => new uint4(r, g, a, b);
        public readonly uint4 rgaa => new uint4(r, g, a, a);

        // rb
        public readonly uint4 rbrr => new uint4(r, b, r, r);
        public readonly uint4 rbrg => new uint4(r, b, r, g);
        public readonly uint4 rbrb => new uint4(r, b, r, b);
        public readonly uint4 rbra => new uint4(r, b, r, a);

        public readonly uint4 rbgr => new uint4(r, b, g, r);
        public readonly uint4 rbgg => new uint4(r, b, g, g);
        public readonly uint4 rbgb => new uint4(r, b, g, b);
        public readonly uint4 rbga => new uint4(r, b, g, a);

        public readonly uint4 rbbr => new uint4(r, b, b, r);
        public readonly uint4 rbbg => new uint4(r, b, b, g);
        public readonly uint4 rbbb => new uint4(r, b, b, b);
        public readonly uint4 rbba => new uint4(r, b, b, a);

        public readonly uint4 rbar => new uint4(r, b, a, r);
        public readonly uint4 rbag => new uint4(r, b, a, g);
        public readonly uint4 rbab => new uint4(r, b, a, b);
        public readonly uint4 rbaa => new uint4(r, b, a, a);

        // ra
        public readonly uint4 rarr => new uint4(r, a, r, r);
        public readonly uint4 rarg => new uint4(r, a, r, g);
        public readonly uint4 rarb => new uint4(r, a, r, b);
        public readonly uint4 rara => new uint4(r, a, r, a);

        public readonly uint4 ragr => new uint4(r, a, g, r);
        public readonly uint4 ragg => new uint4(r, a, g, g);
        public readonly uint4 ragb => new uint4(r, a, g, b);
        public readonly uint4 raga => new uint4(r, a, g, a);

        public readonly uint4 rabr => new uint4(r, a, b, r);
        public readonly uint4 rabg => new uint4(r, a, b, g);
        public readonly uint4 rabb => new uint4(r, a, b, b);
        public readonly uint4 raba => new uint4(r, a, b, a);

        public readonly uint4 raar => new uint4(r, a, a, r);
        public readonly uint4 raag => new uint4(r, a, a, g);
        public readonly uint4 raab => new uint4(r, a, a, b);
        public readonly uint4 raaa => new uint4(r, a, a, a);


        // g
        // gr
        public readonly uint4 grrr => new uint4(g, r, r, r);
        public readonly uint4 grrg => new uint4(g, r, r, g);
        public readonly uint4 grrb => new uint4(g, r, r, b);
        public readonly uint4 grra => new uint4(g, r, r, a);

        public readonly uint4 grgr => new uint4(g, r, g, r);
        public readonly uint4 grgg => new uint4(g, r, g, g);
        public readonly uint4 grgb => new uint4(g, r, g, b);
        public readonly uint4 grga => new uint4(g, r, g, a);

        public readonly uint4 grbr => new uint4(g, r, b, r);
        public readonly uint4 grbg => new uint4(g, r, b, g);
        public readonly uint4 grbb => new uint4(g, r, b, b);
        public readonly uint4 grba => new uint4(g, r, b, a);

        public readonly uint4 grar => new uint4(g, r, a, r);
        public readonly uint4 grag => new uint4(g, r, a, g);
        public readonly uint4 grab => new uint4(g, r, a, b);
        public readonly uint4 graa => new uint4(g, r, a, a);

        // gg
        public readonly uint4 ggrr => new uint4(g, g, r, r);
        public readonly uint4 ggrg => new uint4(g, g, r, g);
        public readonly uint4 ggrb => new uint4(g, g, r, b);
        public readonly uint4 ggra => new uint4(g, g, r, a);

        public readonly uint4 gggr => new uint4(g, g, g, r);
        public readonly uint4 gggg => new uint4(g, g, g, g);
        public readonly uint4 gggb => new uint4(g, g, g, b);
        public readonly uint4 ggga => new uint4(g, g, g, a);

        public readonly uint4 ggbr => new uint4(g, g, b, r);
        public readonly uint4 ggbg => new uint4(g, g, b, g);
        public readonly uint4 ggbb => new uint4(g, g, b, b);
        public readonly uint4 ggba => new uint4(g, g, b, a);

        public readonly uint4 ggar => new uint4(g, g, a, r);
        public readonly uint4 ggag => new uint4(g, g, a, g);
        public readonly uint4 ggab => new uint4(g, g, a, b);
        public readonly uint4 ggaa => new uint4(g, g, a, a);

        // gb
        public readonly uint4 gbrr => new uint4(g, b, r, r);
        public readonly uint4 gbrg => new uint4(g, b, r, g);
        public readonly uint4 gbrb => new uint4(g, b, r, b);
        public readonly uint4 gbra => new uint4(g, b, r, a);

        public readonly uint4 gbgr => new uint4(g, b, g, r);
        public readonly uint4 gbgg => new uint4(g, b, g, g);
        public readonly uint4 gbgb => new uint4(g, b, g, b);
        public readonly uint4 gbga => new uint4(g, b, g, a);

        public readonly uint4 gbbr => new uint4(g, b, b, r);
        public readonly uint4 gbbg => new uint4(g, b, b, g);
        public readonly uint4 gbbb => new uint4(g, b, b, b);
        public readonly uint4 gbba => new uint4(g, b, b, a);

        public readonly uint4 gbar => new uint4(g, b, a, r);
        public readonly uint4 gbag => new uint4(g, b, a, g);
        public readonly uint4 gbab => new uint4(g, b, a, b);
        public readonly uint4 gbaa => new uint4(g, b, a, a);

        // ga
        public readonly uint4 garr => new uint4(g, a, r, r);
        public readonly uint4 garg => new uint4(g, a, r, g);
        public readonly uint4 garb => new uint4(g, a, r, b);
        public readonly uint4 gara => new uint4(g, a, r, a);

        public readonly uint4 gagr => new uint4(g, a, g, r);
        public readonly uint4 gagg => new uint4(g, a, g, g);
        public readonly uint4 gagb => new uint4(g, a, g, b);
        public readonly uint4 gaga => new uint4(g, a, g, a);

        public readonly uint4 gabr => new uint4(g, a, b, r);
        public readonly uint4 gabg => new uint4(g, a, b, g);
        public readonly uint4 gabb => new uint4(g, a, b, b);
        public readonly uint4 gaba => new uint4(g, a, b, a);

        public readonly uint4 gaar => new uint4(g, a, a, r);
        public readonly uint4 gaag => new uint4(g, a, a, g);
        public readonly uint4 gaab => new uint4(g, a, a, b);
        public readonly uint4 gaaa => new uint4(g, a, a, a);


        // b
        // br
        public readonly uint4 brrr => new uint4(b, r, r, r);
        public readonly uint4 brrg => new uint4(b, r, r, g);
        public readonly uint4 brrb => new uint4(b, r, r, b);
        public readonly uint4 brra => new uint4(b, r, r, a);

        public readonly uint4 brgr => new uint4(b, r, g, r);
        public readonly uint4 brgg => new uint4(b, r, g, g);
        public readonly uint4 brgb => new uint4(b, r, g, b);
        public readonly uint4 brga => new uint4(b, r, g, a);

        public readonly uint4 brbr => new uint4(b, r, b, r);
        public readonly uint4 brbg => new uint4(b, r, b, g);
        public readonly uint4 brbb => new uint4(b, r, b, b);
        public readonly uint4 brba => new uint4(b, r, b, a);

        public readonly uint4 brar => new uint4(b, r, a, r);
        public readonly uint4 brag => new uint4(b, r, a, g);
        public readonly uint4 brab => new uint4(b, r, a, b);
        public readonly uint4 braa => new uint4(b, r, a, a);

        // bg
        public readonly uint4 bgrr => new uint4(b, g, r, r);
        public readonly uint4 bgrg => new uint4(b, g, r, g);
        public readonly uint4 bgrb => new uint4(b, g, r, b);
        public readonly uint4 bgra => new uint4(b, g, r, a);

        public readonly uint4 bggr => new uint4(b, g, g, r);
        public readonly uint4 bggg => new uint4(b, g, g, g);
        public readonly uint4 bggb => new uint4(b, g, g, b);
        public readonly uint4 bgga => new uint4(b, g, g, a);

        public readonly uint4 bgbr => new uint4(b, g, b, r);
        public readonly uint4 bgbg => new uint4(b, g, b, g);
        public readonly uint4 bgbb => new uint4(b, g, b, b);
        public readonly uint4 bgba => new uint4(b, g, b, a);

        public readonly uint4 bgar => new uint4(b, g, a, r);
        public readonly uint4 bgag => new uint4(b, g, a, g);
        public readonly uint4 bgab => new uint4(b, g, a, b);
        public readonly uint4 bgaa => new uint4(b, g, a, a);

        // bb
        public readonly uint4 bbrr => new uint4(b, b, r, r);
        public readonly uint4 bbrg => new uint4(b, b, r, g);
        public readonly uint4 bbrb => new uint4(b, b, r, b);
        public readonly uint4 bbra => new uint4(b, b, r, a);

        public readonly uint4 bbgr => new uint4(b, b, g, r);
        public readonly uint4 bbgg => new uint4(b, b, g, g);
        public readonly uint4 bbgb => new uint4(b, b, g, b);
        public readonly uint4 bbga => new uint4(b, b, g, a);

        public readonly uint4 bbbr => new uint4(b, b, b, r);
        public readonly uint4 bbbg => new uint4(b, b, b, g);
        public readonly uint4 bbbb => new uint4(b, b, b, b);
        public readonly uint4 bbba => new uint4(b, b, b, a);

        public readonly uint4 bbar => new uint4(b, b, a, r);
        public readonly uint4 bbag => new uint4(b, b, a, g);
        public readonly uint4 bbab => new uint4(b, b, a, b);
        public readonly uint4 bbaa => new uint4(b, b, a, a);

        // ba
        public readonly uint4 barr => new uint4(b, a, r, r);
        public readonly uint4 barg => new uint4(b, a, r, g);
        public readonly uint4 barb => new uint4(b, a, r, b);
        public readonly uint4 bara => new uint4(b, a, r, a);

        public readonly uint4 bagr => new uint4(b, a, g, r);
        public readonly uint4 bagg => new uint4(b, a, g, g);
        public readonly uint4 bagb => new uint4(b, a, g, b);
        public readonly uint4 baga => new uint4(b, a, g, a);

        public readonly uint4 babr => new uint4(b, a, b, r);
        public readonly uint4 babg => new uint4(b, a, b, g);
        public readonly uint4 babb => new uint4(b, a, b, b);
        public readonly uint4 baba => new uint4(b, a, b, a);

        public readonly uint4 baar => new uint4(b, a, a, r);
        public readonly uint4 baag => new uint4(b, a, a, g);
        public readonly uint4 baab => new uint4(b, a, a, b);
        public readonly uint4 baaa => new uint4(b, a, a, a);


        // a
        // ar
        public readonly uint4 arrr => new uint4(a, r, r, r);
        public readonly uint4 arrg => new uint4(a, r, r, g);
        public readonly uint4 arrb => new uint4(a, r, r, b);
        public readonly uint4 arra => new uint4(a, r, r, a);

        public readonly uint4 argr => new uint4(a, r, g, r);
        public readonly uint4 argg => new uint4(a, r, g, g);
        public readonly uint4 argb => new uint4(a, r, g, b);
        public readonly uint4 arga => new uint4(a, r, g, a);

        public readonly uint4 arbr => new uint4(a, r, b, r);
        public readonly uint4 arbg => new uint4(a, r, b, g);
        public readonly uint4 arbb => new uint4(a, r, b, b);
        public readonly uint4 arba => new uint4(a, r, b, a);

        public readonly uint4 arar => new uint4(a, r, a, r);
        public readonly uint4 arag => new uint4(a, r, a, g);
        public readonly uint4 arab => new uint4(a, r, a, b);
        public readonly uint4 araa => new uint4(a, r, a, a);

        // ag
        public readonly uint4 agrr => new uint4(a, g, r, r);
        public readonly uint4 agrg => new uint4(a, g, r, g);
        public readonly uint4 agrb => new uint4(a, g, r, b);
        public readonly uint4 agra => new uint4(a, g, r, a);

        public readonly uint4 aggr => new uint4(a, g, g, r);
        public readonly uint4 aggg => new uint4(a, g, g, g);
        public readonly uint4 aggb => new uint4(a, g, g, b);
        public readonly uint4 agga => new uint4(a, g, g, a);

        public readonly uint4 agbr => new uint4(a, g, b, r);
        public readonly uint4 agbg => new uint4(a, g, b, g);
        public readonly uint4 agbb => new uint4(a, g, b, b);
        public readonly uint4 agba => new uint4(a, g, b, a);

        public readonly uint4 agar => new uint4(a, g, a, r);
        public readonly uint4 agag => new uint4(a, g, a, g);
        public readonly uint4 agab => new uint4(a, g, a, b);
        public readonly uint4 agaa => new uint4(a, g, a, a);

        // ab
        public readonly uint4 abrr => new uint4(a, b, r, r);
        public readonly uint4 abrg => new uint4(a, b, r, g);
        public readonly uint4 abrb => new uint4(a, b, r, b);
        public readonly uint4 abra => new uint4(a, b, r, a);

        public readonly uint4 abgr => new uint4(a, b, g, r);
        public readonly uint4 abgg => new uint4(a, b, g, g);
        public readonly uint4 abgb => new uint4(a, b, g, b);
        public readonly uint4 abga => new uint4(a, b, g, a);

        public readonly uint4 abbr => new uint4(a, b, b, r);
        public readonly uint4 abbg => new uint4(a, b, b, g);
        public readonly uint4 abbb => new uint4(a, b, b, b);
        public readonly uint4 abba => new uint4(a, b, b, a);

        public readonly uint4 abar => new uint4(a, b, a, r);
        public readonly uint4 abag => new uint4(a, b, a, g);
        public readonly uint4 abab => new uint4(a, b, a, b);
        public readonly uint4 abaa => new uint4(a, b, a, a);

        // aa
        public readonly uint4 aarr => new uint4(a, a, r, r);
        public readonly uint4 aarg => new uint4(a, a, r, g);
        public readonly uint4 aarb => new uint4(a, a, r, b);
        public readonly uint4 aara => new uint4(a, a, r, a);

        public readonly uint4 aagr => new uint4(a, a, g, r);
        public readonly uint4 aagg => new uint4(a, a, g, g);
        public readonly uint4 aagb => new uint4(a, a, g, b);
        public readonly uint4 aaga => new uint4(a, a, g, a);

        public readonly uint4 aabr => new uint4(a, a, b, r);
        public readonly uint4 aabg => new uint4(a, a, b, g);
        public readonly uint4 aabb => new uint4(a, a, b, b);
        public readonly uint4 aaba => new uint4(a, a, b, a);

        public readonly uint4 aaar => new uint4(a, a, a, r);
        public readonly uint4 aaag => new uint4(a, a, a, g);
        public readonly uint4 aaab => new uint4(a, a, a, b);
        public readonly uint4 aaaa => new uint4(a, a, a, a);

        #endregion Swizzles_uint4_RGBA
        #region Swizzles_Extra

        // Swizzles - uint3

        // x
        public readonly uint3 xxx => new uint3(x, x, x);
        public readonly uint3 xxy => new uint3(x, x, y);
        public readonly uint3 xxz => new uint3(x, x, z);
        public readonly uint3 xxw => new uint3(x, x, w);

        public readonly uint3 xyx => new uint3(x, y, x);
        public readonly uint3 xyy => new uint3(x, y, y);
        public readonly uint3 xyz => new uint3(x, y, z);
        public readonly uint3 xyw => new uint3(x, y, w);

        public readonly uint3 xzx => new uint3(x, z, x);
        public readonly uint3 xzy => new uint3(x, z, y);
        public readonly uint3 xzz => new uint3(x, z, z);
        public readonly uint3 xzw => new uint3(x, z, w);

        public readonly uint3 xwx => new uint3(x, w, x);
        public readonly uint3 xwy => new uint3(x, w, y);
        public readonly uint3 xwz => new uint3(x, w, z);
        public readonly uint3 xww => new uint3(x, w, w);

        // y
        public readonly uint3 yxx => new uint3(y, x, x);
        public readonly uint3 yxy => new uint3(y, x, y);
        public readonly uint3 yxz => new uint3(y, x, z);
        public readonly uint3 yxw => new uint3(y, x, w);

        public readonly uint3 yyx => new uint3(y, y, x);
        public readonly uint3 yyy => new uint3(y, y, y);
        public readonly uint3 yyz => new uint3(y, y, z);
        public readonly uint3 yyw => new uint3(y, y, w);

        public readonly uint3 yzx => new uint3(y, z, x);
        public readonly uint3 yzy => new uint3(y, z, y);
        public readonly uint3 yzz => new uint3(y, z, z);
        public readonly uint3 yzw => new uint3(y, z, w);

        public readonly uint3 ywx => new uint3(y, w, x);
        public readonly uint3 ywy => new uint3(y, w, y);
        public readonly uint3 ywz => new uint3(y, w, z);
        public readonly uint3 yww => new uint3(y, w, w);

        // z
        public readonly uint3 zxx => new uint3(z, x, x);
        public readonly uint3 zxy => new uint3(z, x, y);
        public readonly uint3 zxz => new uint3(z, x, z);
        public readonly uint3 zxw => new uint3(z, x, w);

        public readonly uint3 zyx => new uint3(z, y, x);
        public readonly uint3 zyy => new uint3(z, y, y);
        public readonly uint3 zyz => new uint3(z, y, z);
        public readonly uint3 zyw => new uint3(z, y, w);

        public readonly uint3 zzx => new uint3(z, z, x);
        public readonly uint3 zzy => new uint3(z, z, y);
        public readonly uint3 zzz => new uint3(z, z, z);
        public readonly uint3 zzw => new uint3(z, z, w);

        public readonly uint3 zwx => new uint3(z, w, x);
        public readonly uint3 zwy => new uint3(z, w, y);
        public readonly uint3 zwz => new uint3(z, w, z);
        public readonly uint3 zww => new uint3(z, w, w);

        // w
        public readonly uint3 wxx => new uint3(w, x, x);
        public readonly uint3 wxy => new uint3(w, x, y);
        public readonly uint3 wxz => new uint3(w, x, z);
        public readonly uint3 wxw => new uint3(w, x, w);

        public readonly uint3 wyx => new uint3(w, y, x);
        public readonly uint3 wyy => new uint3(w, y, y);
        public readonly uint3 wyz => new uint3(w, y, z);
        public readonly uint3 wyw => new uint3(w, y, w);

        public readonly uint3 wzx => new uint3(w, z, x);
        public readonly uint3 wzy => new uint3(w, z, y);
        public readonly uint3 wzz => new uint3(w, z, z);
        public readonly uint3 wzw => new uint3(w, z, w);

        public readonly uint3 wwx => new uint3(w, w, x);
        public readonly uint3 wwy => new uint3(w, w, y);
        public readonly uint3 wwz => new uint3(w, w, z);
        public readonly uint3 www => new uint3(w, w, w);

        // Swizzles - uint2

        public readonly uint2 xx => new uint2(x, x);
        public readonly uint2 xy => new uint2(x, y);
        public readonly uint2 xz => new uint2(x, z);
        public readonly uint2 xw => new uint2(x, w);

        public readonly uint2 yx => new uint2(y, x);
        public readonly uint2 yy => new uint2(y, y);
        public readonly uint2 yz => new uint2(y, z);
        public readonly uint2 yw => new uint2(y, w);

        public readonly uint2 zx => new uint2(z, x);
        public readonly uint2 zy => new uint2(z, y);
        public readonly uint2 zz => new uint2(z, z);
        public readonly uint2 zw => new uint2(z, w);

        public readonly uint2 wx => new uint2(w, x);
        public readonly uint2 wy => new uint2(w, y);
        public readonly uint2 wz => new uint2(w, z);
        public readonly uint2 ww => new uint2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - uint3

        // r
        public readonly uint3 rrr => new uint3(r, r, r);
        public readonly uint3 rrg => new uint3(r, r, g);
        public readonly uint3 rrb => new uint3(r, r, b);
        public readonly uint3 rra => new uint3(r, r, a);

        public readonly uint3 rgr => new uint3(r, g, r);
        public readonly uint3 rgg => new uint3(r, g, g);
        public readonly uint3 rgb => new uint3(r, g, b);
        public readonly uint3 rga => new uint3(r, g, a);

        public readonly uint3 rbr => new uint3(r, b, r);
        public readonly uint3 rbg => new uint3(r, b, g);
        public readonly uint3 rbb => new uint3(r, b, b);
        public readonly uint3 rba => new uint3(r, b, a);

        public readonly uint3 rar => new uint3(r, a, r);
        public readonly uint3 rag => new uint3(r, a, g);
        public readonly uint3 rab => new uint3(r, a, b);
        public readonly uint3 raa => new uint3(r, a, a);

        // g
        public readonly uint3 grr => new uint3(g, r, r);
        public readonly uint3 grg => new uint3(g, r, g);
        public readonly uint3 grb => new uint3(g, r, b);
        public readonly uint3 gra => new uint3(g, r, a);

        public readonly uint3 ggr => new uint3(g, g, r);
        public readonly uint3 ggg => new uint3(g, g, g);
        public readonly uint3 ggb => new uint3(g, g, b);
        public readonly uint3 gga => new uint3(g, g, a);

        public readonly uint3 gbr => new uint3(g, b, r);
        public readonly uint3 gbg => new uint3(g, b, g);
        public readonly uint3 gbb => new uint3(g, b, b);
        public readonly uint3 gba => new uint3(g, b, a);

        public readonly uint3 gar => new uint3(g, a, r);
        public readonly uint3 gag => new uint3(g, a, g);
        public readonly uint3 gab => new uint3(g, a, b);
        public readonly uint3 gaa => new uint3(g, a, a);

        // b
        public readonly uint3 brr => new uint3(b, r, r);
        public readonly uint3 brg => new uint3(b, r, g);
        public readonly uint3 brb => new uint3(b, r, b);
        public readonly uint3 bra => new uint3(b, r, a);

        public readonly uint3 bgr => new uint3(b, g, r);
        public readonly uint3 bgg => new uint3(b, g, g);
        public readonly uint3 bgb => new uint3(b, g, b);
        public readonly uint3 bga => new uint3(b, g, a);

        public readonly uint3 bbr => new uint3(b, b, r);
        public readonly uint3 bbg => new uint3(b, b, g);
        public readonly uint3 bbb => new uint3(b, b, b);
        public readonly uint3 bba => new uint3(b, b, a);

        public readonly uint3 bar => new uint3(b, a, r);
        public readonly uint3 bag => new uint3(b, a, g);
        public readonly uint3 bab => new uint3(b, a, b);
        public readonly uint3 baa => new uint3(b, a, a);

        // a
        public readonly uint3 arr => new uint3(a, r, r);
        public readonly uint3 arg => new uint3(a, r, g);
        public readonly uint3 arb => new uint3(a, r, b);
        public readonly uint3 ara => new uint3(a, r, a);

        public readonly uint3 agr => new uint3(a, g, r);
        public readonly uint3 agg => new uint3(a, g, g);
        public readonly uint3 agb => new uint3(a, g, b);
        public readonly uint3 aga => new uint3(a, g, a);

        public readonly uint3 abr => new uint3(a, b, r);
        public readonly uint3 abg => new uint3(a, b, g);
        public readonly uint3 abb => new uint3(a, b, b);
        public readonly uint3 aba => new uint3(a, b, a);

        public readonly uint3 aar => new uint3(a, a, r);
        public readonly uint3 aag => new uint3(a, a, g);
        public readonly uint3 aab => new uint3(a, a, b);
        public readonly uint3 aaa => new uint3(a, a, a);

        // RGBA - Swizzles - uint2

        public readonly uint2 rr => new uint2(r, r);
        public readonly uint2 rg => new uint2(r, g);
        public readonly uint2 rb => new uint2(r, b);
        public readonly uint2 ra => new uint2(r, a);

        public readonly uint2 gr => new uint2(g, r);
        public readonly uint2 gg => new uint2(g, g);
        public readonly uint2 gb => new uint2(g, b);
        public readonly uint2 ga => new uint2(g, a);

        public readonly uint2 br => new uint2(b, r);
        public readonly uint2 bg => new uint2(b, g);
        public readonly uint2 bb => new uint2(b, b);
        public readonly uint2 ba => new uint2(b, a);

        public readonly uint2 ar => new uint2(a, r);
        public readonly uint2 ag => new uint2(a, g);
        public readonly uint2 ab => new uint2(a, b);
        public readonly uint2 aa => new uint2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
