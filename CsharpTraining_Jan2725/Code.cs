using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CsharpTraining_Jan2725
{
    public class Code
    {
        public void Find()
        {
            int t = 0;
            int[] a = { 10, 2, 30, 14, 50 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if(a[i] < a[j]) 
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j]= t;
                    }
                }
            }
            Console.WriteLine(a[2]);
        }

        public void Find2()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            numbers.Add(11);
            numbers.Add(12);
            foreach (var num in evenNumbers)//deffered
            {
                Console.WriteLine(num);
            }
        }

        public void Find3()
        {
            int[] a = { 1, 2, 2, 3, 4, 4, 4 };

            var result= a.Distinct();



            HashSet<int> set = new HashSet<int>();
            foreach (var item in a)
            {
                set.Add(item);
            }

        }
    }
}
