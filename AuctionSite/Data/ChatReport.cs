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
    
    public partial class ChatReport
    {
        public int idChatReport { get; set; }
        public int idReport { get; set; }
        public int idUserSender { get; set; }
        public int idUserReciver { get; set; }
        public string message { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual Report Report { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
