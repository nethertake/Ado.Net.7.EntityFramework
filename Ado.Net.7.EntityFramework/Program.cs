using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.Net._7.EntityFramework.Model;

namespace Ado.Net._7.EntityFramework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (mscEntity db = new mscEntity())
            {
                foreach (User user in db.Users.ToList())
                {
                    Console.WriteLine(user.UserId);
                }


            }
        }

        static void Exmpl01()
        {

        }

      

    }
}
