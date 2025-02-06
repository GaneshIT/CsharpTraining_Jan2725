using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    //Delegates-> its function pointer or reference
    //can pass argument as a function
    //function callback
    //to create events
    //Types: single, multicast

    //Func<T1,T2,T3,T4,T5>return type, Action<T> no return type, Predict<T> return boolean type
    public delegate void GetReport();
    public class DelegatesDemo
    {
        public void Get()
        {
            Console.WriteLine("Report 1");
        }
        public void GetReport()
        {
            Console.WriteLine("Report 2");
        }
        public void GetExcelReport()
        {
            Console.WriteLine("Report 3");
        }
        public void GetWordReport()
        {
            // return "Word";

            //GetSalesReport("SalesReprt", 101);
            Action<string, int> myData = GetSalesReport;
            myData("Sales", 1001);
            //Console.WriteLine(r);
        }

        public void GetSalesReport(string name, int id)
        {
            //return "Report details:" + name + "_" + id;
        }

        // A method that checks if a number is even
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // A method that performs an operation using Predicate
        static bool PerformOperation(Predicate<int> operation, int number)
        {
            //number();//err
            return operation(number);
        }

        // Usage
       // bool isEven = PerformOperation(IsEven, 6);
        //Console.WriteLine(isEven); // Output: True
    }
    public class MyDeleateResult
    {
        public void Access(GetReport getReport)
        {
            getReport();//Get(), GetReport(),GetExcelReport();
        }
    }
}


/* TDD: Test Driven Development
 * Unit Testing
 * ->To test the business logic working or not as per the functional requirments
 * Xunit, NUnit, MSTest
 * 
 */