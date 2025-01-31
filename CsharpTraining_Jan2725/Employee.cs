using System;
using System.Collections;
using System.Collections.Generic;//generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Employee
    {
        public string Name { get; set; } = "IT";
        public int GetEmployeeGrade(ref int value)//M001
        {
            if (Name == "IT")
                value = 10; //M001
            else
                value = 20;//M001
            return value;//10
        }

        //public void CreateEmployee(string dept)
        //{
        //}
        //public void CreateEmployee(int grade)
        //{
        //}
        //public void CreateEmployee(bool isPermanent)
        //{
        //}
        public void CreateEmployee<T>(T input)
        {
            T result=input;
            Console.WriteLine(input);
        }

        public void Create(object input)//10
        {
            Console.WriteLine(input);
        }
        public string GetS()
        {
            return "";
        }
        public int GetI()
        {
            return 1;
        }
        public string[] GetStrs()
        {
            string[] strings = new string[1];
            return strings;
        }
        public Dictionary<int,string> GetD()
        {
            Dictionary<int, string> movieDict = new Dictionary<int, string>();
            Dictionary<int, string> resultDict = new Dictionary<int, string>();
            movieDict.Add(101, "ABC");
            movieDict.Add(102, "CCA");
            movieDict.Add(103, "BAC");
            movieDict.Add(104, "CAB"); //C
            movieDict.Add(105, "CBA");
            Console.WriteLine(movieDict[104]);//A4
            foreach (var item in movieDict)
            {
                if (item.Value.StartsWith("C"))
                {
                    resultDict.Add(item.Key, item.Value);
                }
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            return resultDict;
        }
        public void CreateDept()
        {
            #region arraylist
            //String methods-> string.StartsWith(), string.EndsWith(), string.Contans()
            ArrayList arrayList = new ArrayList();//Count=0
            arrayList.Add(100);
            arrayList.Add("Raj");
            arrayList.Add("bangalore");
            //arrayList.Sort();
            arrayList.Reverse();
            object input = Console.ReadLine();
            arrayList[2] = "Pune";//update
            arrayList.RemoveAt(2);//index

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            foreach (object obj in arrayList) 
            {
                if (obj== input)
                    Console.WriteLine(obj);
            }

            Console.WriteLine(arrayList.Count);//3
            #endregion

            #region stack&Queue

            int a;
            a = 10;
            string x;
            x = "welcome";
            var v = "100";//implcitely typed variable
            object o = "100;";
            Stack s=new Stack();
            s.Push(100);
            s.Push("Raj");
            s.Push("bangalore");

            Console.WriteLine(s.Pop());//it removes the top element from the stack

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Queue q = new Queue();//FIFO
            q.Enqueue(100);
            q.Enqueue("Raj");
            q.Enqueue("bangalore");

            Console.WriteLine(q.Dequeue());//it removes the top element from the queue

            foreach (object item in q)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region hashtable
            Hashtable ht=new Hashtable();
            ht.Add(1, "A");//#1AM002
            ht.Add(2, "B");//#2AM001
            ht.Add(3, "C");//#3AM003

            foreach (object item in ht)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region sortedlist
            SortedList st = new SortedList();
            st.Add("X", "A");
            st.Add("Z", "B");
            //st.Add("Z", "C");

            foreach (DictionaryEntry item in st)
            {  
                if (item.Key == "Z")
                Console.WriteLine(item);
            }

            #endregion

            #region list
            List<string> cityLis = new List<string>();
            cityLis.Add("GOA");
            cityLis.Add("Mumbai");

            List<string> list = new List<string>();
            list.Add("Bangalore");
            list.Add("Pune");
            list.Add("Hyd");
            list.Add("Chennai");
            list.Add("Delhi");

            list.AddRange(cityLis);

            list.Reverse();
            list.Sort();
            list.Remove("Pune");
            list[2] = "Kochi";
            foreach (string item in list)
            {
                if (item.StartsWith("B"))
                    Console.WriteLine(item);
            }
            #endregion

            #region dictionary
            Dictionary<int,string> movieDict = new Dictionary<int,string>();
            Dictionary<int, string> resultDict = new Dictionary<int, string>();
            movieDict.Add(101, "ABC");
            movieDict.Add(102, "CCA");
            movieDict.Add(103, "BAC");
            movieDict.Add(104, "CAB"); //C
            movieDict.Add(105, "CBA");
            Console.WriteLine(movieDict[104]);//A4
            foreach (var item in movieDict)
            {
                if (item.Value.StartsWith("C")) 
                {
                    resultDict.Add(item.Key, item.Value);
                }
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            //return resultDict
            #endregion
        }

    }

    public class ExceptionHandling
    {
        public static void FileProcess()
        {
            try
            {

            }
            
            catch(Exception ex)
            {

            }
            finally
            {
            }



            try
            {
            Console.WriteLine($"Enter value");
            int a = Convert.ToInt32(Console.ReadLine());//2bc
                int[] arr = { 3, 3 };
                Console.WriteLine(arr[0]);
            File.Open("xxx.txt",FileMode.Open);

            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Enter number only");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Size exceeded");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File is not available");
                //Console.WriteLine("message:"+ex.Message+"Source:"+ex.Source);

            }
            catch (Exception ex)
            {
                //ex.
                Console.WriteLine("Invalid input");
            }
        }
    }
}

/* int[] a=new int[10]; 
 * C# Collections->add,update,delete
 * 1. non-generic collections
 *      ->ArrayList
 *      ->Stack
 *      ->Queue

 *      ->HashTable
 *      ->SortedList
 * 2. generic collections
 *      ->Dictionary<key,value>
 *      ->List<T>
 *      ->Stack<T>
 *      ->Queue<T>
 *      ->HashSet<T>
 *      ->LinkedList<T>
 *      ->SortedList<Key,Value>
 *      
 *      Dict            Dict[102]-> B
 *      101-A
 *      102-B
 *      103-C
 *      
 *      
 *      sortedlst        sortedlst[2]
 *      101,A
 *      102,B
 *      103,B
 */