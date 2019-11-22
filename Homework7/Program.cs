using System;
using System.Collections.Generic;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool isValid = false;
                var str = Console.ReadLine();

                Stack<char> stack = new Stack<char>();
                List<char> openBrackets = new List<char>() { '(', '[' };
                List<char> closeBrackets = new List<char>() { ')', ']' };

                foreach (char ch in str)
                {
                    if (openBrackets.Contains(ch))
                    {
                        stack.Push(ch);
                    }
                    else if (closeBrackets.Contains(ch))
                    {
                        if (stack.TryPeek(out char bracket))
                        {
                            char inverseBracket;
                            switch (ch)
                            {
                                case ')':
                                    inverseBracket = '(';
                                    break;
                                case ']':
                                    inverseBracket = '[';
                                    break;
                                default:
                                    inverseBracket = ' ';
                                    break;
                            }

                            if (stack.Peek() != inverseBracket)
                            {
                                isValid = false;
                                break;
                            }
                            else
                            {
                                isValid = true;
                                stack.Pop();
                            }
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
        }
    }
}