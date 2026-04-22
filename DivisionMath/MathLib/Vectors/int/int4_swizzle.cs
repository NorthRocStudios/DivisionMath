namespace DivisionEngine.MathLib
{
    public partial struct int4
    {
        #region Swizzles_int4

        // Swizzles - int4

        // x
        // xx
        public readonly int4 xxxx => new int4(x, x, x, x);
        public readonly int4 xxxy => new int4(x, x, x, y);
        public readonly int4 xxxz => new int4(x, x, x, z);
        public readonly int4 xxxw => new int4(x, x, x, w);

        public readonly int4 xxyx => new int4(x, x, y, x);
        public readonly int4 xxyy => new int4(x, x, y, y);
        public readonly int4 xxyz => new int4(x, x, y, z);
        public readonly int4 xxyw => new int4(x, x, y, w);

        public readonly int4 xxzx => new int4(x, x, z, x);
        public readonly int4 xxzy => new int4(x, x, z, y);
        public readonly int4 xxzz => new int4(x, x, z, z);
        public readonly int4 xxzw => new int4(x, x, z, w);

        public readonly int4 xxwx => new int4(x, x, w, x);
        public readonly int4 xxwy => new int4(x, x, w, y);
        public readonly int4 xxwz => new int4(x, x, w, z);
        public readonly int4 xxww => new int4(x, x, w, w);

        // xy
        public readonly int4 xyxx => new int4(x, y, x, x);
        public readonly int4 xyxy => new int4(x, y, x, y);
        public readonly int4 xyxz => new int4(x, y, x, z);
        public readonly int4 xyxw => new int4(x, y, x, w);

        public readonly int4 xyyx => new int4(x, y, y, x);
        public readonly int4 xyyy => new int4(x, y, y, y);
        public readonly int4 xyyz => new int4(x, y, y, z);
        public readonly int4 xyyw => new int4(x, y, y, w);

        public readonly int4 xyzx => new int4(x, y, z, x);
        public readonly int4 xyzy => new int4(x, y, z, y);
        public readonly int4 xyzz => new int4(x, y, z, z);
        public readonly int4 xyzw => new int4(x, y, z, w);

        public readonly int4 xywx => new int4(x, y, w, x);
        public readonly int4 xywy => new int4(x, y, w, y);
        public readonly int4 xywz => new int4(x, y, w, z);
        public readonly int4 xyww => new int4(x, y, w, w);

        // xz
        public readonly int4 xzxx => new int4(x, z, x, x);
        public readonly int4 xzxy => new int4(x, z, x, y);
        public readonly int4 xzxz => new int4(x, z, x, z);
        public readonly int4 xzxw => new int4(x, z, x, w);

        public readonly int4 xzyx => new int4(x, z, y, x);
        public readonly int4 xzyy => new int4(x, z, y, y);
        public readonly int4 xzyz => new int4(x, z, y, z);
        public readonly int4 xzyw => new int4(x, z, y, w);

        public readonly int4 xzzx => new int4(x, z, z, x);
        public readonly int4 xzzy => new int4(x, z, z, y);
        public readonly int4 xzzz => new int4(x, z, z, z);
        public readonly int4 xzzw => new int4(x, z, z, w);

        public readonly int4 xzwx => new int4(x, z, w, x);
        public readonly int4 xzwy => new int4(x, z, w, y);
        public readonly int4 xzwz => new int4(x, z, w, z);
        public readonly int4 xzww => new int4(x, z, w, w);

        // xw
        public readonly int4 xwxx => new int4(x, w, x, x);
        public readonly int4 xwxy => new int4(x, w, x, y);
        public readonly int4 xwxz => new int4(x, w, x, z);
        public readonly int4 xwxw => new int4(x, w, x, w);

        public readonly int4 xwyx => new int4(x, w, y, x);
        public readonly int4 xwyy => new int4(x, w, y, y);
        public readonly int4 xwyz => new int4(x, w, y, z);
        public readonly int4 xwyw => new int4(x, w, y, w);

        public readonly int4 xwzx => new int4(x, w, z, x);
        public readonly int4 xwzy => new int4(x, w, z, y);
        public readonly int4 xwzz => new int4(x, w, z, z);
        public readonly int4 xwzw => new int4(x, w, z, w);

        public readonly int4 xwwx => new int4(x, w, w, x);
        public readonly int4 xwwy => new int4(x, w, w, y);
        public readonly int4 xwwz => new int4(x, w, w, z);
        public readonly int4 xwww => new int4(x, w, w, w);


        // y
        // yx
        public readonly int4 yxxx => new int4(y, x, x, x);
        public readonly int4 yxxy => new int4(y, x, x, y);
        public readonly int4 yxxz => new int4(y, x, x, z);
        public readonly int4 yxxw => new int4(y, x, x, w);

        public readonly int4 yxyx => new int4(y, x, y, x);
        public readonly int4 yxyy => new int4(y, x, y, y);
        public readonly int4 yxyz => new int4(y, x, y, z);
        public readonly int4 yxyw => new int4(y, x, y, w);

        public readonly int4 yxzx => new int4(y, x, z, x);
        public readonly int4 yxzy => new int4(y, x, z, y);
        public readonly int4 yxzz => new int4(y, x, z, z);
        public readonly int4 yxzw => new int4(y, x, z, w);

        public readonly int4 yxwx => new int4(y, x, w, x);
        public readonly int4 yxwy => new int4(y, x, w, y);
        public readonly int4 yxwz => new int4(y, x, w, z);
        public readonly int4 yxww => new int4(y, x, w, w);

        // yy
        public readonly int4 yyxx => new int4(y, y, x, x);
        public readonly int4 yyxy => new int4(y, y, x, y);
        public readonly int4 yyxz => new int4(y, y, x, z);
        public readonly int4 yyxw => new int4(y, y, x, w);

        public readonly int4 yyyx => new int4(y, y, y, x);
        public readonly int4 yyyy => new int4(y, y, y, y);
        public readonly int4 yyyz => new int4(y, y, y, z);
        public readonly int4 yyyw => new int4(y, y, y, w);

        public readonly int4 yyzx => new int4(y, y, z, x);
        public readonly int4 yyzy => new int4(y, y, z, y);
        public readonly int4 yyzz => new int4(y, y, z, z);
        public readonly int4 yyzw => new int4(y, y, z, w);

        public readonly int4 yywx => new int4(y, y, w, x);
        public readonly int4 yywy => new int4(y, y, w, y);
        public readonly int4 yywz => new int4(y, y, w, z);
        public readonly int4 yyww => new int4(y, y, w, w);

        // yz
        public readonly int4 yzxx => new int4(y, z, x, x);
        public readonly int4 yzxy => new int4(y, z, x, y);
        public readonly int4 yzxz => new int4(y, z, x, z);
        public readonly int4 yzxw => new int4(y, z, x, w);

        public readonly int4 yzyx => new int4(y, z, y, x);
        public readonly int4 yzyy => new int4(y, z, y, y);
        public readonly int4 yzyz => new int4(y, z, y, z);
        public readonly int4 yzyw => new int4(y, z, y, w);

        public readonly int4 yzzx => new int4(y, z, z, x);
        public readonly int4 yzzy => new int4(y, z, z, y);
        public readonly int4 yzzz => new int4(y, z, z, z);
        public readonly int4 yzzw => new int4(y, z, z, w);

        public readonly int4 yzwx => new int4(y, z, w, x);
        public readonly int4 yzwy => new int4(y, z, w, y);
        public readonly int4 yzwz => new int4(y, z, w, z);
        public readonly int4 yzww => new int4(y, z, w, w);

        // yw
        public readonly int4 ywxx => new int4(y, w, x, x);
        public readonly int4 ywxy => new int4(y, w, x, y);
        public readonly int4 ywxz => new int4(y, w, x, z);
        public readonly int4 ywxw => new int4(y, w, x, w);

        public readonly int4 ywyx => new int4(y, w, y, x);
        public readonly int4 ywyy => new int4(y, w, y, y);
        public readonly int4 ywyz => new int4(y, w, y, z);
        public readonly int4 ywyw => new int4(y, w, y, w);

        public readonly int4 ywzx => new int4(y, w, z, x);
        public readonly int4 ywzy => new int4(y, w, z, y);
        public readonly int4 ywzz => new int4(y, w, z, z);
        public readonly int4 ywzw => new int4(y, w, z, w);

        public readonly int4 ywwx => new int4(y, w, w, x);
        public readonly int4 ywwy => new int4(y, w, w, y);
        public readonly int4 ywwz => new int4(y, w, w, z);
        public readonly int4 ywww => new int4(y, w, w, w);


        // z
        // zx
        public readonly int4 zxxx => new int4(z, x, x, x);
        public readonly int4 zxxy => new int4(z, x, x, y);
        public readonly int4 zxxz => new int4(z, x, x, z);
        public readonly int4 zxxw => new int4(z, x, x, w);

        public readonly int4 zxyx => new int4(z, x, y, x);
        public readonly int4 zxyy => new int4(z, x, y, y);
        public readonly int4 zxyz => new int4(z, x, y, z);
        public readonly int4 zxyw => new int4(z, x, y, w);

        public readonly int4 zxzx => new int4(z, x, z, x);
        public readonly int4 zxzy => new int4(z, x, z, y);
        public readonly int4 zxzz => new int4(z, x, z, z);
        public readonly int4 zxzw => new int4(z, x, z, w);

        public readonly int4 zxwx => new int4(z, x, w, x);
        public readonly int4 zxwy => new int4(z, x, w, y);
        public readonly int4 zxwz => new int4(z, x, w, z);
        public readonly int4 zxww => new int4(z, x, w, w);

        // zy
        public readonly int4 zyxx => new int4(z, y, x, x);
        public readonly int4 zyxy => new int4(z, y, x, y);
        public readonly int4 zyxz => new int4(z, y, x, z);
        public readonly int4 zyxw => new int4(z, y, x, w);

        public readonly int4 zyyx => new int4(z, y, y, x);
        public readonly int4 zyyy => new int4(z, y, y, y);
        public readonly int4 zyyz => new int4(z, y, y, z);
        public readonly int4 zyyw => new int4(z, y, y, w);

        public readonly int4 zyzx => new int4(z, y, z, x);
        public readonly int4 zyzy => new int4(z, y, z, y);
        public readonly int4 zyzz => new int4(z, y, z, z);
        public readonly int4 zyzw => new int4(z, y, z, w);

        public readonly int4 zywx => new int4(z, y, w, x);
        public readonly int4 zywy => new int4(z, y, w, y);
        public readonly int4 zywz => new int4(z, y, w, z);
        public readonly int4 zyww => new int4(z, y, w, w);

        // zz
        public readonly int4 zzxx => new int4(z, z, x, x);
        public readonly int4 zzxy => new int4(z, z, x, y);
        public readonly int4 zzxz => new int4(z, z, x, z);
        public readonly int4 zzxw => new int4(z, z, x, w);

        public readonly int4 zzyx => new int4(z, z, y, x);
        public readonly int4 zzyy => new int4(z, z, y, y);
        public readonly int4 zzyz => new int4(z, z, y, z);
        public readonly int4 zzyw => new int4(z, z, y, w);

        public readonly int4 zzzx => new int4(z, z, z, x);
        public readonly int4 zzzy => new int4(z, z, z, y);
        public readonly int4 zzzz => new int4(z, z, z, z);
        public readonly int4 zzzw => new int4(z, z, z, w);

        public readonly int4 zzwx => new int4(z, z, w, x);
        public readonly int4 zzwy => new int4(z, z, w, y);
        public readonly int4 zzwz => new int4(z, z, w, z);
        public readonly int4 zzww => new int4(z, z, w, w);

        // zw
        public readonly int4 zwxx => new int4(z, w, x, x);
        public readonly int4 zwxy => new int4(z, w, x, y);
        public readonly int4 zwxz => new int4(z, w, x, z);
        public readonly int4 zwxw => new int4(z, w, x, w);

        public readonly int4 zwyx => new int4(z, w, y, x);
        public readonly int4 zwyy => new int4(z, w, y, y);
        public readonly int4 zwyz => new int4(z, w, y, z);
        public readonly int4 zwyw => new int4(z, w, y, w);

        public readonly int4 zwzx => new int4(z, w, z, x);
        public readonly int4 zwzy => new int4(z, w, z, y);
        public readonly int4 zwzz => new int4(z, w, z, z);
        public readonly int4 zwzw => new int4(z, w, z, w);

        public readonly int4 zwwx => new int4(z, w, w, x);
        public readonly int4 zwwy => new int4(z, w, w, y);
        public readonly int4 zwwz => new int4(z, w, w, z);
        public readonly int4 zwww => new int4(z, w, w, w);


        // w
        // wx
        public readonly int4 wxxx => new int4(w, x, x, x);
        public readonly int4 wxxy => new int4(w, x, x, y);
        public readonly int4 wxxz => new int4(w, x, x, z);
        public readonly int4 wxxw => new int4(w, x, x, w);

        public readonly int4 wxyx => new int4(w, x, y, x);
        public readonly int4 wxyy => new int4(w, x, y, y);
        public readonly int4 wxyz => new int4(w, x, y, z);
        public readonly int4 wxyw => new int4(w, x, y, w);

        public readonly int4 wxzx => new int4(w, x, z, x);
        public readonly int4 wxzy => new int4(w, x, z, y);
        public readonly int4 wxzz => new int4(w, x, z, z);
        public readonly int4 wxzw => new int4(w, x, z, w);

        public readonly int4 wxwx => new int4(w, x, w, x);
        public readonly int4 wxwy => new int4(w, x, w, y);
        public readonly int4 wxwz => new int4(w, x, w, z);
        public readonly int4 wxww => new int4(w, x, w, w);

        // wy
        public readonly int4 wyxx => new int4(w, y, x, x);
        public readonly int4 wyxy => new int4(w, y, x, y);
        public readonly int4 wyxz => new int4(w, y, x, z);
        public readonly int4 wyxw => new int4(w, y, x, w);

        public readonly int4 wyyx => new int4(w, y, y, x);
        public readonly int4 wyyy => new int4(w, y, y, y);
        public readonly int4 wyyz => new int4(w, y, y, z);
        public readonly int4 wyyw => new int4(w, y, y, w);

        public readonly int4 wyzx => new int4(w, y, z, x);
        public readonly int4 wyzy => new int4(w, y, z, y);
        public readonly int4 wyzz => new int4(w, y, z, z);
        public readonly int4 wyzw => new int4(w, y, z, w);

        public readonly int4 wywx => new int4(w, y, w, x);
        public readonly int4 wywy => new int4(w, y, w, y);
        public readonly int4 wywz => new int4(w, y, w, z);
        public readonly int4 wyww => new int4(w, y, w, w);

        // wz
        public readonly int4 wzxx => new int4(w, z, x, x);
        public readonly int4 wzxy => new int4(w, z, x, y);
        public readonly int4 wzxz => new int4(w, z, x, z);
        public readonly int4 wzxw => new int4(w, z, x, w);

        public readonly int4 wzyx => new int4(w, z, y, x);
        public readonly int4 wzyy => new int4(w, z, y, y);
        public readonly int4 wzyz => new int4(w, z, y, z);
        public readonly int4 wzyw => new int4(w, z, y, w);

        public readonly int4 wzzx => new int4(w, z, z, x);
        public readonly int4 wzzy => new int4(w, z, z, y);
        public readonly int4 wzzz => new int4(w, z, z, z);
        public readonly int4 wzzw => new int4(w, z, z, w);

        public readonly int4 wzwx => new int4(w, z, w, x);
        public readonly int4 wzwy => new int4(w, z, w, y);
        public readonly int4 wzwz => new int4(w, z, w, z);
        public readonly int4 wzww => new int4(w, z, w, w);

        // ww
        public readonly int4 wwxx => new int4(w, w, x, x);
        public readonly int4 wwxy => new int4(w, w, x, y);
        public readonly int4 wwxz => new int4(w, w, x, z);
        public readonly int4 wwxw => new int4(w, w, x, w);

        public readonly int4 wwyx => new int4(w, w, y, x);
        public readonly int4 wwyy => new int4(w, w, y, y);
        public readonly int4 wwyz => new int4(w, w, y, z);
        public readonly int4 wwyw => new int4(w, w, y, w);

        public readonly int4 wwzx => new int4(w, w, z, x);
        public readonly int4 wwzy => new int4(w, w, z, y);
        public readonly int4 wwzz => new int4(w, w, z, z);
        public readonly int4 wwzw => new int4(w, w, z, w);

        public readonly int4 wwwx => new int4(w, w, w, x);
        public readonly int4 wwwy => new int4(w, w, w, y);
        public readonly int4 wwwz => new int4(w, w, w, z);
        public readonly int4 wwww => new int4(w, w, w, w);

        #endregion Swizzles_int4
        #region Swizzles_int4_RGBA

        // RGBA - Swizzles - int4

        // r
        // rr
        public readonly int4 rrrr => new int4(r, r, r, r);
        public readonly int4 rrrg => new int4(r, r, r, g);
        public readonly int4 rrrb => new int4(r, r, r, b);
        public readonly int4 rrra => new int4(r, r, r, a);

        public readonly int4 rrgr => new int4(r, r, g, r);
        public readonly int4 rrgg => new int4(r, r, g, g);
        public readonly int4 rrgb => new int4(r, r, g, b);
        public readonly int4 rrga => new int4(r, r, g, a);

        public readonly int4 rrbr => new int4(r, r, b, r);
        public readonly int4 rrbg => new int4(r, r, b, g);
        public readonly int4 rrbb => new int4(r, r, b, b);
        public readonly int4 rrba => new int4(r, r, b, a);

        public readonly int4 rrar => new int4(r, r, a, r);
        public readonly int4 rrag => new int4(r, r, a, g);
        public readonly int4 rrab => new int4(r, r, a, b);
        public readonly int4 rraa => new int4(r, r, a, a);

        // rg
        public readonly int4 rgrr => new int4(r, g, r, r);
        public readonly int4 rgrg => new int4(r, g, r, g);
        public readonly int4 rgrb => new int4(r, g, r, b);
        public readonly int4 rgra => new int4(r, g, r, a);

        public readonly int4 rggr => new int4(r, g, g, r);
        public readonly int4 rggg => new int4(r, g, g, g);
        public readonly int4 rggb => new int4(r, g, g, b);
        public readonly int4 rgga => new int4(r, g, g, a);

        public readonly int4 rgbr => new int4(r, g, b, r);
        public readonly int4 rgbg => new int4(r, g, b, g);
        public readonly int4 rgbb => new int4(r, g, b, b);
        public readonly int4 rgba => new int4(r, g, b, a);

        public readonly int4 rgar => new int4(r, g, a, r);
        public readonly int4 rgag => new int4(r, g, a, g);
        public readonly int4 rgab => new int4(r, g, a, b);
        public readonly int4 rgaa => new int4(r, g, a, a);

        // rb
        public readonly int4 rbrr => new int4(r, b, r, r);
        public readonly int4 rbrg => new int4(r, b, r, g);
        public readonly int4 rbrb => new int4(r, b, r, b);
        public readonly int4 rbra => new int4(r, b, r, a);

        public readonly int4 rbgr => new int4(r, b, g, r);
        public readonly int4 rbgg => new int4(r, b, g, g);
        public readonly int4 rbgb => new int4(r, b, g, b);
        public readonly int4 rbga => new int4(r, b, g, a);

        public readonly int4 rbbr => new int4(r, b, b, r);
        public readonly int4 rbbg => new int4(r, b, b, g);
        public readonly int4 rbbb => new int4(r, b, b, b);
        public readonly int4 rbba => new int4(r, b, b, a);

        public readonly int4 rbar => new int4(r, b, a, r);
        public readonly int4 rbag => new int4(r, b, a, g);
        public readonly int4 rbab => new int4(r, b, a, b);
        public readonly int4 rbaa => new int4(r, b, a, a);

        // ra
        public readonly int4 rarr => new int4(r, a, r, r);
        public readonly int4 rarg => new int4(r, a, r, g);
        public readonly int4 rarb => new int4(r, a, r, b);
        public readonly int4 rara => new int4(r, a, r, a);

        public readonly int4 ragr => new int4(r, a, g, r);
        public readonly int4 ragg => new int4(r, a, g, g);
        public readonly int4 ragb => new int4(r, a, g, b);
        public readonly int4 raga => new int4(r, a, g, a);

        public readonly int4 rabr => new int4(r, a, b, r);
        public readonly int4 rabg => new int4(r, a, b, g);
        public readonly int4 rabb => new int4(r, a, b, b);
        public readonly int4 raba => new int4(r, a, b, a);

        public readonly int4 raar => new int4(r, a, a, r);
        public readonly int4 raag => new int4(r, a, a, g);
        public readonly int4 raab => new int4(r, a, a, b);
        public readonly int4 raaa => new int4(r, a, a, a);


        // g
        // gr
        public readonly int4 grrr => new int4(g, r, r, r);
        public readonly int4 grrg => new int4(g, r, r, g);
        public readonly int4 grrb => new int4(g, r, r, b);
        public readonly int4 grra => new int4(g, r, r, a);

        public readonly int4 grgr => new int4(g, r, g, r);
        public readonly int4 grgg => new int4(g, r, g, g);
        public readonly int4 grgb => new int4(g, r, g, b);
        public readonly int4 grga => new int4(g, r, g, a);

        public readonly int4 grbr => new int4(g, r, b, r);
        public readonly int4 grbg => new int4(g, r, b, g);
        public readonly int4 grbb => new int4(g, r, b, b);
        public readonly int4 grba => new int4(g, r, b, a);

        public readonly int4 grar => new int4(g, r, a, r);
        public readonly int4 grag => new int4(g, r, a, g);
        public readonly int4 grab => new int4(g, r, a, b);
        public readonly int4 graa => new int4(g, r, a, a);

        // gg
        public readonly int4 ggrr => new int4(g, g, r, r);
        public readonly int4 ggrg => new int4(g, g, r, g);
        public readonly int4 ggrb => new int4(g, g, r, b);
        public readonly int4 ggra => new int4(g, g, r, a);

        public readonly int4 gggr => new int4(g, g, g, r);
        public readonly int4 gggg => new int4(g, g, g, g);
        public readonly int4 gggb => new int4(g, g, g, b);
        public readonly int4 ggga => new int4(g, g, g, a);

        public readonly int4 ggbr => new int4(g, g, b, r);
        public readonly int4 ggbg => new int4(g, g, b, g);
        public readonly int4 ggbb => new int4(g, g, b, b);
        public readonly int4 ggba => new int4(g, g, b, a);

        public readonly int4 ggar => new int4(g, g, a, r);
        public readonly int4 ggag => new int4(g, g, a, g);
        public readonly int4 ggab => new int4(g, g, a, b);
        public readonly int4 ggaa => new int4(g, g, a, a);

        // gb
        public readonly int4 gbrr => new int4(g, b, r, r);
        public readonly int4 gbrg => new int4(g, b, r, g);
        public readonly int4 gbrb => new int4(g, b, r, b);
        public readonly int4 gbra => new int4(g, b, r, a);

        public readonly int4 gbgr => new int4(g, b, g, r);
        public readonly int4 gbgg => new int4(g, b, g, g);
        public readonly int4 gbgb => new int4(g, b, g, b);
        public readonly int4 gbga => new int4(g, b, g, a);

        public readonly int4 gbbr => new int4(g, b, b, r);
        public readonly int4 gbbg => new int4(g, b, b, g);
        public readonly int4 gbbb => new int4(g, b, b, b);
        public readonly int4 gbba => new int4(g, b, b, a);

        public readonly int4 gbar => new int4(g, b, a, r);
        public readonly int4 gbag => new int4(g, b, a, g);
        public readonly int4 gbab => new int4(g, b, a, b);
        public readonly int4 gbaa => new int4(g, b, a, a);

        // ga
        public readonly int4 garr => new int4(g, a, r, r);
        public readonly int4 garg => new int4(g, a, r, g);
        public readonly int4 garb => new int4(g, a, r, b);
        public readonly int4 gara => new int4(g, a, r, a);

        public readonly int4 gagr => new int4(g, a, g, r);
        public readonly int4 gagg => new int4(g, a, g, g);
        public readonly int4 gagb => new int4(g, a, g, b);
        public readonly int4 gaga => new int4(g, a, g, a);

        public readonly int4 gabr => new int4(g, a, b, r);
        public readonly int4 gabg => new int4(g, a, b, g);
        public readonly int4 gabb => new int4(g, a, b, b);
        public readonly int4 gaba => new int4(g, a, b, a);

        public readonly int4 gaar => new int4(g, a, a, r);
        public readonly int4 gaag => new int4(g, a, a, g);
        public readonly int4 gaab => new int4(g, a, a, b);
        public readonly int4 gaaa => new int4(g, a, a, a);


        // b
        // br
        public readonly int4 brrr => new int4(b, r, r, r);
        public readonly int4 brrg => new int4(b, r, r, g);
        public readonly int4 brrb => new int4(b, r, r, b);
        public readonly int4 brra => new int4(b, r, r, a);

        public readonly int4 brgr => new int4(b, r, g, r);
        public readonly int4 brgg => new int4(b, r, g, g);
        public readonly int4 brgb => new int4(b, r, g, b);
        public readonly int4 brga => new int4(b, r, g, a);

        public readonly int4 brbr => new int4(b, r, b, r);
        public readonly int4 brbg => new int4(b, r, b, g);
        public readonly int4 brbb => new int4(b, r, b, b);
        public readonly int4 brba => new int4(b, r, b, a);

        public readonly int4 brar => new int4(b, r, a, r);
        public readonly int4 brag => new int4(b, r, a, g);
        public readonly int4 brab => new int4(b, r, a, b);
        public readonly int4 braa => new int4(b, r, a, a);

        // bg
        public readonly int4 bgrr => new int4(b, g, r, r);
        public readonly int4 bgrg => new int4(b, g, r, g);
        public readonly int4 bgrb => new int4(b, g, r, b);
        public readonly int4 bgra => new int4(b, g, r, a);

        public readonly int4 bggr => new int4(b, g, g, r);
        public readonly int4 bggg => new int4(b, g, g, g);
        public readonly int4 bggb => new int4(b, g, g, b);
        public readonly int4 bgga => new int4(b, g, g, a);

        public readonly int4 bgbr => new int4(b, g, b, r);
        public readonly int4 bgbg => new int4(b, g, b, g);
        public readonly int4 bgbb => new int4(b, g, b, b);
        public readonly int4 bgba => new int4(b, g, b, a);

        public readonly int4 bgar => new int4(b, g, a, r);
        public readonly int4 bgag => new int4(b, g, a, g);
        public readonly int4 bgab => new int4(b, g, a, b);
        public readonly int4 bgaa => new int4(b, g, a, a);

        // bb
        public readonly int4 bbrr => new int4(b, b, r, r);
        public readonly int4 bbrg => new int4(b, b, r, g);
        public readonly int4 bbrb => new int4(b, b, r, b);
        public readonly int4 bbra => new int4(b, b, r, a);

        public readonly int4 bbgr => new int4(b, b, g, r);
        public readonly int4 bbgg => new int4(b, b, g, g);
        public readonly int4 bbgb => new int4(b, b, g, b);
        public readonly int4 bbga => new int4(b, b, g, a);

        public readonly int4 bbbr => new int4(b, b, b, r);
        public readonly int4 bbbg => new int4(b, b, b, g);
        public readonly int4 bbbb => new int4(b, b, b, b);
        public readonly int4 bbba => new int4(b, b, b, a);

        public readonly int4 bbar => new int4(b, b, a, r);
        public readonly int4 bbag => new int4(b, b, a, g);
        public readonly int4 bbab => new int4(b, b, a, b);
        public readonly int4 bbaa => new int4(b, b, a, a);

        // ba
        public readonly int4 barr => new int4(b, a, r, r);
        public readonly int4 barg => new int4(b, a, r, g);
        public readonly int4 barb => new int4(b, a, r, b);
        public readonly int4 bara => new int4(b, a, r, a);

        public readonly int4 bagr => new int4(b, a, g, r);
        public readonly int4 bagg => new int4(b, a, g, g);
        public readonly int4 bagb => new int4(b, a, g, b);
        public readonly int4 baga => new int4(b, a, g, a);

        public readonly int4 babr => new int4(b, a, b, r);
        public readonly int4 babg => new int4(b, a, b, g);
        public readonly int4 babb => new int4(b, a, b, b);
        public readonly int4 baba => new int4(b, a, b, a);

        public readonly int4 baar => new int4(b, a, a, r);
        public readonly int4 baag => new int4(b, a, a, g);
        public readonly int4 baab => new int4(b, a, a, b);
        public readonly int4 baaa => new int4(b, a, a, a);


        // a
        // ar
        public readonly int4 arrr => new int4(a, r, r, r);
        public readonly int4 arrg => new int4(a, r, r, g);
        public readonly int4 arrb => new int4(a, r, r, b);
        public readonly int4 arra => new int4(a, r, r, a);

        public readonly int4 argr => new int4(a, r, g, r);
        public readonly int4 argg => new int4(a, r, g, g);
        public readonly int4 argb => new int4(a, r, g, b);
        public readonly int4 arga => new int4(a, r, g, a);

        public readonly int4 arbr => new int4(a, r, b, r);
        public readonly int4 arbg => new int4(a, r, b, g);
        public readonly int4 arbb => new int4(a, r, b, b);
        public readonly int4 arba => new int4(a, r, b, a);

        public readonly int4 arar => new int4(a, r, a, r);
        public readonly int4 arag => new int4(a, r, a, g);
        public readonly int4 arab => new int4(a, r, a, b);
        public readonly int4 araa => new int4(a, r, a, a);

        // ag
        public readonly int4 agrr => new int4(a, g, r, r);
        public readonly int4 agrg => new int4(a, g, r, g);
        public readonly int4 agrb => new int4(a, g, r, b);
        public readonly int4 agra => new int4(a, g, r, a);

        public readonly int4 aggr => new int4(a, g, g, r);
        public readonly int4 aggg => new int4(a, g, g, g);
        public readonly int4 aggb => new int4(a, g, g, b);
        public readonly int4 agga => new int4(a, g, g, a);

        public readonly int4 agbr => new int4(a, g, b, r);
        public readonly int4 agbg => new int4(a, g, b, g);
        public readonly int4 agbb => new int4(a, g, b, b);
        public readonly int4 agba => new int4(a, g, b, a);

        public readonly int4 agar => new int4(a, g, a, r);
        public readonly int4 agag => new int4(a, g, a, g);
        public readonly int4 agab => new int4(a, g, a, b);
        public readonly int4 agaa => new int4(a, g, a, a);

        // ab
        public readonly int4 abrr => new int4(a, b, r, r);
        public readonly int4 abrg => new int4(a, b, r, g);
        public readonly int4 abrb => new int4(a, b, r, b);
        public readonly int4 abra => new int4(a, b, r, a);

        public readonly int4 abgr => new int4(a, b, g, r);
        public readonly int4 abgg => new int4(a, b, g, g);
        public readonly int4 abgb => new int4(a, b, g, b);
        public readonly int4 abga => new int4(a, b, g, a);

        public readonly int4 abbr => new int4(a, b, b, r);
        public readonly int4 abbg => new int4(a, b, b, g);
        public readonly int4 abbb => new int4(a, b, b, b);
        public readonly int4 abba => new int4(a, b, b, a);

        public readonly int4 abar => new int4(a, b, a, r);
        public readonly int4 abag => new int4(a, b, a, g);
        public readonly int4 abab => new int4(a, b, a, b);
        public readonly int4 abaa => new int4(a, b, a, a);

        // aa
        public readonly int4 aarr => new int4(a, a, r, r);
        public readonly int4 aarg => new int4(a, a, r, g);
        public readonly int4 aarb => new int4(a, a, r, b);
        public readonly int4 aara => new int4(a, a, r, a);

        public readonly int4 aagr => new int4(a, a, g, r);
        public readonly int4 aagg => new int4(a, a, g, g);
        public readonly int4 aagb => new int4(a, a, g, b);
        public readonly int4 aaga => new int4(a, a, g, a);

        public readonly int4 aabr => new int4(a, a, b, r);
        public readonly int4 aabg => new int4(a, a, b, g);
        public readonly int4 aabb => new int4(a, a, b, b);
        public readonly int4 aaba => new int4(a, a, b, a);

        public readonly int4 aaar => new int4(a, a, a, r);
        public readonly int4 aaag => new int4(a, a, a, g);
        public readonly int4 aaab => new int4(a, a, a, b);
        public readonly int4 aaaa => new int4(a, a, a, a);

        #endregion Swizzles_int4_RGBA
        #region Swizzles_Extra

        // Swizzles - int3

        // x
        public readonly int3 xxx => new int3(x, x, x);
        public readonly int3 xxy => new int3(x, x, y);
        public readonly int3 xxz => new int3(x, x, z);
        public readonly int3 xxw => new int3(x, x, w);

        public readonly int3 xyx => new int3(x, y, x);
        public readonly int3 xyy => new int3(x, y, y);
        public readonly int3 xyz => new int3(x, y, z);
        public readonly int3 xyw => new int3(x, y, w);

        public readonly int3 xzx => new int3(x, z, x);
        public readonly int3 xzy => new int3(x, z, y);
        public readonly int3 xzz => new int3(x, z, z);
        public readonly int3 xzw => new int3(x, z, w);

        public readonly int3 xwx => new int3(x, w, x);
        public readonly int3 xwy => new int3(x, w, y);
        public readonly int3 xwz => new int3(x, w, z);
        public readonly int3 xww => new int3(x, w, w);

        // y
        public readonly int3 yxx => new int3(y, x, x);
        public readonly int3 yxy => new int3(y, x, y);
        public readonly int3 yxz => new int3(y, x, z);
        public readonly int3 yxw => new int3(y, x, w);

        public readonly int3 yyx => new int3(y, y, x);
        public readonly int3 yyy => new int3(y, y, y);
        public readonly int3 yyz => new int3(y, y, z);
        public readonly int3 yyw => new int3(y, y, w);

        public readonly int3 yzx => new int3(y, z, x);
        public readonly int3 yzy => new int3(y, z, y);
        public readonly int3 yzz => new int3(y, z, z);
        public readonly int3 yzw => new int3(y, z, w);

        public readonly int3 ywx => new int3(y, w, x);
        public readonly int3 ywy => new int3(y, w, y);
        public readonly int3 ywz => new int3(y, w, z);
        public readonly int3 yww => new int3(y, w, w);

        // z
        public readonly int3 zxx => new int3(z, x, x);
        public readonly int3 zxy => new int3(z, x, y);
        public readonly int3 zxz => new int3(z, x, z);
        public readonly int3 zxw => new int3(z, x, w);

        public readonly int3 zyx => new int3(z, y, x);
        public readonly int3 zyy => new int3(z, y, y);
        public readonly int3 zyz => new int3(z, y, z);
        public readonly int3 zyw => new int3(z, y, w);

        public readonly int3 zzx => new int3(z, z, x);
        public readonly int3 zzy => new int3(z, z, y);
        public readonly int3 zzz => new int3(z, z, z);
        public readonly int3 zzw => new int3(z, z, w);

        public readonly int3 zwx => new int3(z, w, x);
        public readonly int3 zwy => new int3(z, w, y);
        public readonly int3 zwz => new int3(z, w, z);
        public readonly int3 zww => new int3(z, w, w);

        // w
        public readonly int3 wxx => new int3(w, x, x);
        public readonly int3 wxy => new int3(w, x, y);
        public readonly int3 wxz => new int3(w, x, z);
        public readonly int3 wxw => new int3(w, x, w);

        public readonly int3 wyx => new int3(w, y, x);
        public readonly int3 wyy => new int3(w, y, y);
        public readonly int3 wyz => new int3(w, y, z);
        public readonly int3 wyw => new int3(w, y, w);

        public readonly int3 wzx => new int3(w, z, x);
        public readonly int3 wzy => new int3(w, z, y);
        public readonly int3 wzz => new int3(w, z, z);
        public readonly int3 wzw => new int3(w, z, w);

        public readonly int3 wwx => new int3(w, w, x);
        public readonly int3 wwy => new int3(w, w, y);
        public readonly int3 wwz => new int3(w, w, z);
        public readonly int3 www => new int3(w, w, w);

        // Swizzles - int2

        public readonly int2 xx => new int2(x, x);
        public readonly int2 xy => new int2(x, y);
        public readonly int2 xz => new int2(x, z);
        public readonly int2 xw => new int2(x, w);

        public readonly int2 yx => new int2(y, x);
        public readonly int2 yy => new int2(y, y);
        public readonly int2 yz => new int2(y, z);
        public readonly int2 yw => new int2(y, w);

        public readonly int2 zx => new int2(z, x);
        public readonly int2 zy => new int2(z, y);
        public readonly int2 zz => new int2(z, z);
        public readonly int2 zw => new int2(z, w);

        public readonly int2 wx => new int2(w, x);
        public readonly int2 wy => new int2(w, y);
        public readonly int2 wz => new int2(w, z);
        public readonly int2 ww => new int2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - int3

        // r
        public readonly int3 rrr => new int3(r, r, r);
        public readonly int3 rrg => new int3(r, r, g);
        public readonly int3 rrb => new int3(r, r, b);
        public readonly int3 rra => new int3(r, r, a);

        public readonly int3 rgr => new int3(r, g, r);
        public readonly int3 rgg => new int3(r, g, g);
        public readonly int3 rgb => new int3(r, g, b);
        public readonly int3 rga => new int3(r, g, a);

        public readonly int3 rbr => new int3(r, b, r);
        public readonly int3 rbg => new int3(r, b, g);
        public readonly int3 rbb => new int3(r, b, b);
        public readonly int3 rba => new int3(r, b, a);

        public readonly int3 rar => new int3(r, a, r);
        public readonly int3 rag => new int3(r, a, g);
        public readonly int3 rab => new int3(r, a, b);
        public readonly int3 raa => new int3(r, a, a);

        // g
        public readonly int3 grr => new int3(g, r, r);
        public readonly int3 grg => new int3(g, r, g);
        public readonly int3 grb => new int3(g, r, b);
        public readonly int3 gra => new int3(g, r, a);

        public readonly int3 ggr => new int3(g, g, r);
        public readonly int3 ggg => new int3(g, g, g);
        public readonly int3 ggb => new int3(g, g, b);
        public readonly int3 gga => new int3(g, g, a);

        public readonly int3 gbr => new int3(g, b, r);
        public readonly int3 gbg => new int3(g, b, g);
        public readonly int3 gbb => new int3(g, b, b);
        public readonly int3 gba => new int3(g, b, a);

        public readonly int3 gar => new int3(g, a, r);
        public readonly int3 gag => new int3(g, a, g);
        public readonly int3 gab => new int3(g, a, b);
        public readonly int3 gaa => new int3(g, a, a);

        // b
        public readonly int3 brr => new int3(b, r, r);
        public readonly int3 brg => new int3(b, r, g);
        public readonly int3 brb => new int3(b, r, b);
        public readonly int3 bra => new int3(b, r, a);

        public readonly int3 bgr => new int3(b, g, r);
        public readonly int3 bgg => new int3(b, g, g);
        public readonly int3 bgb => new int3(b, g, b);
        public readonly int3 bga => new int3(b, g, a);

        public readonly int3 bbr => new int3(b, b, r);
        public readonly int3 bbg => new int3(b, b, g);
        public readonly int3 bbb => new int3(b, b, b);
        public readonly int3 bba => new int3(b, b, a);

        public readonly int3 bar => new int3(b, a, r);
        public readonly int3 bag => new int3(b, a, g);
        public readonly int3 bab => new int3(b, a, b);
        public readonly int3 baa => new int3(b, a, a);

        // a
        public readonly int3 arr => new int3(a, r, r);
        public readonly int3 arg => new int3(a, r, g);
        public readonly int3 arb => new int3(a, r, b);
        public readonly int3 ara => new int3(a, r, a);

        public readonly int3 agr => new int3(a, g, r);
        public readonly int3 agg => new int3(a, g, g);
        public readonly int3 agb => new int3(a, g, b);
        public readonly int3 aga => new int3(a, g, a);

        public readonly int3 abr => new int3(a, b, r);
        public readonly int3 abg => new int3(a, b, g);
        public readonly int3 abb => new int3(a, b, b);
        public readonly int3 aba => new int3(a, b, a);

        public readonly int3 aar => new int3(a, a, r);
        public readonly int3 aag => new int3(a, a, g);
        public readonly int3 aab => new int3(a, a, b);
        public readonly int3 aaa => new int3(a, a, a);

        // RGBA - Swizzles - int2

        public readonly int2 rr => new int2(r, r);
        public readonly int2 rg => new int2(r, g);
        public readonly int2 rb => new int2(r, b);
        public readonly int2 ra => new int2(r, a);

        public readonly int2 gr => new int2(g, r);
        public readonly int2 gg => new int2(g, g);
        public readonly int2 gb => new int2(g, b);
        public readonly int2 ga => new int2(g, a);

        public readonly int2 br => new int2(b, r);
        public readonly int2 bg => new int2(b, g);
        public readonly int2 bb => new int2(b, b);
        public readonly int2 ba => new int2(b, a);

        public readonly int2 ar => new int2(a, r);
        public readonly int2 ag => new int2(a, g);
        public readonly int2 ab => new int2(a, b);
        public readonly int2 aa => new int2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
