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
    
    public partial class HiringTransfersOtherJobs
    {
        public int IdHiringTransfersOtherJobs { get; set; }
        public System.DateTime Date { get; set; }
        public int IdDepartment { get; set; }
        public int IdPosition { get; set; }
        public decimal Salary { get; set; }
        public string Reason { get; set; }
        public string Signature { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual ProfessionalRetrainingHiringTransfersOtherJobs ProfessionalRetrainingHiringTransfersOtherJobs { get; set; }
    }
}