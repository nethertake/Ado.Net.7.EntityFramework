using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBSecond
{
    class Program
    {
        static void Main(string[] args)
        {

         hMalServerContainer db = new hMalServerContainer();
         MFUser user = new MFUser();
            user.DOB = DateTime.Now;
            user.MFUserName = "Timur";
            db.MFUser.Add(user);
            db.SaveChanges();
            foreach (MFUser item in db.MFUser)
            {
                Console.WriteLine(item.Id + "\t" + item.DOB + "\t" + item.MFUserName);
            }



        }
    }

 
}
