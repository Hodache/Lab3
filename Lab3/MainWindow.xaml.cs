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

                ColorRect.Fill = new SolidColorBrush(Color.FromRgb((byte)RGBColor.Red, (byte)RGBColor.Green, (byte)RGBColor.Blue));

                RedSlider.Value = RGBColor.Red;
                GreenSlider.Value = RGBColor.Green;
                BlueSlider.Value = RGBColor.Blue;

                HueTextBox.Text = Math.Round(HSVColor.Hue).ToString();
                SaturationTextBox.Text = Math.Round(HSVColor.Saturation).ToString();
                ValueTextBox.Text = Math.Round(HSVColor.Value).ToString();

                RedTextBox.Text = Math.Round(RGBColor.Red).ToString();
                GreenTextBox.Text = Math.Round(RGBColor.Green).ToString();
                BlueTextBox.Text = Math.Round(RGBColor.Blue).ToString();
            }
        }

        // Событие изменения значения на любом слайдере RGB
        private void RGBSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (RedSlider.IsFocused || GreenSlider.IsFocused || BlueSlider.IsFocused)
            {
                MyRGB RGBColor = new MyRGB((float)RedSlider.Value, (float)GreenSlider.Value, (float)BlueSlider.Value);
                HSV HSVColor = RGBColor.ToHSV();

                ColorRect.Fill = new SolidColorBrush(Color.FromRgb((byte)RGBColor.Red, (byte)RGBColor.Green, (byte)RGBColor.Blue));

                HueSlider.Value = HSVColor.Hue;
                SaturationSlider.Value = HSVColor.Saturation;
                ValueSlider.Value = HSVColor.Value;

                HueTextBox.Text = Math.Round(HSVColor.Hue).ToString();
                SaturationTextBox.Text = Math.Round(HSVColor.Saturation).ToString();
                ValueTextBox.Text = Math.Round(HSVColor.Value).ToString();

                RedTextBox.Text = Math.Round(RGBColor.Red).ToString();
                GreenTextBox.Text = Math.Round(RGBColor.Green).ToString();
                BlueTextBox.Text = Math.Round(RGBColor.Blue).ToString();
            }
        }

        private void HueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.IsFocused)
            {
                // Ограничение на 3 символа
                if (tb.Text.Length > 3)
                {
                    tb.Text = tb.Text.Remove(3);
                }

                // Если пусто, установить 0
                if (tb.Text == "")
                {
                    tb.Text = "0";
                }

                // Ограничение на тип вводимых символов (только числа)
                for (int i = 0; i < tb.Text.Length; i++)
                {
                    if (!char.IsDigit(tb.Text[i]))
                    {
                        tb.Text = tb.Text.Remove(i, 1);
                    }
                    tb.CaretIndex = tb.Text.Length;
                }

                // Ограничение на значение (360, 100, 255)
                    int val = Convert.ToInt32(tb.Text);

                if (tb.Name == "HueTextBox" && val > 360 ||
                    (tb.Name == "SaturationTextBox" || tb.Name == "ValueTextBox") && val > 100 ||
                    (tb.Name == "RedTextBox" || tb.Name == "GreenTextBox" || tb.Name == "BlueTextBox") && val > 255)
                {
                    tb.Text = tb.Text.Remove(tb.Text.Length - 1, 1);
                }


                // Изменение слайдеров, других полей и цвета
                HSV HSVColor;
                MyRGB RGBColor;

                if (tb.Name == "HueTextBox" || tb.Name == "SaturationTextBox" || tb.Name == "ValueTextBox")
                {
                    float hue = float.Parse(HueTextBox.Text);
                    float saturation = float.Parse(SaturationTextBox.Text);
                    float value = float.Parse(ValueTextBox.Text);

                    HSVColor = new HSV(hue, saturation, value);
                    RGBColor = HSVColor.ToRGB();

                    RedTextBox.Text = Convert.ToString(RGBColor.Red);
                    GreenTextBox.Text = Convert.ToString(RGBColor.Green);
                    BlueTextBox.Text = Convert.ToString(RGBColor.Blue);
                }
                else
                {
                    float red = float.Parse(RedTextBox.Text);
                    float green = float.Parse(GreenTextBox.Text);
                    float blue = float.Parse(BlueTextBox.Text);

                    RGBColor = new MyRGB(red, green, blue);
                    HSVColor = RGBColor.ToHSV();

                    HueTextBox.Text = Convert.ToString(HSVColor.Hue);
                    SaturationTextBox.Text = Convert.ToString(HSVColor.Saturation);
                    ValueTextBox.Text = Convert.ToString(HSVColor.Value);
                }

                HueSlider.Value = HSVColor.Hue;
                SaturationSlider.Value = HSVColor.Saturation;
                ValueSlider.Value = HSVColor.Value;

                RedSlider.Value = RGBColor.Red;
                GreenSlider.Value = RGBColor.Green;
                BlueSlider.Value = RGBColor.Blue;

                ColorRect.Fill = new SolidColorBrush(Color.FromRgb((byte)RGBColor.Red, (byte)RGBColor.Green, (byte)RGBColor.Blue));
            }
        }

    }   
}
