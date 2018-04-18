using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Ninject.QuickStart.Context;
using Practice.Ninject.QuickStart.Weapon;
using Practice.Ninject.QuickStart.Soldier;

namespace Practice.Ninject.QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationContainer.Current.LoadSoldierModule();
            var soldier = ApplicationContainer.Current.Resolve<IntermediateSoldier>();
            soldier.Attack("xiaoming");
            JuniorSoldier juniorSoldier = ApplicationContainer.Current.Resolve<JuniorSoldier>();
            juniorSoldier.Attack("xiaonan");

            IntermediateSwordMan swordman = ApplicationContainer.Current.Resolve<IntermediateSwordMan>();
            swordman.Attack("xiaolin");

            swordman = ApplicationContainer.Current.Resolve<IntermediateSwordMan>();
            swordman.Attack("xiaolin2");
        }
    }
}
