﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using DSA;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

class Hello{
    static void Main(string[] args){
        
        /* int[] myArray = {84,85,86,87,85,90,85,83,23,45,84,1,2,0};    
        foreach(var item in UseArray.findTopTwoScores(myArray)){
            Console.Write(item + ", ");
        }; 
        Console.WriteLine();
        Console.Write(string.Join(", ",UseArray.findTopTwoScores(myArray))); */
       

        /* ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Insert(0,9);
        arrayList.Add(4);
        foreach (var item in arrayList)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine(arrayList[2]);
        Console.WriteLine(arrayList.Count); */

       /*  int[] myArray = {1,2,3,4,6};
        DSA.UseArray.findMissingNumberInArray(myArray);

        Console.Write(3^1^1); */

        /* int[] arr = {1, 1, 2, 2, 3, 4, 5};
        int[] duplicatArray = DSA.UseArray.removeDuplicates(arr);
        foreach(int item in duplicatArray){
            Console.Write(item + ", ");
        } */

        /* SinglyLinkedList sll = new SinglyLinkedList();
        sll.createSinglyLinkedList(6);
        Console.Write("head: "+sll.head.value+" tail: "+sll.tail.value); */

        /* int[] prices = {7, 8, 5, 3, 6, 4,8,10,12,5};
        Console.WriteLine( DSA.UseArray.maxProfit(prices)); */

        /* int[] nums = {2,7,11,15};
        int target = 9;
        foreach(int i in DSA.UseArray.twoSum(nums,target)){
            Console.Write(i +", ");
        } */
        
        /* int[] array1 = {1,2,3,4,5};
        int[] array2 = {5,1,2,3,4,};
        Console.WriteLine(DSA.UseArray.permutation(array1,array2)); */

        /* int a = 10;
        int b = 2;
        (a, b) = (b, a);
        Console.Write("a: "+a+"\nb: "+b); 
        int c = 5, d=7;
        c=c^d;
        d=c^d;
        c=c^d;
        Console.Write("\nc: "+c+"\nd: "+d); */
       
       /* int[][] matrix1 = {
        new int[]{1,2,3,4,5},
        new int[]{11,12,13,14,15},
        new int[]{21,22,23,24,25},
        new int[]{31,32,33,34,35},
        new int[]{41,42,43,44,45},
       };
       int[][] matrix = {
        new int[]{1,2,3,4},
        new int[]{5,6,7,8},
        new int[]{9,10,11,12},
        new int[]{13,14,15,16}
       };
       int[][] matrix2={
        new int[]{1,2},
        new int[]{3,4}
       };
       DSA.UseArray.rotateMatrix(matrix);
       DSA.UseArray.printJaggedArray(matrix); */

        /* int temp = 7;
        Console.Write(7/2); */

        /* int[] array = {1,2,3,4,5};
        DSA.UseArray.reverse(array); */

        /* List<int> numbers = new List<int>() { 5, 6, 4 };
        // Violates IDE0180.
        int temp = numbers[0];
        numbers[0] = numbers[1];
        numbers[1] = temp;
        // Fixed code.
        Console.WriteLine(numbers[1]);
        (numbers[0], numbers[1]) = (numbers[1], numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.Write(string.Join(", ",numbers)); */
        
        /* SinglyLinkedList linkedList = new SinglyLinkedList();
        linkedList.createSinglyLinkedList(1);
        linkedList.printSinglyLinkedList();
        linkedList.insertInLinkedList(9,0);
        linkedList.insertInLinkedList(2,1);
        linkedList.insertInLinkedList(3,3);
        linkedList.insertInLinkedList(4,4);
        linkedList.insertInLinkedList(5,9); 
        linkedList.insertInLinkedList(00,0);
        linkedList.printSinglyLinkedList();
        linkedList.insertInLinkedList(100,3);
        linkedList.printSinglyLinkedList();
        linkedList.deleteNode(10);
        linkedList.printSinglyLinkedList();
        linkedList.deleteNode(2);
        linkedList.printSinglyLinkedList();
        linkedList.deleteNode(2);
        linkedList.printSinglyLinkedList();
        Console.WriteLine("\nTail value: "+linkedList.tail.value);
        Console.WriteLine("Head Value: "+linkedList.head.value);
        Console.WriteLine("Size: "+linkedList.size); */

        /* LinkedList<int> lls = new LinkedList<int>();
        lls.AddLast(1);
        lls.AddLast(2);
        lls.AddLast(3);
        lls.AddLast(4);
        lls.AddLast(5);
        foreach(int i in lls){
            Console.Write("   {0}", i);
        }
        lls.Clear();
        Console.Write("\n - - - - - - ");
        foreach(int i in lls){
            Console.Write("   {0}", i);
        } */

        /* CircularSinglyLinkedList csll = new CircularSinglyLinkedList();
        csll.createCSLL(1);
        csll.deleteNode(0);
        csll.printCSLL(); */
        /* csll.insertInCSLL(2,1); 
        csll.insertInCSLL(3,2);
        csll.insertInCSLL(4,3);
        csll.insertInCSLL(5,4);
        csll.insertInCSLL(6,5);
        Console.WriteLine("head value: "+csll.head.value);
        csll.printCSLL();
        Console.WriteLine("tail value: "+csll.tail.value);
        Console.WriteLine("size value: "+csll.size);
        csll.insertInCSLL(12,3);
        csll.printCSLL();
        Console.WriteLine("Index value: "+csll.getNode(3).value);
        Console.WriteLine("Index next-value: "+csll.getNode(2).next.value);
        csll.deleteNode(7);
        csll.printCSLL();
        Console.WriteLine("head value: "+csll.head.value);
        Console.WriteLine("head value: "+csll.tail.next.value);
        Console.WriteLine("tail value: "+csll.tail.value);
        Console.WriteLine("size value: "+csll.size); */

       /*  DoublyLinkedList dll = new DoublyLinkedList();
        dll.createDoublyLinkedList(1);
        dll.deleteNode(6);
        dll.printDLL(); */
        /* dll.insertInDLL(2,1);
        dll.insertInDLL(0,0);
        dll.printDLL();
        dll.insertInDLL(0,1);
        dll.printDLL();
        dll.insertInDLL(3,3);
        dll.insertInDLL(4,4);
        dll.insertInDLL(6,6);
        dll.insertInDLL(5,5);
        dll.insertInDLL(12,4);
        dll.printDLL();
        dll.reversePrintDLL();
        Console.WriteLine("head value: "+dll.head.value);
        Console.WriteLine("tail value: "+dll.tail.value);
        Console.WriteLine("tail prev-value: "+dll.tail.prev.value);
        Console.WriteLine("size value: "+dll.size);
        Console.WriteLine("Index value: "+dll.getValue(4));
        Console.WriteLine("Index prev-value: "+dll.getNode(5).prev.value);
        Console.WriteLine("Index next-value: "+dll.getNode(3).next.value);
        dll.searchNode(5);
        dll.searchNode(120);
        dll.deleteNode(1); dll.printDLL();
        dll.deleteNode(6); dll.printDLL();
        dll.deleteNode(3); dll.printDLL();
        dll.deleteDLL();
        dll.printDLL(); */

        /* CircularDoublyLinkedList cdll = new CircularDoublyLinkedList();
        cdll.createCDLL(1);
        cdll.deleteCDLL();
        cdll.printCDLL();
        cdll.deleteNode(5);
        cdll.printCDLL();
        cdll.insertInCDLL(3,1);
        cdll.printCDLL();
        cdll.insertInCDLL(2,1);
        cdll.printCDLL();
        cdll.insertInCDLL(0,0);
        cdll.printCDLL();
        cdll.insertInCDLL(8,3);
        cdll.insertInCDLL(10,4);
        cdll.printCDLL();
        cdll.insertInCDLL(0,0);
        cdll.insertInCDLL(0,0);
        Console.WriteLine(cdll.head.next.prev.value);
        Console.WriteLine(cdll.tail.next.value);
        cdll.printCDLL();
        cdll.deleteNode(4);
        cdll.printCDLL();
        Console.WriteLine(cdll.getNode(4).value);
        Console.WriteLine(cdll.getNode(-1).next.value);
        Console.WriteLine(cdll.getNode(4).prev.value); */

        /* SinglyLinkedList sll = new SinglyLinkedList();
        UseLinkedList ull = new UseLinkedList();
        sll.createSinglyLinkedList(1);
        sll.add(2);
        sll.add(1);
        sll.add(3);
        sll.add(4);
        sll.add(6);
        sll.add(2);
        sll.add(4);
        sll.add(4);
        sll.add(7);
        sll.printSinglyLinkedList();
        Console.WriteLine("head value: "+ sll.head.value); */
        //ull.deletDups(sll);
        //SinglyLinkedList head = ull.partition(sll,5);
        //Node head = ull.SwapPairs(sll);
        //ull.printLL(head);
        /* sll = ull.partition(sll,5);
        sll.printSinglyLinkedList(); */

        /* ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);
        head.next.next.next.next.next = new ListNode(9);
        head.next.next.next.next.next.next = new ListNode(2);
        head.next.next.next.next.next.next.next =new ListNode(4);
        head.next.next.next.next.next.next.next.next =new ListNode(7);
        head.next.next.next.next.next.next.next.next.next =new ListNode(3); */
        
        /* UseLinkedList  ull = new UseLinkedList();
        ull.createLinkedList(1);
        ull.add(2);
        ull.add(3);
        ull.add(4);
        ull.add(5);
        ListNode head = ull.head;
        ull.printLL(head);
        head = ull.SwapPairs(head);  //very import to reset the head
        ull.printLL(head); */

        /* UseLinkedList ull = new UseLinkedList();
        ull.printLL(head);
        head = ull.partition(head,5);
        ull.printLL(head); */
        

        /* QueueLinkedList qll = new QueueLinkedList();
        qll.enQueue(1);
        qll.enQueue(2);
        qll.enQueue(3);
        qll.enQueue(4);
        qll.enQueue(5);
        qll.printQLL();
        Console.WriteLine(qll.head.value);
        Console.WriteLine(qll.tail.next.next.value);
        Console.WriteLine(qll.head.prev.prev.value);
        int? result = qll.deQueue();
        Console.WriteLine("dequeue value "+result);
        int? result1 = qll.peek();
        Console.WriteLine("The head value is "+result1);
        qll.printQLL(); */

        /* Recursion rec = new Recursion();
        Console.WriteLine(rec.factorial(8));
        Console.WriteLine(rec.fibonacci(-5));
        Console.WriteLine(Math.Max(3,2.5));
        int[] arr = {2,4,5,7,8,9,9,2,1,23,23,345,34,1,6,555};
        Console.WriteLine(rec.findMaxNumRec(arr));
        Console.WriteLine(3%10);
        Console.WriteLine(rec.sumOfDigits(50));
        Console.WriteLine(rec.powerOfNumber(10,-2));
        Console.WriteLine(rec.gcd(56,56));
        Console.WriteLine(rec.decimalToBinary(10));
        Console.WriteLine(13/2);
        Console.WriteLine(rec.power(-2,3)); */

        /* TreeNode drinks = new TreeNode("Drinks");
        TreeNode hot = new TreeNode("Hot");
        TreeNode cold = new TreeNode("Cold");
        TreeNode tea = new TreeNode("Tea");
        TreeNode coffee = new TreeNode("Coffee");
        TreeNode wine = new TreeNode("Wine");
        TreeNode beer = new TreeNode("Beer");
        drinks.children.Add(hot);
        drinks.children.Add(cold);
        hot.children.Add(tea);
        hot.children.Add(coffee);
        cold.children.Add(wine);
        cold.children.Add(beer);

        Console.Write(drinks.print(0));
        drinks.PrintTree(drinks,"",true); */

        /* BinaryTreeLL BTLL = new BinaryTreeLL();
        BinaryNode N1 = new BinaryNode();
        N1.value = "N1";
        BinaryNode N2 = new BinaryNode();
        N2.value = "N2";
        BinaryNode N3 = new BinaryNode();
        N3.value = "N3";
        BinaryNode N4 = new BinaryNode();
        N4.value = "N4";
        BinaryNode N5 = new BinaryNode();
        N5.value = "N5";
        BinaryNode N6 = new BinaryNode();
        N6.value = "N6";
        BinaryNode N7 = new BinaryNode();
        N7.value = "N7";
        BinaryNode N8 = new BinaryNode();
        N8.value = "N8";
        BinaryNode N9 = new BinaryNode();
        N9.value = "N9";
        N1.left = N2; 
        N1.right = N3;
        N2.left = N4;
        N2.right = N5;
        N3.left = N6;
        N3.right = N7;
        N4.left = N8;
        N4.right = N9;
        BTLL.root = N1;

        BTLL.inOrder(N1);
        BTLL.preOrder(N1);
        BTLL.levelOrder();
        BTLL.searchNode("N10");
        BTLL.insertNode("N10");BTLL.insertNode("N11");BTLL.insertNode("N12");
        BTLL.levelOrder();
        Console.WriteLine(BTLL.getDeepestNode().value);
        BTLL.deleteDeepestNode();
        BTLL.levelOrder();
        BTLL.deleteNode("N1");
        BTLL.levelOrder(); */

        /* BinaryTreeArr btarr = new BinaryTreeArr(5);
        btarr.insert("N1");
        btarr.insert("N2");
        btarr.insert("N3");
        btarr.insert("N4");
        btarr.insert("N5");
        btarr.insert("N6");
        btarr.insert("N7");
        btarr.insert("N8");
        btarr.insert("N9");
        btarr.preOrder(0);
        Console.WriteLine();
        btarr.inOrder(0);
        Console.WriteLine();
        btarr.postOrder(0);
        Console.WriteLine();
        btarr.levelOrder();
        Console.WriteLine();
        btarr.searchNode("N4");
        btarr.deleteNode("N3");
        btarr.levelOrder();
        Console.WriteLine();
        btarr.deleteBT(); */

        /* BinarySearchTree newBST = new BinarySearchTree();
        newBST.insert(70);
        newBST.insert(50);
        newBST.insert(90);
        newBST.insert(30);
        newBST.insert(60);
        newBST.insert(80);
        newBST.insert(100);
        newBST.insert(20);
        newBST.insert(40);
        newBST.preOrder(newBST.root);
        Console.WriteLine();
        newBST.inOrder(newBST.root);
        Console.WriteLine();
        newBST.postOrder(newBST.root);
        Console.WriteLine();
        newBST.levelOrder();
        Console.WriteLine();
        newBST.search(newBST.root,40);
        newBST.deleteNode(newBST.root, 90);
        newBST.levelOrder();
        Console.WriteLine(); */

        /* AVLTree newAVL = new AVLTree();
        newAVL.insert(5);
        newAVL.insert(10);
        newAVL.insert(15);
        newAVL.insert(20);
        newAVL.levelOrder();
        newAVL.delete(5);
        Console.WriteLine();
        newAVL.levelOrder(); */

        BinaryHeap BH = new BinaryHeap(5);
        BH.insert(10,"Max");
        BH.insert(5,"Max");
        BH.insert(15,"Max");
        BH.insert(78,"Max");
        BH.insert(11,"Max");
        BH.insert(9,"Max");
        BH.insert(20,"Max");
        BH.insert(29,"Max");
        BH.insert(19,"Max");
        BH.insert(1,"Max");
        Console.WriteLine(BH.arr.Length);
        Console.WriteLine(BH.sizeOfTree);
        BH.levelOrder();
        BH.extractHeadofBH("Max");
        BH.levelOrder();
    }      
}