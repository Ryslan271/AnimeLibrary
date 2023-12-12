﻿using AnimeAX.Models.DataBase;
using AnimeAX.View.ForAdmin.Pages;
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
using Wpf.Ui.Controls;

namespace AnimeAX.View.Windows
{
    /// <summary>
    /// Основное окно, вывода списка
    /// </summary>
    public partial class MainWindow : UiWindow
    {
        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            Instance = this;

            MainFrame.Navigate(new ListAnime());
        }
    }
}
