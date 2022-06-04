using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для ManageCertification.xaml
    /// </summary>
    public partial class ManageCertification : Window
    {
        ObservableCollection<Certification> ListCertification = new ObservableCollection<Certification>();
        ObservableCollection<CertificationDocument> ListCertificationDoc = new ObservableCollection<CertificationDocument>();

        public ManageCertification()
        {
            InitializeComponent();
            DB.db.Certification.Load();
            DB.db.CertificationDocument.Load();
            GridCertificationDocument.IsReadOnly = true;
            GridCertification.IsReadOnly = true;
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Certification certification = GridCertification.SelectedItem as Certification;
            CertificationDocument certificationDocument = GridCertificationDocument.SelectedItem as CertificationDocument;

            if(certificationDocument != null && GridCertificationDocument.Columns != null)
            {
                if(GridCertificationDocument.CurrentCell != null)
                {
                    var result = MessageBox.Show($"Удалить документ номер: {certificationDocument.Number}?", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
                    if(result == MessageBoxResult.OK)
                    {
                        ListCertificationDoc.Remove(certificationDocument);
                        DB.db.CertificationDocument.Remove(certificationDocument);


                        try
                        {
                            
                            DB.db.SaveChanges();
                            
                        }
                        catch 
                        {
                            MessageBox.Show("Документ успешно удалён", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                            //RefreshDoc();
                        }


                    }
                }
            }

            if(GridCertification.Columns != null && certification != null)
            {
                ListCertification.Remove(certification);
                DB.db.Certification.Remove(certification);

                try
                {
                    DB.db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Сначала необходимо удалить документ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                    RefreshCertification();
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddCertification();
            }
            catch
            {
                Validate();
            }

            try
            {
                AddCertificationDoc();
            }
            catch
            {
                Validate();
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveCertification();
            SaveCertificationDoc();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            GridEdit();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            EmployeeCard employeeCard = new EmployeeCard();
            employeeCard.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCertification();
            LoadCertificationDoc();
        }

        private void LoadCertification()
        {
            var certification = DB.db.Certification;
            var q = from item in certification select item;
            foreach(Certification item in q)
            {
                ListCertification.Add(item);
            }
            GridCertification.ItemsSource = ListCertification;
        }

        private void LoadCertificationDoc()
        {
            var doc = DB.db.CertificationDocument;
            var q = from item in doc select item;
            foreach(CertificationDocument item in q)
            {
                ListCertificationDoc.Add(item);
            }
            GridCertificationDocument.ItemsSource = ListCertificationDoc;
        }

        private void RefreshDoc()
        {
            var doc = DB.db.CertificationDocument;
            var q = from item in doc select item;
            foreach(CertificationDocument item in q)
            {
                ListCertificationDoc.Add(item);
            }
            GridCertificationDocument.ItemsSource = ListCertificationDoc;
            GridCertificationDocument.Items.Refresh();
        }

        private void RefreshCertification()
        {
            var certification = DB.db.Certification;
            var q = from item in certification select item;
            foreach(Certification item in q)
            {
                ListCertification.Add(item);
            }
            GridCertification.ItemsSource = ListCertification;
            GridCertification.Items.Refresh();
        }

        private void ClearLists()
        {
            ListCertification.Clear();
            ListCertificationDoc.Clear();
        }

        private void AddCertification()
        {
            Certification certification = new Certification();
            certification.Result = TbResultCommission.Text;
            if(DpDateCertification.SelectedDate == null)
            {
                DpDateCertification.SelectedDate = DateTime.Now;
            }
            certification.Date = (DateTime)DpDateCertification.SelectedDate;
            certification.Footing = TbFooting.Text;
            DB.db.Certification.Add(certification);
            ListCertification.Add(certification);
        }

        private void AddCertificationDoc()
        {
            CertificationDocument certificationDocument = new CertificationDocument();
            certificationDocument.Number = int.Parse( TbDocumentNumber.Text);
            if (DpCertificationGetDate.SelectedDate == null)
            {
                DpCertificationGetDate.SelectedDate = DateTime.Now;
            }
            certificationDocument.Date = (DateTime)DpCertificationGetDate.SelectedDate;
            DB.db.CertificationDocument.Add(certificationDocument);
            ListCertificationDoc.Add(certificationDocument);
        }

        private void SaveCertification()
        {
            GridCertification.CanUserAddRows = false;
            try
            {
                if(GridCertification.Items.Count > 0)
                {
                    DB.db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                }
                else
                {
                    MessageBox.Show("Добавьте данные", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                }

            }
            catch 
            {
                MessageBox.Show("Добавление данных осуществляется по одной записи", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
        }

        private void SaveCertificationDoc()
        {
            GridCertificationDocument.CanUserAddRows = false;
            try
            {
                if(GridCertificationDocument.Items.Count > 0)
                {
                    DB.db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                }
                else
                {
                    MessageBox.Show("Добавьте данные", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                }
            }
            catch 
            {
                MessageBox.Show("Добавление данных осуществляется по одной записи", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
        }

        private void GridEdit()
        {
            if(GridCertificationDocument.SelectedIndex >= 0 || GridCertification.SelectedIndex >= 0)
            {
                GridCertification.IsReadOnly = false;
                GridCertificationDocument.IsReadOnly = false;
                GridCertification.BeginEdit();
                GridCertificationDocument.BeginEdit();
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }
        }

        private void GridCertification_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GridCertificationDocument_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Validate()
        {
            if(DpCertificationGetDate.SelectedDate == null)
            {
                DpCertificationGetDate.SelectedDate = DateTime.Now;
            }

            if(DpDateCertification.SelectedDate == null)
            {
                DpDateCertification.SelectedDate = DateTime.Now;
            }

            if(String.IsNullOrEmpty(TbDocumentNumber.Text) || String.IsNullOrWhiteSpace(TbDocumentNumber.Text))
            {
                ClearLists();
                MessageBox.Show("Заполните поле Номер документа", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            if(String.IsNullOrEmpty(TbFooting.Text) || String.IsNullOrWhiteSpace(TbFooting.Text))
            {
                ClearLists();
                MessageBox.Show("Заполните поле Основание", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            if(String.IsNullOrEmpty(TbResultCommission.Text) || String.IsNullOrWhiteSpace(TbResultCommission.Text))
            {
                ClearLists();
                MessageBox.Show("Заполните поле Решение комисии", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }
        }

        bool CheckNumbers(string numbers)
        {
            Regex regex = new Regex("[1234567890]");
            return regex.IsMatch(numbers);
        }

        private void TbDocumentNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TbDocumentNumber_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TbDocumentNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}
