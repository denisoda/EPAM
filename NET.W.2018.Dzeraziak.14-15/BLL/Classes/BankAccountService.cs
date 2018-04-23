using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DataSaverService.Interfaces;
using System.Collections;

namespace SolutonBankAccount.Classes
{
    class BankAccountService
    {
        private IDataSaver<BankAccount> _saver;
        
        BankAccountService(IBinarySaver<BankAccount> saver)
        {
            _saver = saver;
        }
        
        _saver.save(IEnumerable data);
    }
}
