using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagerBuildApp
{
    public static class InputValidator
    {
        public static bool ValidatePhone(string phone, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrEmpty(phone))
            {
                errorMessage = "Телефон не может быть пустым!";
                return false;
            }
            if (!Regex.IsMatch(phone, @"^\+?\d+$"))
            {
                errorMessage = "Телефон содержит недопустимые символы!";
                return false;
            }
            return true;
        }

        public static bool ValidateName(string name, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                errorMessage = "Имя не может быть пустым!";
                return false;
            }
            return true;
        }
    }

}
