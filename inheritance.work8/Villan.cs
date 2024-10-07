using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.work8
{
    internal class Villan:Character
    {
        public int DarkAbility { get; set; }

        public Villan(string name, int money, int health, int darkAbility) : base(name, money, health, darkAbility)
        {
            DarkAbility = darkAbility;
        }

        public override void Attack(Character opponent)
        {
            opponent.Health -= DarkAbility;
        }

    } 
}
