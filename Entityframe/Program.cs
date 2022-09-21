using Entityframe;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using (helloappContext db = new helloappContext())
{
    // получаем объекты из бд и выводим на консоль
    User artem = new User { Name = "Artem",    Age = 18 };
    User georgi = new User { Name = "Georgi",   Age = 19 };

    // добавляем их в бд
    db.Users.Add(artem);
    db.Users.Add(georgi);
    db.SaveChanges();
    Console.WriteLine("\nObjektide salvestamine õnnestus");
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Objektide loend:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.");
    }
}

using (ApplicationContext db = new ApplicationContext())
{
    User artem = new User { Name = "Artem", Age = 18 };
    User georgi = new User { Name = "Georgi", Age = 19 };

    // Добавление
    db.Users.Add(artem);
    db.Users.Add(georgi);
    db.SaveChanges();
}

// получение
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("\nAndmed pärast lisamist:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}
using (ApplicationContext db = new ApplicationContext())
{
    // получаем первый объект
    User? user = db.Users.FirstOrDefault();
    if (user != null)
    {
        user.Name = "Bob";
        user.Age = 44;
        //обновляем объект
        //db.Users.Update(user);
        db.SaveChanges();
    }
    // выводим данные после обновления
    Console.WriteLine("\nAndmed pärast redigeerimist:");
    var users = db.Users.ToList();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

// Удаление
using (ApplicationContext db = new ApplicationContext())
{
    // получаем первый объект
    User? user = db.Users.FirstOrDefault();
    if (user != null)
    {
        //удаляем объект
        db.Users.Remove(user);
        db.SaveChanges();
    }
    // выводим данные после обновления
    Console.WriteLine("\nandmed pärast kustutamist:");
    var users = db.Users.ToList();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

using (ApplicationContext db = new ApplicationContext())
{

    var users = db.Users.ToList();
    Console.WriteLine("Kasutajade loend:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}



