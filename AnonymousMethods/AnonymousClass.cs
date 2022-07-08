using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{

    //define delegate
    public delegate string GreetingDelegate(string str);
    internal class AnonymousClass
    {
        public static string Greetings(string str)
        {
            return "Hello " + str + ", very good morning to you :-)";
        }

        static void Main(string[] args)
        {
            GreetingDelegate gd = new GreetingDelegate(Greetings);
            string s = gd.Invoke("Neha");

            Console.WriteLine(s+"\n\n\n");

            //or anonymous delegate
            GreetingDelegate gd1 = delegate (string name)
            {
                return "Hello " + name + ", very good morning to you :-)";
            };
            string s2 = gd1.Invoke("Pranita");
            Console.WriteLine("anonymous delegate\n"+s2 + "\n\n\n");


            Console.ReadLine();

        }
    }
}
