using Profile_Evalution.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Profile_Evalution.Services
{
    public interface ICrudService<Tid,Tmodel> where Tmodel: class
    {
        Task<Tmodel> Get(Tid id);

        IQueryable<Tmodel> GetAll();

        Task Delete(Tmodel model);

        Task<Tmodel> Update(Tid id,Tmodel entity);

        Task Create(Tmodel entity);


    }
}