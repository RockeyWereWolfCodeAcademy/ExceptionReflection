using ExceptionTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionTask.Models
{
    internal class User
    {
        string _name;
        public string Name { get => _name; 
            set
            {
                if (value.Length < 2)
                    throw new InvalidNameException("Name must be at least 2 symbols at length");
                
                if (value.Length > 30) 
                    throw new InvalidNameException("Name can't be longer that 30 symbols");
                _name = value;
            }
        }
        byte _age;
        public byte Age {get => _age; 
            set
            {
                if (value <= 0)
                    throw new InvalidAgeException("Age must be bigger than 0");
                _age = value;
            }
        }
        string _phoneNumber;
        public string PhoneNumber { get => _phoneNumber; set 
            {
                Regex phoneFormat = new Regex(@"^\+994-(050)|(051)|(070)|(099)-[0-9]{3}-[0-9]{2}-[0-9]{2}$");
                if (!phoneFormat.IsMatch(value))
                    throw new InvalidPhoneFormatException("Invalid phone format");
                _phoneNumber = value;
            }
        }
        string _password;
        public string Password {get => _password; 
            set
            {
                Regex passwordFormat = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                if (!passwordFormat.IsMatch(value))
                    throw new PasswordException("Invalid password exception");
                _password = value;
            }
        }

        public User(string name, byte age, string password, string phoneNumber)
        {
            Name = name;
            Age = age;
            Password = password;
            PhoneNumber = phoneNumber;
        }

    }
}
