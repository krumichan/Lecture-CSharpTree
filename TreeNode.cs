using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_CSharpTree
{
    class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();
    }
}
