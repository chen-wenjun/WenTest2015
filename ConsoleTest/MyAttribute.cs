using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class MyAttribute : Attribute
    {
        public string MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
}
