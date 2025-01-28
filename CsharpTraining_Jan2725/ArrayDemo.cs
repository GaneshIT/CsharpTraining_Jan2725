using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class ArrayDemo
    {
        public void Find()
        {
            //Dept dept = new Dept();
            //dept.CreateDept();
            //printf("/n");
            //Console.Write(); //no new line
            Console.WriteLine();//it wll print the value and take a new line
            //how to declary array?
            int n;
            Console.WriteLine("enter size of the array");
            n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] a = { 3, 494, 4 };
            Console.WriteLine(a[1]);
            //arr[0] = 11;
            //arr[1] = 2;
            //arr[2] = 30;
            //arr[3] = 42;
            //arr[4] = 15;

            Console.WriteLine("Enter values");
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool f =int.TryParse(Console.ReadLine(), out x);
                arr[i] = x;
                //if (!f)
                //    arr[i] = x;
                //else
                //    arr[i] = x;
            }
            //how to display array values
            //arr.Length->  5
            Console.WriteLine("Array values");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        public void Multidimentional()
        {
            int[,] a = new int[2, 3]; //2x3
            a[0,0] = 10;
            a[0,1] = 20;
            a[0,2] = 30;

            a[1, 0] = 110;
            a[1, 1] = 220;
            a[1, 2] = 330;

            //jagged array
            int[][] counters=new int[3][];

            counters[0] = new int[2];    //-> 10  20
            counters[1] = new int[3];    //-> 30   40   50
            counters[2] = new int[5];    //-> 2    4     6    8  10

            //how to store values
            counters[0][0] = 101;
            counters[0][1] = 102;

            counters[1][0] = 103;
            counters[1][1] = 104;
            counters[1][2] = 105;

            counters[2][0] = 106;
            counters[2][1] = 107;
            counters[2][2] = 108;
            counters[2][3] = 100;
            counters[2][4] = 110;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < counters[i].Length; j++)
                {
                    Console.WriteLine(counters[i][j]);
                }
            }
        }
    }
}

/*
 * 1. single dimentional
 * 2. multi dimentional
 * example: int[,] a=new int[2,2]  2x2 matrix
 * 3. jagged array
 */
