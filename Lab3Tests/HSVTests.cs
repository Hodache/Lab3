using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Tests
{
    [TestClass()]
    public class HSVTests
    {
        [TestMethod()]
        public void HSVToGreen()
        {
            // Перевод зеленого в RGB
            HSV color = new HSV(120, 100, 100);

            Assert.AreEqual(color.ToRGB(), new MyRGB(0, 255, 0));
        }

        [TestMethod()]
        public void HSVToRed()
        {
            // Перевод красного в RGB
            HSV color = new HSV(0, 100, 100);

            Assert.AreEqual(color.ToRGB(), new MyRGB(255, 0 , 0));
        }

        [TestMethod()]
        public void HSVToBlue()
        {
            // Перевод синего в RGB
            HSV color = new HSV(240, 100, 100);

            Assert.AreEqual(color.ToRGB(), new MyRGB(0, 0, 255));
        }

        [TestMethod()]
        public void HSVToSilver()
        {
            // Перевод серебрянного в RGB
            HSV HSVColor = new HSV(150, 2, 79);

            Assert.AreEqual(HSVColor.ToRGB(), new MyRGB(197, 201, 199));
        }

        [TestMethod()]
        public void HSVToCyan()
        {
            // Перевод цианового в RGB
            HSV HSVColor = new HSV(180, 100, 100);

            Assert.AreEqual(HSVColor.ToRGB(), new MyRGB(0, 255, 255));
        }
    }
}