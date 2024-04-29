using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L3
{

    public class Class2 
    {
        public void Method(Class obj) { obj.Method2(this); }
    }
    public partial class Class
    {
        public string Name;
        public static string Surname;
        public const string Asd = "asd";
        public readonly string Wasd;

        public string Hello(string name) { return name; }
        public void Method2(Class2 obj) { }
        public void Method3(ref int a, out int b) 
        {
            a = 1;
            b = a;
        }

        public Class(string name)
        {
            this.Name = name;
        }
        public Class() { }

        
    }
}
