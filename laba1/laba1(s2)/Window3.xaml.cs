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
using System.Windows.Shapes;

namespace laba1_s2_
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void glavnaya3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            Hide();
            mw.Show();
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            calc.Text += b.Content.ToString();
        }
        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception)
            {
                calc.Text = "Error!";
            }
        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (calc.Text.Contains("+"))
            {
                iOp = calc.Text.IndexOf("+");
            }
            else if (calc.Text.Contains("-"))
            {
                iOp = calc.Text.IndexOf("-");
            }
            else if (calc.Text.Contains("*"))
            {
                iOp = calc.Text.IndexOf("*");
            }
            else if (calc.Text.Contains("/"))
            {
                iOp = calc.Text.IndexOf("/");
            }
            else if (calc.Text.Contains("%"))
            {
                iOp = calc.Text.IndexOf("%");
            }
            else
            {
                //error    
            }

            op = calc.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(calc.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(calc.Text.Substring(iOp + 1, calc.Text.Length - iOp - 1));

            if (op == "+")
            {
                calc.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                calc.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                calc.Text += "=" + (op1 * op2);
            }
            else if (op == "%")
            {
                calc.Text += "=" + (op1 % op2);
            }
            else
            {
                calc.Text += "=" + (op1 / op2);
            }
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            calc.Text = "";
        }
        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (calc.Text.Length > 0)
            {
                calc.Text = calc.Text.Substring(0, calc.Text.Length - 1);
            }
        }
    }
}
