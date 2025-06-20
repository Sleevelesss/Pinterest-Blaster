﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;
using PinterestBlaster.ViewModels;

namespace PinterestBlaster
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // This line connects your XAML UI to your MainViewModel for MVVM pattern
            this.DataContext = new MainViewModel();
        }
    }
}