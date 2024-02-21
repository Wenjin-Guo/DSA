using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class BinaryHeap
    {
        //1. Binary Heap is either Min Heap or Max Heap, In Min heap, the key at root must be minimum among all keys
        //2. It's a complete tree(All levels are completely filled except possibly the last level and the last level has all keys as left as possible)
        int[] arr;
        int sizeOfTree;

        public BinaryHeap(int size){
            arr=new int[size+1];
            this.sizeOfTree = 0;
            Console.WriteLine("Binary Heap has been created");
        }

        public bool isEmpty(){
            if(sizeOfTree ==0){
                return true;
            }
            return false;
        }

        public int? peek(){
            if(isEmpty()){
                Console.WriteLine("Binary Heap is empty");
                return null;
            }
            return arr[1];
        }

        public int sizeOfBH(){
            return sizeOfTree;
        }

        //level order traversal
        public void levelOrder(){
            foreach(int i in arr){
                Console.WriteLine(i+ " ");
            }
            Console.WriteLine ("\n");
        }

        
    }
}