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

namespace DiplomaProject
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

        

        private void BtnStaff_Click(object sender, RoutedEventArgs e)
        {
            ListEmployees listEmployees = new ListEmployees();
            listEmployees.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel);
            if(result == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
        }

        private void BtnAddNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.Show();
            this.Close();
        }
    }
}
