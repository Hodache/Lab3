using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class MyRGB
    {
        private float red;
        private float green;
        private float blue;

        // Конструкторы
        public MyRGB()
        {
            this.red = 0;
            this.green = 0;
            this.blue = 0;
        }

        public MyRGB(float red, float green, float blue)
        {
            if (red >= 0 && red <= 255 && green >= 0 && green <= 255 && blue >= 0 && blue <= 255)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
            else
            {
                this.red = 0;
                this.green = 0;
                this.blue = 0;
            }
        }

        // Методы

        // Переопределение метода Equals (для работы AreEqual в тестах)
        public override bool Equals(Object obj)
        {
            bool isEqual;

            if (!(obj is MyRGB))
            {
                isEqual = false;
            }
            else
            {
                MyRGB otherRGB = obj as MyRGB;
                isEqual = red == otherRGB.red && green == otherRGB.green && blue == otherRGB.blue;
            }

            return isEqual;
        }

        //Перевод из RGB в HSV
        public HSV ToHSV()
        {
            HSV HSVColor = new HSV();

            float r = red / 255;
            float g = green / 255;
            float b = blue / 255;
            float RGBMax = 0;
            float RGBMin = 0;
            float difference = 0;

            // Находим максимальное и минимальное значения RGB
            if (r >= g && r >= b)
            {
                RGBMax = r;
                RGBMin = g <= b ? g : b;
            }
            else if (g >= r && g >= b)
            {
                RGBMax = g;
                RGBMin = r <= b ? r : b;
            }
            else if (b >= r && b >= g)
            {
                RGBMax = b;
                RGBMin = r <= g ? r : g;
            }

            // Присваеваем значение Hue
            if (RGBMax != RGBMin)
            {
                difference = RGBMax - RGBMin;

                if (RGBMax == r)
                {
                    HSVColor.Hue = 60 * ((g - b) / difference % 6);
                }
                else if (RGBMax == g)
                {
                    HSVColor.Hue = 60 * ((b - r) / difference + 2);
                }
                else if (RGBMax == b)
                {
                    HSVColor.Hue = 60 * ((r - g) / difference + 4);
                }
            }
            else
            {
                HSVColor.Hue = 0;
            }

            // Присваеваем значение Saturation
            if (RGBMax == 0)
            {
                HSVColor.Saturation = 0;
            }
            else
            {
                HSVColor.Saturation = difference / RGBMax * 100;
            }

            // Значение Value
            HSVColor.Value = RGBMax * 100;

            HSVColor.Hue = (float)Math.Round(HSVColor.Hue);
            HSVColor.Saturation = (float)Math.Round(HSVColor.Saturation);
            HSVColor.Value = (float)Math.Round(HSVColor.Value);

            return HSVColor;
        }


        // get set
        public float Red
        {
            set
            {
                if (value >= 0 && value <= 255)
                {
                    this.red = value;
                }
            }
            get
            {
                return this.red;
            }
        }

        public float Green
        {
            set
            {
                if (value >= 0 && value <= 255)
                {
                    this.green = value;
                }
            }
            get
            {
                return this.green;
            }
        }

        public float Blue
        {
            set
            {
                if (value >= 0 && value <= 255)
                {
                    this.blue = value;
                }
            }
            get
            {
                return this.blue;
            }
        }
    }
}
