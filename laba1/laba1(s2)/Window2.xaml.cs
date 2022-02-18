﻿using System;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        GameLogic _GameLogic = new GameLogic();

        private void glavnaya2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            Hide();
            mw.Show();
        }

        private void PlayerButton_Click(object sender, RoutedEventArgs e)
        {
            var space = (Button)sender;
            if (!String.IsNullOrWhiteSpace(space.Content?.ToString())) return;
            space.Content = _GameLogic.CurrentPlayer;

            var coordinates = space.Tag.ToString().Split(',');
            var xValue = int.Parse(coordinates[0]);
            var yValue = int.Parse(coordinates[1]);

            var buttomPosition = new Posssition() { x = xValue, y = yValue };
            _GameLogic.UpdateBoard(buttomPosition, _GameLogic.CurrentPlayer);

            if (_GameLogic.PlayerWin())
            {
                WinScreen.Text = $"{_GameLogic.CurrentPlayer} ВЫИГРАЛ!!!";
                WinScreen.Visibility = Visibility.Visible;
            }
            _GameLogic.SetNextPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var control in gridBoard.Children) 
            {
                if (control is Button)
                {
                    ((Button)control).Content = String.Empty;
                }
            }
            _GameLogic = new GameLogic();
            WinScreen.Visibility = Visibility.Collapsed;
        }
        
    }
}
