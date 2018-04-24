using System;
using System.Xml;

namespace BLL
{
    public class UrlParser
    {
        IDataProvider<string> _dataProvider;
        readonly string _data;

        UrlParser(IDataProvider<string> dataProvider)
        {
            _data = dataProvider.GetData();
        }

        
    }
}
