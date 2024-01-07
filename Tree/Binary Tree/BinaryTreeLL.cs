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
            Console.WriteLine();
            /* Console.WriteLine(node.value+" ");
            levelOrder(node.left);
            levelOrder(node.right); */
        }

        //use levelOrder traversal do the search function
        public void searchNode(String value){
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                BinaryNode presentNode = queue.Dequeue();
                if(presentNode.value==value){
                    Console.WriteLine("Found "+value+ " in the tree.");
                    return;
                }else{
                    if(presentNode.left!=null){
                        queue.Enqueue(presentNode.left);
                    }
                    if(presentNode.right!=null){
                        queue.Enqueue(presentNode.right);
                    }
                }
            }
            Console.WriteLine("The value does NOT found in the tree.");
        }

        //Insert method
        public void insertNode(String value){
            BinaryNode newNode = new BinaryNode();
            newNode.value = value;
            if(root==null){
                root = newNode;
                Console.WriteLine("Inserted new node at Root");
                return;
            }
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                BinaryNode presentNode = queue.Dequeue();
                if(presentNode.left == null){
                    presentNode.left = newNode;
                    Console.WriteLine("Successfully inserted");
                    break;
                }else if(presentNode.right==null){
                    presentNode.right = newNode;
                    Console.WriteLine("Successfully inserted");
                    break;
                }else{     //continue to loop through the nodes in the tree
                    queue.Enqueue(presentNode.left);
                    queue.Enqueue(presentNode.right);
                }
            }
        }

        //get deepest node in the tree
        public BinaryNode getDeepestNode(){
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            BinaryNode presentNode = null;
            while(queue.Any()){
                presentNode = queue.Dequeue();
                if(presentNode.left != null){
                    queue.Enqueue(presentNode.left);
                }
                if(presentNode.right != null){
                    queue.Enqueue(presentNode.right);
                }
            }
            return presentNode;
        }

        //delete deepest node
        public void deleteDeepestNode(){
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            BinaryNode presentNode  = null;
            BinaryNode previousNode = null;
            while(queue.Any()){
                previousNode = presentNode;
                presentNode = queue.Dequeue();
                if(presentNode.left == null){
                    previousNode.right=null;
                    return;
                }else if(presentNode.right == null){
                    presentNode.left = null;
                    return;
                }
                queue.Enqueue(presentNode.left);
                queue.Enqueue(presentNode.right);
            }
        }

        //delete given node
        public void deleteNode(String value){
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                BinaryNode presentNode = queue.Dequeue();
                if(presentNode.value == value){
                    presentNode.value = getDeepestNode().value;
                    deleteDeepestNode();
                    Console.WriteLine("The node is deleted");
                    return;
                }else{
                    if(presentNode.left!=null) queue.Enqueue(presentNode.left);
                    if(presentNode.right!=null) queue.Enqueue(presentNode.right);
                }
            }
            Console.WriteLine("The node does not exist in this BT");
        }

        //delete Bianry Tree
        public void deleteBT(){
            root = null;
            Console.WriteLine("BT has successfully deleted.");
        }
    }
}