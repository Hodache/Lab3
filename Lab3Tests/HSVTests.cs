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
        public void GreenToGreen()
        {
            // Перевод зеленого в RGB
            HSV color = new HSV();
            color.Hue = 120;

            Assert.AreEqual(color.ToRGB(), new MyRGB() {Red = 0, Green = 255, Blue = 0 });
        }

        [TestMethod()]
        public void RedToRed()
        {
            // Перевод красного в RGB
            HSV color = new HSV();
            color.Hue = 0;

            Assert.AreEqual(color.ToRGB(), new MyRGB() { Red = 255, Green = 0, Blue = 0 });
        }

        [TestMethod()]
        public void BlueToBlue()
        {
            // Перевод синего в RGB
            HSV color = new HSV();
            color.Hue = 240;

            Assert.AreEqual(color.ToRGB(), new MyRGB() { Red = 0, Green = 0, Blue = 255 });
        }
    }
}