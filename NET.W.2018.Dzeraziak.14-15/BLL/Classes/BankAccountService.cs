using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using DAL.Intefaces;

namespace SolutonBankAccount.Classes
{
    class BankAccountService
    {
        private IDataSaver _saver;
        
        BankAccountService(IDataSaver saver)
        {
            _saver = saver;
        }

        public void save(IEnumerable data)
        {
            _saver.Save(data);
        }

    }
}
