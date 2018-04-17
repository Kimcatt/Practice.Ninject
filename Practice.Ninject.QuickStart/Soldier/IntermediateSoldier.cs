using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Ninject.QuickStart.Weapon;
using Ninject;

namespace Practice.Ninject.QuickStart.Soldier
{
    public class IntermediateSoldier : SoldierBase
    {
        private IWeapon[] weapons;

        [Inject]
        public void Arm(IWeapon[] weapons)
        {
            this.weapons = weapons;
            Console.WriteLine("The intermediate soldier armed...");
        }

        public IntermediateSoldier() { }

        public IntermediateSoldier(IWeapon[] weapons)
        {
            this.weapons = weapons;
            Console.WriteLine("The intermediate soldier joined...");
        }

        public override void Attack(string target)
        {
            Console.WriteLine("An intermediate soldier #{0} begins attack ", this.GetHashCode());
            foreach (var weapon in weapons)
            {
                (weapon as IDagger)?.Stab(target);
                (weapon as ISword)?.Chop(target);
            }
            Console.WriteLine("An intermediate soldier #{0} ends attack ", this.GetHashCode());
        }
    }
}
