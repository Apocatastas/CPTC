using System;
using System.Collections.Generic;

namespace CPTC
{
    class MainClass
    {
        public static LinkedList<int> m_list; //используем связный лист, чтобы применить алгоритм Флойда

        public static LinkedListNode<int> NthToLast(LinkedListNode<int> head, int k)  //используем алгоритм Флойда (зайца и черепахи) чтобы найти нужный элемент в один проход листа
        {
            if (k <= 0) return null;

            LinkedListNode<int> p1 = head;
            LinkedListNode<int> p2 = head;

            for (int i = 0; i < k - 1; i++)
            {
                if (p2 == null) return null;
                p2 = p2.Next;
            }
            if (p2 == null) return null;

            while (p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return p1;
        }
        
        public static void Fill()
        {
            string buf;
            while (!string.IsNullOrEmpty((buf = Console.ReadLine())))
            {
                m_list.AddLast(Convert.ToInt32(buf));
                Console.WriteLine("Enter new element");
            }
            Console.WriteLine(string.Join(" ", m_list));
            
        }

        public static void Initialize()
        {
            m_list = new LinkedList<int>();
            Console.WriteLine("Press Enter twice when done filling");
            Console.WriteLine("Enter new element");
        }

        public static void PrintNth() 
        {
            Console.WriteLine("Enter the number of the element, counting from the end");
            int nth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NthToLast(m_list.First,nth).Value);
        }

        public static void Main()
        {
            Initialize();
            Fill();
            PrintNth();
            Console.ReadKey();
        }
    }
}
