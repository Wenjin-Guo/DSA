using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DSA
{
    public class BinaryTreeLL
    {
        public BinaryNode root{get;set;}
        public BinaryTreeLL(){
            this.root = null;
        }

        //PreOrder Traversal: root node->left node->right node
        public void preOrder(BinaryNode node){
            if(node==null){
                return;
            }
            Console.Write(node.value+" ");
            preOrder(node.left);
            preOrder(node.right);
        }

        //inOrder Traversal: left node -> root node -> right node
        public void inOrder(BinaryNode node){
            if(node == null){
                return;
            }
            inOrder(node.left);
            Console.Write(node.value+" ");
            inOrder(node.right);
        }

        //inOrder Traversal: left node-> right node-> root node
        public void postOrder(BinaryNode node){
            if(node ==null){
                return;
            }
            postOrder(node.left);
            postOrder(node.right);
            Console.Write(node.value+ " ");
        }

        //levelOrder Traversal: 
        public void levelOrder(){
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                BinaryNode presentNode = queue.Dequeue();
                Console.Write(presentNode.value+" ");
                if(presentNode.left!=null){
                    queue.Enqueue(presentNode.left);
                }
                if(presentNode.right!=null){
                    queue.Enqueue(presentNode.right);
                }
            }
            /* Console.WriteLine(node.value+" ");
            levelOrder(node.left);
            levelOrder(node.right); */
        }

        public void searchNode(String value){
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                BinaryNode presentNode = queue.Dequeue();
                if(presentNode.value==value){
                    Console.WriteLine("Found "+value);
                }
                if(presentNode.left!=null){
                    queue.Enqueue(presentNode.left);
                }
                if(presentNode.right!=null){
                    queue.Enqueue(presentNode.right);
                }
            }
            Console.WriteLine("The value does NOT find in the tree.");
        }
    }
}