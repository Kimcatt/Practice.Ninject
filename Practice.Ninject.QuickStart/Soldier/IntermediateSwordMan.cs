using Ninject;
using Practice.Ninject.QuickStart.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Ninject.QuickStart.Soldier
{
    public class IntermediateSwordMan : SoldierBase
    {
        private ISword[] swords;

        [Inject]
        public void Arm(ISword[] swords)
        {
            this.swords = swords;
            Console.WriteLine("The intermediate swordman #{0} armed...", GetHashCode());
        }

        public IntermediateSwordMan() { }

        public IntermediateSwordMan(ISword[] swords)
        {
            this.swords = swords;
            Console.WriteLine("The intermediate swordman #{0} joined...", GetHashCode());
        }

        public override void Attack(string target)
        {
            Console.WriteLine("The intermediate swordman #{0} begins attack ", this.GetHashCode());
            foreach (var sword in swords)
            {
                sword?.Chop(target);
            }
            Console.WriteLine("The intermediate swordman #{0} ends attack {1}", this.GetHashCode(), Environment.NewLine);
        }
    }
}
