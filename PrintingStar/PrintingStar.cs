using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingStar
{
    class PrintingStar
    {
        Notice notice;

        public PrintingStar()
        {
            notice = new Notice();
        }

        public void run()
        {
            StarStyle starStyle = new StarStyle();
            int styleNum;
            String a;
            int num;

            while (true)
            {
                Console.Clear();
                notice.PrintMenu();
                a = Console.ReadLine();
                if (a.Length != 1)
                {
                    continue;
                }

                styleNum = int.Parse(a);
                Console.Clear();
                switch (styleNum)
                {
                    case 1:
                        num = int.Parse(Console.ReadLine());
                        starStyle.PrintPiramid(num);
                        break;

                    case 2:
                        num = int.Parse(Console.ReadLine());
                        starStyle.PrintReversePiramid(num);
                        break;

                    case 3:
                        num = int.Parse(Console.ReadLine());
                        starStyle.SandGlass(num);
                        break;

                    case 4:
                        num = int.Parse(Console.ReadLine());
                        starStyle.Diamond(num);
                        break;

                    default:
                        Console.Clear();
                        notice.PrintWarning();
                        break;
                }

                InputAnyKey();
            }
        }

        public void InputAnyKey()
        {
            Console.WriteLine("\n\n아무키나입력하세요");
            ConsoleKeyInfo anykey = Console.ReadKey(true);
            Console.Clear();
            notice.CheckTime();
            anykey = Console.ReadKey(true);
            Console.Clear();
        }
    }
}
