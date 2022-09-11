using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMath
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int @value);
    }
   

    internal class Program : Array
    {
        static void Main(string[] args)
        {
            
            Array array = new Array();
            array.Max();
            array.Min();
            array.Avg();
            Console.WriteLine(array.Search(1000));
        }
    }
}
