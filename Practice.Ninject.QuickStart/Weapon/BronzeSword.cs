using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Ninject.QuickStart.Weapon
{
    class BronzeSword : ISword
    {
        public void Chop(string target)
        {
            Console.WriteLine("Chopped {0} hard...", target);
        }
    }
}
