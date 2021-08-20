using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<M> where M: Base
    {
        public virtual void Create(M model) 
        {
            using (var context = new GaContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        
        }
        public virtual M Read(int id)
        {
            M model = Activator.CreateInstance<M>();
            using (var context = new GaContext())
            {
                model = context.Set<M>().Find(id);
            }
            return model;
        }
        public virtual List<M> Read()
        {
            List<M> list = new List<M>();
            using (var context = new GaContext())
            {
                list = context.Set<M>().ToList();
            }
            return list;
        }
        public virtual void Update(M model)
        {
            using (var context = new GaContext())
            {
                context.Entry<M>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        
        }
        public virtual void Delete(int id)
        {
            using (var context = new GaContext())
            {
                context.Entry<M>(this.Read(id)).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
