using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Opration");
            BinarySearchTrees<int> tree = new BinarySearchTrees<int>(56);

            Console.WriteLine("Enter 1.to value insertion\nEnter 2.to insert more Elements\nEnter 3.to Search the Elements\n");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    tree.Insert(30);
                    tree.Insert(70);
                    tree.Display();
                    break;

                case 2:
                    tree.Insert(30);
                    tree.Insert(70);
                    tree.Insert(22);
                    tree.Insert(40);
                    tree.Insert(60);
                    tree.Insert(95);
                    tree.Insert(11);
                    tree.Insert(65);
                    tree.Insert(3);
                    tree.Insert(16);
                    tree.Insert(63);
                    tree.Insert(67);
                    tree.Display();
                    tree.GetSize();
                    break;

                case 3:
                    tree.Insert(30);
                    tree.Insert(70);
                    tree.Insert(22);
                    tree.Insert(40);
                    tree.Insert(60);
                    tree.Insert(95);
                    tree.Insert(11);
                    tree.Insert(65);
                    tree.Insert(3);
                    tree.Insert(16);
                    tree.Insert(63);
                    tree.Insert(67);
                    tree.Display();
                    tree.GetSize();
                    bool result = tree.IfExists(63, tree);
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
