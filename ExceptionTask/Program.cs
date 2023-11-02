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
            User user = new User();
            bool isValidInput = false;

            while (!isValidInput)
            {
                try
                {
                    Console.Write("Enter name: ");
                    user.Name = Console.ReadLine();
                    isValidInput = true; // Name is valid, exit the loop
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            isValidInput = false;

            while (!isValidInput)
            {
                try
                {
                    Console.Write("Enter age: ");
                    user.Age = byte.Parse(Console.ReadLine());
                    isValidInput = true; // Age is valid, exit the loop
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            isValidInput = false;

            while (!isValidInput)
            {
                try
                {
                    Console.Write("Enter phone number: ");
                    user.PhoneNumber = Console.ReadLine();
                    isValidInput = true; // PhoneNumber is valid, exit the loop
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            isValidInput = false;

            while (!isValidInput)
            {
                try
                {
                    Console.Write("Enter password: ");
                    user.Password = Console.ReadLine();
                    isValidInput = true; // Password is valid, exit the loop
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("User registration successful!");


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
    }
}
