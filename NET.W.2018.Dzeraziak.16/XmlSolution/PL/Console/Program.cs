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
            Program p = new Program();
            
            p.OutputParserResult();
        }

        public void OutputParserResult()
        {
            var data = this.kernel.Get<IDataProvider<string>>();

            var urlParser = new UrlXmlParser(data);
            
            System.Console.WriteLine(urlParser.GenerateXml());
        } 
    }
}
