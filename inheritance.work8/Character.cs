using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.work8
{
    internal class Character
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Health { get; set; }
        public int power {  get; set; }


        public Character(string name, int money, int health, int power) 
        {
            Name = name;
            Money = money;
            Health = health;
            power = power;
           
            
        }
       public virtual void Attack(Character opponent)
        {
            opponent.Health -= power;
        }

       
    }



}
