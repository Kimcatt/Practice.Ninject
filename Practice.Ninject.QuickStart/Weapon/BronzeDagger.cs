using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Ninject.QuickStart.Weapon
{
    public class BronzeDagger : IDagger
    {
        public void Stab(string target)
        {
            Console.WriteLine("Stabbed {0} hard...", target);
        }
    }
}
