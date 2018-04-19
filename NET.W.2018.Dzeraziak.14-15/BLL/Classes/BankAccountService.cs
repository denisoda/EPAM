using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DataSaverService.Interfaces;

namespace SolutonBankAccount.Classes
{
    class BankAccountService
    {
        private IBinarySaver<BankAccount> _saver;
        
        BankAccountService(IBinarySaver<BankAccount> saver)
        {
            _saver = saver;
        }

        
    }
}
