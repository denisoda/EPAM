using System.Collections;

namespace DataSaverService.Interfaces
{
    interface IBinarySaver
    {
        void SaveToBinary(IEnumerable file);
    }
}
