using System;

namespace DAL.Interface
{
    public interface IDataProvider<T> 
    {
        T GetData();
    }
}