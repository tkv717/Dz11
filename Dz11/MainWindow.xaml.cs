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

namespace Dz11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            MessageBox.Show("Координата x=" + p.X.ToString() + " y=" + p.Y.ToString());
        }
        private void textBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(textBox1, textBox1.Text, DragDropEffects.Copy);
        }

        private void button1_Drop(object sender, DragEventArgs e)
        {
            button1.Content = e.Data.GetData(DataFormats.Text);
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Получение фокуса");
        }
    }
}
