using System;
using System.Collections.Generic;
using System.Text;

namespace TreeDemo
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int value)
        {
            this.Value = value;
        }
        public int Value { get; }

        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }


    }
}
