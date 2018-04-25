using System;
using System.Xml;
using BLL.classes;
using BLL.classes.abstracts;
using BLL.interfaces;

namespace BLL
{
    public class UrlXmlParser : ParserBase<string> 
    {
        readonly string _data;
        readonly XmlDocument document;

        public UrlXmlParser(IDataProvider<string> dataProvider) : base(dataProvider)
        {
            if(DataValidator.IsValidUrl(dataProvider.GetData()))
                _data = dataProvider.GetData();
            else    
                throw new ArgumentException("is not valid url");
        }

        public override void Parse()
        {
            document.CreateElement()
        }
    }
}
