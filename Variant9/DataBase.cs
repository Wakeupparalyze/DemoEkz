using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variant9.DB;

namespace Variant9
{
    internal class DataBase
    {
        static User13Context db;

        public static User13Context Instance()
        {
            if (db == null)
                db = new User13Context();
            return db;
        }
    }
}
