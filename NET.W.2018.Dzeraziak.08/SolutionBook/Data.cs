namespace SolutionBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using SolutionBook.Interfaces;

    internal class Data : IDataFolderCreator
    {
        /// <summary>
        /// Path to the data directory
        /// </summary>
        private static readonly string PathData = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "data";

        /// <summary>
        /// Creates the data folder
        /// </summary>
        public void CreateDataFolder()
        {
            Directory.CreateDirectory(PathData);
        }
    }
}
