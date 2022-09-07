using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace passwordAnalyzer
{
    public class PasswordChecker
    {
        public string password
        { get; set; }

       public  PasswordChecker(string password)
        {
            this.password = password;

        }

        public string check()
        {
            bool    hasLower=false, hasUpper=false, 
                    hasSpecial=false, hasDigit =false;
            foreach (char c in password)
            {
                hasLower = Char.IsLower(c) || hasLower;
                hasUpper = Char.IsUpper(c) || hasUpper;
                hasDigit = Char.IsDigit(c) || hasDigit;
                hasSpecial = !Char.IsLetterOrDigit(c) || hasSpecial;

            }
            switch (password.Length)
            {
                case > 8:
                    if (hasLower && hasUpper &&
                                    hasDigit && hasSpecial)
                        return "Strong";
                    else if ((hasLower || hasUpper) &&
                             hasDigit)
                        return "Moderate";
                    else
                        return "Weak";
                default:
                    return "Very weak";
            }




        }

    }
}
