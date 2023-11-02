using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask.Models
{
    internal class UserReflection
    {
        int _id;
        string _name;
        static byte _age;
        static void ChangeAge(byte age)
        {
            _age = age;
        }
    }
}
