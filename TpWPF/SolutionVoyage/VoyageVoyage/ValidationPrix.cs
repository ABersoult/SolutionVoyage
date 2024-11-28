using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VoyageVoyage
{
    internal class ValidationPrix : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double prix = 0.00;
            try
            {
                if (((string)value).Length > 0)
                    prix = Int32.Parse((string)value);
            }
            catch (Exception ex) { return new ValidationResult(false, "Mauvais caractères" + ex.Message); }
            if (prix < 0)
                return new ValidationResult(false, "Entrer une valeur positive");
            return new ValidationResult(true, null);
        }
    }
}
