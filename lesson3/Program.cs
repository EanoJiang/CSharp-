namespace lesson3;

class Program
{
    static void Main(string[] args)
    {
        #region 转义字符
        // \' 单引号
        // \" 双引号
        Console.WriteLine("123\'123");
        Console.WriteLine("123\"123");

        // \\ 反斜杠
        Console.WriteLine("123\\123");

        // \n 换行
        Console.WriteLine("123\n123");

        // \t 制表符
        Console.WriteLine("123\t123");

        // \b 退格
        Console.WriteLine("123\b123");

        // \f 换页 就是上下行文本错开
        Console.WriteLine("123\f123");

        // \0 空字符
        Console.WriteLine("123\0123");

        // \a 系统警报音
        Console.WriteLine("123\a123");
       
        // 取消转义字符
        Console.WriteLine(@"123\a123");

        #endregion
    }
}
