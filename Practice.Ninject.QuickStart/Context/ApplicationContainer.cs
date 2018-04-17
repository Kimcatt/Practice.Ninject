using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Ninject.QuickStart.Soldier;
using Practice.Ninject.QuickStart.Weapon;

namespace Practice.Ninject.QuickStart.Context
{
    public sealed class ApplicationContainer
    {
        private static readonly ApplicationContainer instance = new ApplicationContainer();

        public static ApplicationContainer Current
        {
            get { return instance; }
        }

        private ApplicationContainer() { }

        private global::Ninject.IKernel kernal = new global::Ninject.StandardKernel();

        public void BuildComponents()
        {
            kernal.Bind<Weapon.ISword>().To<Weapon.BronzeSword>();
            kernal.Bind<Soldier.JuniorSoldier>().ToSelf();
        }

        public void BuildComponentsII()
        {
            kernal.Bind<Weapon.IWeapon>().To<Weapon.BronzeSword>();
            kernal.Bind<Weapon.IWeapon>().To<Weapon.BronzeDagger>();
            kernal.Bind<IntermediateSoldier>().ToSelf();
        }


        public T Resolve<T>() where T : class
        {
            return kernal.Get<T>();
        }
    }
}
