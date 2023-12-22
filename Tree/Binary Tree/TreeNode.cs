using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class TreeNode
    {
        public String data{get;set;}

        public List<TreeNode> children{get;set;}

        public TreeNode(String data){
            this.data = data;
            children = new List<TreeNode>();
        }

        public void print(int level){
            Console.WriteLine(new string(' ',level*3)+data);
            foreach(TreeNode a in children){
                print(level +1);
            }
        }

    }
}