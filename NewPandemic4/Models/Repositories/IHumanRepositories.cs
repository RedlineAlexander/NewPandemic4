using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * Создайте интерфейс репозитория для работы с моделью Human. 
   Пусть этот интерфейс содержит пять методов GetAllHumans, GetHuman, CreateHuman, ModifyHuman, KillHuman. 
   Создайте класс реализующий этот интерфейс, назовите его SqlHumanRepository. 
   Реализуйте все методы из интерфейса. Досуп к сущности Humans вы сможете получить используя ваш класс контекста.

    public interface IRepository<T> where T : class
{
   IEnumerable<T> SelectAll(); 
   T SelectById(int id);
   void Insert(T obj);
  void Update(T obj);
   void Delete(T obj);
    void Save();
   }

 */
namespace NewPandemic4.Models.Repositories
{
    public interface IHumanRepositories<T> where T : class
    {
        IQueryable<Human> Humans { get; set; }
        public IQueryable<T> GetAllHumans();
      //  public IQueryable<T> GetHuman();
        public void CreateHuman(T item);

        public void ModifyHuman(T item);
        public Human DeleteHuman(T item);

    }
}
