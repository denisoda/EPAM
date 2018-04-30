using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface;

namespace DAL.Model
{
    public class Data : IDataProvider<string>
    {
        public string Datatext { get; private set; }

        public Data(string data)
        {
            Datatext = data;
        }

        public string GetData()
        {
            return Datatext;
        }
    }
}
