using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordValidation
{
    public class Pass
    {
        public static int Valid(string pass)
        {
            if (string.IsNullOrEmpty(pass))
                return 0;

            int mark = 0;

            if (pass.Any(char.IsDigit)) mark++;
            if (pass.Any(char.IsLower)) mark++;
            if (pass.Any(char.IsUpper)) mark++;
            if (Regex.IsMatch(pass, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]")) mark++;
            if (pass.Length > 10) mark++;

            return mark;
        }
    }
}
