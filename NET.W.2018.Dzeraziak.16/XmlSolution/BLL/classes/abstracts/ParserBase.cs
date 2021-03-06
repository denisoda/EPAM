using System.Collections.Generic;
using DAL.Interface;

namespace BLL.classes.abstracts
{
    public abstract class ParserBase <T>
    {
        IDataProvider<T> _dataProvider;

        public ParserBase(IDataProvider<T> dataProvider)
        {
            _dataProvider = dataProvider;
        }
    }
}