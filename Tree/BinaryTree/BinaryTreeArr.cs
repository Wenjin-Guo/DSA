using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class BinaryTreeArr
    {
        String[] arr {get;set;}
        int lastUsedIndex{get;set;}

        public BinaryTreeArr(int size){
            arr = new string[size+1];
            this.lastUsedIndex = 0;
            Console.WriteLine("Blank Tree of size "+size+" has been created");
        }
        
    }
}