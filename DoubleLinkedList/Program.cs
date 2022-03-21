using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split();
            foreach(var t in temp)
            {
                dll.PushBack(Convert.ToInt32(t));
            }
            Console.WriteLine(dll.Print());

            int st = 1;
            int num_dec = 0;
            dll.setIteratorTail();
            while (dll.Iterator!= null)
            {
                num_dec += st * dll.getIteratorValue();
                Console.WriteLine(dll.getIteratorValue());
                st *= 2;
                dll.previsionIterator();
            }
            Console.WriteLine(num_dec);
        }
    }
}
