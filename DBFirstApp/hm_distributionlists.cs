//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class hm_distributionlists
    {
        public int distributionlistid { get; set; }
        public int distributionlistdomainid { get; set; }
        public string distributionlistaddress { get; set; }
        public byte distributionlistenabled { get; set; }
        public byte distributionlistrequireauth { get; set; }
        public string distributionlistrequireaddress { get; set; }
        public byte distributionlistmode { get; set; }
    }
}
