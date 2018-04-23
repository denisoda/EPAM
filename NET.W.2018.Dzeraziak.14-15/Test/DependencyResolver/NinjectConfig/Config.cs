using System;
using DAL.Intefaces;
using NinjectConfig;
using Ninject;
using BLL.Interfaces;
using SolutonBankAccount.Classes.Services;
using DAL.Classes;

namespace NinjectConfig
{
    public class NinjectConfig
    {
        public readonly IKernel Kernel;

        public NinjectConfig()
        {
            Kernel = new StandardKernel();
            Kernel.Bind<IBankAccountService>().To<BankAccountService>();
            Kernel.Bind<IDataSaver>().To<DbSaver>();
        }
    }
}
