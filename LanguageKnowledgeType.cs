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
    
    public partial class LanguageKnowledgeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LanguageKnowledgeType()
        {
            this.LanguageKnowledge = new HashSet<LanguageKnowledge>();
        }
    
        public int IdLanguageKnowledgeType { get; set; }
        public string LanguageKnowledgeType1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LanguageKnowledge> LanguageKnowledge { get; set; }
    }
}