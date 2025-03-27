namespace lesson2;
class Program
{
    static void Main(string[] args)
    {

        //折叠代码
        #region 这是一段折叠的代码
        
        #endregion

        #region 变量
        //有符号(signed)的整型变量
        //sbyte -2^7 ~ 2^7-1 1字节

        //short -2^15 ~ 2^15-1 2字节

        //int -2^31 ~ 2^31-1 4字节

        //long -2^63 ~ 2^63-1 8字节

        //无符号(unsigned)的整型变量
        //byte 0 ~ 2^8-1 1字节

        //ushort 0 ~ 2^16-1 2字节

        //uint 0 ~ 2^32-1 4字节

        //ulong 0 ~ 2^64-1 8字节

        //浮点型变量 
        //float 4字节，精度7位有效数字，超过精度四舍五入
            //不加f后缀，默认是double类型
            float f1 = 1.221312f;
        //double 8字节，精度15位有效数字  
            double d1 = 1.2213124211249;
        //decimal 16字节，精度28位有效数字

        //其他类型变量
        //bool 1字节，true或false
            bool b1 = true;
            bool b2 = false;
            //可以与字符串相加
            Console.WriteLine(b1 + "and" +b2);
        //char 2字节，表示一个字符，用‘’
            char c1 = 'a';
        //string 字符串，用""
            string str1 = "hello world";

        //注意修改变量直接再赋值就行了

        #endregion


        #region 潜在知识点
        //拼接输出
        int num = 1;
        Console.WriteLine("num is :" + num);

        #endregion

        #region 常量
        //关键字：const
        //声明的时候要带上类型
        //必须初始化
        //常量不能修改
        const float PI = 3.1415926f;
        const string userName = "飞舞";
        
        #endregion
    
    }
}

