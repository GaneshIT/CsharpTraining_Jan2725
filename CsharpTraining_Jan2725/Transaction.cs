using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
       
        public Transaction(int id,string name,string desc,string type) 
        {
            Id = id;
            Name = name;
            Description = desc;
            Type = type;
        }
        public void CreateTransaction()
        {
            FileStream fs = new FileStream("trans.txt", FileMode.Create, FileAccess.Write);//create file
            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("Id:" + Id);
            streamWriter.WriteLine("Name:" + Name);
            streamWriter.WriteLine("Desc:" + Description);
            streamWriter.WriteLine("Type:" + Type);
            streamWriter.Close();
            fs.Close();//file cl
        }
        public void ReadTransaction()
        {
            List<Transaction> list = new List<Transaction>();

            FileStream fs = new FileStream("trans.txt", FileMode.Open, FileAccess.ReadWrite);//create file
            //read
            StreamReader sr = new StreamReader(fs);
            //Console.WriteLine(sr.ReadToEnd());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            int id = 0; string name = ""; string desc = ""; string type = "";
            while (sr.Peek()>0)
            {
                string line = sr.ReadLine();
                if(line.StartsWith("Id"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    id = Convert.ToInt32(s[1]);
                }
                else if (line.StartsWith("Name"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    name = s[1];
                }
                else if (line.StartsWith("Desc"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    desc = s[1];
                }
                else if (line.StartsWith("Type"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    type = s[1];
                }

                if (id != 0 && name != "" && desc != "" && type != "")
                {
                    Transaction t = new Transaction(id, name, desc, type);
                    list.Add(t);
                    id = 0;
                    name = "";
                    desc = "";
                    type = "";
                }
                //Console.WriteLine(line);
            }
            fs.Close();
            Console.WriteLine("Id\t\tName\t\tDesc\t\tType");
            foreach (var item in list)
            {
                if(item.Type=="Credit")
                Console.WriteLine($"{item.Id}\t\t{item.Name}\t\t{item.Description}\t\t{item.Type}");
            }
        }
    }
}
/*
 * File handling
 * 
 * 1. file create
 * 2. file open
 * 3. read/write open
 * 4. file close
 * 
 * namespace: System.IO
 * 
 * 1. FileStream
 * 2. StreamWriter
 * 3. StreamReader
 * 4. File
 * 5. Directory
 * 6. TextReader
 * 7. BinaryReader
 * 8. StringReader
 * 
 * string a="welcme training bangare/Chennai";
 * welcme training bangare-[0]
 * Chennai-[1]
 * a.split('/')
 * 
 * 12/12/2025 12:20:12 AM
 * 
 * split(' ')
 * 12/12/2025
 * 12:20:12
 * AM
 */
