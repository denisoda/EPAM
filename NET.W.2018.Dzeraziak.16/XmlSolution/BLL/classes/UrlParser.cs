using System;
using System.Xml;
using BLL.classes;
using BLL.classes.abstracts;
using DAL.Interface;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NLog;

namespace BLL
{
    public class UrlXmlParser : ParserBase<string> 
    {
        private readonly string[] _url;
        private readonly XmlDocument _document;
        private readonly ILogger _logger;

        public UrlXmlParser(IDataProvider<string> dataProvider, ILogger logger) : base(dataProvider)
        {
            _logger = logger;

            if(DataValidator.IsValidUrl(dataProvider.GetData()))
                _url = dataProvider.GetData().Split(' ');
            else
            {    
                _logger.Error("In a UrlXmlParser constructor the url provided was not valid");    
                throw new ArgumentException("is not valid url");
            }
            
            _document = new XmlDocument(); 
        }

        public XElement GenerateXml()
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
                
                return urlsTree;
            }
        }
    }

