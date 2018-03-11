using Profile_Evalution.Database.Context;
using Profile_Evalution.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Profile_Evalution.Services
{
    public abstract class CrudService<Tid, Tmodel> : ICrudService<Tid, Tmodel> where Tmodel : class
    {
        private readonly ApplicationDBContext context;

        public CrudService(ApplicationDBContext context) { this.context = context; }

        public async Task Create(Tmodel model)
        {
            context.Set<Tmodel>().Add(model);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Tmodel model)
        {
            context.Set<Tmodel>().Remove(model);
            await context.SaveChangesAsync();
        }

        public async Task<Tmodel> Get(Tid id)
        {
            return await context.Set<Tmodel>().FindAsync(id);
        }

        public IQueryable<Tmodel> GetAll()
        {
            return context.Set<Tmodel>().AsNoTracking();
        }
        

        public async Task<Tmodel> Update(Tid id,Tmodel model)
        {

            Tmodel m = await Get(id);
            context.Entry<Tmodel>(m).CurrentValues.SetValues(model);
            await context.SaveChangesAsync();
            return m;
        }
    }
}