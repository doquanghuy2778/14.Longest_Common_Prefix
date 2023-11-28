using System;
using System.Linq;

namespace _14.Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];
            Console.Write("strs =");

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Console.ReadLine();
            }

            string prefix = strings[0];
            if (strings.Length < 1)
                return;
            for (int i = 1; i <= strings.Length; i++) 
            {
                while (i < strings.Length && strings[i].IndexOf(prefix) != 0 && prefix.Length > 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            Console.Write(prefix);
            Console.ReadKey();
        }
    }
}
