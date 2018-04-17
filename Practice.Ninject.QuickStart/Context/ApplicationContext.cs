using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Ninject.QuickStart.Context
{
    public sealed class ApplicationContext
    {
        private static readonly ApplicationContext instance = new ApplicationContext();

        public ApplicationContext Current
        {
            get { return instance; }
        }

        private ApplicationContext() { }



        

    }
}
