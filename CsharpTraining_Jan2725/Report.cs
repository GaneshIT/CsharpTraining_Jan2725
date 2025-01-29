using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    //OOPS
    //static and abstract class ->we cannot create obj

    public abstract class MyMob
    {
        public abstract void Dial();
    }
    public class Calling:MyMob
    {
        public override void Dial()
        {
            //sender num and receiver
            //network
            //call process
            //Response
        }
    }
    public class Report
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }  
        public int ReportLimit { get; set; }
        public DateTime ReportDate { get; set; }
        public Report() 
        {
            Console.WriteLine("Welcome to my reports");
            ReportDate = DateTime.Now; //how to fetch system date time
        }
        public Report(int reportId, string reportName, int reportLimit, DateTime reportDate)
        {
            ReportId = reportId;
            ReportName = reportName;
            ReportLimit = reportLimit;
            ReportDate = reportDate;
        }
        public Report(string reportType)
        {
            Console.WriteLine("Report type"+reportType);
        }
        public Report(string reportType,int limit)
        {
            Console.WriteLine("Report type" + reportType);
            Console.WriteLine("Report Limit" + limit);
        }
        public void ReportData()
        {
            Console.WriteLine("Report Detals:");
            Console.WriteLine("ReportID:"+ReportId);
            Console.WriteLine("ReportName:"+ReportName);
            Console.WriteLine("ReportLimit:"+ReportLimit);
            Console.WriteLine("ReportDate:" + ReportDate.ToString());
            Console.WriteLine("...Loading reports");
        }
        public void ReportData(string reportType)
        {
            Console.WriteLine(ReportDate.ToString());

        }
    }

    public class Sales
    {

        public Sales()
        {
            Console.WriteLine("Sales Dashboard");
        }
        static Sales()
        {
            Console.WriteLine("Bangalore-Sales-Dashboard");
        }
    }

    public class MyLog
    {
        public int y = 20;
        public static int x = 0;
        private static MyLog myLogInstance = null;
        private MyLog()
        {
            y= 20;
            x = x + 1;
            Console.WriteLine(x);
        }
        public static MyLog GetLogInstance()
        {
            if(myLogInstance == null)
                myLogInstance = new MyLog();
            return myLogInstance;
        }
        public void Check()
        {
            Console.WriteLine("Calling");
        }
    }
}

/*
 * Constructors
 * ->class name and function name will be same
 * ->no return type
 * ->constructor function will be exected while creating object for class
 * ->can have constructor overloading
 * 
 * Types:
 * 1. default
 * 2. static
 * 3. private
 */
