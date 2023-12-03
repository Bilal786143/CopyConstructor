using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Constructor 
    {
        int age;
        string name;
        public Constructor()
        {
            Console.WriteLine("This is default Constructor");
        }
        public Constructor(int age,string name)
        {
            this.age = age;
            this.name = name;
        }

        public Constructor(Constructor c)
        {
            this.age = c.age;
            this.name = c.name;
        }


        public void showresult()
        {
            Console.WriteLine("The age is: {0} and name is : {1}",this.age,this.name);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Constructor c = new Constructor(24,"Bilal");
            c.showresult();
            Constructor n = new Constructor(c);
            n.showresult();
            
            Console.ReadLine();
        }
    }
}
