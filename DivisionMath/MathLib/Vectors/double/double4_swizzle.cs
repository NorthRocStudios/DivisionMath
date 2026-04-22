namespace DivisionEngine.MathLib
{
    public partial struct double4
    {
        #region Swizzles_double4

        // Swizzles - double4

        // x
        // xx
        public readonly double4 xxxx => new double4(x, x, x, x);
        public readonly double4 xxxy => new double4(x, x, x, y);
        public readonly double4 xxxz => new double4(x, x, x, z);
        public readonly double4 xxxw => new double4(x, x, x, w);

        public readonly double4 xxyx => new double4(x, x, y, x);
        public readonly double4 xxyy => new double4(x, x, y, y);
        public readonly double4 xxyz => new double4(x, x, y, z);
        public readonly double4 xxyw => new double4(x, x, y, w);

        public readonly double4 xxzx => new double4(x, x, z, x);
        public readonly double4 xxzy => new double4(x, x, z, y);
        public readonly double4 xxzz => new double4(x, x, z, z);
        public readonly double4 xxzw => new double4(x, x, z, w);

        public readonly double4 xxwx => new double4(x, x, w, x);
        public readonly double4 xxwy => new double4(x, x, w, y);
        public readonly double4 xxwz => new double4(x, x, w, z);
        public readonly double4 xxww => new double4(x, x, w, w);

        // xy
        public readonly double4 xyxx => new double4(x, y, x, x);
        public readonly double4 xyxy => new double4(x, y, x, y);
        public readonly double4 xyxz => new double4(x, y, x, z);
        public readonly double4 xyxw => new double4(x, y, x, w);

        public readonly double4 xyyx => new double4(x, y, y, x);
        public readonly double4 xyyy => new double4(x, y, y, y);
        public readonly double4 xyyz => new double4(x, y, y, z);
        public readonly double4 xyyw => new double4(x, y, y, w);

        public readonly double4 xyzx => new double4(x, y, z, x);
        public readonly double4 xyzy => new double4(x, y, z, y);
        public readonly double4 xyzz => new double4(x, y, z, z);
        public readonly double4 xyzw => new double4(x, y, z, w);

        public readonly double4 xywx => new double4(x, y, w, x);
        public readonly double4 xywy => new double4(x, y, w, y);
        public readonly double4 xywz => new double4(x, y, w, z);
        public readonly double4 xyww => new double4(x, y, w, w);

        // xz
        public readonly double4 xzxx => new double4(x, z, x, x);
        public readonly double4 xzxy => new double4(x, z, x, y);
        public readonly double4 xzxz => new double4(x, z, x, z);
        public readonly double4 xzxw => new double4(x, z, x, w);

        public readonly double4 xzyx => new double4(x, z, y, x);
        public readonly double4 xzyy => new double4(x, z, y, y);
        public readonly double4 xzyz => new double4(x, z, y, z);
        public readonly double4 xzyw => new double4(x, z, y, w);

        public readonly double4 xzzx => new double4(x, z, z, x);
        public readonly double4 xzzy => new double4(x, z, z, y);
        public readonly double4 xzzz => new double4(x, z, z, z);
        public readonly double4 xzzw => new double4(x, z, z, w);

        public readonly double4 xzwx => new double4(x, z, w, x);
        public readonly double4 xzwy => new double4(x, z, w, y);
        public readonly double4 xzwz => new double4(x, z, w, z);
        public readonly double4 xzww => new double4(x, z, w, w);

        // xw
        public readonly double4 xwxx => new double4(x, w, x, x);
        public readonly double4 xwxy => new double4(x, w, x, y);
        public readonly double4 xwxz => new double4(x, w, x, z);
        public readonly double4 xwxw => new double4(x, w, x, w);

        public readonly double4 xwyx => new double4(x, w, y, x);
        public readonly double4 xwyy => new double4(x, w, y, y);
        public readonly double4 xwyz => new double4(x, w, y, z);
        public readonly double4 xwyw => new double4(x, w, y, w);

        public readonly double4 xwzx => new double4(x, w, z, x);
        public readonly double4 xwzy => new double4(x, w, z, y);
        public readonly double4 xwzz => new double4(x, w, z, z);
        public readonly double4 xwzw => new double4(x, w, z, w);

        public readonly double4 xwwx => new double4(x, w, w, x);
        public readonly double4 xwwy => new double4(x, w, w, y);
        public readonly double4 xwwz => new double4(x, w, w, z);
        public readonly double4 xwww => new double4(x, w, w, w);


        // y
        // yx
        public readonly double4 yxxx => new double4(y, x, x, x);
        public readonly double4 yxxy => new double4(y, x, x, y);
        public readonly double4 yxxz => new double4(y, x, x, z);
        public readonly double4 yxxw => new double4(y, x, x, w);

        public readonly double4 yxyx => new double4(y, x, y, x);
        public readonly double4 yxyy => new double4(y, x, y, y);
        public readonly double4 yxyz => new double4(y, x, y, z);
        public readonly double4 yxyw => new double4(y, x, y, w);

        public readonly double4 yxzx => new double4(y, x, z, x);
        public readonly double4 yxzy => new double4(y, x, z, y);
        public readonly double4 yxzz => new double4(y, x, z, z);
        public readonly double4 yxzw => new double4(y, x, z, w);

        public readonly double4 yxwx => new double4(y, x, w, x);
        public readonly double4 yxwy => new double4(y, x, w, y);
        public readonly double4 yxwz => new double4(y, x, w, z);
        public readonly double4 yxww => new double4(y, x, w, w);

        // yy
        public readonly double4 yyxx => new double4(y, y, x, x);
        public readonly double4 yyxy => new double4(y, y, x, y);
        public readonly double4 yyxz => new double4(y, y, x, z);
        public readonly double4 yyxw => new double4(y, y, x, w);

        public readonly double4 yyyx => new double4(y, y, y, x);
        public readonly double4 yyyy => new double4(y, y, y, y);
        public readonly double4 yyyz => new double4(y, y, y, z);
        public readonly double4 yyyw => new double4(y, y, y, w);

        public readonly double4 yyzx => new double4(y, y, z, x);
        public readonly double4 yyzy => new double4(y, y, z, y);
        public readonly double4 yyzz => new double4(y, y, z, z);
        public readonly double4 yyzw => new double4(y, y, z, w);

        public readonly double4 yywx => new double4(y, y, w, x);
        public readonly double4 yywy => new double4(y, y, w, y);
        public readonly double4 yywz => new double4(y, y, w, z);
        public readonly double4 yyww => new double4(y, y, w, w);

        // yz
        public readonly double4 yzxx => new double4(y, z, x, x);
        public readonly double4 yzxy => new double4(y, z, x, y);
        public readonly double4 yzxz => new double4(y, z, x, z);
        public readonly double4 yzxw => new double4(y, z, x, w);

        public readonly double4 yzyx => new double4(y, z, y, x);
        public readonly double4 yzyy => new double4(y, z, y, y);
        public readonly double4 yzyz => new double4(y, z, y, z);
        public readonly double4 yzyw => new double4(y, z, y, w);

        public readonly double4 yzzx => new double4(y, z, z, x);
        public readonly double4 yzzy => new double4(y, z, z, y);
        public readonly double4 yzzz => new double4(y, z, z, z);
        public readonly double4 yzzw => new double4(y, z, z, w);

        public readonly double4 yzwx => new double4(y, z, w, x);
        public readonly double4 yzwy => new double4(y, z, w, y);
        public readonly double4 yzwz => new double4(y, z, w, z);
        public readonly double4 yzww => new double4(y, z, w, w);

        // yw
        public readonly double4 ywxx => new double4(y, w, x, x);
        public readonly double4 ywxy => new double4(y, w, x, y);
        public readonly double4 ywxz => new double4(y, w, x, z);
        public readonly double4 ywxw => new double4(y, w, x, w);

        public readonly double4 ywyx => new double4(y, w, y, x);
        public readonly double4 ywyy => new double4(y, w, y, y);
        public readonly double4 ywyz => new double4(y, w, y, z);
        public readonly double4 ywyw => new double4(y, w, y, w);

        public readonly double4 ywzx => new double4(y, w, z, x);
        public readonly double4 ywzy => new double4(y, w, z, y);
        public readonly double4 ywzz => new double4(y, w, z, z);
        public readonly double4 ywzw => new double4(y, w, z, w);

        public readonly double4 ywwx => new double4(y, w, w, x);
        public readonly double4 ywwy => new double4(y, w, w, y);
        public readonly double4 ywwz => new double4(y, w, w, z);
        public readonly double4 ywww => new double4(y, w, w, w);


        // z
        // zx
        public readonly double4 zxxx => new double4(z, x, x, x);
        public readonly double4 zxxy => new double4(z, x, x, y);
        public readonly double4 zxxz => new double4(z, x, x, z);
        public readonly double4 zxxw => new double4(z, x, x, w);

        public readonly double4 zxyx => new double4(z, x, y, x);
        public readonly double4 zxyy => new double4(z, x, y, y);
        public readonly double4 zxyz => new double4(z, x, y, z);
        public readonly double4 zxyw => new double4(z, x, y, w);

        public readonly double4 zxzx => new double4(z, x, z, x);
        public readonly double4 zxzy => new double4(z, x, z, y);
        public readonly double4 zxzz => new double4(z, x, z, z);
        public readonly double4 zxzw => new double4(z, x, z, w);

        public readonly double4 zxwx => new double4(z, x, w, x);
        public readonly double4 zxwy => new double4(z, x, w, y);
        public readonly double4 zxwz => new double4(z, x, w, z);
        public readonly double4 zxww => new double4(z, x, w, w);

        // zy
        public readonly double4 zyxx => new double4(z, y, x, x);
        public readonly double4 zyxy => new double4(z, y, x, y);
        public readonly double4 zyxz => new double4(z, y, x, z);
        public readonly double4 zyxw => new double4(z, y, x, w);

        public readonly double4 zyyx => new double4(z, y, y, x);
        public readonly double4 zyyy => new double4(z, y, y, y);
        public readonly double4 zyyz => new double4(z, y, y, z);
        public readonly double4 zyyw => new double4(z, y, y, w);

        public readonly double4 zyzx => new double4(z, y, z, x);
        public readonly double4 zyzy => new double4(z, y, z, y);
        public readonly double4 zyzz => new double4(z, y, z, z);
        public readonly double4 zyzw => new double4(z, y, z, w);

        public readonly double4 zywx => new double4(z, y, w, x);
        public readonly double4 zywy => new double4(z, y, w, y);
        public readonly double4 zywz => new double4(z, y, w, z);
        public readonly double4 zyww => new double4(z, y, w, w);

        // zz
        public readonly double4 zzxx => new double4(z, z, x, x);
        public readonly double4 zzxy => new double4(z, z, x, y);
        public readonly double4 zzxz => new double4(z, z, x, z);
        public readonly double4 zzxw => new double4(z, z, x, w);

        public readonly double4 zzyx => new double4(z, z, y, x);
        public readonly double4 zzyy => new double4(z, z, y, y);
        public readonly double4 zzyz => new double4(z, z, y, z);
        public readonly double4 zzyw => new double4(z, z, y, w);

        public readonly double4 zzzx => new double4(z, z, z, x);
        public readonly double4 zzzy => new double4(z, z, z, y);
        public readonly double4 zzzz => new double4(z, z, z, z);
        public readonly double4 zzzw => new double4(z, z, z, w);

        public readonly double4 zzwx => new double4(z, z, w, x);
        public readonly double4 zzwy => new double4(z, z, w, y);
        public readonly double4 zzwz => new double4(z, z, w, z);
        public readonly double4 zzww => new double4(z, z, w, w);

        // zw
        public readonly double4 zwxx => new double4(z, w, x, x);
        public readonly double4 zwxy => new double4(z, w, x, y);
        public readonly double4 zwxz => new double4(z, w, x, z);
        public readonly double4 zwxw => new double4(z, w, x, w);

        public readonly double4 zwyx => new double4(z, w, y, x);
        public readonly double4 zwyy => new double4(z, w, y, y);
        public readonly double4 zwyz => new double4(z, w, y, z);
        public readonly double4 zwyw => new double4(z, w, y, w);

        public readonly double4 zwzx => new double4(z, w, z, x);
        public readonly double4 zwzy => new double4(z, w, z, y);
        public readonly double4 zwzz => new double4(z, w, z, z);
        public readonly double4 zwzw => new double4(z, w, z, w);

        public readonly double4 zwwx => new double4(z, w, w, x);
        public readonly double4 zwwy => new double4(z, w, w, y);
        public readonly double4 zwwz => new double4(z, w, w, z);
        public readonly double4 zwww => new double4(z, w, w, w);


        // w
        // wx
        public readonly double4 wxxx => new double4(w, x, x, x);
        public readonly double4 wxxy => new double4(w, x, x, y);
        public readonly double4 wxxz => new double4(w, x, x, z);
        public readonly double4 wxxw => new double4(w, x, x, w);

        public readonly double4 wxyx => new double4(w, x, y, x);
        public readonly double4 wxyy => new double4(w, x, y, y);
        public readonly double4 wxyz => new double4(w, x, y, z);
        public readonly double4 wxyw => new double4(w, x, y, w);

        public readonly double4 wxzx => new double4(w, x, z, x);
        public readonly double4 wxzy => new double4(w, x, z, y);
        public readonly double4 wxzz => new double4(w, x, z, z);
        public readonly double4 wxzw => new double4(w, x, z, w);

        public readonly double4 wxwx => new double4(w, x, w, x);
        public readonly double4 wxwy => new double4(w, x, w, y);
        public readonly double4 wxwz => new double4(w, x, w, z);
        public readonly double4 wxww => new double4(w, x, w, w);

        // wy
        public readonly double4 wyxx => new double4(w, y, x, x);
        public readonly double4 wyxy => new double4(w, y, x, y);
        public readonly double4 wyxz => new double4(w, y, x, z);
        public readonly double4 wyxw => new double4(w, y, x, w);

        public readonly double4 wyyx => new double4(w, y, y, x);
        public readonly double4 wyyy => new double4(w, y, y, y);
        public readonly double4 wyyz => new double4(w, y, y, z);
        public readonly double4 wyyw => new double4(w, y, y, w);

        public readonly double4 wyzx => new double4(w, y, z, x);
        public readonly double4 wyzy => new double4(w, y, z, y);
        public readonly double4 wyzz => new double4(w, y, z, z);
        public readonly double4 wyzw => new double4(w, y, z, w);

        public readonly double4 wywx => new double4(w, y, w, x);
        public readonly double4 wywy => new double4(w, y, w, y);
        public readonly double4 wywz => new double4(w, y, w, z);
        public readonly double4 wyww => new double4(w, y, w, w);

        // wz
        public readonly double4 wzxx => new double4(w, z, x, x);
        public readonly double4 wzxy => new double4(w, z, x, y);
        public readonly double4 wzxz => new double4(w, z, x, z);
        public readonly double4 wzxw => new double4(w, z, x, w);

        public readonly double4 wzyx => new double4(w, z, y, x);
        public readonly double4 wzyy => new double4(w, z, y, y);
        public readonly double4 wzyz => new double4(w, z, y, z);
        public readonly double4 wzyw => new double4(w, z, y, w);

        public readonly double4 wzzx => new double4(w, z, z, x);
        public readonly double4 wzzy => new double4(w, z, z, y);
        public readonly double4 wzzz => new double4(w, z, z, z);
        public readonly double4 wzzw => new double4(w, z, z, w);

        public readonly double4 wzwx => new double4(w, z, w, x);
        public readonly double4 wzwy => new double4(w, z, w, y);
        public readonly double4 wzwz => new double4(w, z, w, z);
        public readonly double4 wzww => new double4(w, z, w, w);

        // ww
        public readonly double4 wwxx => new double4(w, w, x, x);
        public readonly double4 wwxy => new double4(w, w, x, y);
        public readonly double4 wwxz => new double4(w, w, x, z);
        public readonly double4 wwxw => new double4(w, w, x, w);

        public readonly double4 wwyx => new double4(w, w, y, x);
        public readonly double4 wwyy => new double4(w, w, y, y);
        public readonly double4 wwyz => new double4(w, w, y, z);
        public readonly double4 wwyw => new double4(w, w, y, w);

        public readonly double4 wwzx => new double4(w, w, z, x);
        public readonly double4 wwzy => new double4(w, w, z, y);
        public readonly double4 wwzz => new double4(w, w, z, z);
        public readonly double4 wwzw => new double4(w, w, z, w);

        public readonly double4 wwwx => new double4(w, w, w, x);
        public readonly double4 wwwy => new double4(w, w, w, y);
        public readonly double4 wwwz => new double4(w, w, w, z);
        public readonly double4 wwww => new double4(w, w, w, w);

        #endregion Swizzles_double4
        #region Swizzles_double4_RGBA

        // RGBA - Swizzles - double4

        // r
        // rr
        public readonly double4 rrrr => new double4(r, r, r, r);
        public readonly double4 rrrg => new double4(r, r, r, g);
        public readonly double4 rrrb => new double4(r, r, r, b);
        public readonly double4 rrra => new double4(r, r, r, a);

        public readonly double4 rrgr => new double4(r, r, g, r);
        public readonly double4 rrgg => new double4(r, r, g, g);
        public readonly double4 rrgb => new double4(r, r, g, b);
        public readonly double4 rrga => new double4(r, r, g, a);

        public readonly double4 rrbr => new double4(r, r, b, r);
        public readonly double4 rrbg => new double4(r, r, b, g);
        public readonly double4 rrbb => new double4(r, r, b, b);
        public readonly double4 rrba => new double4(r, r, b, a);

        public readonly double4 rrar => new double4(r, r, a, r);
        public readonly double4 rrag => new double4(r, r, a, g);
        public readonly double4 rrab => new double4(r, r, a, b);
        public readonly double4 rraa => new double4(r, r, a, a);

        // rg
        public readonly double4 rgrr => new double4(r, g, r, r);
        public readonly double4 rgrg => new double4(r, g, r, g);
        public readonly double4 rgrb => new double4(r, g, r, b);
        public readonly double4 rgra => new double4(r, g, r, a);

        public readonly double4 rggr => new double4(r, g, g, r);
        public readonly double4 rggg => new double4(r, g, g, g);
        public readonly double4 rggb => new double4(r, g, g, b);
        public readonly double4 rgga => new double4(r, g, g, a);

        public readonly double4 rgbr => new double4(r, g, b, r);
        public readonly double4 rgbg => new double4(r, g, b, g);
        public readonly double4 rgbb => new double4(r, g, b, b);
        public readonly double4 rgba => new double4(r, g, b, a);

        public readonly double4 rgar => new double4(r, g, a, r);
        public readonly double4 rgag => new double4(r, g, a, g);
        public readonly double4 rgab => new double4(r, g, a, b);
        public readonly double4 rgaa => new double4(r, g, a, a);

        // rb
        public readonly double4 rbrr => new double4(r, b, r, r);
        public readonly double4 rbrg => new double4(r, b, r, g);
        public readonly double4 rbrb => new double4(r, b, r, b);
        public readonly double4 rbra => new double4(r, b, r, a);

        public readonly double4 rbgr => new double4(r, b, g, r);
        public readonly double4 rbgg => new double4(r, b, g, g);
        public readonly double4 rbgb => new double4(r, b, g, b);
        public readonly double4 rbga => new double4(r, b, g, a);

        public readonly double4 rbbr => new double4(r, b, b, r);
        public readonly double4 rbbg => new double4(r, b, b, g);
        public readonly double4 rbbb => new double4(r, b, b, b);
        public readonly double4 rbba => new double4(r, b, b, a);

        public readonly double4 rbar => new double4(r, b, a, r);
        public readonly double4 rbag => new double4(r, b, a, g);
        public readonly double4 rbab => new double4(r, b, a, b);
        public readonly double4 rbaa => new double4(r, b, a, a);

        // ra
        public readonly double4 rarr => new double4(r, a, r, r);
        public readonly double4 rarg => new double4(r, a, r, g);
        public readonly double4 rarb => new double4(r, a, r, b);
        public readonly double4 rara => new double4(r, a, r, a);

        public readonly double4 ragr => new double4(r, a, g, r);
        public readonly double4 ragg => new double4(r, a, g, g);
        public readonly double4 ragb => new double4(r, a, g, b);
        public readonly double4 raga => new double4(r, a, g, a);

        public readonly double4 rabr => new double4(r, a, b, r);
        public readonly double4 rabg => new double4(r, a, b, g);
        public readonly double4 rabb => new double4(r, a, b, b);
        public readonly double4 raba => new double4(r, a, b, a);

        public readonly double4 raar => new double4(r, a, a, r);
        public readonly double4 raag => new double4(r, a, a, g);
        public readonly double4 raab => new double4(r, a, a, b);
        public readonly double4 raaa => new double4(r, a, a, a);


        // g
        // gr
        public readonly double4 grrr => new double4(g, r, r, r);
        public readonly double4 grrg => new double4(g, r, r, g);
        public readonly double4 grrb => new double4(g, r, r, b);
        public readonly double4 grra => new double4(g, r, r, a);

        public readonly double4 grgr => new double4(g, r, g, r);
        public readonly double4 grgg => new double4(g, r, g, g);
        public readonly double4 grgb => new double4(g, r, g, b);
        public readonly double4 grga => new double4(g, r, g, a);

        public readonly double4 grbr => new double4(g, r, b, r);
        public readonly double4 grbg => new double4(g, r, b, g);
        public readonly double4 grbb => new double4(g, r, b, b);
        public readonly double4 grba => new double4(g, r, b, a);

        public readonly double4 grar => new double4(g, r, a, r);
        public readonly double4 grag => new double4(g, r, a, g);
        public readonly double4 grab => new double4(g, r, a, b);
        public readonly double4 graa => new double4(g, r, a, a);

        // gg
        public readonly double4 ggrr => new double4(g, g, r, r);
        public readonly double4 ggrg => new double4(g, g, r, g);
        public readonly double4 ggrb => new double4(g, g, r, b);
        public readonly double4 ggra => new double4(g, g, r, a);

        public readonly double4 gggr => new double4(g, g, g, r);
        public readonly double4 gggg => new double4(g, g, g, g);
        public readonly double4 gggb => new double4(g, g, g, b);
        public readonly double4 ggga => new double4(g, g, g, a);

        public readonly double4 ggbr => new double4(g, g, b, r);
        public readonly double4 ggbg => new double4(g, g, b, g);
        public readonly double4 ggbb => new double4(g, g, b, b);
        public readonly double4 ggba => new double4(g, g, b, a);

        public readonly double4 ggar => new double4(g, g, a, r);
        public readonly double4 ggag => new double4(g, g, a, g);
        public readonly double4 ggab => new double4(g, g, a, b);
        public readonly double4 ggaa => new double4(g, g, a, a);

        // gb
        public readonly double4 gbrr => new double4(g, b, r, r);
        public readonly double4 gbrg => new double4(g, b, r, g);
        public readonly double4 gbrb => new double4(g, b, r, b);
        public readonly double4 gbra => new double4(g, b, r, a);

        public readonly double4 gbgr => new double4(g, b, g, r);
        public readonly double4 gbgg => new double4(g, b, g, g);
        public readonly double4 gbgb => new double4(g, b, g, b);
        public readonly double4 gbga => new double4(g, b, g, a);

        public readonly double4 gbbr => new double4(g, b, b, r);
        public readonly double4 gbbg => new double4(g, b, b, g);
        public readonly double4 gbbb => new double4(g, b, b, b);
        public readonly double4 gbba => new double4(g, b, b, a);

        public readonly double4 gbar => new double4(g, b, a, r);
        public readonly double4 gbag => new double4(g, b, a, g);
        public readonly double4 gbab => new double4(g, b, a, b);
        public readonly double4 gbaa => new double4(g, b, a, a);

        // ga
        public readonly double4 garr => new double4(g, a, r, r);
        public readonly double4 garg => new double4(g, a, r, g);
        public readonly double4 garb => new double4(g, a, r, b);
        public readonly double4 gara => new double4(g, a, r, a);

        public readonly double4 gagr => new double4(g, a, g, r);
        public readonly double4 gagg => new double4(g, a, g, g);
        public readonly double4 gagb => new double4(g, a, g, b);
        public readonly double4 gaga => new double4(g, a, g, a);

        public readonly double4 gabr => new double4(g, a, b, r);
        public readonly double4 gabg => new double4(g, a, b, g);
        public readonly double4 gabb => new double4(g, a, b, b);
        public readonly double4 gaba => new double4(g, a, b, a);

        public readonly double4 gaar => new double4(g, a, a, r);
        public readonly double4 gaag => new double4(g, a, a, g);
        public readonly double4 gaab => new double4(g, a, a, b);
        public readonly double4 gaaa => new double4(g, a, a, a);


        // b
        // br
        public readonly double4 brrr => new double4(b, r, r, r);
        public readonly double4 brrg => new double4(b, r, r, g);
        public readonly double4 brrb => new double4(b, r, r, b);
        public readonly double4 brra => new double4(b, r, r, a);

        public readonly double4 brgr => new double4(b, r, g, r);
        public readonly double4 brgg => new double4(b, r, g, g);
        public readonly double4 brgb => new double4(b, r, g, b);
        public readonly double4 brga => new double4(b, r, g, a);

        public readonly double4 brbr => new double4(b, r, b, r);
        public readonly double4 brbg => new double4(b, r, b, g);
        public readonly double4 brbb => new double4(b, r, b, b);
        public readonly double4 brba => new double4(b, r, b, a);

        public readonly double4 brar => new double4(b, r, a, r);
        public readonly double4 brag => new double4(b, r, a, g);
        public readonly double4 brab => new double4(b, r, a, b);
        public readonly double4 braa => new double4(b, r, a, a);

        // bg
        public readonly double4 bgrr => new double4(b, g, r, r);
        public readonly double4 bgrg => new double4(b, g, r, g);
        public readonly double4 bgrb => new double4(b, g, r, b);
        public readonly double4 bgra => new double4(b, g, r, a);

        public readonly double4 bggr => new double4(b, g, g, r);
        public readonly double4 bggg => new double4(b, g, g, g);
        public readonly double4 bggb => new double4(b, g, g, b);
        public readonly double4 bgga => new double4(b, g, g, a);

        public readonly double4 bgbr => new double4(b, g, b, r);
        public readonly double4 bgbg => new double4(b, g, b, g);
        public readonly double4 bgbb => new double4(b, g, b, b);
        public readonly double4 bgba => new double4(b, g, b, a);

        public readonly double4 bgar => new double4(b, g, a, r);
        public readonly double4 bgag => new double4(b, g, a, g);
        public readonly double4 bgab => new double4(b, g, a, b);
        public readonly double4 bgaa => new double4(b, g, a, a);

        // bb
        public readonly double4 bbrr => new double4(b, b, r, r);
        public readonly double4 bbrg => new double4(b, b, r, g);
        public readonly double4 bbrb => new double4(b, b, r, b);
        public readonly double4 bbra => new double4(b, b, r, a);

        public readonly double4 bbgr => new double4(b, b, g, r);
        public readonly double4 bbgg => new double4(b, b, g, g);
        public readonly double4 bbgb => new double4(b, b, g, b);
        public readonly double4 bbga => new double4(b, b, g, a);

        public readonly double4 bbbr => new double4(b, b, b, r);
        public readonly double4 bbbg => new double4(b, b, b, g);
        public readonly double4 bbbb => new double4(b, b, b, b);
        public readonly double4 bbba => new double4(b, b, b, a);

        public readonly double4 bbar => new double4(b, b, a, r);
        public readonly double4 bbag => new double4(b, b, a, g);
        public readonly double4 bbab => new double4(b, b, a, b);
        public readonly double4 bbaa => new double4(b, b, a, a);

        // ba
        public readonly double4 barr => new double4(b, a, r, r);
        public readonly double4 barg => new double4(b, a, r, g);
        public readonly double4 barb => new double4(b, a, r, b);
        public readonly double4 bara => new double4(b, a, r, a);

        public readonly double4 bagr => new double4(b, a, g, r);
        public readonly double4 bagg => new double4(b, a, g, g);
        public readonly double4 bagb => new double4(b, a, g, b);
        public readonly double4 baga => new double4(b, a, g, a);

        public readonly double4 babr => new double4(b, a, b, r);
        public readonly double4 babg => new double4(b, a, b, g);
        public readonly double4 babb => new double4(b, a, b, b);
        public readonly double4 baba => new double4(b, a, b, a);

        public readonly double4 baar => new double4(b, a, a, r);
        public readonly double4 baag => new double4(b, a, a, g);
        public readonly double4 baab => new double4(b, a, a, b);
        public readonly double4 baaa => new double4(b, a, a, a);


        // a
        // ar
        public readonly double4 arrr => new double4(a, r, r, r);
        public readonly double4 arrg => new double4(a, r, r, g);
        public readonly double4 arrb => new double4(a, r, r, b);
        public readonly double4 arra => new double4(a, r, r, a);

        public readonly double4 argr => new double4(a, r, g, r);
        public readonly double4 argg => new double4(a, r, g, g);
        public readonly double4 argb => new double4(a, r, g, b);
        public readonly double4 arga => new double4(a, r, g, a);

        public readonly double4 arbr => new double4(a, r, b, r);
        public readonly double4 arbg => new double4(a, r, b, g);
        public readonly double4 arbb => new double4(a, r, b, b);
        public readonly double4 arba => new double4(a, r, b, a);

        public readonly double4 arar => new double4(a, r, a, r);
        public readonly double4 arag => new double4(a, r, a, g);
        public readonly double4 arab => new double4(a, r, a, b);
        public readonly double4 araa => new double4(a, r, a, a);

        // ag
        public readonly double4 agrr => new double4(a, g, r, r);
        public readonly double4 agrg => new double4(a, g, r, g);
        public readonly double4 agrb => new double4(a, g, r, b);
        public readonly double4 agra => new double4(a, g, r, a);

        public readonly double4 aggr => new double4(a, g, g, r);
        public readonly double4 aggg => new double4(a, g, g, g);
        public readonly double4 aggb => new double4(a, g, g, b);
        public readonly double4 agga => new double4(a, g, g, a);

        public readonly double4 agbr => new double4(a, g, b, r);
        public readonly double4 agbg => new double4(a, g, b, g);
        public readonly double4 agbb => new double4(a, g, b, b);
        public readonly double4 agba => new double4(a, g, b, a);

        public readonly double4 agar => new double4(a, g, a, r);
        public readonly double4 agag => new double4(a, g, a, g);
        public readonly double4 agab => new double4(a, g, a, b);
        public readonly double4 agaa => new double4(a, g, a, a);

        // ab
        public readonly double4 abrr => new double4(a, b, r, r);
        public readonly double4 abrg => new double4(a, b, r, g);
        public readonly double4 abrb => new double4(a, b, r, b);
        public readonly double4 abra => new double4(a, b, r, a);

        public readonly double4 abgr => new double4(a, b, g, r);
        public readonly double4 abgg => new double4(a, b, g, g);
        public readonly double4 abgb => new double4(a, b, g, b);
        public readonly double4 abga => new double4(a, b, g, a);

        public readonly double4 abbr => new double4(a, b, b, r);
        public readonly double4 abbg => new double4(a, b, b, g);
        public readonly double4 abbb => new double4(a, b, b, b);
        public readonly double4 abba => new double4(a, b, b, a);

        public readonly double4 abar => new double4(a, b, a, r);
        public readonly double4 abag => new double4(a, b, a, g);
        public readonly double4 abab => new double4(a, b, a, b);
        public readonly double4 abaa => new double4(a, b, a, a);

        // aa
        public readonly double4 aarr => new double4(a, a, r, r);
        public readonly double4 aarg => new double4(a, a, r, g);
        public readonly double4 aarb => new double4(a, a, r, b);
        public readonly double4 aara => new double4(a, a, r, a);

        public readonly double4 aagr => new double4(a, a, g, r);
        public readonly double4 aagg => new double4(a, a, g, g);
        public readonly double4 aagb => new double4(a, a, g, b);
        public readonly double4 aaga => new double4(a, a, g, a);

        public readonly double4 aabr => new double4(a, a, b, r);
        public readonly double4 aabg => new double4(a, a, b, g);
        public readonly double4 aabb => new double4(a, a, b, b);
        public readonly double4 aaba => new double4(a, a, b, a);

        public readonly double4 aaar => new double4(a, a, a, r);
        public readonly double4 aaag => new double4(a, a, a, g);
        public readonly double4 aaab => new double4(a, a, a, b);
        public readonly double4 aaaa => new double4(a, a, a, a);

        #endregion Swizzles_double4_RGBA
        #region Swizzles_Extra

        // Swizzles - double3

        // x
        public readonly double3 xxx => new double3(x, x, x);
        public readonly double3 xxy => new double3(x, x, y);
        public readonly double3 xxz => new double3(x, x, z);
        public readonly double3 xxw => new double3(x, x, w);

        public readonly double3 xyx => new double3(x, y, x);
        public readonly double3 xyy => new double3(x, y, y);
        public readonly double3 xyz => new double3(x, y, z);
        public readonly double3 xyw => new double3(x, y, w);

        public readonly double3 xzx => new double3(x, z, x);
        public readonly double3 xzy => new double3(x, z, y);
        public readonly double3 xzz => new double3(x, z, z);
        public readonly double3 xzw => new double3(x, z, w);

        public readonly double3 xwx => new double3(x, w, x);
        public readonly double3 xwy => new double3(x, w, y);
        public readonly double3 xwz => new double3(x, w, z);
        public readonly double3 xww => new double3(x, w, w);

        // y
        public readonly double3 yxx => new double3(y, x, x);
        public readonly double3 yxy => new double3(y, x, y);
        public readonly double3 yxz => new double3(y, x, z);
        public readonly double3 yxw => new double3(y, x, w);

        public readonly double3 yyx => new double3(y, y, x);
        public readonly double3 yyy => new double3(y, y, y);
        public readonly double3 yyz => new double3(y, y, z);
        public readonly double3 yyw => new double3(y, y, w);

        public readonly double3 yzx => new double3(y, z, x);
        public readonly double3 yzy => new double3(y, z, y);
        public readonly double3 yzz => new double3(y, z, z);
        public readonly double3 yzw => new double3(y, z, w);

        public readonly double3 ywx => new double3(y, w, x);
        public readonly double3 ywy => new double3(y, w, y);
        public readonly double3 ywz => new double3(y, w, z);
        public readonly double3 yww => new double3(y, w, w);

        // z
        public readonly double3 zxx => new double3(z, x, x);
        public readonly double3 zxy => new double3(z, x, y);
        public readonly double3 zxz => new double3(z, x, z);
        public readonly double3 zxw => new double3(z, x, w);

        public readonly double3 zyx => new double3(z, y, x);
        public readonly double3 zyy => new double3(z, y, y);
        public readonly double3 zyz => new double3(z, y, z);
        public readonly double3 zyw => new double3(z, y, w);

        public readonly double3 zzx => new double3(z, z, x);
        public readonly double3 zzy => new double3(z, z, y);
        public readonly double3 zzz => new double3(z, z, z);
        public readonly double3 zzw => new double3(z, z, w);

        public readonly double3 zwx => new double3(z, w, x);
        public readonly double3 zwy => new double3(z, w, y);
        public readonly double3 zwz => new double3(z, w, z);
        public readonly double3 zww => new double3(z, w, w);

        // w
        public readonly double3 wxx => new double3(w, x, x);
        public readonly double3 wxy => new double3(w, x, y);
        public readonly double3 wxz => new double3(w, x, z);
        public readonly double3 wxw => new double3(w, x, w);

        public readonly double3 wyx => new double3(w, y, x);
        public readonly double3 wyy => new double3(w, y, y);
        public readonly double3 wyz => new double3(w, y, z);
        public readonly double3 wyw => new double3(w, y, w);

        public readonly double3 wzx => new double3(w, z, x);
        public readonly double3 wzy => new double3(w, z, y);
        public readonly double3 wzz => new double3(w, z, z);
        public readonly double3 wzw => new double3(w, z, w);

        public readonly double3 wwx => new double3(w, w, x);
        public readonly double3 wwy => new double3(w, w, y);
        public readonly double3 wwz => new double3(w, w, z);
        public readonly double3 www => new double3(w, w, w);

        // Swizzles - double2

        public readonly double2 xx => new double2(x, x);
        public readonly double2 xy => new double2(x, y);
        public readonly double2 xz => new double2(x, z);
        public readonly double2 xw => new double2(x, w);

        public readonly double2 yx => new double2(y, x);
        public readonly double2 yy => new double2(y, y);
        public readonly double2 yz => new double2(y, z);
        public readonly double2 yw => new double2(y, w);

        public readonly double2 zx => new double2(z, x);
        public readonly double2 zy => new double2(z, y);
        public readonly double2 zz => new double2(z, z);
        public readonly double2 zw => new double2(z, w);

        public readonly double2 wx => new double2(w, x);
        public readonly double2 wy => new double2(w, y);
        public readonly double2 wz => new double2(w, z);
        public readonly double2 ww => new double2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - double3

        // r
        public readonly double3 rrr => new double3(r, r, r);
        public readonly double3 rrg => new double3(r, r, g);
        public readonly double3 rrb => new double3(r, r, b);
        public readonly double3 rra => new double3(r, r, a);

        public readonly double3 rgr => new double3(r, g, r);
        public readonly double3 rgg => new double3(r, g, g);
        public readonly double3 rgb => new double3(r, g, b);
        public readonly double3 rga => new double3(r, g, a);

        public readonly double3 rbr => new double3(r, b, r);
        public readonly double3 rbg => new double3(r, b, g);
        public readonly double3 rbb => new double3(r, b, b);
        public readonly double3 rba => new double3(r, b, a);

        public readonly double3 rar => new double3(r, a, r);
        public readonly double3 rag => new double3(r, a, g);
        public readonly double3 rab => new double3(r, a, b);
        public readonly double3 raa => new double3(r, a, a);

        // g
        public readonly double3 grr => new double3(g, r, r);
        public readonly double3 grg => new double3(g, r, g);
        public readonly double3 grb => new double3(g, r, b);
        public readonly double3 gra => new double3(g, r, a);

        public readonly double3 ggr => new double3(g, g, r);
        public readonly double3 ggg => new double3(g, g, g);
        public readonly double3 ggb => new double3(g, g, b);
        public readonly double3 gga => new double3(g, g, a);

        public readonly double3 gbr => new double3(g, b, r);
        public readonly double3 gbg => new double3(g, b, g);
        public readonly double3 gbb => new double3(g, b, b);
        public readonly double3 gba => new double3(g, b, a);

        public readonly double3 gar => new double3(g, a, r);
        public readonly double3 gag => new double3(g, a, g);
        public readonly double3 gab => new double3(g, a, b);
        public readonly double3 gaa => new double3(g, a, a);

        // b
        public readonly double3 brr => new double3(b, r, r);
        public readonly double3 brg => new double3(b, r, g);
        public readonly double3 brb => new double3(b, r, b);
        public readonly double3 bra => new double3(b, r, a);

        public readonly double3 bgr => new double3(b, g, r);
        public readonly double3 bgg => new double3(b, g, g);
        public readonly double3 bgb => new double3(b, g, b);
        public readonly double3 bga => new double3(b, g, a);

        public readonly double3 bbr => new double3(b, b, r);
        public readonly double3 bbg => new double3(b, b, g);
        public readonly double3 bbb => new double3(b, b, b);
        public readonly double3 bba => new double3(b, b, a);

        public readonly double3 bar => new double3(b, a, r);
        public readonly double3 bag => new double3(b, a, g);
        public readonly double3 bab => new double3(b, a, b);
        public readonly double3 baa => new double3(b, a, a);

        // a
        public readonly double3 arr => new double3(a, r, r);
        public readonly double3 arg => new double3(a, r, g);
        public readonly double3 arb => new double3(a, r, b);
        public readonly double3 ara => new double3(a, r, a);

        public readonly double3 agr => new double3(a, g, r);
        public readonly double3 agg => new double3(a, g, g);
        public readonly double3 agb => new double3(a, g, b);
        public readonly double3 aga => new double3(a, g, a);

        public readonly double3 abr => new double3(a, b, r);
        public readonly double3 abg => new double3(a, b, g);
        public readonly double3 abb => new double3(a, b, b);
        public readonly double3 aba => new double3(a, b, a);

        public readonly double3 aar => new double3(a, a, r);
        public readonly double3 aag => new double3(a, a, g);
        public readonly double3 aab => new double3(a, a, b);
        public readonly double3 aaa => new double3(a, a, a);

        // RGBA - Swizzles - double2

        public readonly double2 rr => new double2(r, r);
        public readonly double2 rg => new double2(r, g);
        public readonly double2 rb => new double2(r, b);
        public readonly double2 ra => new double2(r, a);

        public readonly double2 gr => new double2(g, r);
        public readonly double2 gg => new double2(g, g);
        public readonly double2 gb => new double2(g, b);
        public readonly double2 ga => new double2(g, a);

        public readonly double2 br => new double2(b, r);
        public readonly double2 bg => new double2(b, g);
        public readonly double2 bb => new double2(b, b);
        public readonly double2 ba => new double2(b, a);

        public readonly double2 ar => new double2(a, r);
        public readonly double2 ag => new double2(a, g);
        public readonly double2 ab => new double2(a, b);
        public readonly double2 aa => new double2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
