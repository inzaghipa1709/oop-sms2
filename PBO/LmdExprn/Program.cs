using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmdExprn{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Lambda Expressions :");
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("Friends");

            Console.WriteLine();
            //LambdaExpression1.Start2();

            Console.WriteLine("Linq :");
            LinqPrgm.Start();
        }
    }
}