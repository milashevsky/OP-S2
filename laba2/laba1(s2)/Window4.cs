using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace laba1_s2_
{
    class Class4
    {
        TextBox read1 = new TextBox();
        TextBox read2 = new TextBox();
        TextBox read3 = new TextBox();
        Window wn = new Window();

        public Class4()
        {
            initControls();
        }


        private void initControls()
        {
            wn.Title = "Информация"; wn.Height = 400; wn.Width = 400; wn.Background = Brushes.CadetBlue;
            Grid grid = new Grid();
            grid.Width = 300; grid.Height = 200;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;

            Label About = new Label(); About.FontSize = 12; About.FontFamily = new FontFamily("Comic Sans MS");
            About.Content = "Информация\nМилашевський Микита Олегович\nГрупа КП-13, ФПМ, КПІ.";
            About.Margin = new Thickness(30, 20, 30, 100);
            grid.Children.Add(About);

            Button tomain = new Button(); tomain.FontSize = 24; tomain.FontFamily = new FontFamily("Comic Sans MS"); tomain.Content = "Назад в меню";
            tomain.Margin = new Thickness(40, 120, 40, 30);
            tomain.Click += Button_Click;
            grid.Children.Add(tomain);


            wn.Content = grid;
            wn.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nwc = new MainWindow();
            wn.Hide();
            nwc.Show();
        }
    }
}
