namespace unity_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반복문

            //while
            //for
            //dowhile - 조건이 참이면 아니든 무조건 한 번은 실행




            //int a = 0;

            //while (a < 5) // 무한루프
            //{
            //    Console.WriteLine("무한");
            //    a++;
            //}




            // 1. 정수 변수 num 1로 초기화한다.

            // While 문으로 1부터 10까지 출력
            // 출력 후 num을 1씩 증가.


            //int num = 1; //초기화

            ////while (num <= 10) // 무한루프
            ////{
            ////    Console.WriteLine(num);
            ////    num++;
            ////}


            //do 
            //{
            //    Console.WriteLine("무조건 한번은 실행된다");
            //    num++; //조건 변경
            //} while (num < 11); // 조건



            //for (조건 초기화; 조건; 조건변경) { }



            // 2단 -> 2 * 1 = 2
            //        2 * 2 = 4
            //        .
            //        9 * 8 = 72


            for (int n = 2; n < 10; n++)
            {
                Console.WriteLine($"{n}단");

                for (int m = 1; m < 10; m++)
                {
                    Console.WriteLine($"{n} * {m} = {n * m}");
                }
            }

        }
    }
}
