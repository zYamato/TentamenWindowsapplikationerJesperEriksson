using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Methods
    {
        public static bool validateSSN(string personNum)
        {
            Regex ssnMatcher = new Regex(@"^(\d{2}){0,1}(\d{2})(\d{2})(\d{2})([-|+]{0,1})?(\d{3})(\d{0,1})$");
            if (!ssnMatcher.IsMatch(personNum))
            {
                return false;
            }
            return true;
        }
        public static bool ValidateName(string name)
        {
            Regex nameMatcher = new Regex("^[A-Z][a-zA-Z]*$");
            if (!nameMatcher.IsMatch(name))
            {
                return false;
            }
            return true;
        }
        public static bool ValidateLastName(string LastName)
        {
            Regex lastnameMatcher = new Regex("^[A-Z][a-zA-Z]*$");
            if(!lastnameMatcher.IsMatch(LastName))
            {
                return false;
            }
            return true;
        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            Regex phoneNumberMatcher = new Regex(@"^(([+]46)\s(7)|07)[02369]\s*(\d{4})\s*(\d{3})$");
            if (!phoneNumberMatcher.IsMatch(phoneNumber))
            {
                return false;
            }
            return true;
        }
        public static int CheckWhatMovie(string movie)
        {
            if (movie == "Alien")
            {
                return 3;
            }
            else if (movie == "The Exorcist")
            {
                return 10;
            }
            else if (movie == "A Cure For Wellness")
            {
                return 7;
            }
            else if (movie == "The Conjuring")
            {
                return 9;
            }
            else if (movie == "IT")
            {
                return 5;
            }
            else if (movie == "IT Chapter 2")
            {
                return 6;
            }
            else if (movie == "Psycho")
            {
                return 4;
            }
            else if (movie == "The Shining")
            {
                return 1;
            }
            else if (movie == "The Thing")
            {
                return 2;
            }
            else if (movie == "Us")
            {
                return 8;
            }
            return 0;
        }

    }
}
