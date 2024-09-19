using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;
namespace Program1
{
    class Program1
    {
        static void Main()
        {
            ArrayList progLanguage = new ArrayList();
            progLanguage.Add("C#");
            progLanguage.Add("java");
            progLanguage.Add("C++");
            progLanguage.Add("Php");
            progLanguage.Sort();
            for(int i = 0; i < progLanguage.Count; i++)
            {
                Console.WriteLine(progLanguage[i]);
            }
            Console.WriteLine(progLanguage.Count);
            for (int i = progLanguage.Count-1; 0<=i; i--)
            {
                Console.WriteLine(progLanguage[i]);
            }
            progLanguage.Clear();


            Random random = new Random();
            Stack<int> stack = new Stack<int>();
            Console.Write("Введіть довжину черги:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stack.Push(random.Next(-10, 10));
                Console.WriteLine(stack.Peek());
            }
            int count = stack.Count;
            Console.WriteLine($"Довжина черги {count}");
            int counterPositive = 0;
            for(int i = 0;i < count; i++)
            {
                if (stack.Pop() > 0)
                {
                    counterPositive++;
                };
            }
            if(counterPositive > 0)
            {
                Console.WriteLine($"Додатніх чисел {counterPositive}");
            }
            else
            {
                Console.WriteLine("Додатнiх чисел немає");
            }
        }
    }
}

