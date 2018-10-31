using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBug.Model.Dao

{
    public class MenuDao
    {
        ShopBugDbContext db = null;

        public MenuDao()
        {
            db = new ShopBugDbContext();
        }

        public List<Menu> ListByGroupID(int groupid)
        {
            return db.Menus.Where(x => x.GroupID == groupid).ToList();
        }
    }
}
