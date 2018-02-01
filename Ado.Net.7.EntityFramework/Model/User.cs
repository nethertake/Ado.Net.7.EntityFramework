using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net._7.EntityFramework.Model
{
   public class User
    {
        public int UserId { get; set; }
        // public Guid UserId {get;set;}
        public string SID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? intLocationId { get; set; }

        //public Nullable<int> intLocationId {get;set;}
    }
}
