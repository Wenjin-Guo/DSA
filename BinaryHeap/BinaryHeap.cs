using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class BinaryHeap
    {
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
    }
}