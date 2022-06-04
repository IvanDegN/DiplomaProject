//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiplomaProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        public int IdWorker { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public int IdPlaceBirth { get; set; }
        public int IdCitizenship { get; set; }
        public int IdLanguageKnowledge { get; set; }
        public int IdEducation { get; set; }
        public int IdProfession { get; set; }
        public int IdWorkExperience { get; set; }
        public int IdMaritalStatus { get; set; }
        public int IdFamilyComposition { get; set; }
        public int PassportNumber { get; set; }
        public System.DateTime PassportDateIssue { get; set; }
        public string PassportAddress { get; set; }
        public string ActualAddress { get; set; }
        public int PassportAddressIndex { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public int NumberPhone { get; set; }
        public int IdPersonalCard { get; set; }
        public int ActualAddressIndex { get; set; }
        public int ServiceNumber { get; set; }
        public int INN { get; set; }
        public int SNILS { get; set; }
        public int IdSex { get; set; }
        public int IdMilitaryRegistration { get; set; }
        public string PassportGet { get; set; }
        public int UsersId { get; set; }
    
        public virtual Citizenship Citizenship { get; set; }
        public virtual Education Education { get; set; }
        public virtual FamilyComposition FamilyComposition { get; set; }
        public virtual LanguageKnowledge LanguageKnowledge { get; set; }
        public virtual PersonalCard PersonalCard { get; set; }
        public virtual Profession Profession { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual WorkExperience WorkExperience { get; set; }
        public virtual PlaceBirth PlaceBirth { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Users Users { get; set; }
    }
}
