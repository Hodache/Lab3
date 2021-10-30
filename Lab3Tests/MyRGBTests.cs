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
        // Перевод красного в HSV
        [TestMethod()]
        public void RBGToRed()
        {
            MyRGB RGBColor = new MyRGB(255, 0, 0);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(0, 100, 100));
        }

        // Перевод зеленого в HSV
        [TestMethod()]
        public void RBGToGreen()
        {
            MyRGB RGBColor = new MyRGB(0, 255, 0);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(120, 100, 100));
        }

        // Перевод синего в HSV
        [TestMethod()]
        public void RBGToBlue()
        {
            MyRGB RGBColor = new MyRGB(0, 0, 255);
            Assert.AreEqual(RGBColor.ToHSV(), new HSV(240, 100, 100));
        }

        // Перевод серебряного в HSV
        [TestMethod()]
        public void RBGToSilver()
        {
            MyRGB RGBColor = new MyRGB(197, 201, 199);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(150, 2, 79));
        }

        // Перевод цианового в HSV
        [TestMethod()]
        public void RBGToCyan()
        {
            MyRGB RGBColor = new MyRGB(0, 255, 255);

            Assert.AreEqual(RGBColor.ToHSV(), new HSV(180, 100, 100));
        }
    }
}