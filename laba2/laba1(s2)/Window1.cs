using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace laba1_s2_
{
    class Class1
    {
        public List<string> num = new List<string>();
        TextBox read1 = new TextBox();
        TextBox read2 = new TextBox();
        TextBox read3 = new TextBox();
        TextBox read4 = new TextBox();
        Window wn = new Window();

        public Class1()
        {
            initControls();
        }


        private void initControls()
        {
            wn.Title = "Cчитывание информации"; wn.Height = 320; wn.Width = 470; wn.Background = Brushes.LightBlue;
            Grid grid = new Grid();
            grid.Width = 460; grid.Height = 310;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;
            RowDefinition[] rows = new RowDefinition[13];
            ColumnDefinition[] cols = new ColumnDefinition[13];
            for (int i = 0; i < 13; i++)
            {
                rows[i] = new RowDefinition();
                grid.RowDefinitions.Add(rows[i]);
                cols[i] = new ColumnDefinition();
                grid.ColumnDefinitions.Add(cols[i]);
            }

            Label studid = new Label(); studid.Content = "Студент ID:"; studid.FontSize = 10; studid.FontFamily = new FontFamily("Comic Sans MS");
            Grid.SetRow(studid, 1); Grid.SetColumn(studid, 1); Grid.SetColumnSpan(studid, 3);
            Label names = new Label(); names.Content = "Фамилия и Имя:"; names.FontSize = 10; names.FontFamily = new FontFamily("Comic Sans MS");
            Grid.SetRow(names, 3); Grid.SetColumn(names, 1); Grid.SetColumnSpan(names, 5);
            Label fac = new Label(); fac.Content = "ID:"; fac.FontSize = 10; fac.FontFamily = new FontFamily("Comic Sans MS");
            Grid.SetRow(fac, 5); Grid.SetColumn(fac, 1); Grid.SetColumnSpan(fac, 3);

            read1.FontSize = 17; read1.FontFamily = new FontFamily("Comic Sans MS");
            Grid.SetRow(read1, 1); Grid.SetColumn(read1, 6); Grid.SetColumnSpan(read1, 5);
            read2.FontSize = 17; read2.FontFamily = new FontFamily("Comic Sans MS");
            Grid.SetRow(read2, 3); Grid.SetColumn(read2, 6); Grid.SetColumnSpan(read2, 6);
            read3.FontSize = 17; read3.FontFamily = new FontFamily("Comic Sans MS");
            Grid.SetRow(read3, 5); Grid.SetColumn(read3, 6); Grid.SetColumnSpan(read3, 5);

            Button addbtn = new Button(); addbtn.FontSize = 18; addbtn.FontFamily = new FontFamily("Comic Sans MS"); addbtn.Content = "Добавить";
            addbtn.Click += new RoutedEventHandler(AddReader_Click);
            Grid.SetRow(addbtn, 9); Grid.SetColumn(addbtn, 1); Grid.SetColumnSpan(addbtn, 3); Grid.SetRowSpan(addbtn, 2);
            Button removebtn = new Button(); removebtn.FontSize = 18; removebtn.FontFamily = new FontFamily("Comic Sans MS"); removebtn.Content = "Удалить";
            removebtn.Click += new RoutedEventHandler(RemoveReader_Click);
            Grid.SetRow(removebtn, 9); Grid.SetColumn(removebtn, 5); Grid.SetColumnSpan(removebtn, 3); Grid.SetRowSpan(removebtn, 2);
            Button tomain = new Button(); tomain.FontSize = 19; tomain.FontFamily = new FontFamily("Comic Sans MS"); tomain.Content = "В меню";
            tomain.Click += new RoutedEventHandler(_2ToMain_Click);
            Grid.SetRow(tomain, 9); Grid.SetColumn(tomain, 9); Grid.SetColumnSpan(tomain, 3); Grid.SetRowSpan(tomain, 2);

            grid.Children.Add(fac); grid.Children.Add(names); grid.Children.Add(studid);
            grid.Children.Add(read1); grid.Children.Add(read2); grid.Children.Add(read3);
            grid.Children.Add(addbtn); grid.Children.Add(removebtn); grid.Children.Add(tomain);


            wn.Content = grid;
            wn.Show();
        }

        private void AddReader_Click(object sender, RoutedEventArgs e)
        {
            string text = read1.Text + " " + read2.Text + " " + read3.Text;
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\Микита\source\repos\laba1(s2)\laba1(s2)\Students.txt", true);
            writer.WriteLine(text);
            writer.Close();
            read1.Text = "";
            read2.Text = "";
            read3.Text = "";
        }

        private void RemoveReader_Click(object sender, RoutedEventArgs e)
        {
            if (read1.Text != "" && File.Exists(@"C:\Users\Микита\source\repos\laba1(s2)\laba1(s2)\Students.txt") && read1.Text.Length == 4)
            {
                string[] oldtxt = File.ReadAllLines(@"C:\Users\Микита\source\repos\laba1(s2)\laba1(s2)\Students.txt");
                var newtxt = oldtxt.Where(line => !line.Contains(read1.Text));
                File.WriteAllLines("Students.txt", newtxt);
                MessageBox.Show("Entry deleted!", "Operation succes", MessageBoxButton.OK);
                read1.Text = ""; read2.Text = ""; read3.Text = ""; read4.Text = "";
            }
            else
                MessageBox.Show("Make sure .txt file / entry exists and ID is written correctly!", "Reader error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void _2ToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nwc = new MainWindow();
            wn.Hide();
            nwc.Show();
        }  
    }
}
