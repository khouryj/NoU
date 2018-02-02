using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSL
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = File.ReadAllLines("input.txt");
            Console.WriteLine(input[0]);
            String trashcan = "([{}])";

            foreach (String s in input)
            {
                String h = "";
                foreach (char c in s)
                {
                    if (trashcan.Contains(c))
                    {
                        h += c;
                    }
                }

            }
        }

        static int numOccurences(char c, String s)
        {
            int count = 0;
            foreach (char t in s)
            {
                if (c == t)
                {
                    count++;
                }
            }
        }
    }
}
