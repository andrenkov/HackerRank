using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    /* Define your class here */
    public class MyStack<T> : IEnumerable<T>
    {
        T[] StackElements = new T[0];
        public int StackSize { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)StackElements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)StackElements).GetEnumerator();
        }

        //push
        public void push(T value)
        {
            if (StackSize == size())
            {
                //get new length
                int len = StackSize == 0 ? 1 : StackSize + 1;//4 : StackSize * 2;
                //copy to new array
                T[] arrNew = new T[len];
                StackElements.CopyTo(arrNew, 0);
                //update stack array
                StackElements = arrNew;
            }
            //update element
            StackElements[StackSize] = value;
            //new size
            StackSize++;
        }

        //pop
        public T Pop()
        {
            if (size() > 0)
            {
                StackSize--;
            }
            return StackElements[StackSize];//return stack with the top element removed
        }

        //size
        public int size()
        {
            return StackElements.Length;
        }

        //isEmpty
        public bool IsEmpty()
        {
            return StackSize == 0;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            /* Use your class here */
            MyStack<string> st = new MyStack<string>();
            st.push("string1");
            st.push("string2");
            st.push("string3");
            st.push("string4");

            if (!st.IsEmpty())
            {
                //check what is in the stack
                Console.WriteLine("My stack has:");
                foreach (string item in st)
                {
                    Console.WriteLine(item);
                }
            }
            //remove top element
            if (!st.IsEmpty())
            {
                string s = st.Pop();
                //check what is in the stack
                Console.WriteLine("The element '{0}' removed:", s);
                int _size = 0;
                foreach (string item in st)
                {
                    if (_size < st.StackSize)
                    {
                        Console.WriteLine(item);
                    }
                    _size++;
                }
            }

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }

}