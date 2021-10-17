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
