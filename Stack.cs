using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{


    class Program
    {
        static void Main(string[] args)
        {
            /* A Stack is a data structure for storing a list of elements in a LIFO (last in, first out)
             * fashion. Design a class called Stack with three methods. void Push(object obj) / object Pop()
             * / void Clear(). */

            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push("test");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());



        }
    }
    
    public class Stack
    {
        private ArrayList objects = new ArrayList();
            
        public Stack()
        {
            var objects = new ArrayList();
        }

        

        public void Push(object obj)
        {
            objects.Add(obj);
        }
        
        public object Pop()
        {
            int count = objects.Count-1;
            foreach (object obj in objects)
            {
                if (count == 0)
                {
                    objects.RemoveRange(objects.Count - 1, 1);
                    return obj;
                }
                count--;
            }
            return null;
        }

        public void Clear()
        {
            objects.Clear();
        }

    }
}
