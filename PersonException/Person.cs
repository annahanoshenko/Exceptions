using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PersonException
{
    internal class Person
    {
        private int age;
        public string Name { get; set; } = "";
        public int Age
        {
            get => age;
            set {
                if(value < 18)
                {
                    throw new Exception("You are younger 18 year");
                }
                else
                {
                  age = value;
                }
            }
        }
    }
}
