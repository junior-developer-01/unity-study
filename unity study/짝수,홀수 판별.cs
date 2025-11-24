using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}는 짝수입니다.");
                }
                else
                {
                    Console.WriteLine($"{i}는 홀수입니다.");
                }
            }
        }
    }
