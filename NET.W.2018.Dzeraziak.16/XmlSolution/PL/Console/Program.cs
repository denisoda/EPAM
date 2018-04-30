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
        }

        public void outputParserResult()
        {
            var data = this.kernel.Get<IDataProvider<string>>();

            var urlParser = new UrlXmlParser(data);
            
            urlParser.GenerateXml();
        } 
    }
}
