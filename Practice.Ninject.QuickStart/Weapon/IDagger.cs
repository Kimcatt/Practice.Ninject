using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Ninject.QuickStart.Weapon
{
    public interface IDagger : IWeapon
    {
        void Stab(string target);
    }
}
