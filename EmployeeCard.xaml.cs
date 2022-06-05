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


            GridBenefits.ItemsSource = DB.db.Benefits.ToList();
            GridCertification.ItemsSource = DB.db.Certification.ToList();
            GridEducation.ItemsSource = DB.db.Education.ToList();
            GridFamilyComposition.ItemsSource = DB.db.FamilyComposition.ToList();
            GridHiringTransfersOtherJobs.ItemsSource = DB.db.FamilyComposition.ToList();
            GridProfessionalRetraining.ItemsSource = DB.db.ProfessionalRetraining.ToList();
            GridProfessionalDevelopment.ItemsSource = DB.db.ProfessionalDevelopment.ToList();
            GridReward.ItemsSource = DB.db.Rewards.ToList();
            GridVacation.ItemsSource = DB.db.Vacation.ToList();
            GridWorkExperienceBonus.ItemsSource = DB.db.WorkExperienceBonus.ToList();
            GridWorkExperienceContinuous.ItemsSource = DB.db.WorkExperienceContinuous.ToList();
            GridWorkExperienceTotal.ItemsSource = DB.db.WorkExperienceTotal.ToList();

            GridBenefits.AutoGenerateColumns = false;
            GridCertification.AutoGenerateColumns = false;
            GridEducation.AutoGenerateColumns = false;
            GridFamilyComposition.AutoGenerateColumns = false;
            GridHiringTransfersOtherJobs.AutoGenerateColumns = false;
            GridProfessionalDevelopment.AutoGenerateColumns = false;
            GridReward.AutoGenerateColumns = false;
            GridVacation.AutoGenerateColumns = false;
            GridWorkExperienceBonus.AutoGenerateColumns = false;
            GridWorkExperienceContinuous.AutoGenerateColumns = false;
            GridWorkExperienceTotal.AutoGenerateColumns = false;
            GridProfessionalRetraining.AutoGenerateColumns = false;


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

            CbStockCategory.ItemsSource = DB.db.StockCategory.ToList();
            CbStockCategory.SelectedIndex = 0;
            CbMilitaryRank.ItemsSource = DB.db.MilitaryRank.ToList();
            CbMilitaryRank.SelectedIndex = 0;
            CbCompositionProfile.ItemsSource = DB.db.CompositionProfile.ToList();
            CbCompositionProfile.SelectedIndex = 0;
            CbEligibilityCategory.ItemsSource = DB.db.EligibilityCategory.ToList();
            CbEligibilityCategory.SelectedIndex = 0;
            CbPosition.ItemsSource = DB.db.Position.ToList();
            CbPosition.SelectedIndex = 0;

            

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

        private void BtnEditHiringTransfersOtherJobs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditCertification_Click(object sender, RoutedEventArgs e)
        {
            ManageCertification manageCertification = new ManageCertification();
            manageCertification.Show();
            this.Close();
        }

        private void BtnEditProfessionalDevelopment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditProfessionalDevelopmentDocumentation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditRewardDocument_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditVacation_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void BtnEditDirectionOrSpecialty_Click(object sender, RoutedEventArgs e)
        {
            ManageEducation manageEducation = new ManageEducation();
            manageEducation.Show();
            this.Close();
            
        }

        private void BtnEditWorkExperience_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditFamilyComposition_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditBenefits_Click(object sender, RoutedEventArgs e)
        {
            ManageBenefits manageBenefits = new ManageBenefits();
            manageBenefits.Show();
            this.Close();
        }
    }
}
