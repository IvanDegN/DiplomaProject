using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    /// Логика взаимодействия для ManageBenefits.xaml
    /// </summary>
    public partial class ManageBenefits : Window
    {

        ObservableCollection<Benefits> ListBenefits = new ObservableCollection<Benefits>();
        ObservableCollection<BenefitDocument> ListDocument = new ObservableCollection<BenefitDocument>();
        ObservableCollection<BenefitsFooting> ListFootings = new ObservableCollection<BenefitsFooting>();
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             
            LoadBenefits();
            LoadDocument();
            LoadFooting();

        }


        private void LoadBenefits()
        {
            var benefits = DB.db.Benefits;
            foreach (Benefits item in benefits)
            {
                ListBenefits.Add(item);
            }
            GridBenefits.ItemsSource = ListBenefits;


        }

        private void LoadDocument()
        {
            var document = DB.db.BenefitDocument;
            var q = from item in document select item;
            foreach (BenefitDocument item in q)
            {
                ListDocument.Add(item);
            }
            GridDocuments.ItemsSource = ListDocument;
        }

        private void LoadFooting()
        {
            var footing = DB.db.BenefitsFooting;
            var q = from item in footing select item;
            foreach (BenefitsFooting item in q)
            {
                ListFootings.Add(item);
            }
            GridFooting.ItemsSource = ListFootings;
        }



        public ManageBenefits()
        {
            InitializeComponent();
            DB.db.Benefits.Load();
            DB.db.BenefitsFooting.Load();
            DB.db.BenefitDocument.Load();
            GridBenefits.IsReadOnly = true;
            GridDocuments.IsReadOnly = true;
            GridFooting.IsReadOnly = true;

            
            
            

        }

        private void Validate()
        {
            

            if (DpReleaseDate.SelectedDate == null)
            {
                
                DpReleaseDate.SelectedDate = DateTime.Now;
            }

            


            if(String.IsNullOrEmpty(TbBenefitsFooting.Text) || String.IsNullOrWhiteSpace(TbBenefitsFooting.Text))
            {
                
                ClearLists();
                MessageBox.Show("Заполните поле Основание для выдачи", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            if(String.IsNullOrWhiteSpace(TbTitle.Text) || String.IsNullOrEmpty(TbTitle.Text))
            {
                
                ClearLists();
                MessageBox.Show("Заполните поле Льгота", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            if(String.IsNullOrEmpty(TbNumber.Text) || String.IsNullOrWhiteSpace(TbNumber.Text))
            {
                
                ClearLists();
                MessageBox.Show("Заполните поле Номер документа", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            
            
        }


        private void ClearLists()
        {
            ListBenefits.Clear();
            ListDocument.Clear();
            ListFootings.Clear();
        }


        private void RefreshBenefits()
        {

            var benefits = DB.db.Benefits;
            var query = from item in benefits
                        select item;
            foreach (Benefits ben in query)
            {
                ListBenefits.Add(ben);
            }
            GridBenefits.ItemsSource = ListBenefits;
            
            GridBenefits.Items.Refresh();

        }

        private void RefreshDocument()
        {
            var document = DB.db.BenefitDocument;
            var query = from item in document select item;
            foreach(BenefitDocument item in query)
            {
                ListDocument.Add(item);
            }
            GridDocuments.ItemsSource = ListDocument;
            
            
            GridDocuments.Items.Refresh();
        }

        private void RefreshFooting()
        {
            var footing = DB.db.BenefitsFooting;
            var query = from item in footing select item;
            foreach(BenefitsFooting item in query)
            {
                ListFootings.Add(item);
            }
            GridFooting.ItemsSource = ListFootings;
            
            GridFooting.Items.Refresh();    
        }


       

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {



            

            Benefits benefits = GridBenefits.SelectedItem as Benefits;
            BenefitDocument benefitDocument = GridDocuments.SelectedItem as BenefitDocument;
            BenefitsFooting benefitsFooting = GridFooting.SelectedItem as BenefitsFooting;
           

            var index = GridBenefits.SelectedCells.ToString();
            

            

            if(benefits != null && GridBenefits.Columns != null && index != null )
            {
                if (GridBenefits.CurrentCell != null)
                {

                    var result = MessageBox.Show($"Удалить льготу: {benefits.Title}?", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
                    if (result == MessageBoxResult.OK)
                    {
                        ListBenefits.Remove(benefits);
                        DB.db.Benefits.Remove(benefits);
                        DB.db.SaveChanges();
                        //RefreshBenefits();   
                    }
                }
                
            }
            

            if(GridDocuments.Columns != null && benefitDocument != null)
            {
                ListDocument.Remove(benefitDocument);
                DB.db.BenefitDocument.Remove(benefitDocument);


                try
                {
                    DB.db.SaveChanges();
                }
                catch
                {
                    
                    MessageBox.Show("Сначала необходимо удалить льготу", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                    RefreshDocument();

                }

               
                
                
            }
            

            if(GridFooting.Columns != null && benefitsFooting != null)
            {
                ListFootings.Remove(benefitsFooting);
                DB.db.BenefitsFooting.Remove(benefitsFooting);
                try
                {
                    DB.db.SaveChanges();
                    
                }
                catch
                {
                    
                    MessageBox.Show("Сначала необходимо удалить льготу", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                    RefreshFooting();

                }
            }
           


        }

        private void DbRemove()
        {
            Benefits benefits = new Benefits();
            BenefitDocument benefitDocument = new BenefitDocument();
            BenefitsFooting footing = new BenefitsFooting();

            DB.db.Benefits.Remove(benefits);
            DB.db.BenefitDocument.Remove(benefitDocument);
            DB.db.BenefitsFooting.Remove(footing);
        }

        private void AddBenefits()
        {
            Benefits benefits = new Benefits();
            benefits.Title = TbTitle.Text;


            DB.db.Benefits.Add(benefits);
            ListBenefits.Add(benefits);

        }

        private void AddDocument()
        {
            BenefitDocument benefitDocument = new BenefitDocument();
            benefitDocument.Number = int.Parse(TbNumber.Text);
            

            if (DpReleaseDate.SelectedDate == null)
            {
               
                DpReleaseDate.SelectedDate = DateTime.Now;
            }

            benefitDocument.ReleaseDate = (DateTime)DpReleaseDate.SelectedDate;

            DB.db.BenefitDocument.Add(benefitDocument);
            ListDocument.Add(benefitDocument);

        }

        private void AddFooting()
        {
            BenefitsFooting footing = new BenefitsFooting();
            footing.BenefitsFootingTitle = TbBenefitsFooting.Text;
            
            DB.db.BenefitsFooting.Add(footing);
            ListFootings.Add(footing);
            if (String.IsNullOrEmpty(TbBenefitsFooting.Text) || String.IsNullOrWhiteSpace(TbBenefitsFooting.Text))
            {
                ClearLists();
                DB.db.BenefitsFooting.Remove(footing);
                MessageBox.Show("Заполните поле Основание для выдачи", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            

            try
            {
               
                AddFooting();
            }
            catch
            {
                Validate();
            }

            try
            {
                AddBenefits();
            }
            catch
            {
                Validate();
            }

            try
            {
                AddDocument();
            }
            catch
            {
                Validate();
            }

      

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveBenefits();
            SaveDocument();
            SaveFooting();
        }

        private void SaveFooting()
        {
            GridFooting.CanUserAddRows = false;
            try
            {
                if (GridFooting.Items.Count > 0)
            {
                DB.db.SaveChanges();
                
                MessageBox.Show("Данные успешно сохранены!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            else
            {
                MessageBox.Show("Добавьте данные", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
}

        private void SaveDocument()
        {
            GridDocuments.CanUserAddRows = false;
            try
            {
                if (GridDocuments.Items.Count > 0)
            {
                DB.db.SaveChanges();
                
                MessageBox.Show("Данные успешно сохранены!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            else
            {
                MessageBox.Show("Добавьте данные", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
}


        private void SaveBenefits()
        {
            GridBenefits.CanUserAddRows = false;
             try
              {
            if (GridBenefits.Items.Count > 0)
            {
                DB.db.SaveChanges();
                
                MessageBox.Show("Данные успешно сохранены!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            else
            {
                MessageBox.Show("Добавьте данные", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditGrid();
           
        }

        private void EditGrid()
        {
            if (GridBenefits.SelectedIndex >= 0 || GridDocuments.SelectedIndex >= 0 || GridFooting.SelectedIndex >= 0)
            {
                GridBenefits.IsReadOnly = false;
                GridDocuments.IsReadOnly = false;
                GridFooting.IsReadOnly = false;
                GridDocuments.BeginEdit();
                GridBenefits.BeginEdit();
                GridFooting.BeginEdit();
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }
        }

        

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            EmployeeCard employeeCard = new EmployeeCard();
            employeeCard.Show();
            this.Close();
        }

        private void GridDocuments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnDel.IsEnabled = false;
            if(GridBenefits.Items.Count <= 0)
            {
                BtnDel.IsEnabled = true;
            }

        }

        private void GridFooting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnDel.IsEnabled = false;
            if (GridBenefits.Items.Count <= 0)
            {
                BtnDel.IsEnabled = true;
            }
        }

        private void GridBenefits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            BtnDel.IsEnabled = true;
            if (GridBenefits.Items.Count > 0)
            {
                BtnDel.IsEnabled = true;
            }

        }
    }
}
