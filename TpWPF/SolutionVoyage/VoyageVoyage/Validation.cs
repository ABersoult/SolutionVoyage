using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VoyageVoyage
{
    public class Validation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int notation = 0;
            try
            {
                if (((string)value).Length > 0)
                    notation = Int32.Parse((string)value);
            }
            catch(Exception ex) { return new ValidationResult(false, "Mauvais caractères" + ex.Message); }
            if ((notation < 0) ||  (notation > 5))
            {
                return new ValidationResult(false, "Entrer une valeur entre 0 et 5 compris");
            }
            return new ValidationResult(true, null);
        }
    }
}