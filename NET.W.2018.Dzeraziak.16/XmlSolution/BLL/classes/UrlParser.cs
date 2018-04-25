using System;
using System.Xml;
using BLL.classes;
using BLL.classes.abstracts;
using BLL.interfaces;

namespace BLL
{
    public class UrlXmlParser : ParserBase<string> 
    {
        readonly string[] _url;
        readonly XmlDocument document;

        public UrlXmlParser(IDataProvider<string> dataProvider) : base(dataProvider)
        {
            if(DataValidator.IsValidUrl(dataProvider.GetData()))
                _url = dataProvider.GetData().Split(' ');
            else    
                throw new ArgumentException("is not valid url");
            
            document = new XmlDocument();
        }

        public void GenerateXml(string name = "Urls.xml", string path = "")
        {

            using(XmlWriter xw = XmlWriter.Create(path + name))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("UrlAddresses");

                foreach(var url in _url)
                {
                    xw.WriteStartElement("UrlAdress");

                    xw.WriteElementString("host name", url);
                }
            }
        }
    }
}
