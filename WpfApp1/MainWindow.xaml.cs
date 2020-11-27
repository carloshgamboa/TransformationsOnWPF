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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            PaintTheGridLines();
        }
        private void PaintTheGridLines()
        {
            for (int i = 0; i < 800; i = i + 10)
            {
                MyCanvas.Children.Add(new Line() { Stroke = Brushes.LightGray, X1 = i, X2 = i + 1, Y1 = 450, Y2 = 0 });
            }
            for (int i = 0; i < 450; i = i + 10)
            {
                MyCanvas.Children.Add(new Line() { Stroke = Brushes.LightGray, Y1 = i, Y2 = i + 1, X2 = 800, X1 = 0 });
            }
        }

    }
}
