using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class BinaryTreeLL
    {
        private BinaryNode root{get;set;}
        public BinaryTreeLL(){
            this.root = null;
        }

        //PreOrder Traversal
        public void preOrder(BinaryNode node){
            if(node==null){
                return;
            }
            Console.WriteLine(node.value+" ");
            preOrder(node.left);
            preOrder(node.right);
        }

        //inOrder Traversal
        public void inOrder(BinaryNode node){
            if(node == null){
                return;
            }
            inOrder(node.left);
            Console.WriteLine(node.value+" ");
            inOrder(node.right);
        }
    }
}