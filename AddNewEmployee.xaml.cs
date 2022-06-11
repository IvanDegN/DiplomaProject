using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для AddNewEmployee.xaml
    /// </summary>
    public partial class AddNewEmployee : Window
    {
        
        public AddNewEmployee()
        {
            InitializeComponent();
            string date = DateTime.Now.ToShortDateString();
            DpEmploymentContractNumber.SelectedDate = DateTime.Parse(date);
        }

        

        private void BtnAddNewEmployee_Click(object sender, RoutedEventArgs e)
        {



            
            if (DpWorkerBirthDate.SelectedDate == null)
            {
                string date = DateTime.Now.ToShortDateString();
                DpWorkerBirthDate.SelectedDate = DateTime.Parse(date);
            }

            if(DpWorkExperienceDate.SelectedDate == null)
            {
                string date = DateTime.Now.ToShortDateString();
                DpWorkExperienceDate.SelectedDate = DateTime.Parse(date);
            }

            if(DpFamilyCompositionDateBirth.SelectedDate == null)
            {
                string date = DateTime.Now.ToShortDateString();
                DpFamilyCompositionDateBirth.SelectedDate = DateTime.Parse(date);

            }

            if(DpFinishEducation.SelectedDate == null)
            {
                string date = DateTime.Now.ToShortDateString();
                DpFinishEducation.SelectedDate = DateTime.Parse(date);
            }

            if(DpRegistrationDate.SelectedDate == null)
            {
                string date = DateTime.Now.ToShortDateString();
                DpRegistrationDate.SelectedDate = DateTime.Parse(date);
            }

            if(DpWorkerPassportDateIssue.SelectedDate == null)
            {
                string date = DateTime.Now.ToShortDateString();
                DpWorkerPassportDateIssue.SelectedDate = DateTime.Parse(date);
            }

            try
            {
                WorkCard workCard = new WorkCard
                {

                    Company = CbCompany.SelectedItem as Company,
                    CreateDate = (DateTime)DpEmploymentContractNumber.SelectedDate,
                    ServiceNumber = TbServiceNumber.Text,
                    INN = TbINN.Text,
                    SNILS = TbSNILS.Text,
                    FirstLetter = TbFirstLetter.Text,
                    KindWork = CbKindWork.SelectedItem as KindWork,
                    TypeWork = CbTypeWork.SelectedItem as TypeWork,
                    Sex = CbSex.SelectedItem as Sex,
                    LastName = TbWorkerLastName.Text,
                    Name = TbWorkerName.Text,
                    MiddleName = TbWorkerMiddleName.Text,
                    DateBirth = (DateTime)DpWorkerBirthDate.SelectedDate,
                    DateBirthCode = TbWorkerBirthDateCode.Text,
                    PlaceBirth = CbPlaceBirth.SelectedItem as PlaceBirth,
                    PlaceBirthCode = TbPlaceBirthCode.Text,
                    Citizenship = CbCitizenship.SelectedItem as Citizenship,
                    CitizenshipCode = TbCitizenshipCode.Text,
                    LanguageName = CbLanguageKnowledgeTitle.SelectedItem as LanguageName,
                    LanguageNameCode = TbLanguageKnowledgeCode.Text,
                    LanguageKnowledgeType = CbLanguageKnowledgeType.SelectedItem as LanguageKnowledgeType,
                    EducationTitle = CbEducationTitle.SelectedItem as EducationTitle,
                    EducationTitleCode = TbEducationCode.Text,
                    Profession = CbBaseProfession.SelectedItem as Profession,
                    ProfessionCode = TbBaseProfessionCode.Text,
                    WorkExpDate = (DateTime)DpWorkExperienceDate.SelectedDate,
                    WorkExpTotalDays = TbWorkExperienceTotalDays.Text,
                    WorkExpTotalMonths = TbWorkExperienceTotalMonth.Text,
                    WorkExpTotalYears = TbWorkExperienceTotalYears.Text,
                    WorkExpConDays = TbWorkExperienceContinuousDays.Text,
                    WokrExpConYears = TbWorkExperienceContinuousYears.Text,
                    WorkExpConMonths = TbWorkExperienceContinuousMonth.Text,
                    WorkExpBonusDays = TbWorkExperienceBonusDays.Text,
                    WorkExpBonusYears = TbWorkExperienceBonusYears.Text,
                    WorkExpBounsMonths = TbWorkExperienceBonusMonths.Text,
                    MaritalStatus = CbMaritalStatus.SelectedItem as MaritalStatus,
                    MaritalStatusCode = TbMaritalStatusCode.Text,
                    FamilyComposition = CbDegreeKinship.SelectedItem as FamilyComposition,
                    FamilyCompositionLastName = TbFamilyCompositionLastName.Text,
                    FamilyCompositionName = TbFamilyCompositionName.Text,
                    FamilyCompositionMiddleName = TbFamilyCompositionMiddleName.Text,
                    FamilyCompositionBirthDate = (DateTime)DpFamilyCompositionDateBirth.SelectedDate,
                    PassportNumber = TbWorkerPassportNumber.Text,
                    PassportGetDate = (DateTime)DpWorkerPassportDateIssue.SelectedDate,
                    PassportWhoGet = TbWorkerPassportGet.Text,
                    ActualAddressIndex = TbActualAddressIndex.Text,
                    ActualAddress = ActualAddress.Text,
                    PassportIndex = TbPassportAddressIndex.Text,
                    PassportAddress = TbPassportAddress.Text,
                    RegistrationDate = (DateTime)DpRegistrationDate.SelectedDate,
                    PhoneNumber = TbNumberPhone.Text,
                    TitleCompanyCode = TbCompanyCode.Text,
                    DirectionOrSpecialtyCode = TbDirectionOrSpecialtyCode.Text,


                };

                EmploymentContract employmentContract = new EmploymentContract
                {
                    Number = TbEmploymentContractNumber.Text,
                    Date = DateTime.Now,

                };

                MilitaryRecords militaryRecords = new MilitaryRecords
                {
                    StockCategory = CbStockCategory.SelectedItem as StockCategory,
                    MilitaryRank = CbMilitaryRank.SelectedItem as MilitaryRank,
                    CompositionProfile = CbCompositionProfile.SelectedItem as CompositionProfile,
                    FullCodeDesignationVUS = TbFullCodeDesignationVUS.Text,
                    EligibilityCategory = CbEligibilityCategory.SelectedItem as EligibilityCategory,
                    GeneralMilitaryRecords = TbGeneralMilitaryRecords.Text,
                    SpecialMilitaryRecords = TbSpecialMilitaryRecords.Text,
                    MarkDismissalMilitaryRegistry = TbMarkDismissalMilitaryRegistry.Text,
                    Position = CbPosition.SelectedItem as Position
                };



                MilitaryCommissariat militaryCommissariat = new MilitaryCommissariat
                {
                    MilitaryCommissariat1 = TbMilitaryCommissariat.Text,

                };


                DocumentAboutEducation documentAboutEducation = new DocumentAboutEducation
                {
                    Title = TbDocumentAboutEducationTitle.Text,
                    Series = TbDocumentAboutEducationSeries.Text,
                    Number = int.Parse(TbDocumentAboutEducationNumber.Text)
                };


                DB.db.WorkCard.Add(workCard);
                DB.db.EmploymentContract.Add(employmentContract);
                DB.db.MilitaryRecords.Add(militaryRecords);
                DB.db.MilitaryCommissariat.Add(militaryCommissariat);
                DB.db.DocumentAboutEducation.Add(documentAboutEducation);
            }
            catch
            {
                //if (String.IsNullOrWhiteSpace(TbEmploymentContractNumber.Text) || String.IsNullOrEmpty(TbEmploymentContractNumber.Text))
                //{
                //    MessageBox.Show("Заполните поле Номер", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbServiceNumber.Text) || String.IsNullOrWhiteSpace(TbServiceNumber.Text))
                //{
                //    MessageBox.Show("Заполните поле Табельный номер", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbINN.Text) || String.IsNullOrWhiteSpace(TbINN.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbSNILS.Text) || String.IsNullOrWhiteSpace(TbSNILS.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbFirstLetter.Text) || String.IsNullOrWhiteSpace(TbFirstLetter.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbWorkerLastName.Text) || String.IsNullOrWhiteSpace(TbWorkerLastName.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbWorkerName.Text) || String.IsNullOrWhiteSpace(TbWorkerName.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbWorkerMiddleName.Text) || String.IsNullOrWhiteSpace(TbWorkerMiddleName.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbWorkerBirthDateCode.Text) || String.IsNullOrWhiteSpace(TbWorkerBirthDateCode.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbCitizenshipCode.Text) || String.IsNullOrWhiteSpace(TbCitizenshipCode.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                //if (String.IsNullOrEmpty(TbLanguageKnowledgeCode.Text) || String.IsNullOrWhiteSpace(TbLanguageKnowledgeCode.Text))
                //{
                //    MessageBox.Show("Заполните поле ", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                List<TextBox> textBoxes = new List<TextBox>()
            {
                TbActualAddressIndex,
                TbBaseProfessionCode,
                TbCitizenshipCode,
                TbCompanyCode,
                TbDirectionOrSpecialtyCode,
                TbDocumentAboutEducationNumber,
                TbDocumentAboutEducationSeries,
                TbDocumentAboutEducationTitle,
                TbEducationalInstitution,
                TbEducationCode,
                TbEmploymentContractNumber,
                TbFamilyCompositionLastName,
                TbFamilyCompositionMiddleName,
                TbFamilyCompositionName,
                TbFirstLetter,
                TbFullCodeDesignationVUS,
                TbGeneralMilitaryRecords,
                TbINN,
                TbLanguageKnowledgeCode,
                TbMaritalStatusCode,
                TbMarkDismissalMilitaryRegistry,
                TbMilitaryCommissariat,
                TbNumberPhone,
                TbPassportAddress,
                TbPassportAddressIndex,
                TbPlaceBirthCode,
                TbServiceNumber,
                TbSNILS,
                TbSpecialMilitaryRecords,
                TbWorkerBirthDateCode,
                TbWorkerLastName,
                TbWorkerMiddleName,
                TbWorkerName,
                TbWorkerPassportGet,
                TbWorkerPassportNumber,
                TbWorkExperienceBonusDays,
                TbWorkExperienceBonusMonths,
                TbWorkExperienceBonusYears,
                TbWorkExperienceContinuousDays,
                TbWorkExperienceContinuousMonth,
                TbWorkExperienceContinuousYears,
                TbWorkExperienceTotalDays,
                TbWorkExperienceTotalMonth,
                TbWorkExperienceTotalYears,
                ActualAddress

            };
                foreach (TextBox textBox in textBoxes)
                {
                    

                    if (String.IsNullOrEmpty(textBox.Text) || String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Не все поля заполнены", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    
                }


            }


            

            

            
                

            try
            {
                List<TextBox> textBoxes = new List<TextBox>()
            {
                TbActualAddressIndex,
                TbBaseProfessionCode,
                TbCitizenshipCode,
                TbCompanyCode,
                TbDirectionOrSpecialtyCode,
                TbDocumentAboutEducationNumber,
                TbDocumentAboutEducationSeries,
                TbDocumentAboutEducationTitle,
                TbEducationalInstitution,
                TbEducationCode,
                TbEmploymentContractNumber,
                TbFamilyCompositionLastName,
                TbFamilyCompositionMiddleName,
                TbFamilyCompositionName,
                TbFirstLetter,
                TbFullCodeDesignationVUS,
                TbGeneralMilitaryRecords,
                TbINN,
                TbLanguageKnowledgeCode,
                TbMaritalStatusCode,
                TbMarkDismissalMilitaryRegistry,
                TbMilitaryCommissariat,
                TbNumberPhone,
                TbPassportAddress,
                TbPassportAddressIndex,
                TbPlaceBirthCode,
                TbServiceNumber,
                TbSNILS,
                TbSpecialMilitaryRecords,
                TbWorkerBirthDateCode,
                TbWorkerLastName,
                TbWorkerMiddleName,
                TbWorkerName,
                TbWorkerPassportGet,
                TbWorkerPassportNumber,
                TbWorkExperienceBonusDays,
                TbWorkExperienceBonusMonths,
                TbWorkExperienceBonusYears,
                TbWorkExperienceContinuousDays,
                TbWorkExperienceContinuousMonth,
                TbWorkExperienceContinuousYears,
                TbWorkExperienceTotalDays,
                TbWorkExperienceTotalMonth,
                TbWorkExperienceTotalYears,
                ActualAddress

            };
                foreach (TextBox textBox in textBoxes)
                {
                    

                    if (String.IsNullOrEmpty(textBox.Text) || String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        
                    }
                    else
                    {
                        DB.db.SaveChanges();
                        MessageBox.Show("Карточка нового сотрудника успешно добавлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information); break;
                    }

                }


                
            }
            catch
            {
                MessageBox.Show("Ошибка добавления");
            }
            //catch (DbEntityValidationException ex)
            //{
            //    foreach(DbEntityValidationResult validationError in ex.EntityValidationErrors)
            //    {
            //        MessageBox.Show(validationError.Entry.Entity.ToString());
            //        foreach(DbValidationError err in validationError.ValidationErrors)
            //        {
            //            MessageBox.Show(err.ErrorMessage);
            //        }
            //    }
            //}
                
            
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CbBaseProfession.ItemsSource = DB.db.Profession.ToList();
            CbCitizenship.ItemsSource = DB.db.Citizenship.ToList();
            CbCompositionProfile.ItemsSource = DB.db.CompositionProfile.ToList();
            CbDirectionOrSpecialty.ItemsSource = DB.db.DirectionOrSpecialty.ToList();
            CbEducationTitle.ItemsSource = DB.db.EducationTitle.ToList();
            CbEligibilityCategory.ItemsSource = DB.db.EligibilityCategory.ToList();
            CbLanguageKnowledgeType.ItemsSource = DB.db.LanguageKnowledgeType.ToList();
            CbMaritalStatus.ItemsSource = DB.db.MaritalStatus.ToList();
            CbMilitaryRank.ItemsSource = DB.db.MilitaryRank.ToList();
            CbPlaceBirth.ItemsSource = DB.db.PlaceBirth.ToList();
            CbQualification.ItemsSource = DB.db.Qualification.ToList();
            CbStockCategory.ItemsSource = DB.db.StockCategory.ToList();
            CbSex.ItemsSource = DB.db.Sex.ToList();
            CbUsers.ItemsSource = DB.db.Users.ToList();
            CbDegreeKinship.ItemsSource = DB.db.FamilyComposition.ToList();
            CbCompany.ItemsSource = DB.db.Company.ToList();
            CbKindWork.ItemsSource = DB.db.KindWork.ToList();
            CbTypeWork.ItemsSource = DB.db.TypeWork.ToList();
            CbLanguageKnowledgeTitle.ItemsSource = DB.db.LanguageName.ToList();
            CbPosition.ItemsSource = DB.db.Position.ToList();

            CbPosition.SelectedIndex = 0;
            CbLanguageKnowledgeTitle.SelectedIndex = 0;
            CbTypeWork.SelectedIndex = 0;
            CbKindWork.SelectedIndex = 0;
            CbBaseProfession.SelectedIndex = 0;
            CbCitizenship.SelectedIndex = 0;
            CbCompositionProfile.SelectedIndex = 0;
            CbDirectionOrSpecialty.SelectedIndex = 0;
            CbEducationTitle.SelectedIndex = 0;
            CbEligibilityCategory.SelectedIndex = 0;
            CbLanguageKnowledgeType.SelectedIndex = 0;
            CbMaritalStatus.SelectedIndex = 0;
            CbMilitaryRank.SelectedIndex = 0;
            CbPlaceBirth.SelectedIndex = 0;
            CbQualification.SelectedIndex = 0;
            CbStockCategory.SelectedIndex = 0;
            CbSex.SelectedIndex = 0;
            CbUsers.SelectedIndex = 0;
            CbDegreeKinship.SelectedIndex = 0;
            CbCompany.SelectedIndex = 3;

            DB.db.Sex.Load();
            DB.db.WorkCard.Load();
            DB.db.MilitaryRecords.Load();
            DB.db.Qualification.Load();
        }
    }
}
