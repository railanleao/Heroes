using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.src.Entitis
{
     public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia ";
        }
        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " Lançou magia super poderosa com bonus de " + bonus;
            }
            else
            {
                return this.Name + " Lançou magia fraca com bonus de " + bonus;
            }
        }
    }
}
