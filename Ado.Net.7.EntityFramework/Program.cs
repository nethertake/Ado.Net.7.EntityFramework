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
            mscEntity db = new mscEntity();
            db.Database.Log = (s=>System.Diagnostics.Debug.WriteLine(s));


        }

        static void Exmpl01()
        {

        }

      

    }
}
