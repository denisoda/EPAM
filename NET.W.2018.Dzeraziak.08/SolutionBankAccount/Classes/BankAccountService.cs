using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SolutonBankAccount.NewFolder;

namespace SolutonBankAccount.Classes
{
    class BankAccountService : IBinarySaver<BankAccount>
    {
        public void SaveToBinary(BankAccount file)
        {
            Directory.CreateDirectory(ConfigurationManager.AppSettings["BinFolderAccountsLocation"]);

            using (Stream st = File.Create(ConfigurationManager.AppSettings["BinFolderAccountsLocation"] 
                    + Path.DirectorySeparatorChar + ConfigurationManager.AppSettings["AccountsFileName"]))
            {
                var formatter = new BinaryFormatter();

                formatter.Serialize(st, file);
            }
        }
    }
}
