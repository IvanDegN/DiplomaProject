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
    /// Логика взаимодействия для EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCard : Window
    {
        public EmployeeCard()
        {
            InitializeComponent();
        }

        private void BtnChangeImage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnShowStaffingTable_Click(object sender, RoutedEventArgs e)
        {
            StaffingTable staffingTable = new StaffingTable();
            this.Close();
            staffingTable.Show();
        }

        private void BtnPrintEmployeeCard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            StaffingTable staffingTable = new StaffingTable();
            this.Close();
            staffingTable.Show();
        }
    }
}
