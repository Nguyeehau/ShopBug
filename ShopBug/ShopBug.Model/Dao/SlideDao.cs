using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBug.Model.Dao

{
    public class SlideDao
    {
        ShopBugDbContext db = null;
        public SlideDao()
        {
            db = new ShopBugDbContext();
        }

        public List<Slide> ListAll()
        {
            return db.Slides.Where(x => x.Status == true).OrderBy(y => y.DispalyOrder).ToList();
        }
    }
}
