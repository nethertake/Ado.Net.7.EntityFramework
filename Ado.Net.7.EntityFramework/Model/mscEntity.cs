using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net._7.EntityFramework.Model
{
    public class mscEntity : DbContext
    {
        public mscEntity() : base("Data Source = 192.168.111.107; Initial Catalog =  MCS; User ID = sa; Password = Mc123456;") { 
        }

    public DbSet<User> Users { get; set; }
    }
}
