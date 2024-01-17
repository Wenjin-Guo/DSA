using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace DSA
{
    public class AVLTree
    {
        AVLNode root;

        //constructor
        public AVLTree(){
            this.root=null;
        }

        //preOrder traversal
        public void preOrder(AVLNode node){
            if(node==null){
                return;
            }
            Console.Write(node.value+" ");
            preOrder(node.left);
            preOrder(node.right);
        }

        //inOrder traversal
        public void inOrder(AVLNode node){
            if(node==null){
                return;
            }
            inOrder(node.left);
            Console.Write(node.value+" ");
            inOrder(node.right);
        }

        //postOrder traversal
        public void postOrder(AVLNode node){
            if(node==null){
                return;
            }
            postOrder(node.left);
            postOrder(node.right);
            Console.Write(node.value+" ");
        }

        //levelOrder traversal
        public void levelOrder(){
            Queue<AVLNode> queue = new Queue<AVLNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                AVLNode temp = queue.Dequeue();
                Console.Write(temp.value+ " ");
                if(temp.left!=null){
                    queue.Enqueue(temp.left);
                }
                if(temp.right!=null){
                    queue.Enqueue(temp.right);
                }
            }
        }

        //search method
        public AVLNode search(AVLNode node, int value){
            if(node==null){
                Console.WriteLine(value+" is not found in AVLTree");
                return null;
            }else if(node.value==value){
                Console.WriteLine(value+" has found in AVLTree");
                return node;
            }else if(node.value>value){
                return search(node.left,value);
            }else{
                return search(node.right,value);
            }
                
            
        }
    }
}