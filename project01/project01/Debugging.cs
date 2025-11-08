using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01
{
    class Debugging
    {
        public void TryCatch()
        {
            int a = 10;
            int b = 0;

            // 프로그램 실행이 잘 되기떄문에 어떤 문제인지 알기 힘들다.
            int result = a / b;
            if (b != 0)
                result = a / b;

            try
            {
                int result2 = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("0으로 나눌 수 없습니다.");           
            }
        }
        public void Log()
        {
            // 스테이지 시작
            Console.WriteLine("스테이지 시작");

            // 스테이지 진행
            Console.WriteLine("스테이지 진행");

            // 스테이지 종료
            Console.WriteLine("스테이지 종료");
        }
        public void Assert()
        {
            Player player = new Player(1,1);
            Debug.Assert(player != null, "Player 객체가 존재해야 합니다.");
        }
    }
}
