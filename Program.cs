using System;

namespace PractTask10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i * 5;

            MyIdealTree<int> tree = new MyIdealTree<int>(arr);
            tree.Show();
            tree.TerminateTree(ref tree.root);
            Console.WriteLine();
            tree.Show();
        }
    }
}
