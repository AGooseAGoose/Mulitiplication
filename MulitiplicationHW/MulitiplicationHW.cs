using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulitiplicationHW
{
    public class MulitiplicationHW
    {
        public static void Multiplication()
        {
            
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    string A = string.Empty;
                    A= $"{i*j}".PadLeft(2,' ');
                   Console.Write($"{i}*{j}="  + A +" \n");
                   
                }
                Console.WriteLine();//跑完每一個區塊後換行
            }
            Console.ReadKey();
        }
    }
}
