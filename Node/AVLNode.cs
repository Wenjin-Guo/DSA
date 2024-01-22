using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class AVLNode
    {
        public int value{get;set;}
        public int height{get;set;}
        public AVLNode left{get;set;}
        public AVLNode right{get;set;}

        public AVLNode(){
            this.height=0;
        }
    }
}