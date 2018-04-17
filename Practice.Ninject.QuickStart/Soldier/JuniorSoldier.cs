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

        public JuniorSoldier() { }

        public JuniorSoldier(Weapon.ISword sword)
        {
            this.sword = sword;
        }

        public override void Attack(string target)
        {
            if (sword == null)
            {
                throw new ArgumentNullException("sword");
            }
            this.sword.Chop(target);
        }
    }
}
