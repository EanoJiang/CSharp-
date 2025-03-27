using System.Formats.Asn1;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace 运算符;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // #region 算数运算符
        // float a = 4.11f % 3.11f;
        // Console.WriteLine(a);
        // int a1 = 1, a2 = 1;
        // //先用后变
        // Console.WriteLine(a1++ +" "+ a2--);
        
        // int a3 = 1, a4 = 1;
        // //先变后用
        // Console.WriteLine(++a3 +" "+ --a4);
        // #endregion

        // #region 练习题
        // int seconds = 987652;
        // int one_day = 60 * 60 * 24;
        // int one_hour = 60 * 60;
        // int one_minute = 60;
        // int one_second = 1;
        // Console.WriteLine(seconds/one_day+"天"+seconds%one_day/one_hour+"小时"+seconds%one_hour/one_minute+"分"+seconds%one_minute+"秒");
        // #endregion

        // #region 字符串拼接
        // string str3 = "1";
        // str3 += "2";
        // Console.WriteLine(str3);
        // str3 += 1;
        // Console.WriteLine(str3);
        // str3 += 1 + 2;
        // Console.WriteLine(str3);
        // str3 += "" + 3 ;
        // Console.WriteLine(str3);

        // str3 = "";
        // str3 += 1 + 2 + "" + 2 + 3;
        // Console.WriteLine(str3);

        // #endregion

        // #region 拼接法2
        // //语法：string.Format("格式化字符串",参数1,参数2,参数3...)
        // //格式化字符串里想要拼接的内容用占位符{i}替代，从0依次往后
        // string str4 = string.Format("我是{0},今年{1}岁,身高{2}cm","sb",18,180);
        // Console.WriteLine(str4);
        // #endregion 

        // #region 控制台打印拼接
        // Console.WriteLine("我是{0},今年{1}岁,身高{2}cm", "sb", 18, 180);
        // #endregion

        // #region 逻辑运算符
        //     #region 逻辑与 &&
        //     bool result1 = true && false;
        //     Console.WriteLine(result1); // false
        //     #endregion

        //     #region 逻辑或 ||
        //     bool result2 = true || false;
        //     Console.WriteLine(result2); // true
        //     #endregion
            
        //     #region 逻辑非 !
        //     bool result3 = !true;
        //     Console.WriteLine(result3); // false
        //     #endregion

        //     #region 短路规则
        //     int i3 = 1;
        //     bool result = i3 > 0 || ++i3 >0;
        //     Console.WriteLine(i3); // 1
        //     result = i3 < 0 && ++i3 >0;
        //     Console.WriteLine(i3); // 1
        //     #endregion

        // #endregion
        
        // #region 位运算符
        // // 位取反 ^
        // int a = 5;
        // // 0000 0000 0000 0000 0101
        // // 1111 1111 1111 1111 1010 这样按位取反得到的是补码，还需要找到其原码
        // // 1000 0000 0000 0000 0101 + 1
        // // 1000 0000 0000 0000 0110 而最高位符号位是1，所以是-6
        // Console.WriteLine(~a); // -6
        // #endregion

        // #region 三目运算符
        // string str4 = (1>0)?"大于0":"小于等于0";
        // Console.WriteLine(str4); // 大于0
        // // str4 = (1>0)?"大于0":1; 错误，返回值类型不统一

        // #endregion
        
    //   #region switch
    //     int c = 0;
    //     switch(c)   // switch语句
    //     {
    //         case 1:
    //         case 2:
    //         case 3:
    //             Console.WriteLine("哈哈哈");
    //             break;
    //         case 4:
    //             Console.WriteLine("呵呵呵");
    //             break;
    //         default:
    //             Console.WriteLine("啥也没有");
    //             break;
    //     }
    //     #endregion

        #region while
        // 流程控制关键字break和continue       
        // while(true){
        //     Console.WriteLine("continue前");
        //     continue;
        //     Console.WriteLine("continue后");
        // }
        // Console.WriteLine("循环结束");
        
        // 题目：打印1～20的奇数
        // int i = 0;
        // while(i <= 20){

        //     if(i % 2 == 1){
        //         Console.WriteLine(i);
        //         i+=2;
        //     }
        //     else{
        //         i++;
        //         continue;
        //     }
        // }
        
        // // 题目：斐波那契数列
        // int first_num = 0, second_num=1, third_num=0, count=1;
        // while(first_num<100000){
            
        //     third_num = first_num + second_num;
        //     first_num = second_num;
        //     second_num = third_num;
        //     Console.WriteLine(first_num);  
        //     count++;
        //     if(count == 20){
        //         Console.WriteLine("斐波那契数列的第20个数是："+third_num);
        //         break;
        //     }
        // }

        // //题目：求100以内的素数
        // int num = 2;
        // while(num < 100){
        //     bool isPrime = true;
        //     for(int i = 2; i < num; i++){
        //         if(num % i == 0){
        //             isPrime = false;
        //             break;
        //         }
        //         else{
        //             isPrime = true;
        //         }
        //     }
        //     if(isPrime) Console.WriteLine(num);
            
        //     num++;
        // }

        // //do while 循环
        // do{
        //     Console.WriteLine("do while 循环");
        //     continue;
        // }while(false);


        // //水仙花
        // int ge = 0, shi = 0, bai = 0, num = 0;

        // for(; num <= 999; num++){
        //     bai = num / 100;
        //     shi = num % 100 / 10;
        //     ge = num % 10;
        //     if(num == ge * ge * ge + shi * shi * shi + bai * bai * bai){
        //         Console.WriteLine(num);
        //     }
        // }
        #endregion
    }
}
