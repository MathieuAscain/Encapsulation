using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Character
    {

        private string login;
        private int health;

        public Character(string aLogin)
        {
            login = aLogin;
            Random randNumber = new Random();
            health = randNumber.Next(0, 5);
        }

        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(int aHealth)
        {
            health = aHealth;
        }

        public string GetLogin()
        {
            return login;
        }
    } 
}
