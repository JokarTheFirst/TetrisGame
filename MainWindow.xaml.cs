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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TetrisGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageSource[] tileImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets/TileEmpty.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/LightBlue.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Blue.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Orange.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Yellow.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Green.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Purple.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Red.png",UriKind.Relative)),
            
        };

        private readonly ImageSource[] blockImages = new ImageSource[]
        {
           new BitmapImage(new Uri("Assets/BlockEmpty.png",UriKind.Relative)),
           new BitmapImage(new Uri("Assets/I.png",UriKind.Relative)),
           new BitmapImage(new Uri("Assets/J.png",UriKind.Relative)),
           new BitmapImage(new Uri("Assets/L.png",UriKind.Relative)),
           new BitmapImage(new Uri("Assets/O.png",UriKind.Relative)),
           new BitmapImage(new Uri("Assets/S.png",UriKind.Relative)),
           new BitmapImage(new Uri("Assets/T.png",UriKind.Relative)),
           new BitmapImage(new Uri("Assets/Z.png",UriKind.Relative)),
        };

        private readonly Image[,] imageControls;

        private GameState gameState = new GameState();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private Image[,] SetupGameCanvas(GameGrid grid)
        {
            Image[,] imageControls = new Image[grid.Rows, grid.Columns];
            int cellSize = 25;

            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++)
                {

                }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GameCanvas_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
