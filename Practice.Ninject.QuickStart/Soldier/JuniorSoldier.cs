using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Ninject.QuickStart.Soldier
{
    public class JuniorSoldier : SoldierBase
    {
        private Weapon.ISword sword;

        public JuniorSoldier(Weapon.ISword sword)
        {
            this.sword = sword;
        }

        public override void Attack(string target)
        {
            this.sword.Chop(target);
        }
    }
}
