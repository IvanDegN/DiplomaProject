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
using System.Windows.Shapes;

namespace DiplomaProject
{
    /// <summary>
    /// Логика взаимодействия для EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCard : Window
    {
        Worker worker { get; set; }
        PersonalCard PersonalCard { get; set; }

        public EmployeeCard()
        {
            InitializeComponent();
        }

        private void BtnChangeImage_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void BtnPrintEmployeeCard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            ListEmployees listEmployees = new ListEmployees();
            this.Close();
            listEmployees.Show();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BntDismiss_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

            CbCitizenship.ItemsSource = DB.db.Citizenship.ToList();
            CbEducation.ItemsSource = DB.db.EducationTitle.ToList();
            CbLanguage.ItemsSource = DB.db.LanguageKnowledge.ToList();
            CbLanguageType.ItemsSource = DB.db.LanguageKnowledgeType.ToList();
            CbMarried.ItemsSource = DB.db.MaritalStatus.ToList();
            CbPlaceBirth.ItemsSource = DB.db.PlaceBirth.ToList();
            CbProfession.ItemsSource = DB.db.Profession.ToList();
            CbSex.ItemsSource = DB.db.Sex.ToList();
            CbSex.SelectedIndex = 0;
            CbPlaceBirth.SelectedIndex = 0;
            CbCitizenship.SelectedIndex = 0;
            CbEducation.SelectedIndex = 0;
            CbLanguage.SelectedIndex = 0;
            CbLanguageType.SelectedIndex = 0;
            CbMarried.SelectedIndex = 0;
            CbProfession.SelectedIndex = 0;

            //TbEmploymentContract.Text = PersonalCard.EmploymentContract.ToString();
            
            //TbLastName.Text = worker.LastName.ToString();
            //TbName.Text = worker.Name.ToString();
            //TbMiddleName.Text = worker.MiddleName.ToString();

            //TbPassportNumber.Text = worker.PassportNumber.ToString();

            //TbPassportGet.Text = worker.PassportGet.ToString();
            //TbPassportAddress.Text = worker.PassportAddress.ToString();
            //TbPassportAddressIndex.Text = worker.PassportAddressIndex.ToString();
            //TbActualAddress.Text = worker.ActualAddress.ToString();
            //TbActualAddressIndex.Text = worker.ActualAddressIndex.ToString();
            //TbNumberPhone.Text = worker.NumberPhone.ToString();
            
            //TbServiceNumber.Text = worker.ServiceNumber.ToString();
            //TbINN.Text = worker.INN.ToString();
            //TbSNILS.Text = worker.SNILS.ToString();


            if (DpBirthDate.SelectedDate == null)
            {
                DpBirthDate.SelectedDate = DateTime.Now;
            }
            else
            {
                DpBirthDate.SelectedDate = worker.BirthDate;
            }
            

            if(DpPassportDateIssue.SelectedDate == null)
            {
                DpPassportDateIssue.SelectedDate = DateTime.Now;
            }
            else
            {
                DpPassportDateIssue.SelectedDate = worker.PassportDateIssue;
            }

            if(DpDateCreateDocument.SelectedDate == null)
            {
                DpDateCreateDocument.SelectedDate = DateTime.Now;
            }
            else
            {
                DpDateCreateDocument.SelectedDate = PersonalCard.DateCreateDocument;
            }

            if(DpRegistrationDate.SelectedDate == null)
            {
                DpRegistrationDate.SelectedDate = DateTime.Now;
            }
            else
            {
                DpRegistrationDate.SelectedDate = worker.RegistrationDate;
            }




        }
    }
}
