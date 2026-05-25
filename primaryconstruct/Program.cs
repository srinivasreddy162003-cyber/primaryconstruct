using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primaryconstruct
{
    class myclass
    {
         internal int a = 10;
        public void mymethod()
        {
            Console.WriteLine("value under mymethos is " + a);
        }
    }
    class newclass
    {
        public void newmethod()
        {
           myclass obj = new myclass();
            Console.WriteLine("value under newmethod is " + obj.a);
        }
    }
        

   
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass mc = new myclass();
            mc.mymethod();
            Console.WriteLine("value of a under main method " + mc.a);

            newclass nc = new newclass();
            nc.newmethod();
        }
    }
}
