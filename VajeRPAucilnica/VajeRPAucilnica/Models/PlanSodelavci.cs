//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajeRPAucilnica.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanSodelavci
    {
        public int PlaID { get; set; }
        public int MenID { get; set; }
        public string brezveze { get; set; }
    
        public virtual Mentor Mentor { get; set; }
        public virtual PlanDejavnosti PlanDejavnosti { get; set; }
    }
}
