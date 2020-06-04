using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask10
{
    public class PointIdealTree<T>
    {
        public T data;
        public PointIdealTree<T> left;
        public PointIdealTree<T> right;

        public PointIdealTree(T d)
        {
            data = d;
            left = null;
            right = null;
        }

        public PointIdealTree()
        {
            data = default(T);
            left = null;
            right = null;
        }

        public override string ToString()
        {
            return data.ToString() + " ";
        }

    }
}
