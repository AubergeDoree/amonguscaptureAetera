using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using AmongUsCapture;

namespace AUCapture_WPF.Converters
{
    public class PlayerColorToBrush : IValueConverter
    {
        private static readonly Dictionary<PlayerColor, SolidColorBrush> BrushMapping = new() {
            { PlayerColor.Red,          new SolidColorBrush(Color.FromRgb(197, 17, 17))},
            { PlayerColor.Blue,         new SolidColorBrush(Color.FromRgb(19, 46, 209))},
            { PlayerColor.Green,        new SolidColorBrush(Color.FromRgb(17, 127, 45))},
            { PlayerColor.Pink,         new SolidColorBrush(Color.FromRgb(237, 84, 186))},
            { PlayerColor.Orange,       new SolidColorBrush(Color.FromRgb(239, 125, 13))},
            { PlayerColor.Yellow,       new SolidColorBrush(Color.FromRgb(245, 245, 87))},
            { PlayerColor.Black,        new SolidColorBrush(Color.FromRgb(63, 71, 78))},
            { PlayerColor.White,        new SolidColorBrush(Color.FromRgb(214, 224, 240))},
            { PlayerColor.Purple,       new SolidColorBrush(Color.FromRgb(107, 47, 187))},
            { PlayerColor.Brown,        new SolidColorBrush(Color.FromRgb(113, 73, 30))},
            { PlayerColor.Cyan,         new SolidColorBrush(Color.FromRgb(56, 254, 220))},
            { PlayerColor.Lime,         new SolidColorBrush(Color.FromRgb(80, 239, 57))},
            { PlayerColor.Maroon,       new SolidColorBrush(Color.FromRgb(95, 29, 46))},
            { PlayerColor.Rose,         new SolidColorBrush(Color.FromRgb(236, 192, 211))},
            { PlayerColor.Banana,       new SolidColorBrush(Color.FromRgb(240, 231, 168))},
            { PlayerColor.Gray,         new SolidColorBrush(Color.FromRgb(117, 133, 147))},
            { PlayerColor.Tan,          new SolidColorBrush(Color.FromRgb(145, 136, 119))},
            { PlayerColor.Coral,        new SolidColorBrush(Color.FromRgb(215, 100, 100))},
            { PlayerColor.Tamarind,     new SolidColorBrush(Color.FromRgb( 48,  28,  34))},
            { PlayerColor.Army,         new SolidColorBrush(Color.FromRgb( 39,  45,  31))},
            { PlayerColor.Olive,        new SolidColorBrush(Color.FromRgb(154, 140,  61))},
            { PlayerColor.Turquoise,    new SolidColorBrush(Color.FromRgb( 22, 132, 176))},
            { PlayerColor.Mint,         new SolidColorBrush(Color.FromRgb(111, 192, 156))},
            { PlayerColor.Lavender,     new SolidColorBrush(Color.FromRgb(173, 126, 201))},
            { PlayerColor.Nougat,       new SolidColorBrush(Color.FromRgb(160, 101,  56))},
            { PlayerColor.Peach,        new SolidColorBrush(Color.FromRgb(255, 164, 119))},
            { PlayerColor.Wasabi,       new SolidColorBrush(Color.FromRgb(112, 143,  46))},
            { PlayerColor.HotPink,      new SolidColorBrush(Color.FromRgb(255,  51, 102))},
            { PlayerColor.Petrol,       new SolidColorBrush(Color.FromRgb(  0,  99, 105))},
            { PlayerColor.Lemon,        new SolidColorBrush(Color.FromRgb(219, 253,  47))},
            { PlayerColor.SignalOrange, new SolidColorBrush(Color.FromRgb(247,  68,  23))},
            { PlayerColor.Teal,         new SolidColorBrush(Color.FromRgb( 37, 184, 191))},
            { PlayerColor.Blurple,      new SolidColorBrush(Color.FromRgb( 61,  44, 142))},
            { PlayerColor.Sunrise,      new SolidColorBrush(Color.FromRgb(255, 202,  25))},
            { PlayerColor.Ice,          new SolidColorBrush(Color.FromRgb( 25, 223, 255))},
            { PlayerColor.Fuchsia,      new SolidColorBrush(Color.FromRgb(164,  17, 129))},
            { PlayerColor.RoyalGreen,   new SolidColorBrush(Color.FromRgb(  9,  82,  33))},
            { PlayerColor.Slime,        new SolidColorBrush(Color.FromRgb(244, 255, 188))},
            { PlayerColor.Navy,         new SolidColorBrush(Color.FromRgb(  9,  43, 119))},
            { PlayerColor.Darkness,     new SolidColorBrush(Color.FromRgb( 36,  39,  40))},
            { PlayerColor.Ocean,        new SolidColorBrush(Color.FromRgb( 55, 159, 218))},
            { PlayerColor.Sundown,      new SolidColorBrush(Color.FromRgb(252, 194, 100))},
            { PlayerColor.Unknown, null}

        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
             var color = value as PlayerColor? ?? PlayerColor.Red;
             return BrushMapping[color];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class PlayerColorToBrushShaded : IValueConverter
    {
        public static Color shadeColor(Color inColor, float percent) {
            
            float R = (inColor.R * (100 + percent)) / 100;
            float G = (inColor.G * (100 + percent)) / 100;
            float B = (inColor.B * (100 + percent)) / 100;
            R = R < 255 ? R : 255;
            G = G < 255 ? G : 255;
            B = B < 255 ? B : 255;
            return Color.FromArgb(255, (byte) R, (byte) G, (byte) B);
        }

        private static readonly Dictionary<PlayerColor, SolidColorBrush> BrushMapping = new() {
            { PlayerColor.Red,     new SolidColorBrush(Color.FromRgb(197, 17, 17))},
            { PlayerColor.Blue,    new SolidColorBrush(Color.FromRgb(19, 46, 209))},
            { PlayerColor.Green,   new SolidColorBrush(Color.FromRgb(17, 127, 45))},
            { PlayerColor.Pink,    new SolidColorBrush(Color.FromRgb(237, 84, 186))},
            { PlayerColor.Orange,  new SolidColorBrush(Color.FromRgb(239, 125, 13))},
            { PlayerColor.Yellow,  new SolidColorBrush(Color.FromRgb(245, 245, 87))},
            { PlayerColor.Black,   new SolidColorBrush(Color.FromRgb(63, 71, 78))},
            { PlayerColor.White,   new SolidColorBrush(Color.FromRgb(214, 224, 240))},
            { PlayerColor.Purple,  new SolidColorBrush(Color.FromRgb(107, 47, 187))},
            { PlayerColor.Brown,   new SolidColorBrush(Color.FromRgb(113, 73, 30))},
            { PlayerColor.Cyan,    new SolidColorBrush(Color.FromRgb(56, 254, 220))},
            { PlayerColor.Lime,    new SolidColorBrush(Color.FromRgb(80, 239, 57))},
            { PlayerColor.Maroon,  new SolidColorBrush(Color.FromRgb(95, 29, 46))},
            { PlayerColor.Rose,    new SolidColorBrush(Color.FromRgb(236, 192, 211))},
            { PlayerColor.Banana,  new SolidColorBrush(Color.FromRgb(240, 231, 168))},
            { PlayerColor.Gray,    new SolidColorBrush(Color.FromRgb(117, 133, 147))},
            { PlayerColor.Tan,     new SolidColorBrush(Color.FromRgb(145, 136, 119))},
            { PlayerColor.Coral,   new SolidColorBrush(Color.FromRgb(215, 100, 100))},
            // BetterOtherRole Color
            { PlayerColor.Tamarind,   new SolidColorBrush(Color.FromRgb( 48,  28,  34))},
            { PlayerColor.Army,       new SolidColorBrush(Color.FromRgb( 39,  45,  31))},
            { PlayerColor.Olive,      new SolidColorBrush(Color.FromRgb(154, 140,  61))},
            { PlayerColor.Turquoise,  new SolidColorBrush(Color.FromRgb( 22, 132, 176))},
            { PlayerColor.Mint,       new SolidColorBrush(Color.FromRgb(111, 192, 156))},
            { PlayerColor.Lavender,   new SolidColorBrush(Color.FromRgb(173, 126, 201))},
            { PlayerColor.Nougat,     new SolidColorBrush(Color.FromRgb(160, 101,  56))},
            { PlayerColor.Peach,     new SolidColorBrush(Color.FromRgb(255, 164, 119))},
            { PlayerColor.Wasabi,     new SolidColorBrush(Color.FromRgb(112, 143,  46))},
            { PlayerColor.HotPink,    new SolidColorBrush(Color.FromRgb(255,  51, 102))},
            { PlayerColor.Petrol,     new SolidColorBrush(Color.FromRgb(  0,  99, 105))},
            { PlayerColor.Lemon,      new SolidColorBrush(Color.FromRgb(219, 253,  47))},
            { PlayerColor.SignalOrange,      new SolidColorBrush(Color.FromRgb(247,  68,  23))},
            { PlayerColor.Teal,       new SolidColorBrush(Color.FromRgb( 37, 184, 191))},
            { PlayerColor.Blurple,    new SolidColorBrush(Color.FromRgb( 61,  44, 142))},
            { PlayerColor.Sunrise,    new SolidColorBrush(Color.FromRgb(255, 202,  25))},
            { PlayerColor.Ice,        new SolidColorBrush(Color.FromRgb( 25, 223, 255))},
            { PlayerColor.Fuchsia,    new SolidColorBrush(Color.FromRgb(164,  17, 129))},
            { PlayerColor.RoyalGreen, new SolidColorBrush(Color.FromRgb(  9,  82,  33))},
            { PlayerColor.Slime,      new SolidColorBrush(Color.FromRgb(244, 255, 188))},
            { PlayerColor.Navy,       new SolidColorBrush(Color.FromRgb(  9,  43, 119))},
            { PlayerColor.Darkness,   new SolidColorBrush(Color.FromRgb( 36,  39,  40))},
            { PlayerColor.Ocean,      new SolidColorBrush(Color.FromRgb( 55, 159, 218))},
            { PlayerColor.Sundown,    new SolidColorBrush(Color.FromRgb(252, 194, 100))}

        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value as PlayerColor? ?? PlayerColor.Red;
            var mainColor = BrushMapping[color];
            var shaded = shadeColor(mainColor.Color, -20f);
            return new SolidColorBrush(shaded);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
