using System;
using System.IO;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public List<string> num = new List<string>();
        private void glavnaya1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            Hide();
            mw.Show();
        }

        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string text = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text;
            num.Add(TextBox1.Text);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\Микита\OneDrive\Рабочий стол\text.txt", true);
            writer.WriteLine(text);
            writer.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
        
        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            List<string> text = new List<string>();
            using (StreamReader sr = new StreamReader(@"C:\Users\Микита\OneDrive\Рабочий стол\text.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    text.Add(line);
                }
            }

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] == TextBox1_Copy.Text)
                {
                    text.RemoveAt(i);
                }
            }

            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\Микита\OneDrive\Рабочий стол\text.txt", false);
            for (int i = 0; i < text.Count; i++)
            {
                writer.WriteLine(text[i]);
            }
            writer.Close();
            TextBox1_Copy.Text = "";
        }
    }
}
