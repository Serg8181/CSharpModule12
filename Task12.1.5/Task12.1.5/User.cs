using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12._1._5
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string log, string name,bool isPrem)
        { 
            Login = log;
            Name = name;
            IsPremium = isPrem;
        }
    }
}
