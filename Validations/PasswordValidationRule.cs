using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Simple_App_WPF_MVVM.Validations
{
    public class PasswordValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex("^[A-Za-z0-9!@#$%^&]{5,10}$");

            if (!regex.IsMatch(value.ToString()))
            {
                return new ValidationResult(false, "Please enter a valid password");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
