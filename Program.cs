using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
class Hello{
    static void Main(string[] args){
        

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
        Console.WriteLine(arrayList[2]); */

       /*  int[] myArray = {1,2,3,4,6};
        DSA.UseArray.findMissingNumberInArray(myArray);

        Console.Write(3^1^1); */

        // Create the link list.
        string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };
        LinkedList<string> sentence = new LinkedList<string>(words);
        Display(sentence, "The linked list values:");
        Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
            sentence.Contains("jumps"));

        // Add the word 'today' to the beginning of the linked list.
        sentence.AddFirst("today");
        Display(sentence, "Test 1: Add 'today' to beginning of the list:");

        // Move the first node to be the last node.
        LinkedListNode<string> mark1 = sentence.First;
        sentence.RemoveFirst();
        sentence.AddLast(mark1);
        Display(sentence, "Test 2: Move first node to be last node:");

        // Change the last node to 'yesterday'.
        sentence.RemoveLast();
        sentence.AddLast("yesterday");
        Display(sentence, "Test 3: Change the last node to 'yesterday':");

        static void Display(LinkedList<string> words, string test)
        {   
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}