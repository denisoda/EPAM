using System;
using System.Collections;

namespace DAL.Intefaces
{
    public interface IDataSaver
    {
        void Save(IEnumerable data);
    }
}
