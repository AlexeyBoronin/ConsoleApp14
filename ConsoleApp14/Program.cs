using ConsoleApp14;
using static System.Console;
using (ApplicationContext db = new ApplicationContext())
{
    //создаем два объекта
    User Kirill = new User { Name = "Кирилл", Age = 16 };
    User Semen = new User { Name = "Семён", Age = 14 };

    //добавляем их в бд
    db.Users.Add(Kirill);
    db.Users.Add(Semen);
    db.SaveChanges();
    WriteLine("Объекты успешно сохранены");

    //получаем объекты из бд и выводим на консоль
    var users=db.Users.ToList();
    WriteLine("Список объектов");
    foreach(User u in users)
    {
        WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}