using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Average_Query_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1,2,4,8,6,9,10,3,6,7 };

            var ltAvg = from n in nums
                        let x = nums.Average()
                        where n < x
                        select n;

            Console.WriteLine($"The Average is: {nums.Average()}");

            Console.WriteLine($"These values are less than the average.");
            

            foreach(int i in ltAvg)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
