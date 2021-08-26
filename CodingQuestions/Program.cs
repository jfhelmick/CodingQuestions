using System;

namespace CodingQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean answer = ValidParentheses.isValid("()]{}");
            Console.WriteLine("Answer is {0}", answer);
        }
    }
}
