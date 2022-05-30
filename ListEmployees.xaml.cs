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
using System.Windows.Shapes;

namespace DiplomaProject
{
    /// <summary>
    /// Логика взаимодействия для ListEmployees.xaml
    /// </summary>
    public partial class ListEmployees : Window
    {
        public ListEmployees()
        {
            InitializeComponent();
            
            if(EmployeesGrid.SelectedIndex != 0)
            {

            }

        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
