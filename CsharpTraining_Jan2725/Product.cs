using System;  //import java;  import java.util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//File handling


namespace CsharpTraining_Jan2725
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        private string ProductSerialNumber { get; set; }
        public void CreateProduct()
        {
            Name = "Mouse";
            Description = "Test";
            Category = "Test";
            ProductSerialNumber = "12BCA";
        }
    }
    public class Mobile
    {
        protected string ProductSerialNumber { get; set; }
    }
    public class Device : Mobile
    {
        public void CreateProduct()
        {
            Console.WriteLine(this.ProductSerialNumber);
        }
    }
    public class Samsung
    {
       public void CreateProduct() 
        { 

        }
    }
}
