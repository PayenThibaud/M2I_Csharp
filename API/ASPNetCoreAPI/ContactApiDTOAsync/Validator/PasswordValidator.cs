﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ContactApiDTOAsync.Validator
{
    public class PasswordValidator : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var input = value?.ToString();
            ErrorMessage = string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                ErrorMessage = "Password ne doit pas être vide";
            }
            else
            {
                var hasNumber = new Regex(@"[0-9]{2,}");
                var hasUpperLetters = new Regex(@"[A-Z]{2,}");
                var hasLowerCase = new Regex(@"[a-z]{2,}");
                var hasEnoughChars = new Regex(@".{8,15}");
                var hasSymbol = new Regex(@"[.+*?!:;,^@/$(){}|]{3}");

                if (!hasNumber.IsMatch(input))
                {
                    ErrorMessage = "Il manque des chiffres";
                }
                if (!hasUpperLetters.IsMatch(input))
                {
                    ErrorMessage = "Il manque des majuscules";
                }
                if (hasLowerCase.IsMatch(input))
                {
                    ErrorMessage = "Il manque des miniscule";
                }
                if ((hasEnoughChars.IsMatch(input)))
                {
                    ErrorMessage = "On doit avoir entre 8 et 15 Characters";
                }
                if (!(hasSymbol.IsMatch(input)))
                {
                    ErrorMessage = "On doit avoir 3 symboles";
                }
            }



            return 
        }
    }
}
