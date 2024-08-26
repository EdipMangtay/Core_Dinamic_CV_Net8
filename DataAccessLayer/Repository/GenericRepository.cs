using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class // burada T'nin bir class olması gerektiğini belirttik
    {
        public void Delete(T p)
        {
           using var c  = new Context();
            c.Remove(p);
            c.SaveChanges(); // değişiklikleri kaydet
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);

        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();

        }

        public void Update(T p)
        {
            using var c = new Context();
            c.Update(p);
            c.SaveChanges();

        }
    }
}
