using BookCrossing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossing.Entities
{
    [Serializable]
    public class ClientAccount : IAccount    //Акаунт клієнта
    {
        public string LogIn { get; set; }    //Логін користувача   
        public string Password { get; set; } //Пароль користувача
        public ClientAccount(string Login, string Password)
        {
            this.LogIn = Login;
            this.Password = Password;
        }
    }
}
