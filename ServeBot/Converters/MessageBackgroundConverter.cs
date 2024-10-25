using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ServeBot.Converters
{
    public class MessageBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Prüfen, ob der Sender "Du" oder "KI" ist und entsprechend die Farbe zurückgeben
            if (value != null && value.ToString() == "Du")
            {
                return new SolidColorBrush(Color.FromRgb(220, 248, 198)); // Grüne Farbe für deine Nachrichten
            }
            else
            {
                return new SolidColorBrush(Colors.White); // Weiße Farbe für die KI-Nachrichten
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
