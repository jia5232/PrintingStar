using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrintingStar
{
    class Notice
    {
        public void PrintMenu()
        {
            Console.WriteLine("★★★★★별찍어드립니다★★★★★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★        ♡별찍는 방법♡       ★");
            Console.WriteLine("★ 하나:원하는 모양 번호 + 엔터 ★");
            Console.WriteLine("★     둘:원하는 숫자 + 엔터    ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★        1번: 피라미드 △      ★");
            Console.WriteLine("★     2번: 거꾸로 피라미드▽   ★");
            Console.WriteLine("★       3번: 모래시계 ↕       ★");
            Console.WriteLine("★      4번: 다이아몬드 ◈      ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★★★★★★★★★★★★★★★★★");

        }
        
        public void PrintWarning()
        {

            Console.WriteLine("★★★★★별찍어드립니다★★★★★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★    모양 결정번호는 1,2,3,4   ★");
            Console.WriteLine("★   네가지중에 눌러주세요!> <  ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★        이외의 키에서는       ★");
            Console.WriteLine("★    작동하지 않습니다! ㅜㅜ   ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★     양해 부탁드립니다!       ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★★★★★★★★★★★★★★★★★");
        }

        public void CheckTime()
        {
            for(int time = 3; time > 0; time--)
            {
                Console.Clear();
                PrintQuitWarning(time);
                Thread.Sleep(1000);
            }
        }
        public void PrintQuitWarning(int time)
        {
            Console.WriteLine("★★★★★별찍어드립니다★★★★★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★     {0}초뒤 아무키나 누르시면  ★", time);
            Console.WriteLine("★      처음으로 돌아갑니다!    ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★                              ★");
            Console.WriteLine("★★★★★★★★★★★★★★★★★");


        }
    }
}
