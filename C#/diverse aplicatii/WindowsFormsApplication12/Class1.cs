using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
 
    public class Node
    {
        public string nume;
        public double pret;
        public int cantitate;
        public string data_prim;
        public string data_exp;
        public Node left;
        public Node right;
    }

    class Tree
    {   Node successor;
        public int n;
        public string[] array = new string[50];
        public Node insert(Node root, string nume1, double pret1, int cantitate1, string nume_prim1, string nume_exp1)
        {
            if (root == null)
            {
                root = new Node();
                root.nume = nume1;
                root.pret = pret1;
                root.cantitate = cantitate1;
                root.data_prim = nume_prim1;
                root.data_exp = nume_exp1;

            }
            else if ( 0<String.CompareOrdinal(nume1 , root.nume))
            {
                root.left = insert(root.left,  nume1,  pret1,  cantitate1,  nume_prim1,  nume_exp1);
            }
            else
            {
                root.right = insert(root.right,  nume1,  pret1,  cantitate1,  nume_prim1,  nume_exp1);
            }

            return root;
        }

        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            array[n++] = root.nume;
            traverse(root.left);
            traverse(root.right);
            
        }
        public void traverse2(Node root, string datest)
        {
            if (root == null)
            {
                return;
            }
            
        DateTime db;
        DateTime db1;
        db = Convert.ToDateTime(root.data_exp);
            db1 = Convert.ToDateTime(datest);
        int result = DateTime.Compare(db, db1);
        if (result < 0) array[n++] = root.nume;
            traverse(root.left);
            traverse(root.right);

        }
        public void caut(Node root,string nume1,ref bool gasit){
             if (root!=null ) 

                    if (root.nume==nume1 )gasit=true;

                    else {

                            if (0<String.CompareOrdinal(nume1 , root.nume)) caut (root.left,nume1,ref gasit);
                            if (0 > String.CompareOrdinal(nume1, root.nume)) caut(root.right, nume1,ref gasit);
                                 } else gasit=false;
        }  
                        public Node GetSuccessor(Node delNode) {
                Node successorParent = delNode;
                Node successor = delNode;
                Node current = delNode.right;
                while (!(current == null)) {
                successorParent = current;
                successor = current;
                current = current.left;
                }
                if (!(successor == delNode.right)) {
                successorParent.left = successor.right;
                successor.right = delNode.right;
                }
                return successor;
                }
              public void Delete(ref Node root, string key,ref bool sters) {
                Node current = root;
                Node parent = root;
                
                bool isleftChild = true;
                while (!current.nume.Equals(key)) {
                parent = current;
                if ( 0<String.CompareOrdinal(key , root.nume)) {
                isleftChild = true;
                current = current.right;
                } else {
                isleftChild = false;
                current = current.right;
                }
                if (current == null)
                sters=false;
                }
                if ((current.left == null) && (current.right == null))
                if (current == root)
                root = null;
                else if (isleftChild)
                parent.left = null;
                else
                parent.right = null;
                else if (current.right == null)
                if (current == root)
                root = current.left;
                else if (isleftChild)
                parent.left = current.left;
                else
                parent.right = current.right;
                else if (current.left == null)
                if (current == root)
                root = current.right;
                else if (isleftChild)
                parent.left = parent.right;
                else
                parent.right = current.right;
                else
                successor = GetSuccessor(current);
                if (current == root)
                root = successor;
                else if (isleftChild)
                parent.left = successor;
                else{
                parent.right = successor;
                successor.left = current.left;
                }
                sters=true;
                } 
       
    }
}
