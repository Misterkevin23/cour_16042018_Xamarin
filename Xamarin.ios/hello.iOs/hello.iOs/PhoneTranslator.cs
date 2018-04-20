using System;
using System.Collections.Generic;
using System.Text;

namespace hello.iOs
{
   public static class PhoneTranslator
    {
        public static string ToNumber(string raw)
        {
            if (string.IsNullOrEmpty(raw))
            {
                return "";
            }
            else
            {
                raw = raw.ToUpperInvariant();
            }

            StringBuilder newNumber = new StringBuilder();
            foreach (var c in raw)
            {
                if (" -0123456789".Contains(c.ToString()))
                {
                    newNumber.Append(c);
                }
                else
                {
                    var result = TranslateToNumber(c);
                    if (result != null) newNumber.Append(result);
                   
                }
            }
            return newNumber.ToString();
        }

        private static int? TranslateToNumber(char c)
        {
            
            if ("ABC".Contains(c.ToString()))
            {
                return 2;
            }
            else if ("DEF".Contains(c.ToString()))
            {
                return 3;
            }
            else if ("GHI".Contains(c.ToString()))
            {
                return 4;
            }
            else if ("JKL".Contains(c.ToString()))
            {
                return 5;
            }
            else if ("MNO".Contains(c.ToString()))
            {
                return 6;
            }
            else return 7;
        }
    }
}
