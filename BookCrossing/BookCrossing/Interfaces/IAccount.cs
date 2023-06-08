using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Interfaces
{
    public interface IAccount  //Інтерфейс, створений для різних типів акаунтів
    {
        string LogIn { get; set; }     //Логін
        string Password { get; set; }  //Пароль
    }
}
