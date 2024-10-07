using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.work8
{
    internal class Hero:Character
    {
        public int LightAbility {  get; set; }


        public Hero(string name, int money, int health, int lightAbility):base(name,money,health,lightAbility)
        {
            LightAbility = lightAbility;
        }

        public override void Attack(Character opponent)
        {
            opponent.Health -= LightAbility;
        }

        public  void Help(Hero hero)
        {
            hero.Health += LightAbility;
            Health -= LightAbility;
           
        }


    }
}
 