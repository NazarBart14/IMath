using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMath
{
    internal class Array : IMath
    {
        int[] sered = new int[] {123, 214, 84, 47, 165, 213, 23, 243, 234, 275 };

       
       
        public int Max()
        {
            Console.WriteLine(sered.Max());
            return sered.Max();
        }
        public int Min()
        {
            Console.WriteLine(sered.Min());
            return sered.Min();
        }
        public float Avg()
        {
            Console.WriteLine(sered.Average());
            return 0;
        }
        public bool Search(int @value)
        {
            bool flag = false;
            foreach (int i in sered)
            {
                if(i == @value)
                {
                    flag = true;
                }
            }
            return flag;
           
        }
    }
}
