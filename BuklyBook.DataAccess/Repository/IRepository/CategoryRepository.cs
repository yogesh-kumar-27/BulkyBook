using BulkyBook.Data;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuklyBook.DataAccess.Repository.IRepository
{
    internal class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
            throw new NotImplementedException();
        }

        public void Update(Category obj)
        {
            _db.categories.Update(obj);
            throw new NotImplementedException();
        }
    }
}
