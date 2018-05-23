using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SolutonBankAccount;
using SolutonBankAccount.Enum;
using System.Data.Entity;
using MySqlX.XDevAPI.Relational;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    [Table("Accounts")]
    public class AccountModel 
    {
        [Column("id")]
        [Key]
        public int AccoutId { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public decimal Ballance { get; set; }
        public decimal BonusPoins { get; set; }
        public AccountRate BonusRate { get; set; }
        public IList<AccountModel> Accounts { get; set; }
    }
}