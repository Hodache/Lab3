using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Tests
{
    [TestClass()]
    public class HSVTests
    {
        // Перевод зеленого в RGB
        [TestMethod()]
        public void HSVToGreen()
        {
            HSV color = new HSV(120, 100, 100);
            Assert.AreEqual(color.ToRGB(), new MyRGB(0, 255, 0));
        }

        // Перевод красного в RGB
        [TestMethod()]
        public void HSVToRed()
        {
            HSV color = new HSV(0, 100, 100);

            Assert.AreEqual(color.ToRGB(), new MyRGB(255, 0 , 0));
        }

        // Перевод синего в RGB
        [TestMethod()]
        public void HSVToBlue()
        {
            HSV color = new HSV(240, 100, 100);

            Assert.AreEqual(color.ToRGB(), new MyRGB(0, 0, 255));
        }

        // Перевод серебряного в RGB
        [TestMethod()]
        public void HSVToSilver()
        {
            HSV HSVColor = new HSV(150, 2, 79);

            Assert.AreEqual(HSVColor.ToRGB(), new MyRGB(197, 201, 199));
        }

        // Перевод цианового в RGB
        [TestMethod()]
        public void HSVToCyan()
        {
            HSV HSVColor = new HSV(180, 100, 100);

            Assert.AreEqual(HSVColor.ToRGB(), new MyRGB(0, 255, 255));
        }
    }
}