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
            ApplicationContainer.Current.Init();
            var soldier = ApplicationContainer.Current.Resolve<JuniorSoldier>();
            soldier.Attack("xiaoming");
        }
    }
}
