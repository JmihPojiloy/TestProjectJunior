using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ClinicApp.HelperClasses
{
    public class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dob)
            {
                int age = DateTime.Now.Year - dob.Year;

                if (DateTime.Now.DayOfYear < dob.DayOfYear)
                    age = age - 1;

                return age;
            }
            throw new InvalidOperationException("Неверный формат.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
