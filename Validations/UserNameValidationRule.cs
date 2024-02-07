using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Simple_App_WPF_MVVM.Validations
{
    public class UserNameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex("^[A-Za-z0-9!@#$%^&]{2,25}$");

            string? input = value.ToString();

            if (!regex.IsMatch(input))
            {
                if (input.Length < 2 || input.Length > 25)
                {
                    return new ValidationResult(false, "Username have atleast 2 and maximum 25 character");
                }
                return new ValidationResult(false, "Please enter a valid username");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
