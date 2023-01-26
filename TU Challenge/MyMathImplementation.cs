using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            if (age >= 18)
            {
                if (age > 125)
                    throw new ArgumentException(String.Format("vous ne pouvez pas avoir plus de 125 ans", age),
                                          "num");
                return true;
            }
            else if (age < 0)
                throw new ArgumentException(String.Format("vous ne pouvez pas avoir un age négatif", age),
                                     "num");
            else
                return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0) return true;
            else return false;
        }

        public static bool IsPrimary(int a)
        {
            int sqrt_int = (int)Math.Sqrt(a);
            for (int i = 2; i <= sqrt_int; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                bool result = IsPrimary(i);
                if (result == true)
                {
                    list.Add(i);
                }

            }

            return list;
        }

        public static int Power2(int a)
        {
            return (int)Math.Pow(a, 2);

        }

        public static int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);

        }

        public static int IsInOrder(int a, int b)
        {
            return 1;

        }
    }
}
