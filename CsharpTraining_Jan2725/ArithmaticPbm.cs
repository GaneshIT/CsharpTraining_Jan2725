using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public delegate int Calc(int x, int y);
    public class ArithmaticPbm
    {
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Sub(int x, int y)
        //{
        //    return x - y;
        //}
        //public static int Mul(int x, int y)
        //{
        //    return x * y;
        //}
        public static int Add(int x, int y)=>x+y;
        public static int Sub(int x, int y) => x - y;
        public static int Mul(int x, int y) => x * y;

        //public static int Performoperation(int a,int b,Calc c)//Add
        //{
        //    return c(a,b);//Add(a,b)
        //}
        public static int Performoperation(int a, int b, Calc c)=>c(a,b);

    }
}
