using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxRemap
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaxNum maxnum = new MaxNum();
            Console.WriteLine("test case 1");
            Console.WriteLine("Largest String is " + MaxNum.MaximumStringNumber("Shreyas", "Abhi", "Megha"));
            Console.WriteLine("test case 2");
            Console.WriteLine("Largest String is " + MaxNum.MaximumStringNumber("Megha", "Sagar", "Aish"));
            Console.WriteLine("test case 3");
            Console.WriteLine("Largest String is " + MaxNum.MaximumStringNumber("Bharath", "Gowri", "Virat")); 
            Console.ReadLine();


        }
    }
}
