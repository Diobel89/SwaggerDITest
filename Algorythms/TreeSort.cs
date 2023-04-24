using System.Diagnostics;
using SwaggerDITest.Models;
using SwaggerDITest.Algorythms.Interface;

namespace SwaggerDITest.Algorythms
{
    public class TreeSort : ITreeSort
    {
        Node root;
        public TreeSort()
        {
            root = null;
        }
        void insert(int key)
        {
            root = insertRec(root, key);
        }
        Node insertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            return root;
        }
        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.Write(root.key + " ");
                inorderRec(root.right);
            }
        }
        void treeins(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                insert(arr[i]);
            }

        }
        public OutputDTO Sort(int[] numbers)
        {
            long time;
            Stopwatch watch = new Stopwatch();
            watch.Reset();
            watch.Start();
            TreeSort tree = new TreeSort();

            tree.treeins(numbers);
            watch.Stop();
            time = watch.ElapsedTicks;
            OutputDTO data = new OutputDTO() { AlgorithmName = "Tree Sort", Sorted = numbers, TotalTime = time };
            return data;
        }
    }
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
}
