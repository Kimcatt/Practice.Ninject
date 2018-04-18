using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Practice.Ninject.QuickStart.Soldier;
using Practice.Ninject.QuickStart.Weapon;

namespace Practice.Ninject.QuickStart.Context.Module
{
    public class SoldierModule : global::Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<Weapon.IWeapon>().To<Weapon.BronzeSword>();
            Bind<Weapon.IWeapon>().To<Weapon.BronzeDagger>();
            Bind<Soldier.JuniorSoldier>().ToSelf();
            Bind<ISword>().To<BronzeSword>().InSingletonScope().Named(nameof(BronzeSword));
            Bind<ISword>().To<IronSword>().InSingletonScope().Named(nameof(IronSword));
            Bind<IntermediateSwordMan>().ToSelf();
            Bind<IntermediateSoldier>().ToSelf();
        }
    }
}
