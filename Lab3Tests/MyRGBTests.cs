using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Tests
{
    [TestClass()]
    public class MyRGBTests
    {
        [TestMethod()]
        public void RBGToRed()
        {
            // Перевод красного в HSV
            MyRGB RGBColor = new MyRGB(255, 0, 0);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(0, 100, 100));
        }

        [TestMethod()]
        public void RBGToGreen()
        {
            // Перевод зеленого в HSV
            MyRGB RGBColor = new MyRGB(0, 255, 0);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(120, 100, 100));
        }

        [TestMethod()]
        public void RBGToBlue()
        {
            // Перевод синего в HSV
            MyRGB RGBColor = new MyRGB(0, 0, 255);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(240, 100, 100));
        }

        [TestMethod()]
        public void RBGToSilver()
        {
            // Перевод серебрянного в HSV
            MyRGB RGBColor = new MyRGB(197, 201, 199);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(150, 2, 79));
        }

        [TestMethod()]
        public void RBGToCyan()
        {
            // Перевод цианового в HSV
            MyRGB RGBColor = new MyRGB(0, 255, 255);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(180, 100, 100));
        }
    }
}