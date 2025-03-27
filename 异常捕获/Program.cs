namespace 异常捕获;

class Program
{
    static void Main(string[] args)
    {
        #region 异常捕获
        
        // #region 语法
        // try{
        //     Console.WriteLine("请输入数字:");
        //     string str1 = Console.ReadLine();
        //     int i1 = int.Parse(str1);
        //     Console.WriteLine(i1);
        // }
        // catch{
        //     Console.WriteLine("你输入的不合法");
        // }
        // finally{
        //     Console.WriteLine("请输入合法数字!!!");
        // }
        // #endregion

        #region 习题
        // try{
        //     Console.WriteLine("请输入一个数字:");
        //     string str2 = Console.ReadLine();
        //     int i2 = int.Parse(str2);
        // }
        // catch{
        //     Console.WriteLine("你输入的不合法");
        // }
        try{
            Console.WriteLine("请输入姓名:");
            string str3 = Console.ReadLine();
            Console.WriteLine("请输入成绩1:");
            string str4 = Console.ReadLine();
            int i4 = int.Parse(str4);
            Console.WriteLine("姓名:" + str3 + " 成绩1:" + i4 + "\n");

        }
        catch{
            Console.WriteLine("你输入成绩1不合法");
        }

       try{
            Console.WriteLine("请输入成绩2:");
            string str5 = Console.ReadLine();
            int i5 = int.Parse(str5);
            Console.WriteLine(" 成绩2:" + i5 + "\n");

        }
        catch{
            Console.WriteLine("你输入成绩2不合法");
        }


        #endregion




        #endregion
    }
}
