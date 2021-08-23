using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCController
{
    public class RegexExpression
    {
        public static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Regex letter_validation()
        {
            string pattern = @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ]+$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Regex number_validation()
        {
            string pattern = @"^\d+$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Regex OnlyLettersandSpaces()
        {
            string pattern = "^[A-Za-zñÑáéíóúÁÉÍÓÚ ]+$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Regex OnlyLetterNumberssandSpaces()
        {
            string pattern = "^[0-9A-Za-zñÑáéíóúÁÉÍÓÚ ]+$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }


        public static Regex numberANDletter_validation()
        {
            string pattern = @"^\w+$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public static Regex AvoidSpaces_validation()
        {
            string pattern = @"^\S+$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
    }
}
