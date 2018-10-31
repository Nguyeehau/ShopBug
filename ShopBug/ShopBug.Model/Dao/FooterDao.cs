using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBug.Model.Dao
{
    public class FooterDao
    {
        ShopBugDbContext db = null;
        public FooterDao()
        {
            db = new ShopBugDbContext();
        }

        public Footer GetFooter()
        {
            return db.Footers.SingleOrDefault(x => x.Status == true);
        }
    }
}
