using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
            {
                return true;
            }
            else
            {
                foreach (char c in input)
                {
                    if (c != ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            string result = "";
            int lenghtMix;
            if (a == null || b == null || a == string.Empty || b == string.Empty)
            {
                throw new ArgumentException();
            }
            if (a.Length < b.Length)
            {
                lenghtMix = a.Length;
                for (int i = 0; i < lenghtMix; i++)
                {
                    result += a[i];
                    result += b[i];
                }
                for (int i = lenghtMix; i < b.Length; i++)
                {
                    result += b[i];
                }
                return result;
            }
            if (a.Length > b.Length)
            {
                lenghtMix = b.Length;
                for (int i = 0; i < lenghtMix; i++)
                {
                    result += a[i];
                    result += b[i];
                }
                for (int i = lenghtMix; i < a.Length; i++)
                {
                    result += a[i];
                }
                return result;
            }
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
                result += b[i];
            }
            return result;
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            foreach (char c in a)
            {
                if (((int)c < 65 || (int)c > 90) && ((int)c < 182 || (int)c > 214))
                {
                    result += c;
                    continue;
                }
                int x = (int)c;
                x += 32;
                result += (char)x;
            }
            return result;
        }

        public static string Voyelles(string a)
        {
            string result = "";
            List<int> listVoyelle = new List<int>() { 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121 };
            foreach (char c in a)
            {
                for (int i = 0; i < listVoyelle.Count(); i++)
                {
                    if ((int)c == listVoyelle[i])
                    {
                        result += c;
                        listVoyelle.Remove((int)c);
                    }
                }
            }
            return ToLowerCase(result);
        }

        public static string Reverse(string a)
        {
            string result = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }
            return result;
        }

        public static string BazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            for (int i = 1; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                result += input[i];
                result += input[i + input.Length / 2];
            }
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            return input;
        }
    }
}