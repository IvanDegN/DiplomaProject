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
    
    public partial class WorkExperienceTotal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkExperienceTotal()
        {
            this.WorkExperience = new HashSet<WorkExperience>();
        }
    
        public int IdWorkExperienceTotal { get; set; }
        public int Days { get; set; }
        public int Months { get; set; }
        public int Years { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkExperience> WorkExperience { get; set; }
    }
}