using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * Создайте интерфейс репозитория для работы с моделью Human. 
   Пусть этот интерфейс содержит пять методов GetAllHumans, GetHuman, CreateHuman, ModifyHuman, KillHuman. 
   Создайте класс реализующий этот интерфейс, назовите его SqlHumanRepository. 
   Реализуйте все методы из интерфейса. Досуп к сущности Humans вы сможете получить используя ваш класс контекста.
 */
 
namespace NewPandemic4.Models.Repositories
{

    public class SqlHumanRepository<T> : IHumanRepositories<T> where T : class
    {


        //Вывести всех людей
        //  public List<Human> GetAllHumans()
        // {
        //throw new NotImplementedException();
        //return
        //    }
        //Создаем
        //public Human CreateHuman()
        // {
        //throw new NotImplementedException();
        //   return 
        // }
        //  не по айди
        //public string GetHuman()   
        // {
        //throw new NotImplementedException();
        //  return "";
        // }
        //удалить человека в целом . Не по айди
        //   public Human KillHuman()
        //  {
        // new NotImplementedException();
        //    return
        //   }
        //  Апдейтим 
        //public void ModifyHuman()
        // {
        // throw new NotImplementedException();
        // }
        private readonly InfestationContext dbcontext;
        protected readonly DbSet<T> dbSet;

        public IQueryable<Human> Humans { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SqlHumanRepository(InfestationContext dbcontext)
        {
            this.dbcontext = dbcontext;
            dbSet = this.dbcontext.Set<T>();
        }
        public void CreateHuman(T item)
        {
            dbSet.Add(item);
            dbcontext.SaveChanges();
           // throw new NotImplementedException();
        }

        public void DeleteHuman(T item)
        {
            dbSet.Remove(item);
            dbcontext.SaveChanges();
            //throw new NotImplementedException();
        }

        public IQueryable<T> GetAllHumans()
        {
            return dbSet;
         //   throw new NotImplementedException();
        }

      // public IQueryable<T> GetHuman() {
          //  return new IQueryable<T>();
         //   return dbSet.ToList();
           // return dbSet.Where();

          //  throw new NotImplementedException();
   //     }

        public void ModifyHuman(T item)
        {
            dbcontext.Entry(item).State = EntityState.Modified;
            dbcontext.SaveChanges();

            //throw new NotImplementedException();
        }

        Human IHumanRepositories<T>.DeleteHuman(T item)
        {
            throw new NotImplementedException();
        }
    }
    
}
