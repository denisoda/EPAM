using System;
using System.Collections.Generic;
using System.Text;

namespace SolutonBankAccount.NewFolder
{
    interface IBinarySaver<in T>
    {
        void SaveToBinary(T file);
    }
}
