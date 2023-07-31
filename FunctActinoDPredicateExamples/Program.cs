using System;
using System.ComponentModel;

namespace FuncActionPredicateExamples
{
    class Program
    {
        delegate TResult Func2<out TResult>();
        delegate TResult Func2<in T1, TResult>(T1 arg);
        delegate TResult Func2<in T1, in T2, TResult>(T1 arg1, T2 arg2);
        delegate TResult Func2<in T1, in T2, in T3, TResult>(T1 arg1,T2 arg2, T3 arg3);


        static void Main(string[] args) {
            float d= 2.3f, e = 4.56f;
            int f = 5;
            Func<float, float, int, float> calc2 = (arg1, arg2, arg3) => (arg1 + arg2) * 3;
            float result2 = calc2(d, e, f);
            Console.WriteLine($"Result: {result2}");
            Console.ReadKey();
        }
    }
    public class MathClass
    {

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}