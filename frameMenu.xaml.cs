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

namespace LoginISP
{
    /// <summary>
    /// Логика взаимодействия для frameMenu.xaml
    /// </summary>
    public partial class frameMenu : Page
    {
        public frameMenu()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frameMenu.Content = new Auth();
        }
    }
}
