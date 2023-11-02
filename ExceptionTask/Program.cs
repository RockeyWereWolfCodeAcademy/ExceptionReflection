using ExceptionTask.Exceptions;
using ExceptionTask.Models;
using System.Formats.Asn1;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml.Linq;

namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            bool doLoop = true;
            do
            {
                try
                {
                    CreateUser();
                    doLoop = false;
                }
                catch (InvalidAgeException e)
                {
                    Console.WriteLine($"{e.Message}, try again!");
                }
                catch (InvalidNameException e)
                {
                    Console.WriteLine($"{e.Message}, try again!");
                }
                catch (InvalidPhoneFormatException e)
                {
                    Console.WriteLine($"{e.Message}, try again!");
                }
                catch (PasswordException e)
                {
                    Console.WriteLine($"{e.Message}, try again!");
                }
            } while (doLoop);
            //task 2
            //UserReflection userSecond = new UserReflection();
            //var field = typeof(UserReflection).GetField("_age",BindingFlags.Static | BindingFlags.NonPublic);
            //Console.WriteLine(field.GetValue("_age"));
            //field.SetValue("_age", (byte)1);
            //Console.WriteLine(field.GetValue("_age"));
            //var method = typeof(UserReflection).GetMethod("ChangeAge", BindingFlags.Static | BindingFlags.NonPublic);
            //method.Invoke(obj: null, parameters: new object[] { (byte)3 });
            //Console.WriteLine(field.GetValue("_age"));
        }

        static User CreateUser ()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            return new User(name, age, password, phoneNumber);
        }

        
    }
}