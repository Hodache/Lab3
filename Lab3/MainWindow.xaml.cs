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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HSV testHSV = new HSV(201, 60, 35);
            MyRGB testRGB = testHSV.ToRGB();

            Test.Fill = new SolidColorBrush(Color.FromRgb((byte)testRGB.Red, (byte)testRGB.Green, (byte)testRGB.Blue));
        }
    }
}
