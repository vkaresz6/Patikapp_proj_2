//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Patikapp_proj_2.Modells
{
    using System;
    using System.Collections.Generic;
    
    public partial class users_data
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string TAJ { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int IsEmployedAt { get; set; }
    
        public virtual users users { get; set; }
    }
}