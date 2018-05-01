using System;
using BLL;
using DAL.Model;
using DependecyRes;
using Ninject;
using DAL.Interface;
using NLog;

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
            Program p = new Program();

            p.OutputParserResult();
        }

        public void OutputParserResult()
        {
            var data = this.kernel.Get<IDataProvider<string>>();
            var logger = this.kernel.Get<ILogger>();

            var urlParser = new UrlXmlParser(data, logger);
            
            System.Console.WriteLine(urlParser.GenerateXml());
        } 
    }
}
