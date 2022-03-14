using System;

namespace test3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字：");
            int num = Convert.ToInt32(Console.ReadLine());
           
            
            if(num % 2 == 1)//if練習
            {
                Console.WriteLine("Weird");
            }
            else if(num %2 == 0 && num <=5 && num >= 2)
            {
                Console.WriteLine("Not Weird");
            }
            else if(num % 2 == 0 && num <= 20 && num >= 6)
            {
                Console.WriteLine("Weird");
            }
            else 
            {
                Console.WriteLine("Not Weird");
            }

            Console.WriteLine();//迴圈練習一
            Console.WriteLine("印出*：");
            int i,j;
            for(i=0;i < num; i++) 
            {
                for(j=0; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
           
            
            Console.WriteLine();//迴圈練習二
            Console.WriteLine("印出1~3：");
            int k;
            for (k = 1; k <= 3; k++) 
            {
                Console.WriteLine("N * " + k + "=" + num*k);
            }

            Console.WriteLine();//迴圈練習三
            Console.WriteLine("九九乘法表");
            int one, two;
            for(one = 1; one <= 9; one++) 
            {
                for(two=1; two <=9;two++)
                {
                    Console.Write(one + "*" + two + "=" + one * two+"  ");
                }
                Console.WriteLine();
            }

            int a;
            int[] Snum = { 1, 2, 3, 4, 5 };
            string[] name = { "陳侑威", "洪頎崴", "黃子豪", "侯宇炯", "陳柏豪" };
            int[] computer = { 80, 65, 100, 98, 83 };
            int[] program = { 75, 67, 93, 25, 82 };
            int[] video = { 60, 62, 91, 50, 87 };
         
            Console.WriteLine("輸入你要查詢的號碼(1~5)：");
            int b = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("學號：" + Snum[b - 1]);
            Console.WriteLine("姓名：" + name[b - 1]);
            Console.WriteLine("電腦概論：" + computer[b - 1]);
            Console.WriteLine("程式設計：" + program[b - 1]);
            Console.WriteLine("動畫設計：" + video[b - 1]);
        }
    }
}
