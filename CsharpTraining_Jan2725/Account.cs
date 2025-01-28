using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    //Regex
    //abstract class ->it will have abstract and non-abstract methods
    //we cannot create instance
    //abstract class can be accessed through child class only

    public interface IBank
    {
        void CreateBank();
        void CreateBranch();
    }
    public interface IBranch
    {
        void GetBranches();
    }
    public interface IATM
    {
        void CreateATMs();
    }
    public interface ITransactions : IBranch, IATM
    {
        void CreateTransacttoin();
    }
    public class Transactions : ITransactions
    {
        public void CreateATMs()
        {
            throw new NotImplementedException();
        }

        public void CreateTransacttoin()
        {
            throw new NotImplementedException();
        }

        public void GetBranches()
        {
            throw new NotImplementedException();
        }
    }
    public class IDBIBank:IBank
    {
        public void CreateBank()
        {

        }
        public void CreateBranch() 
        {

        }
    }
    
    public abstract class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string AccType { get; set; }
        public virtual void AccountTypes()
        {
            string[] types = { "Saving", "Current", "Corporate" };
            foreach (string type in types) 
            {
                Console.WriteLine(type);//saving current Corporate
            }
            //for (int i = 0; i < types.Length; i++)
            //{
            //    Console.WriteLine(types[i]);
            //}
        }
        public abstract void LoanTypes();
        
    }
    public class SBI : Account
    {
        public override void LoanTypes()
        {
            Console.WriteLine("Housing Loans");
        }
        public override void AccountTypes()
        {
            string[] types = { "Saving", "Current" };
            foreach (string type in types)
            {
                Console.WriteLine(type);//saving current Corporate
            }
        }
        public void CreateAccount()
        {

        }
        public void CreateAccuont(string accType) 
        {
        }

    }
    public class HDFC : Account
    {
        public override void LoanTypes()
        {
            Console.WriteLine("Car Loans");
        }
        public override void AccountTypes()
        {
            string[] types = { "Saving", "Current","Business" };
            foreach (string type in types)
            {
                Console.WriteLine(type);//saving current Corporate
            }
        }
    }
    public class ICICI : Account
    {
        public override void LoanTypes()
        {
            Console.WriteLine("personal loan");
        }
        public static void GetLoans()
        {
            Console.WriteLine("My Loans");
        }
        public override void AccountTypes()
        {
            string[] types = { "Saving", "Current","Business","Corporate" };
            foreach (string type in types)
            {
                Console.WriteLine(type);//saving current Corporate
            }
        }
    }
}

//Polymorphism -Function ovrriding, Function overloading
