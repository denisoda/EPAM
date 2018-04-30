using System;
using Ninject;
using DAL.Interface;
using DAL.Model;

namespace DependecyRes
{
    public class NinjectConfig
    {
        public IKernel Kerner {get; private set;}

        public NinjectConfig()
        {
            this.Kerner = new StandardKernel();
            this.Kerner.Bind<IDataProvider<string>>().To<Data>();
        }
    }
}
