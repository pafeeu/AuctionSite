//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuctionSite.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Report()
        {
            this.ChatReport = new HashSet<ChatReport>();
        }
    
        public int idReport { get; set; }
        public int idReportCategory { get; set; }
        public int idReportStatus { get; set; }
        public System.DateTime creationDate { get; set; }
        public System.DateTime endDate { get; set; }
        public int idUserReporting { get; set; }
        public int idAuctionReported { get; set; }
    
        public virtual Auction Auction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChatReport> ChatReport { get; set; }
        public virtual ReportCategory ReportCategory { get; set; }
        public virtual ReportStatus ReportStatus { get; set; }
        public virtual User User { get; set; }
    }
}