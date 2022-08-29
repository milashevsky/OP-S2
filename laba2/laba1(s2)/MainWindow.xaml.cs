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

namespace laba1_s2_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Class1 w1 = new Class1();
            Hide();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Class2 w2 = new Class2();
            Hide();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Class3 w3 = new Class3();
            Hide();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Class4 w4 = new Class4();
            Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
