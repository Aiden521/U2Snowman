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

namespace U2Snowman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int diff = 50;

            for (int i = 0; i < 3; i++)
            {

                int Width = 100 * i + diff;
                int Height = 50 * i + diff;
                myStackPanel.Children.Add(drawellipse(Width, Height));
            }

            Ellipse drawellipse(double x1, double x2)
            {
                Ellipse myellipse = new Ellipse();
                myellipse.Width = x1;
                myellipse.Height = x2;
                myellipse.Stroke = Brushes.Black;
                return myellipse;

            }

        }
    }
}
