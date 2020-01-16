using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly EduraDbContext dbContext;
        public EfUnitOfWork(EduraDbContext _dbContext)
        {
            dbContext = _dbContext ?? throw new ArgumentNullException("DbContext Can not Be null");
        }

        private IProductRepository _products;
        private ICategoryRepository _categories;
        private IOrderRepository _orderRepository;

        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbContext));
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                return _orderRepository ?? (_orderRepository = new  EfOrderRepository(dbContext));
            }
        }

        public int SaveChanges()
        {
            try
            {
               return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

 
    }
}
