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
    
    public partial class AdmissionAndDismissal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdmissionAndDismissal()
        {
            this.PersonalCard = new HashSet<PersonalCard>();
        }
    
        public int IdAdmissionAndDismissal { get; set; }
        public System.DateTime DateOrder { get; set; }
        public System.DateTime NumberOrder { get; set; }
        public string PositionName { get; set; }
        public string CommissariatName { get; set; }
        public string NumberHuman { get; set; }
        public System.DateTime DateNumberHuman { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalCard> PersonalCard { get; set; }
    }
}
