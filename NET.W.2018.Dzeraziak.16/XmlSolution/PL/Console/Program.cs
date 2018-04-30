using System;
using BLL;
using DAL.Model;
using DependecyRes;
using Ninject;
using DAL.Interface;

namespace PL.Console
{
    class Program
    {
        private IKernel kernel;

        public Program()
        {
            kernel = new NinjectConfig().Kernel;
        }

        static void Main(string[] args)
        {

            var data = new Data(
                "https://github.com/AnzhelikaKravchuk?tab=repositories https://github.com/AnzhelikaKravchuk/2017-2018.MMF.BSU https://habrahabr.ru/company/it-grad/blog/341486/");

            var urlParser = new UrlXmlParser(data);   
            
            urlParser.GenerateXml();
        }

        public void outputParserResult()
        {
            var data = this.kernel.Get<IDataProvider<string>>();

                         
        } 
    }
}
