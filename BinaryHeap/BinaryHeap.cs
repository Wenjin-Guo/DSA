using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DSA
{
    public class BinaryHeap
    {
        //1. Binary Heap is either Min Heap or Max Heap, In Min heap, the key at root must be minimum among all keys
        //2. It's a complete tree(All levels are completely filled except possibly the last level and the last level has all keys as left as possible)
        // left child = cell[2x], right child = cell[2x+1]
        public int[] arr;
        public int sizeOfTree;

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
            for(int i=1;i<=sizeOfTree;i++){
                Console.Write(arr[i]+" ");
            }
            /* foreach(int i in arr){
                Console.Write(i+ " ");
            } */
            Console.WriteLine ("\n");
        }

        //extend array capacity
        private void extendCapacity(){
            int[] temp = new int[arr.Length*2];
            for(int i=0;i<arr.Length;i++){
                temp[i] = arr[i];
            }
            arr=temp;
            temp=null;
        }

        //Heapify for Insertion
        public void heapifyBottomToTop(int index, String heapType){
            int parent = index/2;
            if(index <= 1){
                return;
            }
            if(heapType == "Min"){
                if(arr[index] < arr[parent]){
                    (arr[index],arr[parent])=(arr[parent],arr[index]);
                }
            }else if(heapType == "Max"){
                if(arr[index] > arr[parent]){
                    int tmp = arr[index];
                    arr[index] = arr[parent];
                    arr[parent] = tmp;
                    //(arr[index],arr[parent])=(arr[parent],arr[index]);
                }
            }
            heapifyBottomToTop(parent, heapType);
        }

        //insertion
        public void insert(int value, String typeHeap){
            if(sizeOfTree+1 >= arr.Length){
                extendCapacity();
            }
            arr[sizeOfTree+1] = value;
            sizeOfTree++;
            heapifyBottomToTop(sizeOfTree,typeHeap);
            Console.WriteLine("Inserted "+value+" successfully in Heap");
        }

        //Heapify for extract root node
        public void heapifyToptoBottom(int index, String heapType){
            int left = 2*index;
            int right = 2*index+1;
            int swapChild;
            if(left >=sizeOfTree){
                return;
            }
            if(heapType == "Min"){
                //1 child case
                if(sizeOfTree == left){
                    if(arr[index] > arr[left]){
                        (arr[index],arr[left])=(arr[left],arr[index]);
                        return;
                    }
                }else{
                    //2 child case
                    if(arr[left] < arr[right]){
                        swapChild = left;
                    }else{
                        swapChild = right;
                    }
                    if(arr[index] > arr[swapChild]){
                        (arr[index],arr[swapChild])=(arr[swapChild],arr[index]);
                    }
                }
                
            }
            else if(heapType == "Max"){
                //1 child case
                if(sizeOfTree == left){
                    if(arr[index] < arr[left]){
                        (arr[index],arr[left])=(arr[left],arr[index]);
                    }
                    return;
                }else{
                    //2 child case
                    if(arr[left] > arr[right]){
                        swapChild = left;
                    }else{
                        swapChild = right;
                    }
                    if(arr[index] < arr[swapChild]){
                        (arr[index],arr[swapChild])=(arr[swapChild],arr[index]);
                    }
                }
            }
            heapifyToptoBottom(swapChild,heapType);
        }

        //extract the root node or head of Binary heap
        public int extractHeadofBH(String heapType){
            if(isEmpty()){
                return -1;
            }else{
                int extractedValue = arr[1];
                arr[1] = arr[sizeOfTree];
                sizeOfTree--;
                heapifyToptoBottom(1, heapType);
                return extractedValue;
            }
        }
    }
}