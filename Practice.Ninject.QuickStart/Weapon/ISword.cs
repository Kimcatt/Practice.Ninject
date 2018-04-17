using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Ninject.QuickStart.Weapon
{
    public interface ISword : IWeapon
    {
        void Chop(string target);

    }
}
