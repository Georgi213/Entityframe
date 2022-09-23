using Entityframe;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using (ApplicationContext db = new ApplicationContext())
{
    User tom = new User();
    db.Users.Add(tom); // ! ошибка Microsoft.EntityFrameworkCore.DbUpdateException
    db.SaveChanges();
}



