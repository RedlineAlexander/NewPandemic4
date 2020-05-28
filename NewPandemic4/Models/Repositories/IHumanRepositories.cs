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
  public  interface IHumanRepositories
    {
        public List<Human> GetAllHumans();
        public string GetHuman();
        public Human CreateHuman();

        public void ModifyHuman();
        public Human KillHuman();

    }
}
