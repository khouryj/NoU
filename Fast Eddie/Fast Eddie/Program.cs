using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Eddie
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ace = new Stack();
            String input = Console.ReadLine().Replace(" ", "");
            String output = "";
            foreach (char t in input)
            {
                if (t != '+' && t != '-' && t != '*' && t != '/')
                {
                    output += t;
                }
                else if (t == ')')
                {
                    char c;
                    
                }
                else
                {
                    ace.Push(t);
                }
            }
        }   
    }
}
