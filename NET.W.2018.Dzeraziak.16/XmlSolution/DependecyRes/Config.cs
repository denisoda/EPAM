using System;
using Ninject;
using DAL.Interface;
using DAL.Model;


namespace DependecyRes
{
    public class NinjectConfig
    {
        public IKernel Kernel {get; private set;}

        public NinjectConfig()
        {
            this.Kernel = new StandardKernel();
            this.Kernel.Bind<IDataProvider<string>>().To<Data>().WithConstructorArgument("https://github.com/AnzhelikaKravchuk?tab=repositories https://github.com/AnzhelikaKravchuk/2017-2018.MMF.BSU https://habrahabr.ru/company/it-grad/blog/341486/");
        }
    }
}
