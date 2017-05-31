using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;
using System.ComponentModel;

namespace WpfApplication1
{
    public class TeamColorConverter : IValueConverter
    {
        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            try
            {
                var teamName = value as string;


                switch (teamName)
                {
                    case "Спартак Москва":
                        {
                            return new SolidColorBrush(Colors.Red);
                        }
                    case "Локомотив Москва":
                        {
                            return new SolidColorBrush(Colors.DarkGreen);
                        }
                    default:
                        {
                            return new SolidColorBrush(Colors.White);
                        }
                }


            }

            catch
            {
                return Colors.White;
            }
        }
        public object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
