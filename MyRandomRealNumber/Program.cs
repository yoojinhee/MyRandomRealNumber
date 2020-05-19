using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correct = random.Next(1, 500);
            Boolean chk = true;
            int answer;
            while (chk)
            {
                Console.Write("숫자를 입력해주세요: ");
                answer = Int32.Parse(Console.ReadLine());

                if (correct == answer)
                {
                    Console.WriteLine("정답입니다!");
                    chk = false;
                }else if (correct < answer)
                {
                    Console.WriteLine(answer+"보다는 작은수입니다!");

                }
                else
                {
                    Console.WriteLine(answer + "보다는 큰수입니다!");
                }

            }

        }
    }
}
