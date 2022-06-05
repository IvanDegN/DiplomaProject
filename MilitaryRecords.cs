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
    
    public partial class MilitaryRecords
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MilitaryRecords()
        {
            this.PersonalCard = new HashSet<PersonalCard>();
        }
    
        public int MilitaryRecordsId { get; set; }
        public int StockCategoryId { get; set; }
        public int MilitaryRankId { get; set; }
        public int CompositionProfileId { get; set; }
        public string FullCodeDesignationVUS { get; set; }
        public int EligibilityCategoryId { get; set; }
        public int MilitaryCommissariatId { get; set; }
        public string GeneralMilitaryRecords { get; set; }
        public string SpecialMilitaryRecords { get; set; }
        public string MarkDismissalMilitaryRegistry { get; set; }
        public Nullable<System.DateTime> MilitaryRecordsDate { get; set; }
        public string HRworker { get; set; }
        public int IdPosition { get; set; }
    
        public virtual CompositionProfile CompositionProfile { get; set; }
        public virtual EligibilityCategory EligibilityCategory { get; set; }
        public virtual MilitaryCommissariat MilitaryCommissariat { get; set; }
        public virtual MilitaryRank MilitaryRank { get; set; }
        public virtual Position Position { get; set; }
        public virtual StockCategory StockCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalCard> PersonalCard { get; set; }
    }
}
