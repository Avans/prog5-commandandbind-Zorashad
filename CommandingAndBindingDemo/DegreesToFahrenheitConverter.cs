using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CommandingAndBindingDemo
{
    class DegreesToFahrenheitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //In deze methode converteer ik de temperatuur naar de juiste hoek voor het plaatje zodat de temp overeenkomt.
            //De waardes zijn door 'trial and error' aangepast zodat het lijtk dat de meter op de juiste temp staat
            double result = (double)value;
            return result * 1.8000f + 32;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //De convert back is onnodig. 
            return value;
        }
    }
}