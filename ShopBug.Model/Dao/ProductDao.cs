using ShopBug.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShopBug.Model.Dao
{
    public class ProductDao
    {
        ShopBugDbContext db = null;

        public ProductDao()
        {
            db = new ShopBugDbContext();
        }

        public List<Product> ListSellProduct(int top)
        {
            return db.Products.OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
    }
}
