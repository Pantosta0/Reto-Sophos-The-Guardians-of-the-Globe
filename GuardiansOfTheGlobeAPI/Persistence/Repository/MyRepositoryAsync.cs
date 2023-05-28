using Application.Interface;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository
{
    internal class MyRepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;
        public MyRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            dbContext = context;
        }
    }
    
    
}
