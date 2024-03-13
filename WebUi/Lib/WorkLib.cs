using System;
using System.Linq;

namespace WebUi.Lib
{
    public static class WorkLib
    {
        private static string OnlyLetter(this string str)
        {
            return string.IsNullOrEmpty(str) ? string.Empty : new string(str.Where(char.IsLetter).ToArray());
        }

        public static string OnlyGoodSymbols(this string str)
        {
            return str.Replace("'", "").Replace("&", "").Replace("-", "");
        }

        public static string OnlyNumber(this string str)
        {
            return string.IsNullOrEmpty(str) ? "0" : new string(str.Where(char.IsNumber).ToArray());
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var em = new System.Net.Mail.MailAddress(email);
                return em.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string ShortName(string s, int n)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            s = s.Replace("&", " ");
            var b = s.Split();
            var t = string.Empty;
            var old = string.Empty;
            foreach (var p in b)
            {
                t += $"{OnlyLetter(p)} ";
                if (t.Length > n) break;
                old = t;
            }
            return old;
        }

        public static string ShortName1(string s, int n)
        {
            return s.Length < n ? s :
                $"{s.Substring(0, n)}...";
        }

        public static string GetRandomNumber(int min, int max)
        {
            var getRandom = new Random();
            lock (getRandom) // synchronize
            {
                var n = getRandom.Next(min, max);
                if (n > 9) return n.ToString();
                return $"0{n}";
            }
        }

        public static string AddBr(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            str = str.Trim();
            return str.Replace("\n", "<br>");
        }

        public static string RemoveSpaces(this string str)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Replace(" ", string.Empty);
        }

        public static decimal StringToDecimal(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            s = s.Replace(",", ".")
                .Replace("$", string.Empty).Trim();
            if (string.IsNullOrEmpty(s)) return 0;
            try
            {
                return Convert.ToDecimal(s, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
