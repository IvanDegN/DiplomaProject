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
    
    public partial class Position
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Position()
        {
            this.HiringTransfersOtherJobs = new HashSet<HiringTransfersOtherJobs>();
        }
    
        public int IdPosition { get; set; }
        public string TitlePosition { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HiringTransfersOtherJobs> HiringTransfersOtherJobs { get; set; }
        public virtual ProfessionalRetrainingHiringTransfersOtherJobs ProfessionalRetrainingHiringTransfersOtherJobs { get; set; }
    }
}
