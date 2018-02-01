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
           

            MFUser user2 = db.MFUser.FirstOrDefault(f => f.Id == 2);
            user2.MFUserName = "new Name";
            db.SaveChanges();

            foreach (MFUser item in db.MFUser)
            {
                Console.WriteLine(item.Id + "\t" + item.DOB + "\t" + item.MFUserName);
            }
        }
    }

 
}
