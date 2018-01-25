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
            Stack<String> ace = new Stack<String>();
            String input = Console.ReadLine().Replace(" ", "");
            String output = "";
            foreach (char t in input)
            {
                if (!"+-*/(".Contains(t))
                {                    
                    output += t;
                }
                else if (t == ')')
                {
                    while (!ace.Peek().Equals('('))
                    {
                        if ("+-*/".Contains(ace.Peek()))
                        {
                            output += ace.Pop(); 
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
                    ace.Push(t.ToString());
                }
                
            }
            Console.WriteLine(output);
        }   
    }
}
