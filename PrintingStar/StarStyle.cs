using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingStar
{
    class StarStyle
    {
        public void PrintPiramid(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public void PrintReversePiramid(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * (num - i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public void SandGlass(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * (num - i + 1) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public void Diamond(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * (num - i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
