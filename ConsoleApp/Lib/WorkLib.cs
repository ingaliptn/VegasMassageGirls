using System;
using System.Linq;

namespace ConsoleApp.Lib
{
    public static class WorkLib
    {
        public static string OnlyLetter(this string str)
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
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
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

        public static string UrlName(string s)
        {
            return s;
        }

        public static string AddBr(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            str = str.Trim();
            return str.Replace("\n", "<br>");
        }

        public static string FirstPhone(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            str = str.Trim();
            var t = str.Split(",");
            return t[0].Contains("+") ? t[0] : $"+{t[0]}";
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

        public static string CentToAmount(int cent)
        {
            var s = cent.ToString();
            if (s.Length < 3) return s;
            var c = s.Substring(s.Length - 2, 2);
            var d = s.Substring(0, s.Length - 2);
            return $"${d}.{c}";
        }
    }
}
