using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Событие изменения значения на любом слайдере HSV
        private void HSVSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (HueSlider.IsFocused || SaturationSlider.IsFocused || ValueSlider.IsFocused)
            {
                HSV HSVColor = new HSV((float)HueSlider.Value, (float)SaturationSlider.Value, (float)ValueSlider.Value);
                MyRGB RGBColor = HSVColor.ToRGB();

                Test.Fill = new SolidColorBrush(Color.FromRgb((byte)RGBColor.Red, (byte)RGBColor.Green, (byte)RGBColor.Blue));

                RedSlider.Value = RGBColor.Red;
                GreenSlider.Value = RGBColor.Green;
                BlueSlider.Value = RGBColor.Blue;
            }
        }

        // Событие изменения значения на любом слайдере RGB
        private void RGBSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (RedSlider.IsFocused || GreenSlider.IsFocused || BlueSlider.IsFocused)
            {
                MyRGB RGBColor = new MyRGB((float)RedSlider.Value, (float)GreenSlider.Value, (float)BlueSlider.Value);
                HSV HSVColor = RGBColor.ToHSV();

                Test.Fill = new SolidColorBrush(Color.FromRgb((byte)RGBColor.Red, (byte)RGBColor.Green, (byte)RGBColor.Blue));

                HueSlider.Value = HSVColor.Hue;
                SaturationSlider.Value = HSVColor.Saturation;
                ValueSlider.Value = HSVColor.Value;
            }
        }
    }
}
