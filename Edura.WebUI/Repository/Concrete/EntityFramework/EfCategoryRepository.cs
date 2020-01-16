using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(EduraDbContext context) : base(context)
        {

        }

        public EduraDbContext eduraContext
        {
            get { return context as EduraDbContext; }
        }


        public Category GetByName(string name)
        {
            return eduraContext.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel()
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                Count = i.ProductCtegories.Count()
            });
        }

        public void RemoveFromCategory(int ProductId, int CategoryId)
        {
            var cmd = $"delete from ProductCategory where ProductId={ProductId} and CategoryId={CategoryId}";
            context.Database.ExecuteSqlCommand(cmd);
            
        }
    }
}
