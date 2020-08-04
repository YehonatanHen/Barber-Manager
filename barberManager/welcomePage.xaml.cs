﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace barberManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private DataAccess data;
        public MainWindow()
        {
            data = new DataAccess();
            InitializeComponent();
        }
        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (data.isUserExist(unameBox.Text, passwordBox.Password.ToString())) this.Content = new mainMenu(this.Content, this);
            else MessageBox.Show("Illegal Password/username");
        }
    }
}
