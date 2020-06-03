using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * Теория:

Про параметры в Path и Query и когда их использовать: https://medium.com/@fullsour/when-should-you-use-path-variable-and-query-parameter-a346790e8a6d
Про Lazy и Eager загрузки данных: https://professorweb.ru/my/entity-framework/6/level3/3_4.php
Поймите основные концепции в EF: https://metanit.com/sharp/entityframeworkcore/, https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli возможно будет полезно создать маленький тренировочний проект, в котором настройте EF Core, чтоб лучше понять базовые концепции.
Дисклеймер: Все задания делайте в вашем проекте из 2 задания прошлого ДЗ. Для того чтоб выполнять задание из ДЗ, вам необходимо добавить в свой проект все то, что мы сделали на уроке. В свой проект я тоже буду заливать все что мы делали на уроке, как напоминание и пример.

Практика:

В HumanController добавьте action Country(если он у вас уже есть с занятия, переделайте согласно этому заданию). 
Action Country должен принимать один параметр - name(это название страны). 
Сделайте так чтоб в виде таблицы выводились все человеки из страны, имя которой было передано в action.
Тут вам необходимо использовать Query параметр, а не Path(прочитайте первый пункт теории).

На уроке мы использовали перегруженый метод OnModelCreating для добавления страны и пары персонажей в базу, 
поскольку это изменяемые данные, мы не хотим, чтоб он находились в нашем InfestationContextModelSnapshot. 
Удалите перегрузку метода OnModelCreating из вашего класса контекста(тот который унаследован от DbContext).
Добавьте новую миграцию чтоб пересобрать InfestationContextModelSnapshot и обновите базу. 
Добавьте несколько собственных человеков с помощью migrationBuilder в методе Up(для этого вам понадобится еще одна миграция).

В Action Index контроллера HumanController добавьте возможность выводить всех человеков, если параметр id равен нулю,
в обратном случае выводить человека Id которого равен значению параметра id.
Переименуйте параметр id в humanId и передавайте его как Query параметр.
Создайте интерфейс репозитория для работы с моделью Human. 

    public async Task<IActionResult>  GetAllHumans(int id){
    if(id == 0)
    {

    }
    else
    {
    }
    if(id == null)
    {
    return NotFound();
    }
    else
    {
    }
    }


Пусть этот интерфейс содержит пять методов GetAllHumans, GetHuman, CreateHuman, ModifyHuman, KillHuman. 
Создайте класс реализующий этот интерфейс, назовите его SqlHumanRepository. 
Реализуйте все методы из интерфейса. Досуп к сущности Humans вы сможете получить используя ваш класс контекста.
Замените использование вашего класса контекста в HumanController использованием вашего нового репозитория из 4 задания.




ПАРАМЕТЫ PATH и QUERY 


 На уроке мы использовали перегруженый метод OnModelCreating для добавления страны и пары персонажей в базу, 
поскольку это изменяемые данные, мы не хотим, чтоб он находились в нашем InfestationContextModelSnapshot. 
Удалите перегрузку метода OnModelCreating из вашего класса контекста(тот который унаследован от DbContext).
Добавьте новую миграцию чтоб пересобрать InfestationContextModelSnapshot и обновите базу. 


Добавьте несколько собственных человеков с помощью migrationBuilder в методе Up(для этого вам понадобится еще одна миграция).!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


На уроке мы использовали перегруженый метод OnModelCreating для добавления страны и пары персонажей в базу, 
поскольку это изменяемые данные, мы не хотим, чтоб он находились в нашем InfestationContextModelSnapshot. 
Удалите перегрузку метода OnModelCreating из вашего класса контекста(тот который унаследован от DbContext).
 */
namespace NewPandemic4.Models
{
    public class InfestationContext : DbContext
    {


        InfestationContext _context { get; set; }
        public InfestationContext(DbContextOptions options) : base(options)
        {
            // _context = context; AGGREGATEEXCEPTION
            //сontext = infestationContext; нельзя
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Human> Humans { get; set; }


        public DbSet<News> News { get; set; }
        public DbSet<WorldPart> WorldParts { get; set; }

        //НЕЛЬЗЯ!!!!
        //ЧТОБЫ ПОБЕДИТЬ ЭТОТ ЭКСЕПШН НЕОБХОДИМО ВНИМАТЕЛЬНО ПОСМОТРЕТЬ УНИКАЛЬНЫЕ ПОЛЯ!!!АЙДИ
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "US", Population = 328200000, SickCount = 1647741, DeadCount = 97811, RecoveredCount = 376266, Vaccine = false });
            modelBuilder.Entity<Human>().HasData(new Human { Id = 4, FirstName = "Obi-wan", LastName = "Gamgee", Age = 54, IsSick = false, Gender = "Male", CountryId = 1 },
                new Human { Id = 2, FirstName = "Sanwise", LastName = "Gamgee", Age = 54, IsSick = false, Gender = "Male", CountryId = 1 });
        }

        //internal object GetAllHumans()
     //   {
         //   throw new NotImplementedException();
       // }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //   {
        //      optionsBuilder.UseSqlServer("Data Source=DESKTOP-V020Q9R;   Initial Catalog=NewPandemic4; Integrated Security=SSPI;");
        // }

        //НЕ ЗАПУСКАТЬ. ЧРЕВАТО INVALIDOPERATIONEXCEPTION при MIGRATION
     //   protected override void OnModelCreating(ModelBuilder modelBuilder)
       //  {

        //     modelBuilder.Entity<Human>().Property(h => h.FirstName).HasColumnType("varchar(30)");
        //   modelBuilder.Entity<Human>().ToTable("Human").HasKey(h => h.Age);
        //   modelBuilder.Entity<Human>().Property(h => h.Country).IsRequired().HasMaxLength(30);
        //    


        //       }
    }
}
