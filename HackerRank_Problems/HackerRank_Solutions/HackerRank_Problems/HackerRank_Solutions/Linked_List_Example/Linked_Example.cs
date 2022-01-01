using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Example
{
    class Linked_Example
    {
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);

            Console.ReadKey();
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.Data + " ");
                start = start.Next;
            }
        }
        public static Node insert(Node node,int data)
        {
            if(node==null)
            {
                return new Node(data);
            }
            else if(node.Next==null)
            {
                node.Next = new Node(data);
            }
            else
            {
                insert(node.Next, data);
            }
            return node;
        }
    }


    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            this.Data = data;
            Next = null;
        }
    }
    
}
