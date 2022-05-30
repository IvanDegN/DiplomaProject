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
    
    public partial class PersonalCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonalCard()
        {
            this.Worker = new HashSet<Worker>();
        }
    
        public int IdPersonalCard { get; set; }
        public int IdCompany { get; set; }
        public System.DateTime DateCreateDocument { get; set; }
        public int StaffNumber { get; set; }
        public int INN { get; set; }
        public int SNILS { get; set; }
        public string FirstLetterLastName { get; set; }
        public int IdKindWork { get; set; }
        public int IdTypeWork { get; set; }
        public int IdSex { get; set; }
        public int IdEmploymentContract { get; set; }
        public int IdMilitaryRegistration { get; set; }
        public int IdAdmissionAndDismissal { get; set; }
        public int IdCertification { get; set; }
        public int IdProfessionalDevelopment { get; set; }
        public int IdProfessionalRetraining { get; set; }
        public int IdRewards { get; set; }
        public int IdVacation { get; set; }
        public int IdBenefits { get; set; }
        public string AdditionalInformation { get; set; }
        public int IdDismissal { get; set; }
        public int MilitaryRecordsId { get; set; }
    
        public virtual AdmissionAndDismissal AdmissionAndDismissal { get; set; }
        public virtual Benefits Benefits { get; set; }
        public virtual Certification Certification { get; set; }
        public virtual Company Company { get; set; }
        public virtual Dismissal Dismissal { get; set; }
        public virtual EmploymentContract EmploymentContract { get; set; }
        public virtual KindWork KindWork { get; set; }
        public virtual MilitaryRecords MilitaryRecords { get; set; }
        public virtual ProfessionalDevelopment ProfessionalDevelopment { get; set; }
        public virtual ProfessionalRetraining ProfessionalRetraining { get; set; }
        public virtual Rewards Rewards { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual TypeWork TypeWork { get; set; }
        public virtual Vacation Vacation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Worker> Worker { get; set; }
    }
}