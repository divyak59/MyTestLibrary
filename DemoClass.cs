using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyTestLibrary
{
    public class DemoClass
    {
        public int AddNumber(int n1, int n2)
        {
            return n1 + n2;
        }
        public int DivideNumber(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("B cannot be zero");
            }
            return a / b;
        }
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public string Validate(int age)
        {
            if (age >= 18 && age <= 60)
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }

        }
        public bool ValidateUser(string UserId, string password)
        {
            if (string.IsNullOrWhiteSpace(UserId))
            {
                throw new ArgumentException();
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException();
            }
            if (UserId == "" && password == "")
            {
                throw new ArgumentException();

            }

            if (UserId == "dia" && password == "dia@123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
