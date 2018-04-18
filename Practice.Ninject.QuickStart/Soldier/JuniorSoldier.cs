using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Practice.Ninject.QuickStart.Soldier
{
    public class JuniorSoldier : SoldierBase
    {
        private Weapon.ISword sword;

        public JuniorSoldier() { }

        public JuniorSoldier([Named(nameof(Weapon.IronSword))]Weapon.ISword sword)
        {
            this.sword = sword;
            Console.WriteLine("The junior soldier #{0} joined...", GetHashCode());
        }

        public override void Attack(string target)
        {
            Console.WriteLine("The junior soldier #{0} begins attack...", GetHashCode());
            this.sword?.Chop(target);
            Console.WriteLine("The junior soldier #{0} ends attack...{1}", GetHashCode(), Environment.NewLine);
        }
    }
}
