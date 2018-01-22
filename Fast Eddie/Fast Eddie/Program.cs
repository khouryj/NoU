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
                    while (!ace.Pop().Equals('('))
                    {
                        if(ace.Pop().Equals('+') || ace.Pop().Equals('-') || ace.Pop().Equals('*') || ace.Pop().Equals('/'))
                        {
                            output += ace.Pop(); //faggot
                        }
                        else
                        {
                            ace.Pop();
                        }
                    }
                }
                else
                {
                    if (ace.Count != 0)
                    {
                        output += ace.Pop();
                    }
                    ace.Push(t);
                }
                
            }
            Console.WriteLine(output);
        }   
    }
}
