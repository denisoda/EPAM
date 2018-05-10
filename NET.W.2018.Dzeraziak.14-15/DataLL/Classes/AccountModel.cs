using System.Collections;
using System.Collections.Generic;
using SolutonBankAccount;
using SolutonBankAccount.Enum;
using System.Data.Entity;

namespace DAL
{
    public class AccountModel 
    {
        public int AccoutId { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public decimal Ballance { get; set; }
        public decimal BonusPoins { get; set; }
        public AccountRate BonusRate { get; set; }
        public IList<AccountModel> Accounts { get; set; }
    }
}