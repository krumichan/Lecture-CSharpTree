using System;

namespace Lecture_CSharpTree
{
    class Program
    {
        

        static void Main(string[] args)
        { 
            Console.WriteLine("#####");
            Console.WriteLine("TreeNode -- start");

            TreeNodeImpl treeNodeImpl = new TreeNodeImpl();
            TreeNode<string> root = treeNodeImpl.MakeTree();

            treeNodeImpl.PrintTree(root);

            Console.WriteLine(treeNodeImpl.GetHeight(root));

            Console.WriteLine("TreeNode -- end");
            Console.WriteLine("#####");

            Console.WriteLine("#####");
            Console.WriteLine("PriorityQueue<int> -- start");

            PriorityQueue<int> q = new PriorityQueue<int>();
            q.Push(20);
            q.Push(10);
            q.Push(30);
            q.Push(90);
            q.Push(40);

            while (q.Count() > 0)
            {
                Console.WriteLine(q.Pop());
            }
            Console.WriteLine("PriorityQueue<int> -- end");
            Console.WriteLine("#####");

            Console.WriteLine("#####");
            Console.WriteLine("PriorityQueue<Knight> -- start");

            PriorityQueue<Knight> qKnight = new PriorityQueue<Knight>();
            qKnight.Push(new Knight() { Id = 20 });
            qKnight.Push(new Knight() { Id = 30 });
            qKnight.Push(new Knight() { Id = 40 });
            qKnight.Push(new Knight() { Id = 10 });
            qKnight.Push(new Knight() { Id = 5 });

            while (qKnight.Count() > 0)
            {
                Console.WriteLine(qKnight.Pop().Id);
            }
            Console.WriteLine("PriorityQueue<Kinght> -- end");
            Console.WriteLine("#####");
        }
    }
}
