using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для ManageEducation.xaml
    /// </summary>
    public partial class ManageEducation : Window
    {
        ObservableCollection<Education> ListEducation = new ObservableCollection<Education>();
        ObservableCollection<DocumentAboutEducation> ListDocumentAboutEducations = new ObservableCollection<DocumentAboutEducation>();
        ObservableCollection<Qualification> ListQualification = new ObservableCollection<Qualification>();
        ObservableCollection<DirectionOrSpecialty> ListDirecrionOrSpecialty = new ObservableCollection<DirectionOrSpecialty>();
        ObservableCollection<EducationTitle> ListEductionTitle = new ObservableCollection<EducationTitle>();

        public ManageEducation()
        {
            InitializeComponent();
            DB.db.Education.Load();
            DB.db.DocumentAboutEducation.Load();
            DB.db.Qualification.Load();
            DB.db.DirectionOrSpecialty.Load();
            DB.db.EducationTitle.Load();
            GridDocumentAboutEducation.IsReadOnly = true;
            GridEducation.IsReadOnly = true;
        }

        private void SaveData()
        {
            try
            {
                
                
                    DB.db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);

                
                
                
            }
            catch
            {
                MessageBox.Show("Ошибка добавления. Добавление данных осуществляется по одной записи. Необходимо перезайти в окно редактирования, чтобы добавить запись", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }



        }

        private void LoadGrids()
        {
            var eduction = DB.db.Education;
            var docAboutEduction = DB.db.DocumentAboutEducation;
            var qualification = DB.db.Qualification;
            var directionOrSpecialty = DB.db.DirectionOrSpecialty;
            var educaitonTitle = DB.db.EducationTitle;

            foreach(Education item in eduction)
            {
                ListEducation.Add(item);
            }
            GridEducation.ItemsSource = ListEducation;

            foreach(DocumentAboutEducation item in docAboutEduction)
            {
                ListDocumentAboutEducations.Add(item);
            }
            GridDocumentAboutEducation.ItemsSource = ListDocumentAboutEducations;

            
        }

        private void ClearLists()
        {
            ListDirecrionOrSpecialty.Clear();
            ListDocumentAboutEducations.Clear();
            ListEducation.Clear();
            ListEductionTitle.Clear();
            ListQualification.Clear();
        }

        private void SaveGrids()
        {
           

            GridDocumentAboutEducation.CanUserAddRows=false;
            try
            {
                if (GridDocumentAboutEducation.Items.Count > 0)
                {
                    SaveData();

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

            GridEducation.CanUserAddRows = false;
            try
            {
                if (GridEducation.Items.Count > 0)
                    SaveData();
                else
                    MessageBox.Show("Добавьте данные", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            catch
            {
                MessageBox.Show("Добавление данных осуществляется по одной записи", "Warning", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }



        }

        private void EditGrids()
        {
            if(  GridDocumentAboutEducation.SelectedIndex >= 0 || GridEducation.SelectedIndex >=0)
            {
                GridDocumentAboutEducation.IsReadOnly = false;
                GridEducation.IsReadOnly = false;
                GridDocumentAboutEducation.BeginEdit();
                GridEducation.BeginEdit();
            }
            else
                MessageBox.Show("Выберите строку для редактирования", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
        }

        private void Validate()
        {
            // MessageBox.Show("Необходимо заполнить поле", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);

            if (String.IsNullOrEmpty(TbEducationalInstitution.Text) || String.IsNullOrWhiteSpace(TbEducationalInstitution.Text))
            {
                MessageBox.Show("Необходимо заполнить поле Наименование уч. З", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            if(DpFinishEducation.SelectedDate == null)
            {
                DpFinishEducation.SelectedDate = DateTime.Now;
            }


            string Str = TbEducationCode.Text.Trim();
            string validateTbNumberDoc = TbNumberDoc.Text.Trim();

            int Num;

            bool isNum = int.TryParse(Str,  out Num);

            if (!isNum)
            {
                MessageBox.Show("Введите правильные данные (число) в Поле Код по ОКСО", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                
            }

            bool numberDoc = int.TryParse(validateTbNumberDoc, out Num);

            if(!numberDoc)
            {
                MessageBox.Show("Введите правильные данные (число) в Поле Номер документа", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }
            
            if(CbQualification.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать квалификацию", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                CbQualification.SelectedIndex = 0;
            }

            if (CbDirectionOrSpecialty.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать направление или специализацию", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                CbDirectionOrSpecialty.SelectedIndex = 0;
            }

            

            if(String.IsNullOrEmpty(TbTitleDoc.Text) || String.IsNullOrWhiteSpace(TbTitleDoc.Text))
            {
                MessageBox.Show("Необходимо заполнить поле Наименование документа", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            if(String.IsNullOrEmpty(TbSeriesDoc.Text) || String.IsNullOrWhiteSpace(TbSeriesDoc.Text) )
            {
                MessageBox.Show("Необходимо заполнить поле Cерия документа", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

        }

        private void AddData()
        {
            Education education = new Education
            {
                EducationalInstitution = TbEducationalInstitution.Text,
                FinishEducation = (DateTime)DpFinishEducation.SelectedDate,
                EducationCode = TbEducationCode.Text,
                Qualification = CbQualification.SelectedItem as Qualification,
                DirectionOrSpecialty = CbDirectionOrSpecialty.SelectedItem as DirectionOrSpecialty,
               
                 
            };
            DocumentAboutEducation documentAboutEducation = new DocumentAboutEducation();
            EducationTitle educationTitle = new EducationTitle();

            DB.db.Education.Add(education);
            ListEducation.Add(education);

            documentAboutEducation.Title = TbTitleDoc.Text;
            documentAboutEducation.Series = TbSeriesDoc.Text;
            documentAboutEducation.Number = int.Parse(TbNumberDoc.Text);

            DB.db.DocumentAboutEducation.Add(documentAboutEducation);
            ListDocumentAboutEducations.Add(documentAboutEducation);

            
        }

        

        private void RefreshEducation()
        {
            var education = DB.db.Education;

            foreach (Education item in education)
            {
                ListEducation.Add(item);
            }
            GridEducation.ItemsSource = ListEducation;
            GridEducation.Items.Refresh();

        }

        private void RefreshDoc()
        {
            var docAboutEduction = DB.db.DocumentAboutEducation;

            foreach (DocumentAboutEducation item in docAboutEduction)
            {
                ListDocumentAboutEducations.Add(item);
            }
            GridDocumentAboutEducation.ItemsSource = ListDocumentAboutEducations;
            GridDocumentAboutEducation.Items.Refresh();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Education education = GridEducation.SelectedItem as Education;
            DocumentAboutEducation documentAboutEducation = GridDocumentAboutEducation.SelectedItem as DocumentAboutEducation;
          

            if(education != null && GridEducation.Columns != null)
            {
                if(GridEducation.CurrentCell != null)
                {
                    var result = MessageBox.Show($"Удалить образовательное учреждение: {education.EducationalInstitution}?", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
                    if (result == MessageBoxResult.OK)
                    {
                        ListEducation.Remove(education);
                        DB.db.Education.Remove(education);
                        try
                        {
                            DB.db.SaveChanges();
                            MessageBox.Show("Образовательное учреждение удалено успешно ", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка удаления ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                        }
                    }
                }
            }

            if(GridEducation.SelectedItem == null || GridDocumentAboutEducation.SelectedItem == null)
            {
                MessageBox.Show("Выберете строку для удаления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }
            else
            {
                MessageBox.Show("Объект удалён", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            if(GridDocumentAboutEducation.Columns != null && documentAboutEducation != null)
            {

                if(GridEducation.Items.Count != GridDocumentAboutEducation.Items.Count)
                {
                    try
                    {
                        ListDocumentAboutEducations.Remove(documentAboutEducation);
                        DB.db.DocumentAboutEducation.Remove(documentAboutEducation);
                        DB.db.SaveChanges();
                        MessageBox.Show("Документ удалён успешно ", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Сначала необходимо удалить образовательное учреждение", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                    
                }
                
                
            }

           

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                AddData();
            }
            catch
            {
                Validate();
            }
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveGrids();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditGrids();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            EmployeeCard employeeCard = new EmployeeCard();
            employeeCard.Show();
            this.Close();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadGrids();
            CbDirectionOrSpecialty.ItemsSource = DB.db.DirectionOrSpecialty.ToList();
            CbDirectionOrSpecialty.SelectedIndex = 0;
            
            CbQualification.ItemsSource = DB.db.Qualification.ToList();
            CbQualification.SelectedIndex = 0;

        }

        

        private void TbSeriesDoc_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            }

            e.Handled = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ".IndexOf(e.Text) < 0;


            if (TbSeriesDoc.Text.Length >= 1)
            {
                MessageBox.Show("Серия документа может содержать только одну букву", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                TbSeriesDoc.Text.Remove(TbSeriesDoc.Text.Length - 1);
            }
        }

    }
}
