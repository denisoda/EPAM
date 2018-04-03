using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SolutionBook.Interfaces;

namespace SolutionBook
{
    class Data : IDataFolderCreator
    {
        public static string PathData = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "data";

        public void CreateDataFolder()
        {
            Directory.CreateDirectory(PathData);
        }
    }
}
