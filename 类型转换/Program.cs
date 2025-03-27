namespace 类型转换;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("隐式转换");
        #region 隐式转换————同一大类型之间
        
        //有符号
        long l = 1;
        int i = 1;
        short s = 1;
        sbyte sb = 1;
        //下面用隐式转换：大范围装小范围的类型  long -> int -> short -> sbyte
        l = i;
        l = s;
        l = sb;
        //如果反过来装，则会数据溢出，报错
        //比如：i = l;错误

        //无符号
        ulong ul = 1;
        uint ui = 1;
        ushort us = 1;
        byte b = 1;
        //也是大范围装小范围的类型  ulong -> uint -> ushort -> byte

        //浮点数
        decimal de = 1.1m;
        double d = 1.1;
        float f = 1.1f;
        //decimal类型不能隐式转换，不能用来存储double和float
        //比如：de = d; 错误
        //但是float和double可以隐式转换   double -> float
        d = f;

        //特殊类型  bool char string
        //不是同一大类型，不存在隐式转换

        #endregion

        #region 隐式转换————不同大类型之间
        
            #region 无符号和有符号之间
            //无符号
            byte b2 = 1;
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号    装不了，因为无符号不存在符号位
            //比如：b2 = sb2; 错误

            //有符号装无符号    能隐式转换的前提是有符号的范围要更大，才能装下无符号的范围
            i2 = b2;
            l2 = i2;
            // 比如：i2 = ui2; 错误

            #endregion

            #region 整型和浮点型之间
            //浮点数
            float f2 = 1.1f;
            double d2 = 1.1;
            decimal de2 = 1.1m;
            
            //浮点数装整数  浮点数可以装任意整数 还是大范围装小范围
            //decimal虽然不能隐式存储double和float，但是可以隐式存储整形
            f2 = i2;
            de2 = i2;
            /*总结*/
            // double -> float -> 所有整形（有无符号都行）
            // decimal -> 所有整形（有无符号都行）

            //整数装浮点数  不行，因为整数的范围比浮点数的范围小，而且整数也没小数位置



            #endregion

            #region 特殊类型和其他类型之间
            bool bo2 = true;
            char c2 = 'a';
            string str2 = "hello";
            //bool 不能和其他类型 相互隐式转换
                // i2 = bo2;
                // bo2 = i2;
                // 均报错
            //char 不能隐式转换成其他类型，但是可以隐式转换成整形浮点型大范围的类型
                // c2 = i2; 报错
                i2 = c2;
                f2 = c2;
            //string 不能和其他类型 相互隐式转换
                // str2 = i2;
                // i2 = str2;
                // 均报错
            




            #endregion





        #endregion

        //作业：
        int tang = '唐';
        int lao = '老';
        int shi = '狮';
        Console.WriteLine("名字："+tang+lao+shi);//前面是字符串，后面相连也就是字符串拼接
    
    
        Console.WriteLine("显式转换");
        #region 显式转换————括号强转
            //用于：将高精度的类型强制转换为低精度的类型
            //语法： (目标类型) 源类型变量名
            // long l1 = 1;
            // int i1 = (int) l1;
            //long l1 = (long) i1; 错误，低精度不能强转高精度

            //注意：精度问题(浮点数) 范围问题
            //相同大类的整形
            sbyte sb1 = 1;
            short s1= 1;
            int i1 = 1;
            long l1 = 1;

            s1 = (short)i;//小存大会因为范围产生异常，但不会报错
            
            //浮点数
            float f1 = 1.1f;
            double d1 = 1.1124234213f;
            decimal de1 = 1.1m;

            f1 = (float)d1; //小存大会精度丢失，但不会报错
            Console.WriteLine(f1);

            //无符号和有符号
            uint ui1 = 1;
            i1 = (int)ui1;
            Console.WriteLine(i1);
            i1 = -1;
            ui1 = (uint)i1; //无符号存有符号，会因为缺少符号位产生异常，但不会报错
            Console.WriteLine(ui1);
            
            //浮点和整形
            i1 = (int)f1;//整形存浮点会精度丢失
            Console.WriteLine(i1);
            f1 = (float)i1;//浮点存整形肯定没问题
            Console.WriteLine(f1);

            //char和数值类型
            i2 = 'a';
            char c = (char)i2;//对应ASCII码转字符，来回都能转
            Console.WriteLine(c);
            f1 = 97.2f;
            c = (char)f1;//char存浮点数，会自动舍去小数位后映射到ASCII码
            Console.WriteLine(c);

            //bool 和 string 都不能通过括号强转
            bool bo1 = true;
            //  i1 = (int)bo1;//报错
            string str1 = "123";
            // i1 = (int)str1;//报错


        #endregion

        #region 显式转换————Parse法
        //作用： 把string转换成其他类型（前面有提到，string不能括号强转）
        //语法： 目标类型.Parse(string类型变量名)  
        //      目标类型.Parse("字符串")
        //注意：字符串必须能够转换成对应类型才行，否则会报错

        //整形
        
        int i4 = int.Parse("123");
        Console.WriteLine(i4);

        //i4 = int.Parse("123.45"); //异常了，报错，编译不通过
        //Console.WriteLine(i4); 

        // short s4 = short.Parse("6666666"); //超出范围，报错
        // Console.WriteLine(s4);

        //浮点型 和上面一样

        // bool 字符串必须是true或false，否则会报错
        bool b5 = bool.Parse("true");
        Console.WriteLine(b5);
        
        // char  字符串必须是单个字符，否则会报错
        char c5 = char.Parse("a");
        Console.WriteLine(c5);



        #endregion

        #region 显式转换————Convert法
        //作用： 更准确地在各个类型之间转换
        //语法： Convert.To目标类型(源类型变量名/常量名)
        //      Convert.ToInt32()
        //      Convert.ToInt16() 相当于short
        //      Convert.ToInt64() 相当于long

        //      Convert.ToSingle() Single就是单精度，相当于float
        //      Convert.ToDouble() 相当于double
        //      Convert.ToDecimal() 相当于decimal

        //      Convert.ToSByte()
        //      Convert.ToByte()
        //      Convert.ToBoolean()
        //      Convert.ToChar()
        //      Convert.ToString()
        //注意： 填写的变量/常量必须是可以转换的类型，否则会报错
        //Conver.ToInt32(string)
        int i3 = Convert.ToInt32("123");
        Console.WriteLine(i3);
        //Conver.ToInt32(浮点数) 会四舍五入
        i3 = Convert.ToInt32(1.5f);
        Console.WriteLine(i3);
        
        //Conver.ToInt32(bool)
        i3 = Convert.ToInt32(true);
        Console.WriteLine(i3);
        i3 = Convert.ToInt32(false);
        Console.WriteLine(i3);

        //其他类型也能转
        bool b3 = Convert.ToBoolean(312);
        Console.WriteLine(b3);

        #endregion

        #region 显式转换————其他类型转string
        //作用：拼接打印
        //语法： 源变量.ToString()

        string str3 = 1.ToString();
        Console.WriteLine(str3);

        string str4 = true.ToString();
        Console.WriteLine(str3);

        string str5 =  1.2f.ToString();
        Console.WriteLine(str3);

        //下面两个是等价的
        Console.WriteLine("1"+true+1.2f);//实际运行的时候自动调用toString()方法
        Console.WriteLine(str3+str4+str5);
        
        #endregion
 
        //题目2：
        //char只能隐式转换成其他大范围的类型，而不能隐式存放其他类型
        char c1 = (char)24069;
        Console.WriteLine(c1);

        c1 = Convert.ToChar(24069);
        Console.WriteLine(c1);

        //题目3:
        Console.WriteLine("请按语文数学英语的顺序，输入三门成绩：");
        Console.WriteLine("输入语文成绩：");
        int chinese = Convert.ToInt32(Console.ReadLine());
        //或者：int chinese = int.Parse(Console.ReadLine());
        Console.WriteLine("输入数学成绩：");
        int math = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("输入英语成绩：");
        int english = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Chinese: {0}\nMath: {1}\nEnglish: {2}",chinese,math,english);
        //或者：Console.WriteLine("Chinese:"+chinese+"\n"+"Math:"+math+"\n"+"English:"+english);        
    }
}
