using System;
using System.Xml;
using BLL.classes;
using BLL.classes.abstracts;
using DAL.Interface;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class UrlXmlParser : ParserBase<string> 
    {
        private readonly string[] _url;
        private readonly XmlDocument _document;

        public UrlXmlParser(IDataProvider<string> dataProvider) : base(dataProvider)
        {
            if(DataValidator.IsValidUrl(dataProvider.GetData()))
                _url = dataProvider.GetData().Split(' ');
            else    
                throw new ArgumentException("is not valid url");
            
            _document = new XmlDocument();
        }

        public void GenerateXml(string name = "Urls.xml", string path = "")
        {
                var _document = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"));
                XElement urlsTree = new XElement("urlAddresses",
                            from a in _url
                                select
                            new XElement("urlAddress",
                                new XElement("host", 
                                    new XAttribute("name", a.First()),
                                new XElement("uri",
                                    new XElement("segment", "name"), // add a var name into the scope
                                new XElement("parameters",
                                    new XElement("parametr",
                                        new XAttribute("value", "value"), // add the real value
                                        new XAttribute("key", "key") // add the real key
                                )
                                )))));
                
                System.Console.WriteLine(urlsTree);
            }
        }
    }

