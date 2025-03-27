/// <summary>
/// 引用命名空间（工具包），相当于头文件
/// </summary>
using System;

/// <summary>
/// 命名空间（工具包），相当于自定义的头文件
/// </summary>
namespace lesson1;

/// <summary>
/// 类
/// </summary>
class Program
{
    /// <summary>
    /// 主函数
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        ////WriteLine(),Write()
        //Console.WriteLine("自带换行的print");
        //Console.Write("不带换行的print");
        //Console.Write("你看就没有换行");

        ////ReadLine():输入完需要按回车
        //Console.WriteLine("请输入：");
        //Console.ReadLine();
        //Console.WriteLine("over");

        //ReadKey():输入一个键，自动回车
        Console.ReadKey();
        Console.WriteLine("\nover");
    }
}

