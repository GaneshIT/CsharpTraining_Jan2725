using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SOLID Principles 
//Single Responsible 
//Interface segregate
//LISKOV
namespace CsharpTraining_Jan2725
{
    interface IVoiceMail
    {
        void VoiceMail(string email);
        void VoiceSms(string sms);
    }
    interface IEmail
    {
        void SendEmail(string email);
        void SendSms(string sms);
    }
    public abstract class Email
    {
        public virtual void SendEmail()
        {
            //if(server== "Google")
            //{

            //}
            //else if(server== "Yahoo")
            //{

            //}

        }

    }
    public class Fb : Email
    {
        public override void SendEmail() { }
    }
    public class Insta : Email
    {
        public override void SendEmail() { }
    }
    public class MyClass
    {
        public void Call()
        {
            //IEmail email = new Yahoo();
            //Fb fb = new Fb();
            //SendFbMail(fb);
            //Insta insta = new Insta();
            //SendInstaMail(insta);
            Email email = new Fb();
            SendMail(email);
            email = new Insta();
            SendMail(email);
        }
        public void SendMail(Email email)
        {
            email.SendEmail();//calling abstract class method
        }
        //public void SendFbMail(Fb fb)
        //{
        //    fb.SendEmail();
        //}
        //public void SendInstaMail(Insta insta)
        //{
        //    insta.SendEmail();
        //}
    }
    public class Google : IEmail, IVoiceMail
    {
        public void SendEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SendSms(string sms)
        {
            throw new NotImplementedException();
        }

        public void VoiceMail(string email)
        {
            throw new NotImplementedException();
        }

        public void VoiceSms(string sms)
        {
            throw new NotImplementedException();
        }
    }
    public class Yahoo : IEmail, IVoiceMail
    {
        public void SendEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SendSms(string sms)
        {
            throw new NotImplementedException();
        }

        public void VoiceMail(string email)
        {
            throw new NotImplementedException();
        }

        public void VoiceSms(string sms)
        {
            throw new NotImplementedException();
        }
    }
    public class Microsoft : IEmail
    {
        public void SendEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SendSms(string sms)
        {
            throw new NotImplementedException();
        }
    }
    public class SMS
    {
        public void SendSms()
        {
            Google google = new Google();
            google.SendEmail();
        }


    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public int GetEmployeeCount(List<Customer> customers)//6
        {
            return customers.Count();//6
        }
        public bool Create(Customer customer)
        {
            if (customer == null)
                return false;
            return true;
        }
    }


    //DI - Dependency Injection
    //Repository pattern
    //Singleton pattern  private constructor
    //Factory pattern creditcard- goldcard or plantinumcard

    interface IClass
    {
        void Method();
    }
    class MyProductClass:IClass
    {
        IClass iclassobj;
        public MyProductClass()
        {
        }
        public MyProductClass(IClass iclass)
        {
            iclassobj = iclass;
        }

        public void Method()
        {
            iclassobj.Method();
        }

    }
    class MyCustomerClass : IClass
    {
        IClass iclassobj;
        public MyCustomerClass() { }
        public MyCustomerClass(IClass iclass)
        {
            iclassobj = iclass;
        }
        public void Method()
        {
            iclassobj.Method();
        }
    }
    class A
    {
        public void Cal()
        {
            IClass iclass = new MyProductClass();
            IClass myclass = new MyProductClass(iclass);

            MyCustomerClass myCustomerClass = new MyCustomerClass();
            iclass = new MyProductClass(myCustomerClass);
        }
    }
    class B
    {
        A a=new A();
        public void MethodA() { }
    }
    class C
    {
        B b=new B();
        public void MethodC() { }
    }
    class D 
    {
        public void MethodD()
        {
            string input = "gold";
            //if (input == "gold")
            //    return new GoldCard;
            C c=new C(); //
        }
    }

}
