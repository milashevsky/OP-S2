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
            Window1 mw = new Window1();
            Hide();
            mw.Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Window2 mw = new Window2();
            Hide();
            mw.Show();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Window3 mw = new Window3();
            Hide();
            mw.Show();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Window4 mw = new Window4();
            Hide();
            mw.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
