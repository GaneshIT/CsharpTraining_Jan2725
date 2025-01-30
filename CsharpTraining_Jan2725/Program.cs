using CsharpTraining_Jan2725;
using System.Text;

public class Program {
    /*public static int x = 10;
    public int y = 10;
    public Program() //non-static constructor
    {
        x = x + 10;
        y=y + 10;
        Console.WriteLine("My Program loading");
    }
    public void GetValue() //non-static constructor
    {
        x = x + 10;
        y = y + 10;
        Program p = new Program();
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine("GetValue");
    }
    static Program() //static constructor
    {
        x =x+ 20;
        Console.WriteLine("My static Program loading");
    }
    */
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.CreateDept();
        //employee.CreateEmployee("IT");
        //employee.CreateEmployee(2);
        //employee.CreateEmployee<int>(10);
        //employee.CreateEmployee<string>("IT");
        //employee.CreateEmployee<bool>(false);

        //employee.Create(10);
        //employee.Create("10");
        //int value=0;//M001
        //employee.GetEmployeeGrade(ref value);//M001
        //Console.WriteLine(value);//M001
        //MyLog myLog = MyLog.GetLogInstance();
        //myLog.Check();//First time calling

        //myLog = MyLog.GetLogInstance();
        //myLog.Check();//2nd time calling
        //Program p = new Program();
        //p.GetValue();
        //Console.WriteLine(x);
        //int y = x;
    }
}
/*
Report report = new Report(101,"Excel",500,DateTime.Now);
report.ReportData();



SBI sBIobj1 = new SBI(); // SBI and Account
sBIobj1.LoanTypes();
sBIobj1.ShowBrances(); //parent class method will be hide because of new keyword

Account accountObj1=new SBI(); //SOLID principles   Account and SBI
//accountObj.LoanTypes();
accountObj1.ShowBrances();//

Account accountObj2 = new HDFC();

MyLoans myLoans = new MyLoans();
string acc = "SBI";
if(acc=="SBI")
myLoans.DisplayLoans(accountObj1);
else
myLoans.DisplayLoans(accountObj2);
//Account obj= new Account();
//obj.Name = "Raj";   //set()
//obj.AccountId = 123;
//obj.AccType = "Saving";

//obj.AccountTypes();

SBI sBI = new SBI();
sBI.AccountTypes();
sBI.LoanTypes();

HDFC hDFC = new HDFC();
hDFC.AccountTypes();

ICICI iCICI=new ICICI();//instance created 
iCICI.AccountTypes();//non-static
ICICI.GetLoans();//static
*/

//Console.WriteLine(obj.Name);//get()

//Account accountObj=new Account();
//accountObj.AccountTypes();

//Dept objDept=new Dept();
//objDept.CreateDept();//function calling usng object

//ArrayDemo obj = new ArrayDemo();
//obj.Find();

/*
Product productObj= new Product();//create object

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);//
}

int a = 100;  //M001
object o = a;//value type to ref type-> Boxing    -> o->m002 ->value: 100 main memory

int b =Convert.ToInt32(o); //ref type to value type -unboxing

string b2 = Convert.ToString(o); //unboxing
b2 = "abc";
Console.WriteLine("Welcome");// Print statement

Console.WriteLine("Enter acno:");
int acno=Convert.ToInt32(Console.ReadLine());    

Console.WriteLine("Enter name");
string name=Console.ReadLine();


Console.WriteLine("***************");
Console.WriteLine("You have entered acno:"+acno);
Console.WriteLine("You have entered name:" + name);

StringBuilder stringBuilder = new StringBuilder();

stringBuilder.Append("Hai");
stringBuilder.Append("Welcome");
*/

/*
 * CLR - Common Language Runtime           
 *        ->Compilation
 *        ->Memory management
 *        ->Development
 *        ->Debugging
 * CLS - common Language Specifications
 * CTS - common type system
 *     c++-> int a;
 *     java-> int a
 *     vb->   Dim a as integer
 *     
 * BCL -> base class library
 *     
 * CTS->    INPUT a
 * 
 * Compilation
 * 1. source code convert to MSIl(Microsoft intermediate language)
 * 2. MSIL to Machine code by JIT(just in time compiler)
 * 
 * Boxing and unboxing in C#?
 * string and stringbuilder?
 * 
 * string ->immutable
 * stringbuilder ->mutable 
 * 
 * string a="welcome";        a->M001->welcome
 * a="Hai";                   a->M002->hai
 * 
 * stringbuilder b="welcome";      ->M002
 * b="Hai"                         ->M002
 * 
 * 
 * for->process steps 3,4,5
 * 1.init
 * 2.cond
 * 3.incr/decr
 * 
 * Assembly -> it will have collections of code files that compiled into exectuable(.exe)
 * 
 * Type of assemblies:
 * 1. Private Assemblies
 * 2. Shared Assemblies:
 *      ->Global Assembly Cache (GAC)
 * 3. Satellite Assemblies:
 * 4. Dynamic Link Libraries (DLLs):
 * 
 * OOPS:
 * 1. class -> mobile
 * 2. Object -> instance
 * 3. abstraction-> DialCall(), RecieveCall()
 * 4. Encapsulation - IMEno
 * 5. Polymorphism - poly(many) morphism(forms)
 *      cameraclick();
 *      cameraclick(cameramode);
 *      cameraclick(cameramode,zoomValue)
 * 6. Inheritance
 */