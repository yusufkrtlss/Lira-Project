using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EfRepositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new LiraDb();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new LiraDb();
            return c.Set<T>().Find(id);
        }
        public T GetSymbol(string symbol)
        {
            using var c = new LiraDb();
            return c.Set<T>().FirstOrDefault();
        }

        public List<T> GetListAll()
        {
            using var c = new LiraDb();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new LiraDb();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new LiraDb();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
