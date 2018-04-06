using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using SolutonBankAccount.Classes;
using SolutonBankAccount.NewFolder;
using System.Runtime.Serialization.Formatters.Binary;

namespace SolutonBankAccount.Interfaces
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
