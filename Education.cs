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
    
    public partial class Education
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Education()
        {
            this.Worker = new HashSet<Worker>();
        }
    
        public int IdEducation { get; set; }
        public string EducationalInstitution { get; set; }
        public int IdDocumentAboutEducation { get; set; }
        public System.DateTime FinishEducation { get; set; }
        public int IdQualification { get; set; }
        public int IdDirectionOrSpecialty { get; set; }
        public string EducationTitle { get; set; }
        public int EducationCode { get; set; }
    
        public virtual DirectionOrSpecialty DirectionOrSpecialty { get; set; }
        public virtual DocumentAboutEducation DocumentAboutEducation { get; set; }
        public virtual Qualification Qualification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Worker> Worker { get; set; }
    }
}