using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class HSV
    {
        private float hue;
        private float saturation;
        private float value;

        // Конструкторы
        public HSV()
        {
            this.hue = 0;
            this.saturation = 100;
            this.value = 100;
        }

        public HSV(float hue, float saturation, float value)
        {
            if (hue >= 0 && hue <= 360 && saturation >= 0 && saturation <= 100 && value >= 0 && value <= 100)
            {
                this.hue = hue;
                this.saturation = saturation;
                this.value = value;
            }
            else
            {
                this.hue = 0;
                this.saturation = 100;
                this.value = 100;
            }
        }

        // Методы

        // Переопределение метода Equals (для работы AreEqual в тестах)
        public override bool Equals(object obj)
        {
            bool isEqual;

            if (!(obj is HSV))
            {
                isEqual = false;
            }
            else
            {
                HSV otherRGB = obj as HSV;
                isEqual = hue == otherRGB.hue && saturation == otherRGB.saturation && value == otherRGB.value;
            }

            return isEqual;
        }

        //Перевод HSV в RGB
        public MyRGB ToRGB ()
        {
            // Вычисления необходимых величин
            int hCase = (int)Math.Floor(hue / 60) % 6;
            float valueMin = (100 - saturation) * value / 100;
            float a = (value - valueMin) * (hue % 60 / 60);
            float valueInc = valueMin + a;
            float valueDec = value - a;
            MyRGB RGBColor = new MyRGB() { Red = (float)255/100, Green = (float)255 /100, Blue = (float)255 /100 };

            // Определение параметров, в зависимости от hCase
            switch (hCase) {
                case 0:
                    RGBColor.Red *= value;
                    RGBColor.Green *= valueInc;
                    RGBColor.Blue *= valueMin;
                    break;
                case 1:
                    RGBColor.Red *= valueDec;
                    RGBColor.Green *= value;
                    RGBColor.Blue *= valueMin;
                    break;
                case 2:
                    RGBColor.Red *= valueMin;   
                    RGBColor.Green *= value;
                    RGBColor.Blue *= valueInc;
                    break;
                case 3:
                    RGBColor.Red *= valueMin;
                    RGBColor.Green *= valueDec;
                    RGBColor.Blue *= value;
                    break;
                case 4:
                    RGBColor.Red *= valueInc;
                    RGBColor.Green *= valueMin;
                    RGBColor.Blue *= value;
                    break;
                case 5:
                    RGBColor.Red *= value;
                    RGBColor.Green *= valueMin;
                    RGBColor.Blue *= valueDec;
                    break;
            }

            // Округление полученных значений
            RGBColor.Red = (float)Math.Round(RGBColor.Red);
            RGBColor.Green = (float)Math.Round(RGBColor.Green);
            RGBColor.Blue = (float)Math.Round(RGBColor.Blue);

            return RGBColor;
        }

        // get set
        public float Hue 
        {
            set
            {
                if (value < 0)
                {
                    this.hue = 360 + (value % 360);
                }
                else if (value > 360)
                {
                    this.hue = value % 360;
                }
                else
                {
                    this.hue = value;
                }
            }
            get
            {
                return this.hue;
            }
        }

        public float Saturation
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.saturation = value;
                }
            }
            get
            {
                return this.saturation;
            }
        }

        public float Value
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.value = value;
                }
            }
            get
            {
                return this.value;
            }
        }
    }
}
