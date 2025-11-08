using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01
{
    class DataStructure
    {
        int[] array = new int[10];
        Stack<int> stack = new Stack<int>();
        Stack<float> floatStack = new Stack<float>();
        Queue<int> queue = new Queue<int>(); 
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        HashSet<int> hashset = new HashSet<int>();
        private void Search()
        {
            array[0] = 1;
            array[5] = 5;

            stack.Push(1);
            stack.Push(2);
            int pop = stack.Pop();

            queue.Enqueue(1);
            int dequeue = queue.Dequeue();

            dictionary[100] = 1;
            int result = dictionary[100];
            dictionary.Remove(100);

            hashset.Add(100);
            hashset.Remove(100);
            bool Contains = hashset.Contains(100);
        }
    }
}
