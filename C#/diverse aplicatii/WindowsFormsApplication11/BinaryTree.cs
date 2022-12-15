
using System;
using System.Drawing;

namespace BinaryTree
{
    public class BinaryTree
    {
      public int n=0;
        public int[] array=new int[50];
        public Node RootNode { get; private set; }

        public BinaryTree()
        {
            RootNode = new Node(int.MinValue);
        }

   
        public int Count { get { return RootNode.Right.Count; } }

        public bool Add(Node node)
        {
            return RootNode.Add(node);
        }
  
        public bool Remove(int value)
        {
            bool isRootNode;
            var res = RootNode.Remove(value, out isRootNode);
            return !isRootNode && res;
        }
  
        public Image Draw()
        {
            GC.Collect();
            int temp;
            return RootNode.Right == null ? null : RootNode.Right.Draw(out temp);
        }

     
        public bool Exists(int item)
        {
            return RootNode.Exists(item);
        }
        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            array[n++] = root.Value;
            traverse(root.Left);
            traverse(root.Right);

        }
        public void traverse1(Node root)
        {
            if (root == null)
            {
                return;
            }
            
            traverse1(root.Left);
            array[n++] = root.Value;
            traverse1(root.Right);

        }
        public void traverse2(Node root)
        {
            if (root == null)
            {
                return;
            }
            
            traverse2(root.Left);
            traverse2(root.Right); 
            array[n++] = root.Value;

        }
    }
}
