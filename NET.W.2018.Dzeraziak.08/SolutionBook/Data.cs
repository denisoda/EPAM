using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SolutionBook.Interfaces;

namespace SolutionBook
{
    class Data : IDataFolderCreator
    {
        public static string path = Directory.GetCurrentDirectory() + "data";

        public void CreateDataFolder()
        {
            
        }
    }
}
